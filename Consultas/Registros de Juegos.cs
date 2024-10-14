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
    public partial class Registros_de_Juegos : Form
    {
        public Registros_de_Juegos()
        {
            InitializeComponent();
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            NuevoJuego nuevoJuego = new NuevoJuego();
            nuevoJuego.ShowDialog(this);
        }
    }
}
