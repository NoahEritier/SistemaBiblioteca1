using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevaEnciclopedia : Form
    {
        private int? enciclopediaId; // Identificador de la enciclopedia (null si es nueva)

        public NuevaEnciclopedia(int? idEnciclopedia = null, string nombre = "", int? idEditorial = null, string idioma = "", int año = 0, int? tomos = null, int? idTema = null)
        {
            InitializeComponent();
            enciclopediaId = idEnciclopedia;

            CargarEditoriales();
            CargarTemas();

            if (enciclopediaId.HasValue)
            {
                // Rellenar los campos si estamos editando
                txtTitulo.Text = nombre;
                cmbEditoriales.SelectedValue = idEditorial;
                cmbIdiomas.SelectedItem = idioma;
                txtAño.Text = año.ToString();
                txtTomos.Text = tomos?.ToString() ?? ""; // Mostrar tomos si hay un valor, o dejar vacío
                cmbTemas.SelectedValue = idTema;

                this.Text = "Editar Enciclopedia";
            }
            else
            {
                this.Text = "Nueva Enciclopedia";
            }
        }

        private void CargarEditoriales()
        {
            string consulta = "SELECT Id, Nombre FROM Editoriales ORDER BY Nombre";
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
                        cmbEditoriales.DataSource = dataTable;
                        cmbEditoriales.DisplayMember = "Nombre";
                        cmbEditoriales.ValueMember = "Id";
                        cmbEditoriales.SelectedIndex = -1; // Sin selección inicial
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
            }
        }

        private void CargarTemas()
        {
            string consulta = "SELECT Id, Nombre FROM Temas WHERE Grupo = 'Libros' ORDER BY Nombre";
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
            }
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El campo 'Título' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbEditoriales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEditorial = Convert.ToInt32(cmbEditoriales.SelectedValue);

            if (cmbTemas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idTema = Convert.ToInt32(cmbTemas.SelectedValue);

            if (cmbIdiomas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un idioma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idioma = cmbIdiomas.SelectedItem.ToString();

            if (!int.TryParse(txtAño.Text.Trim(), out int año))
            {
                MessageBox.Show("El campo 'Año' es obligatorio y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? tomos = null;
            if (!string.IsNullOrEmpty(txtTomos.Text.Trim()))
            {
                if (int.TryParse(txtTomos.Text.Trim(), out int valorTomos))
                {
                    tomos = valorTomos;
                }
                else
                {
                    MessageBox.Show("El campo 'Tomos' debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var stringConexion = ConfigurationManager.ConnectionStrings["MyDbContext"].ToString();

            using (MySqlConnection mySqlConnection = new MySqlConnection(stringConexion))
            {
                try
                {
                    mySqlConnection.Open();

                    string query;
                    if (enciclopediaId.HasValue)
                    {
                        query = @"
                            UPDATE enciclopedias 
                            SET nombre = @titulo, año = @año, tomos = @tomos, idEditorial = @idEditorial, idioma = @idioma, idTema = @idTema 
                            WHERE Id = @idEnciclopedia";
                    }
                    else
                    {
                        query = @"
                            INSERT INTO enciclopedias (nombre, año, tomos, idEditorial, idioma, idTema) 
                            VALUES (@titulo, @año, @tomos, @idEditorial, @idioma, @idTema)";
                    }

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@titulo", titulo);
                        sqlCommand.Parameters.AddWithValue("@año", año);
                        sqlCommand.Parameters.AddWithValue("@tomos", tomos.HasValue ? (object)tomos.Value : DBNull.Value);
                        sqlCommand.Parameters.AddWithValue("@idEditorial", idEditorial);
                        sqlCommand.Parameters.AddWithValue("@idioma", idioma);
                        sqlCommand.Parameters.AddWithValue("@idTema", idTema);

                        if (enciclopediaId.HasValue)
                        {
                            sqlCommand.Parameters.AddWithValue("@idEnciclopedia", enciclopediaId.Value);
                        }

                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        MessageBox.Show(
                            enciclopediaId.HasValue
                                ? "Enciclopedia actualizada correctamente."
                                : "Enciclopedia registrada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la enciclopedia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CargarEditoriales();
        }

        private void btnAgregarNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema("Enciclopedias");
            nuevoTema.ShowDialog();
            CargarTemas();
        }
    }
}
