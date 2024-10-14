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
    public partial class Registro_de_Autores : Form
    {
        public Registro_de_Autores()
        {
            InitializeComponent();
        }

        private void Registro_de_Autores_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoAutor_Click(object sender, EventArgs e)
        {
            NuevoAutor nuevoAutor = new NuevoAutor();
            nuevoAutor.ShowDialog(this);
        }
    }
}
