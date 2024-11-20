using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Consultas
{
    public partial class Registro_de_Proyecto_de_Catedra : Form
    {
        public Registro_de_Proyecto_de_Catedra()
        {
            InitializeComponent();

            // Inicializar opciones de periodo
            cmbFiltroPeriodo.Items.Add("1 semana");
            cmbFiltroPeriodo.Items.Add("1 mes");
            cmbFiltroPeriodo.Items.Add("6 meses");
            cmbFiltroPeriodo.Items.Add("Cualquier momento");
            cmbFiltroPeriodo.SelectedIndex = 3;

            CargarCarreras();
            CargarMaterias(); // Cargar todas las materias inicialmente
            cmbFiltroCarrera.SelectedIndexChanged += cmbFiltroCarrera_SelectedIndexChanged;
        }

        private void cmbFiltroCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCarrera = Convert.ToInt32(cmbFiltroCarrera.SelectedValue);
            CargarMaterias(idCarrera); // Filtrar materias según la carrera seleccionada
        }

        private void btnBuscarProyecto_Click(object sender, EventArgs e)
        {
            string filtroPeriodo = cmbFiltroPeriodo.SelectedItem.ToString();
            int idCarrera = Convert.ToInt32(cmbFiltroCarrera.SelectedValue);
            int idMateria = Convert.ToInt32(cmbMaterias.SelectedValue);

            // Construir la consulta SQL con JOIN entre proyectosdecatedra y materias
            string consulta = @"
            SELECT p.*, m.descripcion AS MateriaDescripcion
            FROM proyectosdecatedra p
            JOIN materias m ON p.idMateria = m.idMateria
            WHERE 1=1";

            DateTime fechaFiltro = DateTime.Now;
            if (filtroPeriodo != "Cualquier momento")
            {
                switch (filtroPeriodo)
                {
                    case "1 semana":
                        fechaFiltro = DateTime.Now.AddDays(-7);
                        break;
                    case "1 mes":
                        fechaFiltro = DateTime.Now.AddMonths(-1);
                        break;
                    case "6 meses":
                        fechaFiltro = DateTime.Now.AddMonths(-6);
                        break;
                }
                consulta += " AND p.FechaRegistro >= @fechaFiltro";
            }

            // Filtrar por carrera solo si se ha seleccionado una carrera específica
            if (idCarrera != 0)
            {
                consulta += " AND m.idCarrera = @idCarrera";
            }

            // Filtrar por materia solo si se ha seleccionado una materia específica
            if (idMateria != 0)
            {
                consulta += " AND p.idMateria = @idMateria";
            }

            // Filtrar por año si el campo de año no está vacío
            int año;
            bool filtrarPorAño = int.TryParse(txtAño.Text, out año);
            if (filtrarPorAño)
            {
                consulta += " AND p.año = @año";
            }

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();
                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    // Asignar parámetros para el filtro de periodo
                    if (filtroPeriodo != "Cualquier momento")
                        sqlCommand.Parameters.AddWithValue("@fechaFiltro", fechaFiltro);

                    // Asignar parámetros para carrera y materia según corresponda
                    if (idCarrera != 0)
                        sqlCommand.Parameters.AddWithValue("@idCarrera", idCarrera);

                    if (idMateria != 0)
                        sqlCommand.Parameters.AddWithValue("@idMateria", idMateria);

                    if (filtrarPorAño)
                        sqlCommand.Parameters.AddWithValue("@año", año);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Verificar si hay datos
                    if (dataTable.Rows.Count > 0)
                    {
                        dgvProyecto.AutoGenerateColumns = true;  // Asegura que el DataGridView genere las columnas automáticamente
                        dgvProyecto.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al filtrar los proyectos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }


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

                    List<Carrera> carreras = new List<Carrera>
                    {
                        new Carrera { IdCarrera = 0, Descripcion = "Cualquier carrera" }
                    };

                    while (reader.Read())
                    {
                        carreras.Add(new Carrera
                        {
                            IdCarrera = Convert.ToInt32(reader["idCarrera"]),
                            Descripcion = reader["descripcion"].ToString()
                        });
                    }

                    cmbFiltroCarrera.DataSource = carreras;
                    cmbFiltroCarrera.DisplayMember = "Descripcion";
                    cmbFiltroCarrera.ValueMember = "IdCarrera";
                    cmbFiltroCarrera.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las carreras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarMaterias(int idCarrera = 0)
        {
            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    string consulta = "SELECT idMateria, descripcion FROM materias";
                    if (idCarrera != 0)
                        consulta += " WHERE idCarrera = @idCarrera";

                    MySqlCommand sqlCommand = new MySqlCommand(consulta, mySqlConnection);

                    if (idCarrera != 0)
                        sqlCommand.Parameters.AddWithValue("@idCarrera", idCarrera);

                    MySqlDataReader reader = sqlCommand.ExecuteReader();

                    List<Materia> materias = new List<Materia>
                    {
                        new Materia { IdMateria = 0, Descripcion = "Cualquier materia" }
                    };

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
                    cmbMaterias.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las materias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            NuevoProyectoDeCatedra nuevoProyectoDeCatedra = new NuevoProyectoDeCatedra();
            nuevoProyectoDeCatedra.ShowDialog(this);
        }

        private void btnModificarProyectos_Click(object sender, EventArgs e)
        {
            // Verificar si hay un proyecto seleccionado
            if (dgvProyecto.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow filaSeleccionada = dgvProyecto.SelectedRows[0];

                    // Obtener el ID del proyecto seleccionado
                    int idProyecto = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value); // Nombre exacto de la columna

                    // Abrir el formulario de modificación
                    NuevoProyectoDeCatedra nuevoProyecto = new NuevoProyectoDeCatedra(idProyecto);
                    nuevoProyecto.ShowDialog();

                    // Refrescar la tabla después de la modificación
                    btnBuscarProyecto_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar modificar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proyecto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


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

        private void btnEliminarProyectos_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvProyecto.SelectedRows.Count > 0)
            {
                // Obtener el ID del autor seleccionado (asumiendo que el ID está en la primera columna)
                int idProyecto = Convert.ToInt32(dgvProyecto.SelectedRows[0].Cells[0].Value);

                // Confirmar la eliminación
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?", "Confirmar Eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();
                    using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
                    {
                        try
                        {
                            mySqlConnection.Open();

                            // Crear el comando SQL para eliminar el autor
                            string query = "DELETE FROM proyectosdecatedra WHERE Id = @Id"; // Asegúrate de que el nombre de la columna sea correcto
                            MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Id", idProyecto);

                            // Ejecutar el comando
                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Proyecto eliminado exitosamente.");

                            // Recargar la lista de autores después de eliminar
                            btnBuscarProyecto_Click(sender, e); // Llama a tu método de búsqueda para recargar
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

