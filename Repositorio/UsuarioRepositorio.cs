using Inventario_residencias.Interfaces;
using Inventario_residencias.modelos;
using Inventario_residencias.Modelos;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;


namespace Inventario_residencias.Repositorio
{
    public class UsuarioRepositorio: IUsuarioRepositorio
    {
        private ConexionMysql conexionMysql;

        public UsuarioRepositorio()
        {
            conexionMysql = new ConexionMysql();
        }

        public bool agregarUsuario(Usuario usuario)
        {
            string query = "INSERT INTO usuarios(nombre, correo, password, tipo, estatus, imagen)" +
            " Values(@nombre, @correo, @password, @tipo, @estatus, @imagen)";
            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());
            command.Parameters.Add(new MySqlParameter("@nombre", usuario.nombre));
            command.Parameters.Add(new MySqlParameter("@correo", usuario.correo));
            command.Parameters.Add(new MySqlParameter("@password", usuario.password));
            command.Parameters.Add(new MySqlParameter("@tipo", usuario.tipo));
            command.Parameters.Add(new MySqlParameter("@estatus", usuario.status));
            command.Parameters.Add(new MySqlParameter("@imagen", usuario.imagen));

            return command.ExecuteNonQuery() > 0;
        }

        public bool eliminarUsuario(int usuarioId)
        {
            string query = "UPDATE usuarios SET estatus= @estatus WHERE usuarioId=@usuarioId";
            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());
            command.Parameters.Add(new MySqlParameter("@estatus", false));
            return command.ExecuteNonQuery() > 0;
        }

        public string hashPassword(string password)
        {
            string securePassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 10);
            return securePassword;
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                return null;
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }

        public bool login(Usuario? usuario, string password)
        {

            if (!usuario.status)
            {
                MessageBox.Show("El correo no existe o tu usuario fue dado de baja");
                return false;
            }

            if(!verifyPassword(usuario.password, password))
            {
                MessageBox.Show("La contraseña no es coincidente");
                return false;
            }

            Session.usuarioId = (int)usuario.usuarioId;
            Session.nombre = usuario.nombre;
            Session.tipo = usuario.tipo;
    
            return true;

        }

        public bool modificarUsuario(Usuario usuario)
        {
            string query = "UPDATE usuarios SET nombre= @nombre, correo= @correo, tipo=@tipo, imagen=@imagen WHERE usuarioId=@usuarioId";

            MySqlCommand command = new MySqlCommand(query, conexionMysql.sqlConnection());

            command.Parameters.Add(new MySqlParameter("@nombre", usuario.nombre));
            command.Parameters.Add(new MySqlParameter("@correo", usuario.correo));
            command.Parameters.Add(new MySqlParameter("@tipo", usuario.tipo));
            command.Parameters.Add(new MySqlParameter("@imagen", usuario.imagen));
            command.Parameters.Add(new MySqlParameter("@usuarioId", usuario.usuarioId));
            return command.ExecuteNonQuery() > 0;
        }

        public Usuario obtenerUsuarioPorCorreo(string correo)
        {
            string query = "SELECT * FROM usuarios WHERE correo='" + correo + "' ";
            MySqlDataReader mReader = null;
            Usuario usuario = null;

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
                mReader = mySqlCommand.ExecuteReader();

                usuario = new Usuario();
                while (mReader.Read())
                {
                    usuario.usuarioId = mReader.GetInt16("usuarioId");
                    usuario.nombre = mReader.GetString("nombre");
                    usuario.correo = mReader.GetString("correo");
                    usuario.password = mReader.GetString("password");
                    usuario.tipo = mReader.GetString("tipo");
                    usuario.status = mReader.GetBoolean("estatus");
                }
                mReader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return usuario;

        }

        public List<Usuario> obtenerUsuarios(bool estatus, int usuarioId)
        {
            string query = "SELECT * FROM usuarios WHERE estatus='"+estatus+ "' AND usuarioId <> '" + usuarioId+"' ";

            MySqlDataReader mReader = null;

            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = conexionMysql.sqlConnection();
                mReader = mySqlCommand.ExecuteReader();

                Usuario usuario = null;
                while (mReader.Read())
                {
                    usuario = new Usuario();
                    usuario.usuarioId = mReader.GetInt16("usuarioId");
                    usuario.nombre = mReader.GetString("nombre");
                    usuario.correo = mReader.GetString("correo");
                    usuario.password = mReader.GetString("password");
                    usuario.tipo = mReader.GetString("tipo");
                    usuario.status = mReader.GetBoolean("estatus");
                    usuario.imagen = (byte[])mReader.GetValue(6);

                    usuarios.Add(usuario);
                }
                mReader.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return usuarios;
        }

        public bool verifyPassword(string passwordBd, string passwordLg)
        {
            bool isPassword = BCrypt.Net.BCrypt.EnhancedVerify(passwordLg, passwordBd);
            return isPassword;
        }
        

    }
}
