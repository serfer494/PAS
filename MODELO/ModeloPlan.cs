using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloPlan
    {
        public List<string> ObtenerComidas()
        {
            List<string> lista = new List<string>();
            string query = "SELECT nombre FROM COMIDA";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lista.Add(reader["nombre"].ToString());
                        }
                        return lista;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    return lista;
                }
            }
        }

        public int ObtenerIdComida(string str)
        {
            string query = "SELECT idComida FROM COMIDA WHERE nombre=@nombreComida";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombreComida", SqlDbType.VarChar).Value = str;
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    return 0;
                }

            }
        }

        public DataTable GetTable(int idComida)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT idAlimento, cantidad FROM COMIDA_INGREDIENTES " +
                "WHERE idComida=@idComida";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@idComida", SqlDbType.Int).Value = idComida;
                        SqlDataReader reader = cmd.ExecuteReader();
                        tabla.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            return tabla;
        }

        public string ObtenerAlimento(int id)
        {
            string query = "SELECT nombreAlimento FROM ALIMENTO WHERE idAlimento=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        return Convert.ToString(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    return "";
                }
            }
        }

        public int ObtenerCalorias(int id)
        {
            string query = "SELECT energia FROM ALIMENTO WHERE idAlimento=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    return 0;
                }

            }
        }
    }
}
