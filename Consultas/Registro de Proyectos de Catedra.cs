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
    public partial class Registro_de_Proyecto_de_Catedra : Form
    {
        public Registro_de_Proyecto_de_Catedra()
        {
            InitializeComponent();
        }

        private void btnNuevoProyecto_Click(object sender, EventArgs e)
        {
            NuevoProyectoDeCatedra nuevoProyectoDeCatedra = new NuevoProyectoDeCatedra();
            nuevoProyectoDeCatedra.ShowDialog(this);
        }
    }
}
