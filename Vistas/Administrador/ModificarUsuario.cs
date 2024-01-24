using Inventario_residencias.Repositorio;
using Inventario_residencias.modelos;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class ModificarUsuario : Form
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        

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
