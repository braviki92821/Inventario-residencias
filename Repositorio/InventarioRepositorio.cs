using Inventario_residencias.Exceptions;
using Inventario_residencias.Interfaces;
using Inventario_residencias.modelos;
using Inventario_residencias.Modelos;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Inventario_residencias.Repositorio
{
    public class InventarioRepositorio : ConexionMysql, IInventarioRepositorio
    {

        public InventarioRepositorio()
        {
        }

        public bool actualizarItem(Inventario inventario)
        {
            string query = "UPDATE inventario SET descripcion=@descripcion, tablero=@tablero, columna=@columna, fila=@fila, ubicacion= @ubicacion, imagen=@imagen WHERE numeroFisico=@numeroFisico";
            bool rows = false;
            MySqlCommand command = new MySqlCommand(query, sqlConnection());

            try
            {
                command.Parameters.Add(new MySqlParameter("@descripcion", inventario.descripcion));
                command.Parameters.Add(new MySqlParameter("@tablero", inventario.tablero));
                command.Parameters.Add(new MySqlParameter("@columna", inventario.columna));
                command.Parameters.Add(new MySqlParameter("@fila", inventario.fila));
                command.Parameters.Add(new MySqlParameter("@ubicacion", inventario.ubicacion));
                command.Parameters.Add(new MySqlParameter("@imagen", inventario.imagen));
                command.Parameters.Add(new MySqlParameter("@numeroFisico", inventario.numeroFisicoId));
                rows = command.ExecuteNonQuery() > 0;
                CloseCommand(command);
            }
            catch(MySqlException ex)
            {
                CloseCommand(command);
                throw new InventarioException(ex.Message);
            } finally
            {
                sqlConnection().Close();
            }

            return rows;
        }

        public bool agregarItem(Inventario inventario) 
        {
            string query = "INSERT INTO inventario(numeroFisico, descripcion, tablero, columna, fila, ubicacion, imagen, existencia, fechaCompra)" +
                " VALUES(@numeroFisico, @descripcion, @tablero, @columna, @fila, @ubicacion, @imagen, @existencia, @fechaCompra) ";
            bool rows = false;
            MySqlCommand command = new MySqlCommand(query, sqlConnection());
            try
            {
                command.Parameters.Add(new MySqlParameter("@numeroFisico", inventario.numeroFisicoId));
                command.Parameters.Add(new MySqlParameter("@descripcion", inventario.descripcion));
                command.Parameters.Add(new MySqlParameter("@tablero", inventario.tablero));
                command.Parameters.Add(new MySqlParameter("@columna", inventario.columna));
                command.Parameters.Add(new MySqlParameter("@fila", inventario.fila));
                command.Parameters.Add(new MySqlParameter("@ubicacion", inventario.ubicacion));
                command.Parameters.Add(new MySqlParameter("@imagen", inventario.imagen));
                command.Parameters.Add(new MySqlParameter("@existencia", inventario.existencia));
                command.Parameters.Add(new MySqlParameter("@fechaCompra", inventario.fecha));
                rows = command.ExecuteNonQuery() > 0;
                CloseCommand(command);
            }
            catch(MySqlException ex)
            {
                CloseCommand(command);
                throw new InventarioException(ex.Message);
            }
            finally
            {
                sqlConnection().Close();
            }

            return rows;
        }

        public Inventario buscarPorNumeroFisico(string numeroFisico)
        {
            string query = "SELECT * FROM inventario WHERE numeroFisico='" + numeroFisico + "'";
            MySqlDataReader mReader = null;
            Inventario inventario = null;
            MySqlCommand mySqlCommand = new MySqlCommand(query);
            try 
            {
                mySqlCommand.Connection = sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                if (mReader.Read())
                {
                    inventario = new Inventario();
                    inventario.numeroFisicoId = mReader.GetString("numeroFisico");
                    inventario.descripcion = mReader.GetString("descripcion");
                    inventario.tablero = mReader.GetInt16("tablero");
                    inventario.columna = mReader.GetString("columna");
                    inventario.fila = mReader.GetString("fila");
                    inventario.ubicacion = mReader.GetString("ubicacion");
                    inventario.imagen = (byte[])mReader.GetValue(6);
                    inventario.existencia = mReader.GetBoolean(7);
                }
                CloseCommand(mySqlCommand);
            }
            catch(Exception ex)
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

            return inventario; 
        }

        public int cantidadRegistros()
        {
            string query = "SELECT COUNT(*) FROM inventario ";
            MySqlDataReader mReader = null;
            int registros = 0;
            MySqlCommand mySqlCommand = new MySqlCommand(query);
            try
            {        
                mySqlCommand.Connection = sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                while (mReader.Read())
                {
                    registros = mReader.GetInt16("COUNT(*)");
                }
                CloseCommand(mySqlCommand);
            }
            catch(MySqlException ex)
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

            return registros;
        }

        public bool eliminarExistenciaItem(string numeroFisico, bool existencia)
        {
            string query = "UPDATE inventario SET existencia=@existencia WHERE numeroFisico=@numeroFisico";
            bool rows = false;
            MySqlCommand command = new MySqlCommand(query, sqlConnection());
            try
            {
                command.Parameters.Add(new MySqlParameter("@existencia", existencia));
                command.Parameters.Add(new MySqlParameter("@numeroFisico", numeroFisico));
                rows = command.ExecuteNonQuery() > 0;
                CloseCommand(command);
            } catch(MySqlException ex)
            {
                CloseCommand(command);
                throw new InventarioException(ex.Message);
            } finally
            {
                sqlConnection().Close();
            }

            return rows;
        }

        public bool eliminarItem(string numeroFisico)
        {
            string query = "DELETE FROM inventario WHERE numeroFisico=@numeroFisico";
            bool rows = false;
            MySqlCommand command = new MySqlCommand(query, sqlConnection());
            try
            {
                command.Parameters.Add(new MySqlParameter("@numeroFisico", numeroFisico));
                rows = command.ExecuteNonQuery() > 0;
                CloseCommand(command);
            }
            catch(MySqlException ex)
            {
                CloseCommand(command);
                throw new InventarioException(ex.ToString());
            }
            finally
            {
                sqlConnection().Close();
            }
            return rows;
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }

        public bool numeroFisico(string numeroFisico)
        {
            string query = "SELECT numeroFisico FROM inventario WHERE numeroFisico='"+ numeroFisico + "' ";
            bool rows = false;
            MySqlDataReader mReader = null;
            MySqlCommand mySqlCommand = new MySqlCommand(query);
            try
            {
                mySqlCommand.Connection = sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                rows = mReader.Read();
                CloseCommand(mySqlCommand);
            }
            catch(MySqlException ex)
            {
                CloseCommand(mySqlCommand);
                throw;
            }
            finally
            {
                sqlConnection().Close();
                CloseReader(mReader);
            }
            return rows;
        }

        public List<Inventario> obtenerInventario(string numeroFisico, int limite, int offset)
        {
            string query = "SELECT numeroFisico, descripcion, tablero, columna, fila, ubicacion, existencia, fechaCompra FROM inventario  LIMIT " + limite + " OFFSET " + offset + "";
            MySqlDataReader mReader = null;
            List<Inventario> inventarios = new List<Inventario>();

            if (!numeroFisico.Equals(""))
            {
                query = "SELECT numeroFisico, descripcion, tablero, columna, fila, ubicacion, existencia, fechaCompra FROM inventario WHERE numeroFisico LIKE '%" + numeroFisico + "%' LIMIT " + limite + " OFFSET " + offset + "";
            }

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
                    inventario.tablero= mReader.GetInt16("tablero");
                    inventario.columna = mReader.GetString("columna");
                    inventario.fila = mReader.GetString("fila");
                    inventario.ubicacion = mReader.GetString("ubicacion");
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

            return inventarios;
        }

        public List<Tablero> obtenerTableros()
        {
            string query = "SELECT * FROM tablero";
            List<Tablero> tableros = new List<Tablero>();
            MySqlDataReader mReader = null;
            MySqlCommand mySqlCommand = null;
            try
            {
                mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                Tablero tablero = null;
                while (mReader.Read())
                {
                    tablero = new Tablero();
                    tablero.tableroId = mReader.GetInt16("tableroId");
                    tablero.tablero = mReader.GetString("tablero");
                    tableros.Add(tablero);
                }
                CloseCommand(mySqlCommand);
            }
            catch(MySqlException ex)
            {
                CloseCommand(mySqlCommand);
                CloseReader(mReader);
                throw new InventarioException(ex.ToString());
            } finally
            {
                sqlConnection().Close();
                CloseReader(mReader);
            }

            return tableros;
        }

    }
}
