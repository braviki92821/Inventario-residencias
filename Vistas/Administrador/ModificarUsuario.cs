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
    public partial class ModificarUsuario : Form
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        Usuario usuario = new Usuario();

        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void pbxImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbxImagen.ImageLocation = openFile.FileName;
            }
        }
    }
}
