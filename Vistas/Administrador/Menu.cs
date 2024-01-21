﻿using Inventario_residencias.Vistas.Administrador;
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

        private void btnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void btnListaItems_Click(object sender, EventArgs e)
        {
            openChildForm(new Lista_Inventario());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Usuarios());
        }
    }
}