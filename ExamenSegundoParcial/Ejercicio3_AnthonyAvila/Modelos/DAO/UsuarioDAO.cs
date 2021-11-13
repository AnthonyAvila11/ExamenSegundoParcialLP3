using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_AnthonyAvila
{
    public class UsuarioDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool valUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM Registro WHERE Correo = @Correo AND Contrasena = @Contrasena;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 30).Value = user.Correo;
                comando.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 80).Value = user.Contrasena;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

            }
            return valido;
        }

        public bool Registrar(Usuario user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO Registro ");
                sql.Append(" VALUES (@Nombre,@Apellido,@Correo, @Contrasena, @ConfirmarContrasena); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 20).Value = user.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.NVarChar, 20).Value = user.Apellido;
                comando.Parameters.Add("@Correo", SqlDbType.NVarChar, 30).Value = user.Correo;
                comando.Parameters.Add("@Contrasena", SqlDbType.NVarChar, 80).Value = Encriptar(user.Contrasena);
                comando.Parameters.Add("@ConfirmarContrasena", SqlDbType.NVarChar, 80).Value = Encriptar(user.ConfirmarContrasena);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string Encriptar(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

        }
    }
}
