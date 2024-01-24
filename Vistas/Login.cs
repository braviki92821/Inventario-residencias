using Inventario_residencias.Modelos;
using Inventario_residencias.Repositorio;
using System.ComponentModel.DataAnnotations;


namespace Inventario_residencias
{
    public partial class Login : Form
    {
        private UsuarioRepositorio UsuarioRepositorio = new UsuarioRepositorio();

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }

            string correo = txtCorreo.Text.Trim();
            string password = txtPassword.Text;
            if (UsuarioRepositorio.login(UsuarioRepositorio.obtenerUsuarioPorCorreo(correo), password))
            {
                if (Session.tipo == "Administrador")
                {
                    MessageBox.Show("Bienvenido");
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else if (Session.tipo == "Usuario")
                {
                    MessageBox.Show("Hola" + Session.nombre);
                }

            }
        }

        private bool validaciones()
        {
            EmailAddressAttribute email = new EmailAddressAttribute();

            if (txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("Debe colocar un correo");
                return false;
            }

            if (!email.IsValid(txtCorreo.Text))
            {
                MessageBox.Show("Debe ingresar un correo valido");
                return false;
            }

            if (txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe colocar su contraseña");
                return false;
            }
            return true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
