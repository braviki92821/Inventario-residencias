using Inventario_residencias.Properties;
using Inventario_residencias.Repositorio;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Opciones_Reporte : Form
    {
        private InventarioRepositorio inventarioRepositorio = new InventarioRepositorio();
        private ReporteRepositorio ReporteRepositorio = new ReporteRepositorio();

        public Opciones_Reporte()
        {
            InitializeComponent();
            estadoInicial();
            cargarTableros();
        }

        private void rbtnGeneral_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void rbtnTablero_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
        }

        private void estadoInicial()
        {
            if (rbtnGeneral.Checked)
            {
                panel2.Enabled = false;
            }
        }

        private void cargarTableros()
        {
            cbxTablero.DataSource = inventarioRepositorio.obtenerTableros();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            if (queryGeneral().Equals(""))
            {
                MessageBox.Show("Seleccione campos para el contenido");
                return;
            }

            string campos = queryGeneral();

            if (queryGeneral().EndsWith(','))
            {
                int t = queryGeneral().Length;
                campos = queryGeneral().Remove(t - 1);
            }

            string[] colums = queryGeneral().Split(',');
            float[] tamanios = (float[])tamanosGeneral().Where(x => x != 0).ToArray();

            ReporteRepositorio.GenerarReporteGeneral(colums, tamanios, campos);

        }

        private void btnReporteTablero_Click(object sender, EventArgs e)
        {
            if (queryTablero().Equals(""))
            {
                MessageBox.Show("Seleccione campos para el contenido");
                return;
            }

            string campos = queryTablero();

            if (queryTablero().EndsWith(','))
            {
                int t = queryTablero().Length;
                campos = queryTablero().Remove(t - 1);
            }

            string[] colums = queryTablero().Split(',');
            float[] tamanios = (float[])tamanosTablero().Where(x => x != 0).ToArray();

            string value = cbxTablero.SelectedValue.ToString();
            string columna = cbxTablero.Text;
            ReporteRepositorio.GenerarReporteTablero(colums, tamanios, campos, value, columna);
        }

        public string queryGeneral()
        {
            string query = "";
            if (chbxNumeroFG.Checked)
                query += "numeroFisico,";
            if (chbxDescripcionG.Checked)
                query += "descripcion,";
            if (chbxTablero.Checked)
                query += "tablero,";
            if (chbxColumnaG.Checked)
                query += "columna,";
            if (chbxFilaG.Checked)
                query += "fila,";
            if (chbxUbicacionG.Checked)
                query += "ubicacion,";
            if (chbxExistenciaG.Checked)
                query += "existencia,";
            if (chbxFechaG.Checked)
                query += "fechaCompra";

            return query;

        }

        public float[] tamanosGeneral()
        {
            float[] tamano = new float[8];
            if (chbxNumeroFG.Checked)
                tamano[0] = 2f;
            if (chbxDescripcionG.Checked)
                tamano[1] = 4f;
            if (chbxTablero.Checked)
                tamano[2] = 2f;
            if (chbxColumnaG.Checked)
                tamano[3] = 2f;
            if (chbxFilaG.Checked)
                tamano[4] = 2f;
            if (chbxUbicacionG.Checked)
                tamano[5] = 4f;
            if (chbxExistenciaG.Checked)
                tamano[6] = 2f;
            if (chbxFechaG.Checked)
                tamano[7] = 4f;
            return tamano;
        }

        public string queryTablero()
        {
            string query = "";
            if (chbxNumeroFG.Checked)
                query += "numeroFisico,";
            if (chbxDescripcionG.Checked)
                query += "descripcion,";
            if (chbxColumnaG.Checked)
                query += "columna,";
            if (chbxFilaG.Checked)
                query += "fila,";
            if (chbxUbicacionG.Checked)
                query += "ubicacion,";
            if (chbxExistenciaG.Checked)
                query += "existencia,";
            if (chbxFechaG.Checked)
                query += "fechaCompra";

            return query;
        }

        public float[] tamanosTablero()
        {
            float[] tamano = new float[7];
            if (chbxNumeroFG.Checked)
                tamano[0] = 2f;
            if (chbxDescripcionG.Checked)
                tamano[1] = 4f;
            if (chbxColumnaG.Checked)
                tamano[2] = 2f;
            if (chbxFilaG.Checked)
                tamano[3] = 2f;
            if (chbxUbicacionG.Checked)
                tamano[4] = 4f;
            if (chbxExistenciaG.Checked)
                tamano[5] = 2f;
            if (chbxFechaG.Checked)
                tamano[6] = 4f;
            return tamano;
        }
    }
}
