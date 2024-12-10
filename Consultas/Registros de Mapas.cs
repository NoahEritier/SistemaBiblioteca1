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
using WindowsFormsApp1.Registros_de_Datos;

namespace WindowsFormsApp1.Consultas
{
    public partial class Registros_de_Mapas : Form
    {
        public Registros_de_Mapas()
        {
            InitializeComponent();

            // Inicializar ComboBox con opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"

            CargarTemas();
        }

        private void Registros_de_Mapas_Load(object sender, EventArgs e)
        {
            btnBuscarMapa.PerformClick();
        }

        private void Registro_de_Mapas_Load(object sender, EventArgs e)
        {
            btnBuscarMapa.PerformClick();
        }

        private void btnNuevoMapa_Click(object sender, EventArgs e)
        {
            NuevoMapas nuevoMapas = new NuevoMapas();
            nuevoMapas.ShowDialog(this);
        }

        private void btnModificarMapas_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvMapas.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvMapas.SelectedRows[0];

                // Asumimos que las columnas son: Id, Nombre, IdTema, Ilustraciones
                int idMapa = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                // Crear una instancia del formulario NuevoMapas, pasando los datos
                NuevoMapas nuevoMapa = new NuevoMapas(idMapa);
                nuevoMapa.ShowDialog(this);

                // Refrescar la lista de mapas después de editar
                btnBuscarMapa_Click(sender, e); // Esto volverá a cargar los mapas
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un mapa para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarMapas_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvMapas.SelectedRows.Count > 0)
            {
                // Obtener el ID del mapa seleccionado (asumiendo que el ID está en una columna llamada "Id")
                int idMapa = Convert.ToInt32(dgvMapas.SelectedRows[0].Cells["Id"].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este mapa?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Realizar la conexión a la base de datos y eliminar el registro
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar el mapa
                            string query = "DELETE FROM mapas WHERE Id = @Id";
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idMapa);

                            // Ejecutar el comando
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Mapa eliminado exitosamente.");
                                btnBuscarMapa_Click(sender, e);  // Recargar la lista después de eliminar
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el mapa para eliminar.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Error de SQL al eliminar el mapa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            mySqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un mapa para eliminar.");
            }
        }

        private void btnBuscarMapa_Click(object sender, EventArgs e)
        {
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();
            int idTema = Convert.ToInt32(cmbTemas.SelectedValue);

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM mapas WHERE 1=1";

            if (idTema != 0)
            {
                consulta += " AND idTema = @idTema";
            }

            DateTime fechaFiltro = DateTime.Now;
            switch (filtroPeriodo)
            {
                case "1 semana":
                    fechaFiltro = DateTime.Now.AddDays(-7);
                    consulta += " AND FechaRegistro >= @fechaFiltro";
                    break;
                case "1 mes":
                    fechaFiltro = DateTime.Now.AddMonths(-1);
                    consulta += " AND FechaRegistro >= @fechaFiltro";
                    break;
                case "6 meses":
                    fechaFiltro = DateTime.Now.AddMonths(-6);
                    consulta += " AND FechaRegistro >= @fechaFiltro";
                    break;
                case "Cualquier momento":
                    // No se agrega filtro por fecha
                    break;
            }       // Conectar a la base de datos y ejecutar la consulta
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Crear el comando SQL con la consulta
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    if (filtroPeriodo != "Cualquier momento")
                    {
                        sqlCommand.Parameters.AddWithValue("@fechaFiltro", fechaFiltro);
                    }

                    if (idTema != 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@idTema", idTema);
                    }

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvMapas.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvMapas.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los mapas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }

            }

        }
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
                        DataRow nuevaFila = dataTable.NewRow();
                        nuevaFila["Id"] = 0;
                        nuevaFila["Nombre"] = "Cualquier tema";
                        dataTable.Rows.InsertAt(nuevaFila, 0);

                        // Asignar el DataSource a la ComboBox
                        cmbTemas.DataSource = dataTable;
                        cmbTemas.DisplayMember = "Nombre";
                        cmbTemas.ValueMember = "Id";
                        cmbTemas.SelectedIndex = 0; // Seleccionar "Cualquier tema" por defecto
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
    }
}
