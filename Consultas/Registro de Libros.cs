using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Registro_de_Libros : Form
    {
        public Registro_de_Libros()
        {
            InitializeComponent();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            NuevoLibro nuevoLibro = new NuevoLibro();
            nuevoLibro.ShowDialog(this);
        }
    }
}
