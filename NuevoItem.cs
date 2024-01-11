using Inventario_residencias.crud;
using Inventario_residencias.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_residencias
{
    public partial class NuevoItem : Form
    {
        private Inventario Inventario;
        private InventarioCRUD inventarioCRUD;

        public NuevoItem()
        {
            InitializeComponent();
            Inventario = new Inventario();
            inventarioCRUD = new InventarioCRUD();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Inventario.numeroFisicoId = txtNumeroFisico.Text;
            Inventario.descripcion = txtDescripcion.Text;
            Inventario.tablero = cbxTablero.SelectedItem.ToString();
            Inventario.columna = cbxColumna.SelectedItem.ToString();
            Inventario.fila = cbxFila.SelectedItem.ToString();
            Inventario.ubicacion = cbxColumna.SelectedItem.ToString() + "-" + cbxFila.SelectedItem.ToString();
            Inventario.imagen = ImageToByteArray(pbxImagen.Image);
            Inventario.existencia = cbxExistencia.SelectedItem.ToString() == "Si" ? true : false;
            if (inventarioCRUD.agregarItem(Inventario))
            {
                MessageBox.Show("Agregado Correctamente");
                return;
            }
            MessageBox.Show("Error al guardar");
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
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
    }
}
