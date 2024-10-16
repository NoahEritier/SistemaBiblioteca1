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

        private void txtFiltroAutor_Click(object sender, EventArgs e)
        {
            txtFiltroAutor.Clear();
        }

        // Eliminar texto al hacer clic en txtFiltroNacionalidad
        private void txtFiltroNacionalidad_Click(object sender, EventArgs e)
        {
            txtFiltroNacionalidad.Clear();
        }

        private void Registro_de_Autores_Load(object sender, EventArgs e)
        {

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
                consulta += " AND nombre LIKE @filtroAutor";
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
                        sqlCommand.Parameters.AddWithValue("@filtroAutor", "%" + filtroAutor + "%");
                    }

                    if (!string.IsNullOrEmpty(filtroNacionalidad))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroNacionalidad", "%" + filtroNacionalidad + "%");
                    }

                    if (filtroPeriodo != "Cualquier momento")
                    {
                        sqlCommand.Parameters.AddWithValue("@fechaFiltro", fechaFiltro);
                    }

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Mostrar los resultados en el DataGridView
                    dgvAutores.DataSource = dataTable;
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

    }
}