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
    public partial class registro_de_temas : Form
    {
        public string Grupo = string.Empty;
        public registro_de_temas(string grupo)
        {
            InitializeComponent();
            // Inicializar ComboBox con opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"
            Grupo = grupo;
        }


        private void btnNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema(Grupo);
            nuevoTema.ShowDialog(this);
        }

        private void btnBuscarTema_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los filtros
            string nombreNroTema = txtFiltroNombreNroTema.Text.Trim();
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT Id, Nombre, NumeroTema FROM temas WHERE 1=1";

            // Filtrar por grupo
            consulta += " AND grupo = @grupo";

            // Verificar si el valor de nombreNroTema es numérico o texto
            int numeroTema;
            bool esNumero = int.TryParse(nombreNroTema, out numeroTema);

            if (esNumero)
            {
                // Si es numérico, aplicar coincidencia exacta en numeroTema
                consulta += " AND numeroTema = @numeroTema";
            }
            else if (!string.IsNullOrEmpty(nombreNroTema))
            {
                // Si no es numérico, aplicar coincidencia parcial en nombre
                consulta += " AND nombre LIKE @nombre";
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

                    // Asignar valores a los parámetros según el tipo de valor ingresado en nombreNroTema
                    sqlCommand.Parameters.AddWithValue("@grupo", Grupo);

                    if (esNumero)
                    {
                        sqlCommand.Parameters.AddWithValue("@numeroTema", numeroTema);
                    }
                    else if (!string.IsNullOrEmpty(nombreNroTema))
                    {
                        sqlCommand.Parameters.AddWithValue("@nombre", "%" + nombreNroTema + "%");
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
                        dgvTemas.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvTemas.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los temas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnModificarTemas_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema(Grupo);
            nuevoTema.ShowDialog(this);
        }

        private void btnEliminarTemas_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvTemas.SelectedRows.Count > 0)
            {
                // Obtener el ID del tema seleccionado (asumiendo que el ID está en la primera columna)
                int idTema = Convert.ToInt32(dgvTemas.SelectedRows[0].Cells["Id"].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este tema?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar el tema
                            string query = "DELETE FROM temas WHERE Id = @Id";
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idTema);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Tema eliminado exitosamente.");

                            // Recargar la lista de temas después de eliminar
                            btnBuscarTema_Click(sender, e); // Llama al método de búsqueda para actualizar la lista
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el tema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecciona un tema para eliminar.");
            }
        }
    }
}
