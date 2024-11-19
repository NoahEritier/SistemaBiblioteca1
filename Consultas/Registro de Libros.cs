using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registro_de_Libros : Form
    {
        public Registro_de_Libros()
        {
            InitializeComponent();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros
            string filtroTitulo = txtFiltroLibro.Text.Trim();
            string filtroAutor = cmbFiltroPeriodo.Text.Trim();

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM libros WHERE 1=1";

            // Filtrar por título si no está vacío
            if (!string.IsNullOrEmpty(filtroTitulo))
            {
                consulta += " AND titulo LIKE @filtroTitulo";
            }

            // Filtrar por autor si no está vacío
            if (!string.IsNullOrEmpty(filtroAutor))
            {
                consulta += " AND autor LIKE @filtroAutor";
            }

            // Conectar a la base de datos y ejecutar la consulta
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Crear el comando SQL con la consulta
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    // Asignar valores a los parámetros si son necesarios
                    if (!string.IsNullOrEmpty(filtroTitulo))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroTitulo", "%" + filtroTitulo + "%");
                    }

                    if (!string.IsNullOrEmpty(filtroAutor))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroAutor", "%" + filtroAutor + "%");
                    }

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos y mostrarlos en el DataGridView
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvLibros.AutoGenerateColumns = true;
                        dgvLibros.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                        dgvLibros.DataSource = null;  // Limpia el DataGridView si no hay resultados
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            NuevoLibro nuevoLibro = new NuevoLibro();
            nuevoLibro.ShowDialog(this);
        }

        private void btnModificarLibros_Click(object sender, EventArgs e)
        {
            NuevoLibro nuevoLibro = new NuevoLibro();
            nuevoLibro.ShowDialog(this);
        }

        private void btnEliminarLibros_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvLibros.SelectedRows.Count > 0)
            {
                // Obtener el ID del libro seleccionado (asumiendo que el ID está en la primera columna)
                int idLibro = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[0].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este libro?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar el libro
                            string consulta = "DELETE FROM libros_autores WHERE IdLibro = @Id";
                            string query = "DELETE FROM libros WHERE Id = @Id"; // Asegúrate de que el nombre de la columna sea correcto
                            MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);
                            MySqlCommand sqlCommand2 = new MySqlCommand(query, mySqlConnection);

                            sqlCommand.Parameters.AddWithValue("@Id", idLibro);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Libro eliminado exitosamente.");

                            // Recargar la lista de libros después de eliminar
                            btnBuscarLibro_Click(sender, e); // Llama a tu método de búsqueda para recargar
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecciona un libro para eliminar.");
            }
        }

        private void cmbFiltroPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
