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
    /// El modelo de "Registrar Usuario" se encarga de ingresar registros y revisar si ya hay algun usuario con los mismos datos
    /// a la tabla de "Usuarios" de la base de datos "BDPAS" destinada al sisema.
    /// </summary>
    public class ModeloRegistrarUsuario
    {
        public string AgregarUsuario(string usuario, string contrasena, int tipo)
        {
            string query = "INSERT INTO USUARIO ([nombre], [pass], [tipo]) VALUES(@usuario,PwdEncrypt(@pass),@tipo)";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = contrasena;
                        cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo;
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            Console.WriteLine("Filas insertadas");
                        }
                        else
                        {
                            Console.WriteLine("No se insertaron las filas");
                        }
                    }
                    return "";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return ex.ToString();
                }
            }
        }

        public bool RevisarSiYaExiste(string usuario)
        {
            int contador = 0;
            string query = "SELECT nombre FROM USUARIO WHERE nombre=@usuario";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            contador++;
                        }
                    }
                    if(contador > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return true;
                }
            }
        }

    }
}
