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

            string consulta = "SELECT Id, Nombre FROM Temas WHERE Grupo = 'Enciclopedias' ORDER BY Nombre";
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
                        cmbFiltroTema.DataSource = dataTable;
                        cmbFiltroTema.DisplayMember = "Nombre";
                        cmbFiltroTema.ValueMember = "Id";
                        cmbFiltroTema.SelectedIndex = 0; // Seleccionar "Cualquier tema" por defecto
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
            int idTema = Convert.ToInt32(cmbFiltroTema.SelectedValue);
            string filtroIdioma = cmbFiltroIdioma.SelectedItem.ToString();

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM enciclopedias WHERE 1=1";

            // Filtrar por título si no está vacío
            if (!string.IsNullOrEmpty(titulo))
            {
                consulta += " AND nombre LIKE @titulo";
            }

            if (cmbFiltroIdioma.SelectedIndex != 0)
            {
                consulta += " AND idioma = @idioma";
            }

            if (idTema != 0)
            {
                consulta += " AND idTema = @idTema";
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

                    if (cmbFiltroIdioma.SelectedIndex != 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@idioma", filtroIdioma);
                    }

                    if (idTema != 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@idTema", idTema);
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
            if (dgvEnciclopedia.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEnciclopedia.SelectedRows[0];

                int idEnciclopedia = Convert.ToInt32(filaSeleccionada.Cells["id"].Value); // Nombre exacto de la columna
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                int idEditorial = Convert.ToInt32(dgvEnciclopedia.SelectedRows[0].Cells["IdEditorial"].Value);
                string idioma = dgvEnciclopedia.SelectedRows[0].Cells["Idioma"].Value.ToString();
                int año = Convert.ToInt32(dgvEnciclopedia.SelectedRows[0].Cells["Año"].Value);
                int? tomos = dgvEnciclopedia.SelectedRows[0].Cells["Tomos"].Value != DBNull.Value ?
                             Convert.ToInt32(dgvEnciclopedia.SelectedRows[0].Cells["Tomos"].Value) : (int?)null;
                int idTema = Convert.ToInt32(dgvEnciclopedia.SelectedRows[0].Cells["IdTema"].Value);


                // Abrir el formulario de edición con los datos seleccionados
                NuevaEnciclopedia nuevaEnciclopedia = new NuevaEnciclopedia(idEnciclopedia, nombre, idioma, idEditorial, año, tomos, idTema);
                nuevaEnciclopedia.ShowDialog(this);

                // Refrescar la lista de autores después de guardar cambios
                btnBuscarEnciclopedia_Click(sender, e); // Vuelve a ejecutar la búsqueda
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una enciclopedia para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
