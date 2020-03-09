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
    /// El modelo "Pedir Permisos" se encarga de comprobar los datos del administrador para confirmar el ingreso de un
    /// nuevo usuario a la tabla "Usuarios"
    /// </summary>
    public class ModeloPedirPermisos
    {
        public bool ComprobarAutorizacion(string usuario, string contrasena)
        {
            int contador = 0;
            string query = "SELECT * FROM USUARIO WHERE nombre=@usuario AND PwdCompare(@password, pass) = 1 AND tipo < 2";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = contrasena;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            contador++;
                        }
                    }
                    if (contador > 0)
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
