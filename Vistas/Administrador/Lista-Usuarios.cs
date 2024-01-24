using Inventario_residencias.Modelos;
using Inventario_residencias.Repositorio;
using Inventario_residencias.modelos;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Lista_Usuarios : Form
    {
        List<modelos.Usuario> usuarios = new List<modelos.Usuario>();
        private UsuarioRepositorio UsuarioRepositorio = new UsuarioRepositorio();
        public Lista_Usuarios()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.ShowDialog();
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
            usuarios = UsuarioRepositorio.obtenerUsuarios(true, Session.usuarioId);
            dgvUsuarios.DataSource = usuarios;
        }

        private void Lista_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
           // ConexionMysql.sqlConnection().Close();
        }
    }
}
