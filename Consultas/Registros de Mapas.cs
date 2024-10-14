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
    public partial class Registros_de_Mapas : Form
    {
        public Registros_de_Mapas()
        {
            InitializeComponent();
        }

        private void btnNuevoMapa_Click(object sender, EventArgs e)
        {
            NuevoMapas nuevoMapas = new NuevoMapas();
            nuevoMapas.ShowDialog(this);
        }
    }
}
