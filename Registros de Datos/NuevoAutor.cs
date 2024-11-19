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
        private int? autorId = null; // ID del autor para edición

        // Constructor para nuevo o existente
        public NuevoAutor(int? id = null, string nombre = "", string apellido = "", string nacionalidad = "")
        {
            InitializeComponent();

            autorId = id; // Si es null, es un nuevo autor

            // Rellenar los campos si se pasa información
            txtNombreAutor.Text = nombre;
            txtApellidoAutor.Text = apellido;
            txtNacionalidadAutor.Text = nacionalidad;

            if (autorId != null)
            {
                this.Text = "Modificar Autor"; // Cambia el título de la ventana
            }
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAutor.Text.Trim();
            string apellido = txtApellidoAutor.Text.Trim();
            string nacionalidad = txtNacionalidadAutor.Text.Trim();

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Los campos 'Nombre' y 'Apellido' son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    string query;
                    if (autorId == null) // Nuevo autor
                    {
                        query = "INSERT INTO autores (nombre, apellido, nacionalidad, fechaRegistro) VALUES (@nombre, @apellido, @nacionalidad, @fechaRegistro)";
                    }
                    else // Modificar autor existente
                    {
                        query = "UPDATE autores SET nombre = @nombre, apellido = @apellido, nacionalidad = @nacionalidad WHERE id = @id";
                    }

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                        sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                        sqlCommand.Parameters.AddWithValue("@nacionalidad", string.IsNullOrEmpty(nacionalidad) ? DBNull.Value : (object)nacionalidad);

                        if (autorId != null)
                        {
                            sqlCommand.Parameters.AddWithValue("@id", autorId);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@fechaRegistro", DateTime.Now);
                        }

                        int registrosAfectados = sqlCommand.ExecuteNonQuery();
                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show(autorId == null ? "Autor registrado correctamente." : "Autor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}