using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;

namespace Inventario_residencias
{
    public partial class Inventario_Admin : Form
    {

        List<Inventario> inventarios = new List<Inventario>();
        InventarioRepositorio inventarioRepositorio = new InventarioRepositorio();
        private Inventario Inventario;

        public Inventario_Admin()
        {
            InitializeComponent();
            cargarInventario("");
            Inventario = new Inventario();
        }

        private void cargarInventario(string numeroFisico = "")
        {
            inventarios.Clear();
            inventarios = inventarioRepositorio.obtenerInventario(numeroFisico, 5, 0);
            dgvInventario.DataSource = inventarios;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int limite = int.Parse(comboBox1.SelectedItem.ToString());
            inventarios.Clear();
            inventarios = inventarioRepositorio.obtenerInventario("", limite, 0);
            dgvInventario.DataSource = inventarios;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroFisico = txtNumFisico.Text;
            if (!numeroFisico.Equals(""))
            {
                inventarios.Clear();
                inventarios = inventarioRepositorio.obtenerInventario(numeroFisico, 5, 0);
                dgvInventario.DataSource = inventarios;
                return;
            }
            MessageBox.Show("Debe ingresar un numero fisico");
        }

        private void txtNumFisico_TextChanged(object sender, EventArgs e)
        {
            string numeroFisico = txtNumFisico.Text;
            inventarios.Clear();
            inventarios = inventarioRepositorio.obtenerInventario(numeroFisico, 5, 0);
            dgvInventario.DataSource = inventarios;
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumeroFisico.Text = dgvInventario.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
            cbxTablero.SelectedItem = dgvInventario.CurrentRow.Cells[2].Value.ToString();
            cbxColumna.SelectedItem = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            cbxFila.SelectedItem = dgvInventario.CurrentRow.Cells[4].Value.ToString();
            cbxExistencia.SelectedItem = dgvInventario.CurrentRow.Cells[7].Value.Equals(true) ? "Si" : "No";

            MemoryStream memoryStream = new MemoryStream((byte[])dgvInventario.CurrentRow.Cells[6].Value);
            Image image = Image.FromStream(memoryStream);
            pbxImagen.Image = image;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
                 return;
            Inventario.numeroFisicoId = txtNumeroFisico.Text;

            //if (!inventarioRepositorio.buscarPorNumeroFisico(txtNumeroFisico.Text))
            //{
            //    MessageBox.Show("Este elemento no existe en la base de datos");
            //    return;
            //}

            Inventario.descripcion = txtDescripcion.Text;
            Inventario.tablero = cbxTablero.SelectedItem.ToString();
            Inventario.columna = cbxColumna.SelectedItem.ToString();
            Inventario.fila = cbxFila.SelectedItem.ToString();
            Inventario.ubicacion = cbxColumna.SelectedItem.ToString() + "-" + cbxFila.SelectedItem.ToString();
            Inventario.imagen = inventarioRepositorio.ImageToByteArray(pbxImagen.Image);
            Inventario.existencia = cbxExistencia.SelectedItem.ToString() == "Si" ? true : false;

            if (inventarioRepositorio.actualizarItem(Inventario))
            {
                MessageBox.Show("Modificado Correctamente");
                cargarInventario("");
                return;
            }
            MessageBox.Show("Error al guardar");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroFisico.Text = "";
            txtDescripcion.Text = "";
            cbxTablero.Text = "-----Seleccione-----";
            cbxColumna.Text = "-----Seleccione-----";
            cbxFila.Text = "-----Seleccione-----";
            cbxExistencia.Text = "-----Seleccione-----";
            pbxImagen.Image = null;
        }

        private bool validaciones()
        {
            if (txtNumeroFisico.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un Numero Fisico");
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

            if (cbxExistencia.Text == "-----Seleccione-----")
            {
                MessageBox.Show("Debe seleccionar si el item tiene existencias");
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
