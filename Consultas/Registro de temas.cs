using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Registros_de_Datos;

namespace WindowsFormsApp1.Consultas
{
    public partial class registro_de_temas : Form
    {
        public registro_de_temas()
        {
            InitializeComponent();
        }

        private void registro_de_temas_Load(object sender, EventArgs e)
        {































        }

        private void btnNuevoTema_Click(object sender, EventArgs e)
        {
            NuevoTema nuevoTema = new NuevoTema();
            nuevoTema.ShowDialog(this);
        }
    }
}
