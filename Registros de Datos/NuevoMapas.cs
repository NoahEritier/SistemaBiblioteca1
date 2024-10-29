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

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevoMapas : Form
    {
        public NuevoMapas()
        {
            InitializeComponent();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles
            string nombre = cmbTema.Text.Trim();
            string descripcion = cmbIlustraciones.Text.Trim();

            // Validación básica de campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conexión a la base de datos
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(stringConexion))
            {
                try
                {
                    sqlConnection.Open();

                    // Consulta SQL para insertar un nuevo registro en la tabla "mapas"
                    string consulta = "INSERT INTO mapas (nombre, descripcion) VALUES (@nombre, @descripcion)";
                    SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                    sqlCommand.Parameters.AddWithValue("@descripcion", descripcion);

                    // Ejecutar el comando
                    int filasAfectadas = sqlCommand.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Mapa registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close(); // Cierra el formulario después de guardar
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el mapa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el mapa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema("Mapas");
            nuevoTema.ShowDialog(this);
        }
    }
}
