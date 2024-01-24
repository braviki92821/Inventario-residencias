using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;
using Inventario_residencias.Vistas.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_residencias.Vistas.Usuario
{
    public partial class Tablero_Inventario : Form
    {
        List<Inventario> inventarios = new List<Inventario>();
        InventarioRepositorio inventarioRepositorio = new InventarioRepositorio();
        string registro = "";
        double total;
        double paginas;
        int paginaActual = 1;
        int offSet = 0;

        public Tablero_Inventario()
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

        private void btnBuscarNumero_Click(object sender, EventArgs e)
        {
            cargarInventario(0, txtNumFisico.Text);
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            registro = dgvInventario.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            if (registro.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un item");
                return;
            }
            Reportar reportar = new Reportar();
            reportar.ShowDialog();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cargarInventario(0, "");
        }
    }
}
