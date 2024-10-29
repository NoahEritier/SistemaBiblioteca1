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
            CargarMapas();
        }

        private void CargarMapas()
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(stringConexion))
            {
                try
                {
                    sqlConnection.Open();

                    // Crear el comando SQL para seleccionar todos los mapas
                    string consulta = "SELECT * FROM mapas";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, sqlConnection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable como fuente de datos del DataGridView
                    dgvMapas.AutoGenerateColumns = true;  // Asegura que se generen columnas automáticamente
                    dgvMapas.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los mapas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarMapa_Click(object sender, EventArgs e)
        {
            // Obtener el valor de filtro desde el TextBox
            string filtroNombre = txtFiltroTema.Text.Trim();

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(stringConexion))
            {
                try
                {
                    sqlConnection.Open();

                    // Crear la consulta SQL con filtro por nombre, si está especificado
                    string consulta = "SELECT * FROM mapas WHERE 1=1";

                    if (!string.IsNullOrEmpty(filtroNombre))
                    {
                        consulta += " AND nombre LIKE @filtroNombre";
                    }

                    // Crear el comando SQL y agregar parámetros si es necesario
                    SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection);

                    if (!string.IsNullOrEmpty(filtroNombre))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroNombre", "%" + filtroNombre + "%");
                    }

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos y asignarlos al DataGridView
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvMapas.AutoGenerateColumns = true;  // Asegura que se generen columnas automáticamente
                        dgvMapas.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar mapas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoMapa_Click(object sender, EventArgs e)
        {
            NuevoMapas nuevoMapas = new NuevoMapas();
            nuevoMapas.ShowDialog(this);
        }

        private void btnModificarMapas_Click(object sender, EventArgs e)
        {
            NuevoMapas nuevoMapas = new NuevoMapas();
            nuevoMapas.ShowDialog(this);
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
                    using (SqlConnection sqlConnection = new SqlConnection(stringConexion))
                    {
                        try
                        {
                            sqlConnection.Open();

                            // Crear el comando SQL para eliminar el mapa
                            string query = "DELETE FROM mapas WHERE Id = @Id";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idMapa);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Mapa eliminado exitosamente.");

                            // Recargar la lista de mapas después de eliminar
                            btnBuscarMapa_Click(sender, e); // Llama al método de búsqueda para actualizar la lista
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el mapa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un mapa para eliminar.");
            }
        }
    }
}
