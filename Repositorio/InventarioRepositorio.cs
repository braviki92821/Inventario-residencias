using Inventario_residencias.Interfaces;
using Inventario_residencias.modelos;
using Inventario_residencias.Modelos;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Drawing.Imaging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Inventario_residencias.Repositorio
{
    public class InventarioRepositorio : IInventarioRepositorio
    {
        private ConexionMysql conexionMysql;

        public InventarioRepositorio()
        {
            conexionMysql = new ConexionMysql();
        }

        public bool actualizarItem(Inventario inventario)
        {
            string query = "UPDATE inventario SET descripcion=@descripcion, tablero= @tablero, columna=@columna, fila= @fila, ubicacion= @ubicacion, imagen=@imagen, existencia=@existencia WHERE numeroFisico=@numeroFisico";

            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());

            command.Parameters.Add(new MySqlParameter("@descripcion", inventario.descripcion));
            command.Parameters.Add(new MySqlParameter("@tablero", inventario.tablero));
            command.Parameters.Add(new MySqlParameter("@columna", inventario.columna));
            command.Parameters.Add(new MySqlParameter("@fila", inventario.fila));
            command.Parameters.Add(new MySqlParameter("@ubicacion", inventario.ubicacion));
            command.Parameters.Add(new MySqlParameter("@imagen", inventario.imagen));
            command.Parameters.Add(new MySqlParameter("@numeroFisico", inventario.numeroFisicoId));

            return command.ExecuteNonQuery() > 0;
        }

        public bool agregarItem(Inventario inventario)
        {
            string query = "INSERT INTO inventario(numeroFisico, descripcion, tablero, columna, fila, ubicacion, imagen, existencia, fechaCompra)" +
                " Values(@numeroFisico, @descripcion, @tablero, @columna, @fila, @ubicacion, @imagen, @existencia, @fechaCompra) ";

            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());

            command.Parameters.Add(new MySqlParameter("@numeroFisico", inventario.numeroFisicoId));
            command.Parameters.Add(new MySqlParameter("@descripcion", inventario.descripcion));
            command.Parameters.Add(new MySqlParameter("@tablero", inventario.tablero));
            command.Parameters.Add(new MySqlParameter("@columna", inventario.columna));
            command.Parameters.Add(new MySqlParameter("@fila", inventario.fila));
            command.Parameters.Add(new MySqlParameter("@ubicacion", inventario.ubicacion));
            command.Parameters.Add(new MySqlParameter("@imagen", inventario.imagen));
            command.Parameters.Add(new MySqlParameter("@existencia", inventario.existencia));
            command.Parameters.Add(new MySqlParameter("@fechaCompra", inventario.fecha));

            return command.ExecuteNonQuery() > 0;
        }

        public Inventario buscarPorNumeroFisico(string numeroFisico)
        {
            string query = "SELECT * FROM inventario WHERE numeroFisico='" + numeroFisico + "'";
            MySqlDataReader mReader = null;
            Inventario inventario = null;
            try 
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
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
                    inventario.existencia = mReader.GetBoolean(7);
                }
                mReader.Close();
            }
            catch(Exception ex)
            {
                throw;
            }

            return inventario; 
        }

        public int cantidadRegistros()
        {
            string query = "SELECT COUNT(*) FROM inventario ";
            MySqlDataReader mReader = null;
            int registros = 0;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
                mReader = mySqlCommand.ExecuteReader();
                while (mReader.Read())
                {
                    registros = mReader.GetInt16("COUNT(*)");
                }
                mReader.Close();
            }
            catch(MySqlException ex)
            {
                throw;
            }

            return registros;
        }

        public bool eliminarExistenciaItem(string numeroFisico)
        {
            string query = "UPDATE inventario SET existencia=@existencia WHERE numeroFisico=@numeroFisico";
            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());
            command.Parameters.Add(new MySqlParameter("@existencia", false));
            command.Parameters.Add(new MySqlParameter("@numeroFisico", numeroFisico));
            return command.ExecuteNonQuery() > 0;
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }

        public List<Inventario> obtenerInventario(string numeroFisico, int limite, int offset)
        {
            string query = "SELECT * FROM inventario  LIMIT " + limite + " OFFSET " + offset + "";
            MySqlDataReader mReader = null;
            List<Inventario> inventarios = new List<Inventario>();

            try
            {
                if (!numeroFisico.Equals(""))
                {
                    query = "SELECT * FROM inventario WHERE numeroFisico LIKE '%" + numeroFisico + "%' LIMIT " + limite + " OFFSET " + offset + "";
                    Console.WriteLine(query);
                }
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
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
                    inventario.existencia = mReader.GetBoolean(7);
                    inventarios.Add(inventario);
                }
                mReader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return inventarios;
        }

        public List<Tablero> obtenerTableros()
        {
            string query = "SELECT * FROM tablero ";
            MySqlDataReader mReader = null;
            List<Tablero> tableros = new List<Tablero>();

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
                mReader = mySqlCommand.ExecuteReader();

                Tablero tablero = null;
                while (mReader.Read())
                {
                    tablero = new Tablero();
                    tablero.tableroId = mReader.GetInt16("tableroId");
                    tablero.tablero = mReader.GetString("tablero");
                    tableros.Add(tablero);
                }
                mReader.Close();
            }
            catch(MySqlException ex)
            {
                throw;
            }

            return tableros;
        }
    }
}
