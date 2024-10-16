using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Registros_de_Datos
{
    public partial class NuevaEnciclopedia : Form
    {
        public NuevaEnciclopedia()
        {
            InitializeComponent();
        }

        private void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarNuevaEditorial_Click(object sender, EventArgs e)
        {
            NuevaEditorial nuevaEditorial = new NuevaEditorial();
            nuevaEditorial.ShowDialog(this);
        }

        private void btnAgregarNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema();
            nuevoTema.ShowDialog(this);
        }
    }
}
