
using Inventario_residencias.Modelos;
using Inventario_residencias.Repositorio;

namespace Inventario_residencias.Vistas.Users
{
    public partial class Reportar : Form
    {
        ReporteRepositorio ReporteRepositorio = new ReporteRepositorio();

        public Reportar()
        {
            InitializeComponent();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();

            if (!validaciones())
            {
                return;
            }

            reporte.titulo = txtAsunto.Text;
            reporte.descripcion = txtDescripcion.Text;
            reporte.Item = lblNumeroFisico.Text;
            reporte.usuario = Session.usuarioId;
            reporte.fecha = DateTime.Now;
            DialogResult = ReporteRepositorio.reportarItem(reporte) ? MessageBox.Show("Reporte Enviado") : MessageBox.Show("Error al enviar");
        }

        public void numeroFisico(string numeroFisico)
        {
            lblNumeroFisico.Text = numeroFisico;
        }

        private bool validaciones()
        {
            if (txtAsunto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe colocar el titulo del reporte");
                return false;
            }

            if (txtDescripcion.Text.Trim().Equals(""))
            {
                MessageBox.Show("Debe completar este campo");
                return false;
            }

            if (txtDescripcion.Text.Length < 10)
            {
                MessageBox.Show("La descripcion del problema debe contener al menos 10 caracteres");
                return false;
            }

            return true;
        }

        private void txtAsunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
