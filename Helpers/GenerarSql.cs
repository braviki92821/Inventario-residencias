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
                MessageBox.Show("Archico creado correctamente", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

    }
}
