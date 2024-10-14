using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.Registros_de_Datos;

namespace WindowsFormsApp1.Consultas
{
    public partial class Registro_de_Diccionarios : Form
    {
        public Registro_de_Diccionarios()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevaEnciclopedia_Click(object sender, EventArgs e)
        {
            NuevaEnciclopedia nuevaEnciclopedia = new NuevaEnciclopedia();
            nuevaEnciclopedia.ShowDialog(this);
        }
    }
}
