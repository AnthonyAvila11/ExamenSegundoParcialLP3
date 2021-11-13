using Ejercicio3_AnthonyAvila.Modelos.Entidadaes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_AnthonyAvila.Modelos.DAO
{    
    public class TipoSopoteDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarDatos(TipoSoporte tsopoerte)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TipoSoporte ");
                sql.Append(" VALUES (@TipoSoporte,@Modelo); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 50).Value = tsopoerte.Tipo;
                comando.Parameters.Add("@Modelo", SqlDbType.NVarChar, 50).Value = tsopoerte.Modelo;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
