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

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevaTesis : Form
    {
        public NuevaTesis()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombreAutor = txtNombreAutor.Text.Trim();
            string apellidoAutor = txtApellidoAutor.Text.Trim();
            string titulo = txtTitulo.Text.Trim();
            int año = Convert.ToInt32(txtAño.Text.Trim());
            DateTime fechaRegistro = DateTime.Now;

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(nombreAutor))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(apellidoAutor))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El campo 'Titulo' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAño.Text))
            {
                MessageBox.Show("El campo 'Año' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Cadena de conexión desde el archivo de configuración
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Sentencia SQL para insertar datos
                    var sentencia = "INSERT INTO tesis (titulo, año, nombreAutor, apellidoAutor, fechaRegistro) VALUES (@titulo, @año, @nombreAutor, @apellidoAutor, @fechaRegistro)";

                    // Crear el comando SQL
                    using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                    {
                        // Asignar los valores a los parámetros
                        sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                        sqlCommand.Parameters.AddWithValue("@año", año);
                        sqlCommand.Parameters.AddWithValue("@nombreAutor", nombreAutor);
                        sqlCommand.Parameters.AddWithValue("@apellidoAutor", apellidoAutor);
                        sqlCommand.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);


                        // Ejecutar la inserción
                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show("Tesis registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la tesis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar la tesis: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión
                    mySqlConnection.Close();
                }
            }
        }
    }
}
