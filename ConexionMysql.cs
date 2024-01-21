using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_residencias
{
    internal class ConexionMysql : Conexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMysql()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection sqlConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return connection;
        }
    }
}
