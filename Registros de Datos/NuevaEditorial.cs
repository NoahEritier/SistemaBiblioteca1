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
    public partial class NuevaEditorial : Form
    {
        private int? editorialId = null; // ID del autor para edición

        public NuevaEditorial(int? id = null, string nombre = "")
        {
            InitializeComponent();

            editorialId = id;
            txtNombreEditorial.Text = nombre;

            if (editorialId != null)
            {
                this.Text = "Modificar Editorial"; // Cambia el título de la ventana
            }
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string nombre = txtNombreEditorial.Text.Trim();

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sentencia;
                    if (editorialId == null)
                    {
                        sentencia = "INSERT INTO editoriales (nombre, fechaRegistro) VALUES (@nombre, @fechaRegistro)";
                    }
                    else
                    {
                        sentencia = "UPDATE editoriales SET nombre = @nombre WHERE id = @id";
                    }
                    // Crear el comando SQL
                    using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                    {
                        // Asignar los valores a los parámetros
                        sqlCommand.Parameters.AddWithValue("@nombre", nombre);

                        if (editorialId != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@id", editorialId);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@fechaRegistro", DateTime.Now);
                        }
                        // Ejecutar la inserción
                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show("Editorial registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar la editorial: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión
                    mySqlConnection.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
