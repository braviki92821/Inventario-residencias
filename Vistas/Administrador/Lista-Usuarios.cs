using Inventario_residencias.Modelos;
using Inventario_residencias.Repositorio;
using Inventario_residencias.modelos;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Lista_Usuarios : Form
    {
        List<modelos.Usuario> usuarios = new List<modelos.Usuario>();
        private UsuarioRepositorio UsuarioRepositorio = new UsuarioRepositorio();
        string registro = "";

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
            if (registro.Equals(""))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            ModificarUsuario modificarUsuario = new ModificarUsuario();
            modificarUsuario.info(int.Parse(registro));
            modificarUsuario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (registro.Equals(""))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            if (UsuarioRepositorio.eliminarUsuario(int.Parse(registro)))
            {
                MessageBox.Show("Usuario dado de baja");
                cargarUsuarios();
                return;
            }
            MessageBox.Show("Error al actualizar estatus del usuario");
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            registro = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
