using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Registros_de_Datos;

namespace WindowsFormsApp1.Consultas
{
    public partial class Registro_de_Diccionarios : Form
    {
        public Registro_de_Diccionarios()
        {
            InitializeComponent();

            // Inicializar ComboBox con opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"


            cmbFiltroIdioma.SelectedIndex = 0;
            // Llamar al método para cargar los temas en la ComboBox
            CargarTemas();
        }

        // Método para cargar los nombres de los temas en cmbFiltroTema
        private void CargarTemas()
        {
            // Cadena de conexión desde el archivo de configuración
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Consulta para obtener los nombres de los temas
                    string consulta = "SELECT nombre FROM temas";

                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);
                    MySqlDataReader reader = sqlCommand.ExecuteReader();

                    // Agregar "Todos los temas" como opción predeterminada
                    cmbFiltroTema.Items.Add("Todos los temas");

                    // Llenar la ComboBox con los nombres de los temas
                    while (reader.Read())
                    {
                        cmbFiltroTema.Items.Add(reader["nombre"].ToString());
                    }

                    reader.Close();

                    cmbFiltroTema.SelectedIndex = 0; // Seleccionar "Todos los temas" como opción predeterminada
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

        private void btnNuevaEnciclopedia_Click(object sender, EventArgs e)
        {
            NuevaEnciclopedia nuevaEnciclopedia = new NuevaEnciclopedia();
            nuevaEnciclopedia.ShowDialog(this);
        }

        private void btnBuscarEnciclopedia_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros
            string titulo = txtFiltroTituloEnciclopedia.Text.Trim();
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();
            string temaSeleccionado = cmbFiltroTema.SelectedItem.ToString();
            string filtroIdioma = cmbFiltroIdioma.SelectedItem.ToString();

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM enciclopedias WHERE 1=1";

            // Filtrar por título si no está vacío
            if (!string.IsNullOrEmpty(titulo))
            {
                consulta += " AND nombre LIKE @titulo";
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
                    if (!string.IsNullOrEmpty(titulo))
                    {
                        sqlCommand.Parameters.AddWithValue("@titulo", "%" + titulo + "%"); // Agrega los comodines %
                    }

                    if (filtroIdioma != "Cualquier idioma")
                    {
                        sqlCommand.Parameters.AddWithValue("@idioma", filtroIdioma);
                        consulta += " AND idioma = @filtroIdioma";
                    }

                    // Solo filtrar por tema si se seleccionó uno distinto de "Todos los temas"
                    //if (cmbFiltroTema.SelectedIndex != 0) // "Todos los temas" es la primera opción
                    //{
                      //  sqlCommand.Parameters.AddWithValue("@tema", temaSeleccionado);
                        //consulta += " AND tema = @tema"; // Asegúrate de agregar la condición para el tema en la consulta.
                    //}

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
                        dgvEnciclopedia.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvEnciclopedia.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar las enciclopedias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnModificarEnciclopedias_Click(object sender, EventArgs e)
        {
            NuevaEnciclopedia nuevaEnciclopedia = new NuevaEnciclopedia();
            nuevaEnciclopedia.ShowDialog(this);
        }

        private void btnEliminarEnciclopedias_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvEnciclopedia.SelectedRows.Count > 0)
            {
                // Obtener el ID de la enciclopedia seleccionada (asumiendo que el ID está en la primera columna)
                int idEnciclopedia = Convert.ToInt32(dgvEnciclopedia.SelectedRows[0].Cells[0].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta enciclopedia?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar la enciclopedia
                            string query = "DELETE FROM enciclopedias WHERE Id = @Id"; // Asegúrate de que el nombre de la columna sea correcto
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idEnciclopedia);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Enciclopedia eliminada exitosamente.");

                            // Recargar la lista de enciclopedias después de eliminar
                            btnBuscarEnciclopedia_Click(sender, e); // Llama a tu método de búsqueda para recargar
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar la enciclopedia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecciona una enciclopedia para eliminar.");
            }
        }
    }
}
