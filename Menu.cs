using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_residencias
{
    public partial class Menu : Form
    {
        private Form activeForm = null;

        public Menu()
        {
            InitializeComponent();
            customDesing();
        }

        private void customDesing()
        {
            panelProfileSubMenu.Visible = false;
            panelInventarioSubMenu.Visible = false;
            panelUsuarioSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelProfileSubMenu.Visible == true)
                panelProfileSubMenu.Visible = false;
            if (panelInventarioSubMenu.Visible == true)
                panelInventarioSubMenu.Visible = false;
            if (panelUsuarioSubMenu.Visible == true)
                panelUsuarioSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProfileSubMenu);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInventarioSubMenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsuarioSubMenu);
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            openChildForm(new NuevoItem());
        }

        private void btnListaItems_Click(object sender, EventArgs e)
        {
            openChildForm(new Inventario_Admin());
        }
    }
}
