using Inventario_residencias.Repositorio;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Reportes : Form
    {
        ReporteRepositorio ReporteRepositorio = new ReporteRepositorio();
        string registro = "";
        int id = 0;

        public Reportes()
        {
            InitializeComponent();
            cargarReportes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id == 0 || registro.Equals(""))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            ReporteRepositorio.eliminarReporte(id);
            MessageBox.Show("Reporte eliminado");
            cargarReportes();
        }

        public void cargarReportes()
        {
            dgvReportes.DataSource = ReporteRepositorio.obtenerReportes();
        }

        private void dgvReportes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvReportes.CurrentRow.Cells[0].Value.ToString());
            registro = dgvReportes.CurrentRow.Cells[3].Value.ToString();
            Clipboard.SetText(registro);
            MessageBox.Show("Numero Fisico copiado al porta papeles");
        }

    }
}
