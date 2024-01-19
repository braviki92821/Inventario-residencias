using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;
using System.Drawing.Imaging;


namespace Inventario_residencias
{
    public partial class NuevoItem : Form
    {
        private Inventario Inventario;
        private InventarioRepositorio inventarioRepositorio;

        public NuevoItem()
        {
            InitializeComponent();
            Inventario = new Inventario();
            inventarioRepositorio = new InventarioRepositorio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }

            Inventario.numeroFisicoId = txtNumeroFisico.Text;
            Inventario.descripcion = txtDescripcion.Text;
            Inventario.tablero = cbxTablero.SelectedItem.ToString();
            Inventario.columna = cbxColumna.SelectedItem.ToString();
            Inventario.fila = cbxFila.SelectedItem.ToString();
            Inventario.ubicacion = cbxColumna.SelectedItem.ToString() + "-" + cbxFila.SelectedItem.ToString();
            Inventario.imagen = inventarioRepositorio.ImageToByteArray(pbxImagen.Image);
            Inventario.existencia = true;
            if (inventarioRepositorio.agregarItem(Inventario))
            {
                MessageBox.Show("Agregado Correctamente");
                return;
            }
            MessageBox.Show("Error al guardar");
        }


        private void pbxImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbxImagen.ImageLocation = openFile.FileName;
            }
        }

        private void NuevoItem_Load(object sender, EventArgs e)
        {

        }

        private bool validaciones()
        {
            if (txtNumeroFisico.Text.Equals(""))
            {
                MessageBox.Show("Numero Fisico es requerido");
                return false;
            }
            if (txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("La descripcion es requerido");
                return false;
            }

            if (cbxTablero.Text == "-----Seleccione-----")
            {
                MessageBox.Show("Seleccione un tablero");
                return false;
            }
            if (cbxColumna.Text == "-----Seleccione-----")
            {
                MessageBox.Show("Seleccione una columna");
                return false;
            }

            if (cbxFila.Text == "-----Seleccione-----")
            {
                MessageBox.Show("Seleccione una fila");
                return false;
            }

            if (pbxImagen.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen");
                return false;
            }
            return true;
        }

    }
}
