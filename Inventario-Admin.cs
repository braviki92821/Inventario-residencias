using Inventario_residencias.crud;
using Inventario_residencias.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Inventario_residencias
{
    public partial class Inventario_Admin : Form
    {

        List<Inventario> inventarios = new List<Inventario>();
        InventarioCRUD inventarioCRUD = new InventarioCRUD();

        public Inventario_Admin()
        {
            InitializeComponent();
            cargarInventario("");
        }

        private void cargarInventario(string numeroFisico = "")
        {
            inventarios.Clear();
            inventarios = inventarioCRUD.obtenerInventario(numeroFisico, 5, 0);
            dgvInventario.DataSource = inventarios;
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int limite = int.Parse(comboBox1.SelectedItem.ToString());
            inventarios.Clear();
            inventarios = inventarioCRUD.obtenerInventario("", limite, 0);
            dgvInventario.DataSource = inventarios;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numeroFisico = txtNumFisico.Text;
            if (!numeroFisico.Equals(""))
            {
                inventarios.Clear();
                inventarios = inventarioCRUD.obtenerInventario(numeroFisico, 5, 0);
                dgvInventario.DataSource = inventarios;
                return;
            }
            MessageBox.Show("Debe ingresar un numero fisico");
        }

        private void txtNumFisico_TextChanged(object sender, EventArgs e)
        {
            string numeroFisico = txtNumFisico.Text;
            inventarios.Clear();
            inventarios = inventarioCRUD.obtenerInventario(numeroFisico, 5, 0);
            dgvInventario.DataSource = inventarios;
        }
    }
}
