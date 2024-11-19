using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevoDiccionario : Form
    {
        private int? diccionarioId; // Identificador del diccionario (null si es nuevo)

        public NuevoDiccionario(int? idDiccionario = null, int? idEditorial = null, string idioma = "", int año = 0, int? tomos = null)
        {
            InitializeComponent();
            diccionarioId = idDiccionario;

            // Cargar editoriales en el ComboBox
            CargarEditoriales();

            if (diccionarioId.HasValue)
            {
                // Rellenar los campos si estamos editando
                cmbEditoriales.SelectedValue = idEditorial;
                cmbIdiomas.SelectedItem = idioma;
                txtAño.Text = año.ToString();
                txtTomos.Text = tomos?.ToString() ?? ""; // Mostrar tomos si hay un valor, o dejar vacío
                this.Text = "Editar Diccionario";
            }
            else
            {
                this.Text = "Nuevo Diccionario";
            }
        }

        // Método para cargar las editoriales en el ComboBox
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
                finally
                {
                    mySqlConnection.Close();
                }
            }
        }

        // Método para registrar o actualizar un diccionario
        private void btnRegistrarDiccionario_Click(object sender, EventArgs e)
        {
            if (cmbEditoriales.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una editorial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idEditorial = Convert.ToInt32(cmbEditoriales.SelectedValue);

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

                    if (diccionarioId.HasValue)
                    {
                        query = @"
                            UPDATE diccionarios 
                            SET idEditorial = @idEditorial, idioma = @idioma, año = @año, tomos = @tomos
                            WHERE Id = @idDiccionario";
                    }
                    else
                    {
                        query = @"
                            INSERT INTO diccionarios (idEditorial, idioma, año, tomos)
                            VALUES (@idEditorial, @idioma, @año, @tomos)";
                    }

                    using (MySqlCommand sqlCommand = new MySqlCommand(query, mySqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@idEditorial", idEditorial);
                        sqlCommand.Parameters.AddWithValue("@idioma", idioma);
                        sqlCommand.Parameters.AddWithValue("@año", año);

                        if (tomos.HasValue)
                        {
                            sqlCommand.Parameters.AddWithValue("@tomos", tomos);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@tomos", DBNull.Value);
                        }

                        if (diccionarioId.HasValue)
                        {
                            sqlCommand.Parameters.AddWithValue("@idDiccionario", diccionarioId);
                        }

                        int registrosAfectados = sqlCommand.ExecuteNonQuery();

                        if (registrosAfectados > 0)
                        {
                            MessageBox.Show(diccionarioId.HasValue
                                ? "Diccionario actualizado correctamente."
                                : "Diccionario registrado correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el diccionario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el diccionario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Refrescar el ComboBox de editoriales después de agregar una nueva
            CargarEditoriales();
        }
    }
}
