using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    /// <summary>
    /// El modelo de "Inicio" se encarga de comprobar el tipo y los usuarios que intenten entrar al sistema 
    /// usando los registros a la tabla de 
    /// "Usuarios" de la base de datos "BDPAS" destinada al sisema.
    /// </summary>
    public class ModeloInicio
    {
        public int contador = 0;
        public string Login(string usuario, string password)
        {
            string query = "SELECT nombre, pass FROM USUARIO WHERE nombre=@usuario AND PwdCompare(@password,pass) = 1";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            contador++;
                        }
                        if (contador == 1)
                        {
                            return "";
                        }
                    }
                    return "Usuario no encontrado";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return ex.ToString();
                }
            }
        }

        public int ObtenerTipo(string usuario)
        {
            string query = "SELECT tipo FROM USUARIO WHERE nombre=@usuario";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return -1;
                }
            }
        }
    }
}
