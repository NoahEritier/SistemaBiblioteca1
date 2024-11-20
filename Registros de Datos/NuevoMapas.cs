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

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevoMapas : Form
    {
        private int? mapaId = null; // ID del mapa (para saber si estamos editando un mapa existente)

        // Constructor para crear o editar un mapa
        public NuevoMapas(int? idMapa = null)
        {
            InitializeComponent();

            mapaId = idMapa; // Si el ID es null, significa que estamos creando un nuevo mapa

            // Cargar los temas si no se han cargado previamente
            CargarTemas();
            CargarEditoriales();

            if (mapaId != null)
            {
                CargarDatosMapa();
            }
        }

        // Método para cargar los datos del mapa al editar
        private void CargarDatosMapa()
        {
            string consulta = @"
        SELECT m.idTema, m.ilustraciones, m.idEditorial
        FROM mapas m
        WHERE m.Id = @idMapa";

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);
                    sqlCommand.Parameters.AddWithValue("@idMapa", mapaId);

                    using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Asignar los valores a los ComboBox correspondientes
                            cmbTemas.SelectedValue = reader["idTema"];
                            cmbIlustraciones.SelectedItem = Convert.ToBoolean(reader["ilustraciones"]) ? "Si" : "No";
                            cmbEditorial.SelectedValue = reader["idEditorial"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos del mapa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
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

        private void CargarEditoriales()
        {
            string consulta = "SELECT Id, Nombre FROM Editoriales ORDER BY Nombre";
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
                        cmbEditorial.DataSource = dataTable;
                        cmbEditorial.DisplayMember = "Nombre";
                        cmbEditorial.ValueMember = "Id";
                        cmbEditorial.SelectedIndex = -1; // Sin selección inicial
                    }
                    else
                    {
                        cmbTemas.Text = ("No se encontraron editoriales.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (cmbEditorial.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idEditorial = Convert.ToInt32(cmbEditorial.SelectedValue);
            // Validar si ilustraciones está seleccionado
            bool ilustraciones = cmbIlustraciones.SelectedItem.ToString() == "Si";

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
                        INSERT INTO mapas (fechaRegistro, idTema, ilustraciones, idEditorial)
                        VALUES (@fechaRegistro, @idTema, @ilustraciones, @idEditorial)";
                    }
                    else // Si estamos editando un mapa existente
                    {
                        query = @"
                        UPDATE mapas
                        SET idTema = @idTema, ilustraciones = @ilustraciones, idEditorial = @idEditorial
                        WHERE Id = @idMapa";
                    }

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idTema", idTema);
                        sqlCommand.Parameters.AddWithValue("@ilustraciones", ilustraciones);
                        sqlCommand.Parameters.AddWithValue("@idEditorial", idEditorial);

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
        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {
            NuevaEditorial nuevaEditorial = new NuevaEditorial();
            nuevaEditorial.ShowDialog();
        }
    }
}