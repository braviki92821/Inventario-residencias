using Inventario_residencias.Interfaces;
using Inventario_residencias.modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            command.Parameters.Add(new MySqlParameter("@existencia", inventario.existencia));
            command.Parameters.Add(new MySqlParameter("@numeroFisico", inventario.numeroFisicoId));

            return command.ExecuteNonQuery() > 0;
        }

        public bool agregarItem(Inventario inventario)
        {
            string query = "INSERT INTO inventario(numeroFisico, descripcion, tablero, columna, fila, ubicacion, imagen, existencia)" +
                " Values(@numeroFisico, @descripcion, @tablero, @columna, @fila, @ubicacion, @imagen, @existencia) ";

            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());

            command.Parameters.Add(new MySqlParameter("@numeroFisico", inventario.numeroFisicoId));
            command.Parameters.Add(new MySqlParameter("@descripcion", inventario.descripcion));
            command.Parameters.Add(new MySqlParameter("@tablero", inventario.tablero));
            command.Parameters.Add(new MySqlParameter("@columna", inventario.columna));
            command.Parameters.Add(new MySqlParameter("@fila", inventario.fila));
            command.Parameters.Add(new MySqlParameter("@ubicacion", inventario.ubicacion));
            command.Parameters.Add(new MySqlParameter("@imagen", inventario.imagen));
            command.Parameters.Add(new MySqlParameter("@existencia", inventario.existencia));

            return command.ExecuteNonQuery() > 0;
        }

        public bool buscarPorNumeroFisico(string numeroFisico)
        {
            string query = "SELECT * FROM inventario WHERE numeroFisico='" + numeroFisico + "'";
            bool existe;
            MySqlDataReader mReader = null;

            MySqlCommand mySqlCommand = new MySqlCommand(query);
            mySqlCommand.Connection = conexionMysql.sqlConnection();
            mReader = mySqlCommand.ExecuteReader();
            existe = mReader.Read();
            mReader.Close();
            return existe;
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
            string query = "SELECT * FROM inventario LIMIT " + limite + " OFFSET " + offset + "";

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
                    inventario.tablero = mReader.GetString("tablero");
                    inventario.columna = mReader.GetString("columna");
                    inventario.fila = mReader.GetString("fila");
                    inventario.ubicacion = mReader.GetString("ubicacion");
                    inventario.imagen = (byte[])mReader.GetValue(6);
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
    }
}
