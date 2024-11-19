using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registro_de_Autores : Form
    {
        public Registro_de_Autores()
        {
            InitializeComponent();

            // Inicializar ComboBox con opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros
            string filtroAutor = txtFiltroAutor.Text.Trim();
            string filtroNacionalidad = txtFiltroNacionalidad.Text.Trim();
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM autores WHERE 1=1";

            // Filtrar por nombre de autor si no está vacío
            if (!string.IsNullOrEmpty(filtroAutor))
            {
                // Buscar coincidencia en nombre o apellido
                consulta += " AND (nombre LIKE @filtroAutor OR apellido LIKE @filtroAutor)";
            }

            // Filtrar por nacionalidad si no está vacío
            if (!string.IsNullOrEmpty(filtroNacionalidad))
            {
                consulta += " AND nacionalidad LIKE @filtroNacionalidad";
            }

            // Filtrar por el periodo de tiempo en FechaRegistro
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
                    if (!string.IsNullOrEmpty(filtroAutor))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroAutor", "%" + filtroAutor + "%"); // Agrega los comodines %
                    }

                    if (!string.IsNullOrEmpty(filtroNacionalidad))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroNacionalidad", "%" + filtroNacionalidad + "%"); // Agrega los comodines %
                    }

                    if (filtroPeriodo != "Cualquier momento")
                    {
                        sqlCommand.Parameters.AddWithValue("@fechaFiltro", fechaFiltro);
                    }

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvAutores.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvAutores.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los autores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            NuevoAutor nuevoAutor = new NuevoAutor();
            nuevoAutor.ShowDialog(this);
        }

        private void btnModificarAutores_Click(object sender, EventArgs e)
        {
            NuevoAutor nuevoAutor = new NuevoAutor();
            nuevoAutor.ShowDialog(this);
        }

        private void btnEliminarAutores_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvAutores.SelectedRows.Count > 0)
            {
                // Obtener el ID del autor seleccionado (asumiendo que el ID está en la primera columna)
                int idAutor = Convert.ToInt32(dgvAutores.SelectedRows[0].Cells[0].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este autor?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar el autor
                            string query = "DELETE FROM autores WHERE Id = @Id"; // Asegúrate de que el nombre de la columna sea correcto
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idAutor);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Autor eliminado exitosamente.");

                            // Recargar la lista de autores después de eliminar
                            btnBuscarAutor_Click(sender, e); // Llama a tu método de búsqueda para recargar
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecciona un autor para eliminar.");
            }
        }
    }
}
