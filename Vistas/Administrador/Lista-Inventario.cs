using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Lista_Inventario : Form
    {
        List<Inventario> inventarios = new List<Inventario>();
        InventarioRepositorio inventarioRepositorio = new InventarioRepositorio();
        private Inventario Inventario;
        string registro = "";
        double total;
        decimal paginas;
        int paginaActual = 1;

        public Lista_Inventario()
        {
            InitializeComponent();
            Inventario = new Inventario();
            cargarInventario();
            txtPaginaActual.Text = paginaActual.ToString();
        }

        private void cargarInventario(string numeroFisico = "")
        {
            inventarios.Clear();
            inventarios = inventarioRepositorio.obtenerInventario(numeroFisico, 20, 0);
            total = inventarios.Count;
            paginas = (decimal)Math.Ceiling(total / 20);
            txtTotalPaginas.Text = paginas.ToString();
            dgvInventario.DataSource = inventarios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoItem nuevoItem = new NuevoItem();
            nuevoItem.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(registro.Equals(""))
            {
                MessageBox.Show("seleccione un registro");
                return;
            }
            ModificarItem modificarItem = new ModificarItem();
            modificarItem.info(registro);
            modificarItem.ShowDialog();
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            registro = dgvInventario.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
