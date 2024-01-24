using MySql.Data.MySqlClient;
using System.Configuration;

namespace Inventario_residencias
{
    public class ConexionMysql
    {
        private MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMysql()
        {
        }

        public MySqlConnection sqlConnection()
        {
            try
            {
                cadenaConexion = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                connection = new MySqlConnection(cadenaConexion);
                connection.Open();

            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            return connection;
        }

        public void CloseCommand(MySqlCommand mySqlCommand)
        {
            try
            {
                mySqlCommand.Connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public void CloseReader(MySqlDataReader mReader)
        {
            try
            {
                mReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
