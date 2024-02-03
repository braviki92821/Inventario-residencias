using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net;
using System.Text;
using Inventario_residencias.Repositorio;
using Inventario_residencias.modelos;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class NuevoUsuario : Form
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private modelos.Usuario Usuario;

        public NuevoUsuario()
        {
            InitializeComponent();
            Usuario = new modelos.Usuario();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }
            string correo = txtCorreo.Text;
            string password = CreatePassword(6);

            if (usuarioRepositorio.correoRegistrado(correo.Trim()))
            {
                MessageBox.Show("Este correo ya esta registrado");
                return;
            }

            Usuario.nombre = txtNombre.Text;
            Usuario.correo = correo.Trim();
            Usuario.password = usuarioRepositorio.hashPassword(password);
            Usuario.tipo = cbxTipo.SelectedItem.ToString();
            Usuario.status = true;
            Usuario.imagen = usuarioRepositorio.ImageToByteArray(pbxImagen.Image);

            if (usuarioRepositorio.agregarUsuario(Usuario))
            {
                await enviar(correo, password);
                MessageBox.Show("Agregado Correctamente");
                Limpiar();
                return;
            }
            MessageBox.Show("Error al guardar");

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

        private async Task enviar(string correo, string password)
        {
            string body = "Hola tu contraseña de acceso para tableros de inventario es: " + password + " guarda esta contraseña en un lugar seguro";

            SmtpClient client = new SmtpClient("mail.vw-pozarica.com.mx", 26)
            {
                Credentials = new NetworkCredential("inventario@vw-pozarica.com.mx", "inventario123"),
                EnableSsl = true
            };
            await client.SendMailAsync("inventario@vw-pozarica.com.mx", correo, "Contraseña de acceso", body);
            //client.Send("inventario@vw-pozarica.com.mx", correo, "Contraseña de acceso", body);
            MessageBox.Show("enviado correctamente");
        }

        private void Limpiar()
        {
            txtCorreo.Text = "";
            txtNombre.Text = "";
            pbxImagen.Image = null;
        }

        private void pbxImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFile.Filter = "Png File |*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbxImagen.ImageLocation = openFile.FileName;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }
    }
}
