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
public partial class NuevoJuego : Form
    {
        public NuevoJuego()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
        //Obtener datos del formulario
        string nombre = txtNombre.Text.Trim();
        int cantidad = (int)NumCantidad.Value;
        DateTime fechaRegistro = DateTime.Now;

        // Validar campos obligatorios
        if (string.IsNullOrEmpty(nombre))
        {
            MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (cantidad <= 0)
        {
            MessageBox.Show("La cantidad debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var sentencia = "INSERT INTO juegos (nombre, cantidad, fechaRegistro) VALUES (@nombre, @cantidad, @fechaRegistro)";

                // Crear el comando SQL
                using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                {
                    // Asignar los valores a los parámetros
                    sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                    sqlCommand.Parameters.AddWithValue("@cantidad", cantidad);
                    sqlCommand.Parameters.AddWithValue(@"fechaRegistro", fechaRegistro);


                    // Ejecutar la inserción
                    int registrosAfectados = sqlCommand.ExecuteNonQuery();

                    if (registrosAfectados > 0)
                    {
                        MessageBox.Show("Juegos registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el juego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el juego: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
