using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class ModificarItem : Form
    {
        private Inventario Inventario;
        private InventarioRepositorio inventarioRepositorio;

        public ModificarItem()
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

        public void info(string numeroFisico)
        {
            Inventario = inventarioRepositorio.buscarPorNumeroFisico(numeroFisico);
            txtNumeroFisico.Text = numeroFisico;
            txtDescripcion.Text = Inventario.descripcion;
            cbxTablero.SelectedItem = Inventario.tablero;
            cbxColumna.SelectedItem = Inventario.columna;
            cbxFila.SelectedItem = Inventario.fila;
        }



    }
}
