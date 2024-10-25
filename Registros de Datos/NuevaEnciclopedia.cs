using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using static WindowsFormsApp1.Registros_de_Datos.NuevoDiccionario;

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevaEnciclopedia : Form
    {
        public NuevaEnciclopedia()
        {
            InitializeComponent();
            CargarEditoriales();
            CargarTemas();  // Cargar temas al iniciar el formulario
        }

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

        private void CargarTemas()
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT id, nombre FROM temas"; // Consulta para obtener los temas

                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<Tema> temas = new List<Tema>(); // Lista para almacenar objetos Tema
                            while (reader.Read())
                            {
                                temas.Add(new Tema // Crear una instancia de Tema
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["nombre"].ToString()
                                });
                            }

                            // Asignar la lista de temas al ComboBox
                            cmbTemas.DataSource = temas; // Asumiendo que tienes un ComboBox para temas
                            cmbTemas.DisplayMember = "Nombre"; // Muestra el nombre
                            cmbTemas.ValueMember = "Id"; // Almacena el ID
                            cmbTemas.SelectedIndex = -1; // Sin selección por defecto
                            cmbTemas.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los temas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            DateTime fechaRegistro = DateTime.Now;
            string titulo = txtTitulo.Text.Trim();

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El campo 'Titulo' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el id de la editorial seleccionada
            if (cmbEditoriales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEditorial = Convert.ToInt32(cmbEditoriales.SelectedValue);  // Obtener el ID de la editorial seleccionada

            // Obtener el id del tema seleccionado
            if (cmbTemas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idTema = Convert.ToInt32(cmbTemas.SelectedValue);  // Obtener el ID de la tema seleccionada

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

                    // Sentencia SQL para insertar datos, incluyendo el idTema
                    var sentencia = "INSERT INTO enciclopedias (nombre, año, tomos, fechaRegistro, idEditorial, idioma, idTema) VALUES (@titulo, @año, @tomos, @fechaRegistro, @idEditorial, @idioma, @idTema)";

                    // Crear el comando SQL
                    using (MySqlCommand sqlCommand = new MySqlCommand(sentencia, mySqlConnection))
                    {
                        // Asignar los valores a los parámetros
                        sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                        sqlCommand.Parameters.AddWithValue("@año", año);
                        sqlCommand.Parameters.AddWithValue("@tomos", tomos);
                        sqlCommand.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                        sqlCommand.Parameters.AddWithValue("@idEditorial", idEditorial);
                        sqlCommand.Parameters.AddWithValue("@idioma", idioma);
                        sqlCommand.Parameters.AddWithValue("@idTema", idTema); // Agregar el ID del tema

                        // Ejecutar la inserción
                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show("Enciclopedia registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la enciclopedia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar la enciclopedia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión
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
            nuevaEditorial.ShowDialog(this);
            CargarEditoriales(); // Cargar nuevamente las editoriales después de cerrar el formulario
        }

        private void btnAgregarNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema("Enciclopedias");
            nuevoTema.ShowDialog(this);
            CargarTemas(); // Cargar nuevamente los temas después de cerrar el formulario
        }
    }

    // Clase Tema para almacenar id y nombre
    public class Tema
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
