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

namespace WindowsFormsApp1
{
    public partial class NuevoAutor : Form
    {
        public NuevoAutor()
        {
            InitializeComponent();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombre = txtNombreAutor.Text.Trim();
            string apellido = txtApellidoAutor.Text.Trim();
            string nacionalidad = txtNacionalidadAutor.Text.Trim(); // Campo no obligatorio
            DateTime fechaRegistro = DateTime.Now;

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var sentencia = "INSERT INTO autores (nombre, apellido, nacionalidad, fechaRegistro) VALUES (@nombre, @apellido, @nacionalidad, @fechaRegistro)";

                    // Crear el comando SQL
                    using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                    {
                        // Asignar los valores a los parámetros
                        sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                        sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                        sqlCommand.Parameters.AddWithValue(@"fechaRegistro", fechaRegistro);

                        // Si nacionalidad está vacía, se inserta como NULL
                        if (string.IsNullOrEmpty(nacionalidad))
                        {
                            sqlCommand.Parameters.AddWithValue("@nacionalidad", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@nacionalidad", nacionalidad);
                        }

                        // Ejecutar la inserción
                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show("Autor registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión
                    mySqlConnection.Close();
                }
            }
        }

        private void btnCancelar_CLick(object sender, EventArgs e)
        {
            Close();
        }
    }
}