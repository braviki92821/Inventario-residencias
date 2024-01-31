using Inventario_residencias.Helpers;
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
    public partial class Respaldo : Form
    {
        GenerarSql GenerarSql = new GenerarSql();

        public Respaldo()
        {
            InitializeComponent();
        }

        private void btnGenerarSql_Click(object sender, EventArgs e)
        {
            GenerarSql.crearCopia();
        }

        private async void btnGenerarJson_Click(object sender, EventArgs e)
        {
           await GenerarSql.crearJsonRespaldoAsync();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            GenerarSql.cargaMasivaAsync();
        }
    }
}
