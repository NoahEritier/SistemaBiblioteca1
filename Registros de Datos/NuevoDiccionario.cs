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
    public partial class NuevoDiccionario : Form
    {
        // Clase para representar Editorial
        public class Editorial
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            // Sobrescribir el método ToString() para que el ComboBox muestre solo el nombre
            public override string ToString()
            {
                return Nombre;
            }
        }

            public NuevoDiccionario()
            {
                InitializeComponent();

                // Cargar las editoriales en el ComboBox
                CargarEditoriales();
            }

            // Método para cargar las editoriales en el ComboBox
            private void CargarEditoriales()
            {
                var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                {
                    try
                    {
                        mySqlConnection.Open();
                        string query = "SELECT id, nombre FROM editoriales";

                        using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                List<Editorial> editoriales = new List<Editorial>();
                                while (reader.Read())
                                {
                                    // Crear instancias de la clase Editorial con los datos de la base de datos
                                    editoriales.Add(new Editorial
                                    {
                                        Id = Convert.ToInt32(reader["id"]),
                                        Nombre = reader["nombre"].ToString()
                                    });
                                }

                                // Asignar la lista de editoriales al ComboBox
                                cmbEditoriales.DataSource = editoriales;

                                // Establecer el DisplayMember para mostrar el nombre y el ValueMember para el id
                                cmbEditoriales.DisplayMember = "Nombre";  // Mostrará solo el nombre
                                cmbEditoriales.ValueMember = "Id";        // Internamente trabajará con el id
                                cmbEditoriales.SelectedIndex = -1; // Esto hace que no haya ninguna opción seleccionada
                                cmbEditoriales.Text = "";
                        }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar las editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void btnRegistrarDiccionario_Click(object sender, EventArgs e)
            {
                // Obtener el id de la editorial seleccionada
                if (cmbEditoriales.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idEditorial = Convert.ToInt32(cmbEditoriales.SelectedValue);  // Obtener el ID de la editorial seleccionada

                // Obtener el valor del idioma seleccionado
                if (cmbIdiomas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un idioma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string idioma = cmbIdiomas.SelectedItem.ToString(); // Idioma seleccionado

                // Validar y obtener el año
                int año;
                if (string.IsNullOrEmpty(txtAño.Text.Trim()) || !int.TryParse(txtAño.Text.Trim(), out año))
                {
                    MessageBox.Show("El campo 'Año' es obligatorio y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el número de tomos, que es opcional
                int? tomos = null;
                if (!string.IsNullOrEmpty(txtTomos.Text.Trim()))
                {
                    int valorTomos;
                    if (int.TryParse(txtTomos.Text.Trim(), out valorTomos))
                    {
                        tomos = valorTomos; // Si se ingresa, se guarda
                    }
                    else
                    {
                        MessageBox.Show("El campo 'Tomos' debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Cadena de conexión desde el archivo de configuración
                var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

                using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                {
                    try
                    {
                        mySqlConnection.Open();

                        // Sentencia SQL para insertar datos
                        string sentencia = "INSERT INTO diccionarios (idEditorial, idioma, año, tomos) VALUES (@idEditorial, @idioma, @año, @tomos)";

                        // Crear el comando SQL
                        using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                        {
                            // Asignar los valores a los parámetros
                            sqlCommand.Parameters.AddWithValue("@idEditorial", idEditorial);
                            sqlCommand.Parameters.AddWithValue("@idioma", idioma);
                            sqlCommand.Parameters.AddWithValue("@año", año);

                            // Si no se ingresaron tomos, insertar NULL
                            if (tomos.HasValue)
                            {
                                sqlCommand.Parameters.AddWithValue("@tomos", tomos);
                            }
                            else
                            {
                                sqlCommand.Parameters.AddWithValue("@tomos", DBNull.Value);
                            }

                            // Ejecutar la inserción
                            int registrosAfectados = sqlCommand.ExecuteNonQuery();

                            if (registrosAfectados > 0)
                            {
                                MessageBox.Show("Diccionario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar el diccionario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al registrar el diccionario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }

            private void btnCancelarRegistro_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void btnAgregarNuevaEditorial_Click(object sender, EventArgs e)
            {
                NuevaEditorial nuevaEditorial = new NuevaEditorial();
                nuevaEditorial.ShowDialog();
            }
        
    }
}
