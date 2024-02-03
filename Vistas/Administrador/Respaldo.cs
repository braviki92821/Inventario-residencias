using Inventario_residencias.Helpers;
using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_residencias.Vistas.Administrador
{
    public partial class Respaldo : Form
    {
        GenerarSql GenerarSql = new GenerarSql();
        InventarioRepositorio InventarioRepositorio = new InventarioRepositorio();

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

        private async void btnCarga_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFile.Filter = "Json File |*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFile.FileName);
                List<Inventario> inventarios = JsonSerializer.Deserialize<List<Inventario>>(jsonString)!;
                
                if (!await validarJson(inventarios))
                {
                    llbProgreso.Text = "Progreso";
                    return;
                }
                llbProgreso.Text = "Progreso: Cargando Datos";
                pgbCarga.Maximum = inventarios.Count;
                foreach (var item in inventarios)
                {
                    pgbCarga.Value++;
                    if (await InventarioRepositorio.numeroFisico(item.numeroFisicoId))
                    {
                        MessageBox.Show("Este numero Fisico ya esta registrado");
                        return;
                    }

                    InventarioRepositorio.agregarItem(item);
                }

                MessageBox.Show("La carga de datos fue realizada con exito", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pgbCarga.Value = 0;
                llbProgreso.Text = "Progreso";
                return;
            }

            MessageBox.Show("Operacion Cancelada", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public async Task<bool> validarJson(List<Inventario> inventarios)
        {

            pgbCarga.Maximum = inventarios.Count;
            llbProgreso.Text = "Progreso: Validado archivo";

            foreach (var item in inventarios)
            {
                pgbCarga.Value++;
                if (item.numeroFisicoId == null)
                {
                    MessageBox.Show("La información no contiene un numero Fisico", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.descripcion == null)
                {
                    MessageBox.Show("La información no contiene una descripcion", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.tablero == null || item.tablero == 0)
                {
                    MessageBox.Show("La información no contiene tablero", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.columna == null)
                {
                    MessageBox.Show("La información no contiene columna", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.fila == null)
                {
                    MessageBox.Show("La información no contiene fila", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.ubicacion == null)
                {
                    MessageBox.Show("La información no contiene ubicación", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.imagen == null)
                {
                    MessageBox.Show("La información no contiene imagen", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
               if (item.existencia == null)
                {
                    MessageBox.Show("La información no contiene existencia", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (item.fecha == null)
                {
                    MessageBox.Show("La información no contiene fecha", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     return false;
                }

            }
             pgbCarga.Value = 0;
             return true;
        }
    }
}
