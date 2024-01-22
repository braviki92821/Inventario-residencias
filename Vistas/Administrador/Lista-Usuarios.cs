using Inventario_residencias.modelos;
using Inventario_residencias.Modelos;
using Inventario_residencias.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Lista_Usuarios : Form
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private List<Usuario> usuarios = new List<Usuario>();
        public Lista_Usuarios()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnBaja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cargarUsuarios()
        {
            usuarios.Clear();
            usuarios = usuarioRepositorio.obtenerUsuarios(true, Session.usuarioId);
            dgvUsuarios.DataSource = usuarios;
        }
    }
}
