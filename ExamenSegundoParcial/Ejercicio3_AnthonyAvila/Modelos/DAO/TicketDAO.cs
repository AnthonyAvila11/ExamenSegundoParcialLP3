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
    public class TicketDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarDato(Ticket tick)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO Tickets ");
                sql.Append(" VALUES (@NombreCliente,@TipoServicio,@ModeloServ,@DescripcionServ); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 50).Value = tick.NomCliente;
                comando.Parameters.Add("@TipoServicio", SqlDbType.NVarChar, 50).Value = tick.TipoSop;
                comando.Parameters.Add("@ModeloServ", SqlDbType.NVarChar, 50).Value = tick.ModeloSop;
                comando.Parameters.Add("@DescripcionServ", SqlDbType.NVarChar, 150).Value = tick.DescripcionMod;
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetTicket()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM Tickets");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }catch (Exception)
            {

            }
            return dt;
        }
    }
}
