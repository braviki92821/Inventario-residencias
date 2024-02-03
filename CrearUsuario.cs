using Inventario_residencias.modelos;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Inventario_residencias.Repositorio;
using Inventario_residencias.Modelos;

namespace Inventario_residencias
{
    public partial class Usuarios : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        private Usuario Usuario;
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public Usuarios()
        {
            InitializeComponent();
            cargarUsuarios();
            Usuario = new Usuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaciones(true))
            {
                return;
            }
            string correo = txtCorreo.Text;
            string password = CreatePassword(6);
            Usuario.nombre = txtNombre.Text;
            Usuario.correo = correo;
            Usuario.password = usuarioRepositorio.hashPassword(password);
            Usuario.tipo = cbxTipo.SelectedItem.ToString();
            Usuario.status = true;
            Usuario.imagen = usuarioRepositorio.ImageToByteArray(pbxImagen.Image);

            if (usuarioRepositorio.agregarUsuario(Usuario))
            {
                enviar(correo, password);
                MessageBox.Show("Agregado Correctamente");
                Limpiar();
                cargarUsuarios();
                return;
            }
            MessageBox.Show("Error al guardar");
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuarioId.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            cbxTipo.SelectedItem = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();

            MemoryStream memoryStream = new MemoryStream((byte[])dgvUsuarios.CurrentRow.Cells[6].Value);
            Image image = Image.FromStream(memoryStream);
            pbxImagen.Image = image;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validaciones(false))
                return;
            Usuario.usuarioId = int.Parse(txtUsuarioId.Text);
            Usuario.nombre = txtNombre.Text;
            Usuario.correo = txtCorreo.Text;
            Usuario.tipo = cbxTipo.SelectedItem.ToString();
            Usuario.imagen = usuarioRepositorio.ImageToByteArray(pbxImagen.Image);

            if (usuarioRepositorio.modificarUsuario(Usuario))
            {
                MessageBox.Show("Modificado Correctamente");
                cargarUsuarios();
                return;
            }
            MessageBox.Show("Error al guardar");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool validaciones(bool nuevo)
        {
            EmailAddressAttribute email = new EmailAddressAttribute();

            if (txtUsuarioId.Text.Equals("") && !nuevo)
            {
                MessageBox.Show("No ha seleccionado un usuario");
                return false;
            }

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

        private string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@-/";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void enviar(string correo, string password)
        {
            string body = "Hola tu contraseña de acceso para tableros de inventario es: " + password + " guarda esta contraseña en un lugar seguro";

            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("54f8dae7745779", "ec4e98dc4e3817"),
                EnableSsl = true
            };

            client.Send("from@example.com", correo, "Contraseña de acceso", body);
            MessageBox.Show("enviado correctamente");
        }

        private async void cargarUsuarios()
        {
            usuarios.Clear();
            usuarios = await usuarioRepositorio.obtenerUsuarios(true, Session.usuarioId);
            dgvUsuarios.DataSource = usuarios;
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

        private void Limpiar()
        {
            txtUsuarioId.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
            pbxImagen.Image = null;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
