using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevoMapas : Form
    {
        private int? mapaId = null; // ID del mapa (para saber si estamos editando un mapa existente)

        // Constructor para crear o editar un mapa
        public NuevoMapas(int? idMapa = null, string nombre = "", int idTema = 0, bool ilustraciones = false)
        {
            InitializeComponent();

            mapaId = idMapa; // Si el ID es null, significa que estamos creando un nuevo mapa

            // Rellenar los campos si hay datos
            cmbTemas.SelectedValue = idTema;
            cmbIlustraciones.SelectedItem = ilustraciones ? "Sí" : "No"; // Convertir el booleano

            if (mapaId.HasValue)
            {
                this.Text = "Modificar Mapa"; // Cambiar el título si estamos editando un mapa
            }
            else
            {
                this.Text = "Nuevo Mapa"; // Cambiar el título si estamos creando un nuevo mapa
            }

            // Cargar los temas si no se han cargado previamente
            CargarTemas();
        }

        // Método para cargar los temas
        private void CargarTemas()
        {
            string consulta = "SELECT Id, Nombre FROM Temas WHERE Grupo = 'Mapas' ORDER BY Nombre";
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        cmbTemas.DataSource = dataTable;
                        cmbTemas.DisplayMember = "Nombre";
                        cmbTemas.ValueMember = "Id";
                        cmbTemas.SelectedIndex = -1; // Sin selección inicial
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron temas.");
                        cmbTemas.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los temas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        // Confirmar la acción de guardar (ya sea nuevo o editado)
        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // Validar selección de tema
            if (cmbTemas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idTema = Convert.ToInt32(cmbTemas.SelectedValue);

            // Validar si ilustraciones está seleccionado
            bool ilustraciones = cmbIlustraciones.SelectedItem.ToString() == "Sí";

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    string query;

                    if (mapaId == null) // Si es un nuevo mapa
                    {
                        query = @"
                        INSERT INTO mapas (fechaRegistro, idTema, ilustraciones)
                        VALUES (@fechaRegistro, @idTema, @ilustraciones)";
                    }
                    else // Si estamos editando un mapa existente
                    {
                        query = @"
                        UPDATE mapas
                        SET idTema = @idTema, ilustraciones = @ilustraciones
                        WHERE Id = @idMapa";
                    }

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idTema", idTema);
                        sqlCommand.Parameters.AddWithValue("@ilustraciones", ilustraciones);

                        if (mapaId != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@idMapa", mapaId); // Solo cuando estamos editando
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@fechaRegistro", DateTime.Now); // Para un nuevo mapa
                        }

                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show(mapaId == null ? "Mapa registrado correctamente." : "Mapa modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el mapa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el mapa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema("Mapas");
            nuevoTema.ShowDialog();

            // Refrescar el ComboBox de editoriales después de agregar una nueva
            CargarTemas();
        }
    }
}
