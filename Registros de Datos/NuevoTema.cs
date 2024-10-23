﻿using MySql.Data.MySqlClient;
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
    public partial class NuevoTema : Form
    {
        public NuevoTema()
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
            string nombre = txtNombre.Text.Trim();
            string numeroTema = txtNumerodeTema.Text.Trim(); // Campo no obligatorio
            DateTime fechaRegistro = DateTime.Now;

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(numeroTema))
            {
                MessageBox.Show("El campo 'NumerodeTema' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var sentencia = "INSERT INTO temas (nombre, numeroTema) VALUES (@nombre, @numeroTema)";

                    // Crear el comando SQL
                    using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                    {
                        // Asignar los valores a los parámetros
                        sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                        sqlCommand.Parameters.AddWithValue("@numeroTema", numeroTema);
                        sqlCommand.Parameters.AddWithValue(@"fechaRegistro", fechaRegistro);


                        // Ejecutar la inserción
                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show("Tema registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el tema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el tema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
