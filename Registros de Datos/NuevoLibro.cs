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

namespace WindowsFormsApp1
{
    public partial class NuevoLibro : Form
    {
        public NuevoLibro()
        {
            InitializeComponent();
            CargarAutores();
            CargarEditorial();
            CargarTemas();
            CargarNivel();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string titulo = txtTitulo.Text.Trim();
            int edicion;
            if (!int.TryParse(txtEdicion.Text.Trim(), out edicion))
            {
                MessageBox.Show("Por favor, ingresa un número válido para la edición.");
                return; // Salir de la función si no es un número válido.
            }

            string resumen = txtResumen.Text.Trim();
            string palabrasClave = txtPalabrasClave.Text.Trim();
            DateTime fechaRegistro = DateTime.Now;


            // Validar campos obligatorios
            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El campo 'Título' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var sentenciaInsert = "INSERT INTO Libros (nombre, edicion) VALUES (@nombre, @edicion)";

                    using (MySqlCommand sqlCommandInsert = new MySqlCommand(sentenciaInsert, mySqlConnection))
                    {
                        sqlCommandInsert.Parameters.AddWithValue("@nombre", titulo);
                        sqlCommandInsert.Parameters.AddWithValue("@edicion", edicion);

                        int registrosAfectados = sqlCommandInsert.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            var sentenciaSelectId = "SELECT LAST_INSERT_ID();";
                            using (MySqlCommand sqlCommandSelect = new MySqlCommand(sentenciaSelectId, mySqlConnection))
                            {
                                object result = sqlCommandSelect.ExecuteScalar();
                                txtId.Text = result != null ? result.ToString() : "0";
                            }
                        }
                        else
                        {
                            txtId.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el Libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void btnAgregarNuevoAutor_Click(object sender, EventArgs e)
        {
            NuevoAutor nuevoAutor = new NuevoAutor();
            nuevoAutor.ShowDialog(this);
        }

        private void btnAgregarNuevaEditorial_Click(object sender, EventArgs e)
        {
            NuevaEditorial nuevaEditorial = new NuevaEditorial();
            nuevaEditorial.ShowDialog(this);
        }

        private void btnAgregarNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema("Libros");
            nuevoTema.ShowDialog(this);
        }

        private void btnPasarAGrilla_Click(object sender, EventArgs e)
        {
            if (cmbAutores.SelectedValue != null)
            {
                // Cadena de conexión desde el archivo de configuración
                var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

                using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                {
                    try
                    {
                        mySqlConnection.Open();

                        // Sentencia SQL para insertar datos en la tabla de relación
                        var sentenciaInsert = "INSERT INTO Libros_Autores (IdLibro, IdAutor) VALUES (@IdLibro, @IdAutor)";

                        using (MySqlCommand sqlCommandInsert = new MySqlCommand(sentenciaInsert, mySqlConnection))
                        {
                            // Asignar los valores a los parámetros
                            sqlCommandInsert.Parameters.AddWithValue("@IdLibro", txtId.Text);
                            sqlCommandInsert.Parameters.AddWithValue("@IdAutor", cmbAutores.SelectedValue);

                            // Ejecutar la inserción
                            int registrosAfectados = sqlCommandInsert.ExecuteNonQuery();

                            if (registrosAfectados > 0)
                            {
                                CargarGrillaAutores();
                                // Confirmación de inserción exitosa
                                MessageBox.Show("Autor agregado correctamente al libro.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar el autor al libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al registrar el Autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
                }
            }
        }

        private void NuevoLibro_Load(object sender, EventArgs e)
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Sentencia SQL para insertar datos
                    var sentenciaInsert = "INSERT INTO Libros (Titulo) VALUES (@titulo)";

                    // Crear el comando SQL para la inserción
                    using (MySqlCommand sqlCommandInsert = new MySqlCommand(sentenciaInsert, mySqlConnection))
                    {
                        // Asignar el valor del parámetro
                        sqlCommandInsert.Parameters.AddWithValue("@titulo", "Nombre del libro");

                        // Ejecutar la inserción
                        int registrosAfectados = sqlCommandInsert.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            // Si la inserción fue exitosa, obtener el ID del último registro insertado
                            var sentenciaSelectId = "SELECT LAST_INSERT_ID();";

                            // Crear el comando SQL para obtener el último ID
                            using (MySqlCommand sqlCommandSelect = new MySqlCommand(sentenciaSelectId, mySqlConnection))
                            {
                                object result = sqlCommandSelect.ExecuteScalar();

                                // Convertir el resultado a texto si no es null, y asignarlo al TextBox
                                txtId.Text = result != null ? result.ToString() : "0";
                            }
                        }
                        else
                        {
                            // Si no se insertaron registros, asignar "0" al TextBox
                            txtId.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el Libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión
                    mySqlConnection.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAutores.SelectedRows.Count > 0)
            {
                int idAutor = Convert.ToInt32(dgvAutores.CurrentRow.Cells[0].Value);
                int idLibro = Convert.ToInt32(txtId.Text);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este autor?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar el autor
                            string query = "Delete From libros_autores WHERE IdLibro = @IdLibro And IdAutor = @IdAutor"; // Asegúrate de que el nombre de la columna sea correcto
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@IdLibro", idLibro);
                            sqlCommand.Parameters.AddWithValue("@IdAutor", idAutor);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Autor eliminado exitosamente.");

                            // Recargar la lista de autores después de eliminar
                            CargarGrillaAutores();                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            mySqlConnection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un autor para eliminar.");
            }
        }
    
        private void CargarGrillaAutores()
        {
            // Construir la sentencia SQL dinámica
            string consulta = "Select Autores.Id, Autores.Nombre, Autores.Apellido, Autores.Nacionalidad From Libros_Autores Left Join Autores ON Libros_Autores.IdAutor = Autores.Id Where Libros_Autores.IdLibro = " + txtId.Text;

            // Conectar a la base de datos y ejecutar la consulta
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Crear el comando SQL con la consulta
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvAutores.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvAutores.DataSource = dataTable;
                    }
                    else
                    {
                       dgvAutores.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los autores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void CargarAutores()
        {
            // Construir la sentencia SQL dinámica
            string consulta = "Select Id, Concat(Apellido, ' ', Nombre) as NombreCompleto From Autores Order By Apellido, Nombre";

            // Conectar a la base de datos y ejecutar la consulta
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Crear el comando SQL con la consulta
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        cmbAutores.DataSource = dataTable;
                        cmbAutores.DisplayMember = "NombreCompleto";
                        cmbAutores.ValueMember = "Id";
                        cmbAutores.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los autores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void CargarEditorial()
        {
            // Consulta SQL para obtener las editoriales, ordenadas alfabéticamente
            string consulta = "SELECT Id, Nombre FROM Editoriales ORDER BY Nombre";

            // Obtener la cadena de conexión desde el archivo de configuración
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Crear el comando SQL y asignar la consulta
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        // Configurar el ComboBox de editoriales
                        cmbEditoriales.DataSource = dataTable;
                        cmbEditoriales.DisplayMember = "Nombre";
                        cmbEditoriales.ValueMember = "Id";
                        cmbEditoriales.SelectedIndex = -1; // Opcional: No seleccionar ninguna editorial al inicio
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron editoriales en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las editoriales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void CargarTemas()
        {
            string consulta = "SELECT Id, Nombre FROM Temas ORDER BY Nombre";
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        cmbTemas.DataSource = dataTable;
                        cmbTemas.DisplayMember = "Nombre";
                        cmbTemas.ValueMember = "Id";
                        cmbTemas.SelectedIndex = -1; // Sin selección inicial
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron temas.");
                        cmbTemas.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los temas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void CargarNivel()
        {
            // Consulta SQL para obtener los niveles, ordenados alfabéticamente
            string consulta = "SELECT Id, Nombre FROM Niveles ORDER BY Nombre";

            // Obtener la cadena de conexión desde el archivo de configuración
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Crear el comando SQL y asignar la consulta
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    // Ejecutar la consulta y cargar los resultados en un DataTable
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        // Configurar el ComboBox de niveles
                        cmbNiveles.DataSource = dataTable;
                        cmbNiveles.DisplayMember = "Nombre";
                        cmbNiveles.ValueMember = "Id";
                        cmbNiveles.SelectedIndex = -1; // Opcional: No seleccionar ningún nivel al inicio
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron niveles en la base de datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los niveles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void CmbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que haya un tema seleccionado y que no sea null
            if (cmbTemas.SelectedIndex != -1)
            {
                // Obtener el ID del tema seleccionado
                int idTema;
                if (int.TryParse(cmbTemas.SelectedValue.ToString(), out idTema))
                {
                    // Cadena de conexión desde el archivo de configuración
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Consulta para obtener los libros relacionados con el tema seleccionado
                            string consulta = "SELECT Id, Titulo FROM Libros WHERE idTema = @idTema"; 
                            using (MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection))
                            {
                                // Asignar el parámetro
                                sqlCommand.Parameters.AddWithValue("@idTema", idTema);

                                // Ejecutar la consulta y cargar los resultados en un DataTable
                                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                                DataTable dataTable = new DataTable();
                                dataAdapter.Fill(dataTable);

                                // Verificar si hay libros disponibles
                                if (dataTable.Rows.Count > 0)
                                {
                                    // Configurar el ComboBox de libros
                                    cmbTemas.DataSource = dataTable; // Aquí cargamos los libros en el mismo ComboBox
                                    cmbTemas.DisplayMember = "Titulo"; // Mostrar el título del libro
                                    cmbTemas.ValueMember = "Id"; // Valor del libro seleccionado
                                    cmbTemas.SelectedIndex = -1; // Sin selección inicial
                                }
                                else
                                {
                                    // Si no hay libros, limpiar el ComboBox de libros
                                    MessageBox.Show("No se encontraron libros para el tema seleccionado.");
                                    cmbTemas.DataSource = null;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            mySqlConnection.Close();
                        }
                    }
                }
            }
        }

    }
}
