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
using WindowsFormsApp1.Registros_de_Datos;

namespace WindowsFormsApp1.Consultas
{
    public partial class Registro_de_Editoriales : Form
    {
        public Registro_de_Editoriales()
        {
            InitializeComponent();
        

            // Inicializar ComboBox con opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"
        }

        private void btnBuscarEditorial_Click(object sender, EventArgs e)
    {
        // Obtener los valores de los filtros
        string filtroNombre = txtFiltroNombre.Text.Trim();
        string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();

        // Construir la sentencia SQL dinámica
        string consulta = "SELECT * FROM editoriales WHERE 1=1";

        // Filtrar por nombre de autor si no está vacío
        if (!string.IsNullOrEmpty(filtroNombre))
        {
            consulta += " AND nombre LIKE @filtroNombre";
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
                if (!string.IsNullOrEmpty(filtroNombre))
                {
                    sqlCommand.Parameters.AddWithValue("@filtroNombre", "%" + filtroNombre + "%"); // Agrega los comodines %
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
                    dgvEditoriales.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                    dgvEditoriales.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }

        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {
            NuevaEditorial nuevaEditorial = new NuevaEditorial();
            nuevaEditorial.ShowDialog(this);
        }

        private void btnModificarEditoriales_Click(object sender, EventArgs e)
        {
            if (dgvEditoriales.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEditoriales.SelectedRows[0];

                int idEditorial = Convert.ToInt32(filaSeleccionada.Cells["id"].Value); // Nombre exacto de la columna
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();

                // Abrir el formulario de edición con los datos seleccionados
                NuevaEditorial nuevaEditorial = new NuevaEditorial(idEditorial, nombre);
                nuevaEditorial.ShowDialog(this);

                // Refrescar la lista de autores después de guardar cambios
                btnBuscarEditorial_Click(sender, e); // Vuelve a ejecutar la búsqueda
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una editorial para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarEditoriales_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvEditoriales.SelectedRows.Count > 0)
            {
                // Obtener el ID de la editorial seleccionada (asumiendo que el ID está en la primera columna)
                int idEditorial = Convert.ToInt32(dgvEditoriales.SelectedRows[0].Cells[0].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar esta editorial?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar la editorial
                            string query = "DELETE FROM editoriales WHERE Id = @Id"; // Asegúrate de que el nombre de la columna sea correcto
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idEditorial);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Editorial eliminada exitosamente.");

                            // Recargar la lista de editoriales después de eliminar
                            btnBuscarEditorial_Click(sender, e); // Llama a tu método de búsqueda para recargar
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar la editorial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecciona una editorial para eliminar.");
            }
        }
    }
}
