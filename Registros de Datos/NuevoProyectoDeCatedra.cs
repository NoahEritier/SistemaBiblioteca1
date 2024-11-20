using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NuevoProyectoDeCatedra : Form
    {
        private int? IdProyecto { get; set; } = null; // Campo para identificar si es creación o modificación

        // Constructor para creación de un nuevo proyecto
        public NuevoProyectoDeCatedra()
        {
            InitializeComponent();
            CargarCarreras();
            cmbCarreras.SelectedValueChanged += CmbCarreras_SelectedValueChanged;
            cmbMaterias.SelectedIndex = -1;
        }

        // Constructor para modificar un proyecto existente
        public NuevoProyectoDeCatedra(int idProyecto) : this()
        {
            IdProyecto = idProyecto;
            CargarProyectoExistente(idProyecto);
        }

        // Método para cargar los datos del proyecto existente
        private void CargarProyectoExistente(int idProyecto)
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    // Consulta para obtener los datos del proyecto de cátedra
                    string query = @"
                        SELECT pc.idMateria, pc.año, m.idCarrera
                        FROM proyectosdecatedra pc
                        JOIN materias m ON pc.idMateria = m.idMateria
                        WHERE pc.id = @idProyecto";
                    MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.AddWithValue("@idProyecto", idProyecto);

                    using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Cargar los valores en los controles del formulario
                            int idCarrera = Convert.ToInt32(reader["idCarrera"]);
                            int idMateria = Convert.ToInt32(reader["idMateria"]);
                            int año = Convert.ToInt32(reader["año"]);

                            cmbCarreras.SelectedValue = idCarrera;
                            CargarMaterias(idCarrera); // Asegurar que se carguen las materias
                            cmbMaterias.SelectedValue = idMateria;
                            txtAño.Text = año.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el proyecto especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el proyecto de cátedra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para cargar las carreras en el ComboBox cmbCarreras
        private void CargarCarreras()
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT idCarrera, descripcion FROM carreras";

                    MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                    MySqlDataReader reader = sqlCommand.ExecuteReader();

                    List<Carrera> carreras = new List<Carrera>();
                    while (reader.Read())
                    {
                        carreras.Add(new Carrera
                        {
                            IdCarrera = Convert.ToInt32(reader["idCarrera"]),
                            Descripcion = reader["descripcion"].ToString()
                        });
                    }

                    cmbCarreras.DataSource = carreras;
                    cmbCarreras.DisplayMember = "Descripcion";
                    cmbCarreras.ValueMember = "IdCarrera";
                    cmbCarreras.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las carreras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento para cargar materias automáticamente cuando se selecciona una carrera
        private void CmbCarreras_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMaterias.SelectedIndex = -1;
            if (cmbCarreras.SelectedIndex != -1)
            {
                int idCarrera = Convert.ToInt32(cmbCarreras.SelectedValue);
                CargarMaterias(idCarrera);
            }
        }

        // Método para cargar las materias en cmbMaterias basadas en el idCarrera seleccionado
        private void CargarMaterias(int idCarrera)
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT idMateria, descripcion FROM materias WHERE idCarrera = @idCarrera";
                    MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.AddWithValue("@idCarrera", idCarrera);
                    MySqlDataReader reader = sqlCommand.ExecuteReader();

                    List<Materia> materias = new List<Materia>();
                    while (reader.Read())
                    {
                        materias.Add(new Materia
                        {
                            IdMateria = Convert.ToInt32(reader["idMateria"]),
                            Descripcion = reader["descripcion"].ToString()
                        });
                    }

                    cmbMaterias.DataSource = materias;
                    cmbMaterias.DisplayMember = "Descripcion";
                    cmbMaterias.ValueMember = "IdMateria";
                    cmbMaterias.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cmbMaterias.SelectedValueChanged += cmbMaterias_SelectedValueChanged;
            }
        }
        // Método para obtener el profesor titular y mostrarlo en txtProfesor al seleccionar una materia
        private void cmbMaterias_SelectedValueChanged(object sender, EventArgs e)
        {
            txtProfesor.Text = "";
            if (cmbMaterias.SelectedIndex != -1)
            {
                int idMateria = Convert.ToInt32(cmbMaterias.SelectedValue);
                ObtenerProfesorTitular(idMateria);
            }
        }

        // Método para obtener el profesor titular y mostrarlo en txtProfesor
        private void ObtenerProfesorTitular(int idMateria)
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = @"
                        SELECT p.nombre, p.apellido
                        FROM profesores p 
                        JOIN materias m ON m.idProfesorTitular = p.idProfesor 
                        WHERE m.idMateria = @idMateria";
                    MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.AddWithValue("@idMateria", idMateria);
                    using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Concatenar nombre y apellido
                            string profesorNombreApellido = $"{reader["nombre"]} {reader["apellido"]}";
                            txtProfesor.Text = profesorNombreApellido;
                        }
                        else
                        {
                            // Si no hay profesor asignado, mostrar mensaje
                            txtProfesor.Text = "Sin Profesor Asignado";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el profesor titular: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Método para confirmar el registro o la modificación
        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            if (cmbCarreras.SelectedIndex == -1 || cmbMaterias.SelectedIndex == -1 || string.IsNullOrEmpty(txtAño.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCarrera = Convert.ToInt32(cmbCarreras.SelectedValue);
            int idMateria = Convert.ToInt32(cmbMaterias.SelectedValue);
            int año = int.Parse(txtAño.Text.Trim());
            DateTime fechaRegistro = DateTime.Now;

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    string query;
                    if (IdProyecto == null)
                    {
                        // Insertar un nuevo proyecto de cátedra
                        query = "INSERT INTO proyectosdecatedra (idMateria, año, fechaRegistro) VALUES (@idMateria, @año, @fechaRegistro)";
                    }
                    else
                    {
                        // Actualizar un proyecto de cátedra existente
                        query = "UPDATE proyectosdecatedra SET idMateria = @idMateria, año = @año WHERE idProyecto = @idProyecto";
                    }

                    MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                    sqlCommand.Parameters.AddWithValue("@idMateria", idMateria);
                    sqlCommand.Parameters.AddWithValue("@año", año);
                    sqlCommand.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);

                    if (IdProyecto != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@idProyecto", IdProyecto);
                    }

                    int registrosAfectados = sqlCommand.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        string mensaje = IdProyecto == null ? "Proyecto de Cátedra registrado correctamente." : "Proyecto de Cátedra actualizado correctamente.";
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el proyecto de cátedra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el proyecto de cátedra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Clases de ayuda para cargar datos en los ComboBox
        public class Carrera
        {
            public int IdCarrera { get; set; }
            public string Descripcion { get; set; }
        }

        public class Materia
        {
            public int IdMateria { get; set; }
            public string Descripcion { get; set; }
        }
    }
}
