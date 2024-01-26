using Inventario_residencias.Repositorio;
using Inventario_residencias.modelos;
using System.ComponentModel.DataAnnotations;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class ModificarUsuario : Form
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private modelos.Usuario Usuario;

        public ModificarUsuario()
        {
            InitializeComponent();
            Usuario = new modelos.Usuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }

            Usuario.nombre = txtNombre.Text;
            Usuario.correo = txtCorreo.Text;
            Usuario.tipo = cbxTipo.SelectedItem.ToString();
            Usuario.imagen = usuarioRepositorio.ImageToByteArray(pbxImagen.Image);

            if (usuarioRepositorio.modificarUsuario(Usuario))
            {
                MessageBox.Show("Usuario Modificado corectamente");
                this.Close();
                return;
            }
            MessageBox.Show("Error al Modificar");
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

        private bool validaciones()
        {
            EmailAddressAttribute email = new EmailAddressAttribute();

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un nombre");
                return false;
            }
            if (txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un correo");
                return false;
            }

            if (!email.IsValid(txtCorreo.Text))
            {
                MessageBox.Show("Debe ingresar un correo valido");
                return false;
            }

            if (cbxTipo.Text == "-----Seleccione-----")
            {
                MessageBox.Show("Seleccione una tipo de usuario");
                return false;
            }

            if (pbxImagen.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen");
                return false;
            }

            return true;
        }

        public void info(int usuarioId)
        {
            Usuario = usuarioRepositorio.obtenerUsuarioPorId(usuarioId);
            txtUsuario.Text = usuarioId.ToString();
            txtNombre.Text = Usuario.nombre;
            txtCorreo.Text = Usuario.correo;
            cbxTipo.SelectedItem = Usuario.tipo;
            MemoryStream memoryStream = new MemoryStream(Usuario.imagen);
            Image image = Image.FromStream(memoryStream);
            pbxImagen.Image = image;
        }

    }
}
