using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Consultas;

namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        

        public MenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelLibros_submenu.Visible = false;
            panelEnciclopedias_submenu.Visible = false;
            panelDiccionarios_submenu.Visible = false;
            panelMapas_submenu.Visible = false;
            panelProyectos_submenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelLibros_submenu.Visible == true)
                panelLibros_submenu.Visible = false;
            if (panelEnciclopedias_submenu.Visible == true)
                panelEnciclopedias_submenu.Visible = false;
            if (panelDiccionarios_submenu.Visible == true)
                panelDiccionarios_submenu.Visible = false;
            if (panelMapas_submenu.Visible == true)
                panelMapas_submenu.Visible = false;
            if (panelProyectos_submenu.Visible == true)
                panelProyectos_submenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }   

        private void btnDespLibros_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelLibros_submenu);
        }

        private void btnRegistrosLib_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Libros());
            HideSubMenu();
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            openChildForm(new registro_de_temas());
            HideSubMenu();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Editoriales());
            HideSubMenu();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Autores());
            HideSubMenu();
        }

        private void btnEnciclopedias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEnciclopedias_submenu);
        }

        private void btnRegistrosCiclo_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Diccionarios());
            HideSubMenu();
        }

        private void btnTemasCiclo_Click_1(object sender, EventArgs e)
        {
            openChildForm(new registro_de_temas());
            HideSubMenu();
        }

        private void btnEditorialCiclo_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Editoriales());
            HideSubMenu();
        }

        private void btnDiccionarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDiccionarios_submenu);
        }

        private void btnRegistrosDiccio_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_De_Diccionarios_1());
            HideSubMenu();
        }

        private void btnEditorialDiccio_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Editoriales());
            HideSubMenu();
        }

        private void btnMapas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMapas_submenu);
        }

        private void btnRegistrosMap_Click(object sender, EventArgs e)
        {
            openChildForm(new Registros_de_Mapas());
            HideSubMenu();
        }

        private void btnTemasMap_Click(object sender, EventArgs e)
        {
            openChildForm(new registro_de_temas());
            HideSubMenu();
        }

        private void btnEditorialMap_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Editoriales());
            HideSubMenu();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProyectos_submenu);
        }

        private void btnRegistrosPro_Click(object sender, EventArgs e)
        {
            openChildForm(new Registro_de_Proyecto_de_Catedra());
            HideSubMenu();
        }

        private void btnJuegos_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Registros_de_Juegos());
        }

        private void btnTesis_Click_1(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private Form activateForm = null;
        private void openChildForm(Form childForm)
        {
            if (activateForm != null)
                activateForm.Close();
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
