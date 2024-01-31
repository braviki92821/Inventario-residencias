using DocumentFormat.OpenXml.Drawing;
using Inventario_residencias.Exceptions;
using Inventario_residencias.modelos;
using Inventario_residencias.Repositorio;
using MySql.Data.MySqlClient;
using System.Text.Json;
using Windows.UI.Popups;

namespace Inventario_residencias.Helpers
{
    public class GenerarSql : ConexionMysql
    {
        InventarioRepositorio InventarioRepositorio = new InventarioRepositorio();

        public void crearCopia()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL File |*.sql";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = sqlConnection();
                MySqlBackup mySqlBackup = new MySqlBackup(mySqlCommand);
                mySqlBackup.ExportToFile(sfd.FileName);
                CloseCommand(mySqlCommand);
                sqlConnection().Close();
                MessageBox.Show("Respaldo de la base creado correctamente");
            }
        }

        public async Task crearJsonRespaldoAsync()
        {
            string query = "SELECT * FROM inventario";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Json File |*.json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MySqlDataReader mReader = null;
                List<Inventario> inventarios = new List<Inventario>();
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                try
                {
                    mySqlCommand.Connection = sqlConnection();
                    mReader = mySqlCommand.ExecuteReader();

                    Inventario inventario = null;
                    while (mReader.Read())
                    {
                        inventario = new Inventario();
                        inventario.numeroFisicoId = mReader.GetString("numeroFisico");
                        inventario.descripcion = mReader.GetString("descripcion");
                        inventario.tablero = mReader.GetInt16("tablero");
                        inventario.columna = mReader.GetString("columna");
                        inventario.fila = mReader.GetString("fila");
                        inventario.ubicacion = mReader.GetString("ubicacion");
                        inventario.imagen = (byte[])mReader.GetValue(6);
                        inventario.existencia = mReader.GetBoolean("existencia");
                        inventario.fecha = mReader.GetString("fechaCompra");
                        inventarios.Add(inventario);
                    }
                    CloseCommand(mySqlCommand);
                }
                catch (Exception ex)
                {
                    CloseCommand(mySqlCommand);
                    CloseReader(mReader);
                    throw new InventarioException(ex.Message);
                }
                finally
                {
                    sqlConnection().Close();
                    CloseReader(mReader);
                }

                var options = new JsonSerializerOptions { WriteIndented = true };         
                await using FileStream createStream = File.Create(sfd.FileName);
                await JsonSerializer.SerializeAsync(createStream, inventarios, options);
            }


        }

        public async void cargaMasivaAsync()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Json File |*.json";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(openFile.FileName);
                List<Inventario> inventarios = JsonSerializer.Deserialize<List<Inventario>>(jsonString)!;

                if (!validarJson(inventarios))
                    return;

                foreach(var item in inventarios)
                {
                   if(await InventarioRepositorio.numeroFisico(item.numeroFisicoId))
                    {
                        MessageBox.Show("Este numero Fisico ya esta registrado");
                        return;
                    }

                    InventarioRepositorio.agregarItem(item);
                }

                MessageBox.Show("La carga de datos fue realizada con exito", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Operacion Cancelada", "Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool validarJson(List<Inventario> inventarios)
        {
            bool valido = false;
            int contador = 0;
            int total = inventarios.Count;
            ProgressBar progressBar = new ProgressBar();
            

            foreach (var item in inventarios)
            {
                if(item.numeroFisicoId == null)
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

            return true;
        }
    }
}
