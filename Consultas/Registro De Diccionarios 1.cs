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
    public partial class Registro_De_Diccionarios_1 : Form
    {
        public Registro_De_Diccionarios_1()
        {
            InitializeComponent();

            // Inicializar ComboBox con opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3; // Por defecto: "Cualquier momento"
        }

        private void btnNuevoDiccionario_Click(object sender, EventArgs e)
        {
            NuevoDiccionario nuevoDiccionario = new NuevoDiccionario();
            nuevoDiccionario.ShowDialog(this);
        }

        private void btnBuscarDiccionario_Click(object sender, EventArgs e)
        {

            string filtroIdioma = cmbFiltroIdiomas.SelectedItem != null ? cmbFiltroIdiomas.SelectedItem.ToString() : string.Empty;
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();
            int filtroAño = 0;

            // Construir la sentencia SQL dinámica
            string consulta = "SELECT * FROM diccionarios WHERE 1=1";

            if (!string.IsNullOrEmpty(txtFiltroAño.Text.Trim()))
            {
                try
                {
                    // Convertir el valor a entero
                    filtroAño = Convert.ToInt32(txtFiltroAño.Text.Trim());

                    // Agregar el filtro por año a la consulta si se ingresó un valor válido
                    consulta += " AND año = @filtroAño";
                    // Asignar el parámetro @filtroAño

                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido para el año.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener la ejecución si hay un error de formato
                }
            }

            // Filtrar por nacionalidad si no está vacío
            if (!string.IsNullOrEmpty(filtroIdioma))
            {
                consulta += " AND idioma LIKE @filtroIdioma";
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

                    if (!string.IsNullOrEmpty(filtroIdioma))
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroIdioma", "%" + filtroIdioma + "%"); // Agrega los comodines %
                    }
                    if (filtroAño != 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@filtroAño", filtroAño); // Agrega los comodines %
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
                        dgvDiccionarios.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvDiccionarios.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los diccionarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
