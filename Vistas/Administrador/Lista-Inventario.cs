using DocumentFormat.OpenXml.Spreadsheet;
using Inventario_residencias.Exceptions;
using Inventario_residencias.Helpers;
using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;
using MySql.Data.MySqlClient;
using SpreadsheetLight;
using SpreadsheetLight.Drawing;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Lista_Inventario : Form
    {
        List<Inventario> inventarios = new List<Inventario>();
        InventarioRepositorio inventarioRepositorio = new InventarioRepositorio();
        GenerarExcel GenerarExcel = new GenerarExcel();
        string registro = "";
        bool existencia = false;
        double total;
        double paginas;
        int paginaActual = 1;
        int offSet = 0;

        public Lista_Inventario()
        {
            InitializeComponent();
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
            existencia = dgvInventario.CurrentRow.Cells[7].Value.Equals(true) ? true : false;
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Opciones_Reporte opciones_Reporte = new Opciones_Reporte();
            opciones_Reporte.ShowDialog();
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            GenerarExcel.CrearExcel();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarInventario(offSet = 0);
        }

        private void Lista_Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnEstatus_Click(object sender, EventArgs e)
        {
            if (registro.Equals(""))
            {
                MessageBox.Show("seleccione un registro");
                return;
            }
            DialogResult result = MessageBox.Show("¿Cambiar Estatus?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string mensaje = inventarioRepositorio.eliminarExistenciaItem(registro, !existencia) ? "Existencia del Item actualizada" : "Error al actualizar";
            MessageBox.Show(mensaje);
            cargarInventario(offSet);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (registro.Equals(""))
            {
                MessageBox.Show("seleccione un registro");
                return;
            }

            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                MessageBox.Show("Operacion Cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (inventarioRepositorio.eliminarItem(registro))
            {
                MessageBox.Show("Operacion realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarInventario(offSet);
                return;
            }

            MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
