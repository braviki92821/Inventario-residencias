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
        double paginas;
        int paginaActual = 1;
        int offSet = 0;

        public Lista_Inventario()
        {
            InitializeComponent();
            Inventario = new Inventario();
            cargarInventario(offSet);
            txtPaginaActual.Text = paginaActual.ToString();
        }

        private void cargarInventario(int offSet, string numeroFisico = "")
        {
            inventarios.Clear();
            inventarios = inventarioRepositorio.obtenerInventario(numeroFisico, 10, offSet);
            total = inventarioRepositorio.cantidadRegistros();
            paginas = Math.Ceiling(total / 10);
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
            if (registro.Equals(""))
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

        private void txtNumFisico_TextChanged(object sender, EventArgs e)
        {
            cargarInventario(0, txtNumFisico.Text);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (txtPaginaActual.Text.Equals("1"))
            {
                return;
            }
            paginaActual--;
            offSet = paginaActual * 10 - 10;
            cargarInventario(offSet);
            txtPaginaActual.Text = paginaActual.ToString();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtPaginaActual.Text.Equals(paginas.ToString()))
            {
                return;
            }
            paginaActual++;
            offSet = paginaActual * 10 - 10;
            cargarInventario(offSet);
            txtPaginaActual.Text = paginaActual.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (registro.Equals(""))
            {
                MessageBox.Show("seleccione un registro");
                return;
            }

            string mensaje = inventarioRepositorio.eliminarExistenciaItem(registro) ? "Existencia del Item actualizada" : "Error al actualizar";
            MessageBox.Show(mensaje);
            cargarInventario(offSet);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Opciones_Reporte opciones_Reporte = new Opciones_Reporte();
            opciones_Reporte.ShowDialog();
        }
    }
}
