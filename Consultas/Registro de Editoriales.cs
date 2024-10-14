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
    public partial class Registro_de_Editoriales : Form
    {
        public Registro_de_Editoriales()
        {
            InitializeComponent();
        }

        private void Registro_de_Editoriales_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaEditorial_Click(object sender, EventArgs e)
        {
            NuevaEditorial nuevaEditorial = new NuevaEditorial();
            nuevaEditorial.ShowDialog(this);
            
         
        }
    }
}
