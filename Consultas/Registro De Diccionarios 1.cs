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
    public partial class Registro_De_Diccionarios_1 : Form
    {
        public Registro_De_Diccionarios_1()
        {
            InitializeComponent();
        }

        private void btnNuevoDiccionario_Click(object sender, EventArgs e)
        {
            NuevoDiccionario nuevoDiccionario = new NuevoDiccionario();
            nuevoDiccionario.ShowDialog(this);
        }

        private void btnBuscarDiccionario_Click(object sender, EventArgs e)
        {

        }
    }
}
