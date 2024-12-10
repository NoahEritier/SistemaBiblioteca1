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
using System.Transactions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registro_de_Libros : Form
    {
        public Registro_de_Libros()
        {
            InitializeComponent();
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"
        }

        private void Registro_de_Libros_Load(object sender, EventArgs e)
        {
            btnBuscarLibro.PerformClick();
        }


        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros
            string filtroTitulo = txtFiltroLibro.Text.Trim();
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();
            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM libros WHERE 1=1";

            // Filtrar por título si no está vacío
            if (!string.IsNullOrEmpty(filtroTitulo))
            {
                consulta += " AND titulo LIKE @filtroTitulo";
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

                    if(filtroPeriodo != "Cualquier momento")
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroPeriodo", filtroPeriodo);
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
            btnBuscarLibro_Click(sender, e);
        }

        private void btnModificarLibros_Click(object sender, EventArgs e)
        {
            // Verificar si hay un proyecto seleccionado
            if (dgvLibros.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvLibros.SelectedRows[0];

                    // Obtener el ID del proyecto seleccionado
                    int idLibro = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value); // Nombre exacto de la columna

                    // Abrir el formulario de modificación
                    NuevoLibro nuevoLibro = new NuevoLibro(idLibro);
                    nuevoLibro.ShowDialog();

                    // Refrescar la tabla después de la modificación
                    btnBuscarLibro_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar modificar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proyecto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

                            string consulta1 = "DELETE FROM libros_autores WHERE IdLibro = @Id";
                            MySqlCommand sqlCommand1 = new MySqlCommand(consulta1, mySqlConnection);
                            sqlCommand1.Parameters.AddWithValue("@Id", idLibro);

                            // Ejecutar el primer comando (libros_autores)
                            sqlCommand1.ExecuteNonQuery();

                            // Crear el comando SQL para eliminar de la tabla libros
                            string consulta2 = "DELETE FROM libros WHERE Id = @Id";
                            MySqlCommand sqlCommand2 = new MySqlCommand(consulta2, mySqlConnection);
                            sqlCommand2.Parameters.AddWithValue("@Id", idLibro);

                            // Ejecutar el segundo comando (libros)
                            sqlCommand2.ExecuteNonQuery();

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
