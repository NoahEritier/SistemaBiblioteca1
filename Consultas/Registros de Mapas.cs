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
