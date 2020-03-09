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
    /// El modelo "Comida" se encarga de realizar el CRUD para los registros de la tabla
    /// "Comida_Ingredientes y Comida" de la base de datos "BDPAS" destinada al sistema.
    /// </summary>
    public class ModeloComida
    {
        //Proxy

        public List<string> ObtenerAlimentos()
        {
            List<string> lista = new List<string>();
            string query = "SELECT nombreAlimento FROM ALIMENTO";
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
                            lista.Add(reader["nombreAlimento"].ToString());
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

        public int ObtenerIdAlimento(string str)
        {
            string query = "SELECT idAlimento FROM Alimento WHERE nombreAlimento=@nombre";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = str;
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
        //Facade
        public void AgregarComida(string nombre, int id1, int id2, int id3, int id4, int id5, string cant1, string cant2, string cant3, string cant4, string cant5)
        {
            int idComida = 0;
            string query = "INSERT INTO COMIDA ([nombre]) VALUES(@nombre)";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            query = "SELECT idComida FROM COMIDA WHERE nombre=@nombre";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        idComida = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    
                }

            }
            if(id1 != 0 && Convert.ToInt32(cant1) > 0)
            {
                query = "INSERT INTO COMIDA_INGREDIENTES ([idAlimento], [idComida], [cantidad]) VALUES(@id, @idComida, @cant)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id1;
                            cmd.Parameters.Add("@idComida", SqlDbType.VarChar).Value = idComida;
                            cmd.Parameters.Add("@cant", SqlDbType.VarChar).Value = cant1;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            if (id2 != 0 && Convert.ToInt32(cant2) > 0)
            {
                query = "INSERT INTO COMIDA_INGREDIENTES ([idAlimento], [idComida], [cantidad]) VALUES(@id, @idComida, @cant)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id2;
                            cmd.Parameters.Add("@idComida", SqlDbType.VarChar).Value = idComida;
                            cmd.Parameters.Add("@cant", SqlDbType.VarChar).Value = cant2;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            if (id3 != 0 && Convert.ToInt32(cant3) > 0)
            {
                query = "INSERT INTO COMIDA_INGREDIENTES ([idAlimento], [idComida], [cantidad]) VALUES(@id, @idComida, @cant)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id3;
                            cmd.Parameters.Add("@idComida", SqlDbType.VarChar).Value = idComida;
                            cmd.Parameters.Add("@cant", SqlDbType.VarChar).Value = cant3;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            if (id4 != 0 && Convert.ToInt32(cant4) > 0)
            {
                query = "INSERT INTO COMIDA_INGREDIENTES ([idAlimento], [idComida], [cantidad]) VALUES(@id, @idComida, @cant)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id4;
                            cmd.Parameters.Add("@idComida", SqlDbType.VarChar).Value = idComida;
                            cmd.Parameters.Add("@cant", SqlDbType.VarChar).Value = cant4;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            if (id5 != 0 && Convert.ToInt32(cant5) > 0)
            {
                query = "INSERT INTO COMIDA_INGREDIENTES ([idAlimento], [idComida], [cantidad]) VALUES(@id, @idComida, @cant)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id5;
                            cmd.Parameters.Add("@idComida", SqlDbType.VarChar).Value = idComida;
                            cmd.Parameters.Add("@cant", SqlDbType.VarChar).Value = cant5;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        //Singleton
        public DataTable GetTable()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT nombre AS 'Nombre de Comida', nombreAlimento AS 'Nombre de Alimento', cantidad AS 'Cantidad' FROM COMIDA, ALIMENTO, COMIDA_INGREDIENTES " +
                "WHERE COMIDA.idComida = COMIDA_INGREDIENTES.idComida AND ALIMENTO.idAlimento = COMIDA_INGREDIENTES.idAlimento; ";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
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

        public int ObtenerIdComida(string str)
        {
            string query = "SELECT idComida FROM COMIDA WHERE nombre=@nombre";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = str;
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

        public string ObtenerNombre(int id)
        {
            string query = "SELECT nombre FROM COMIDA WHERE idComida=@id";
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

        public int ObtenerIdComidaIngrediente(int idAlimento, int idComida)
        {
            string query = "SELECT idComidaAlimento FROM COMIDA_INGREDIENTES WHERE idAlimento=@idAlimento AND idComida=@idComida";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@idAlimento", SqlDbType.Int).Value = idAlimento;
                        cmd.Parameters.Add("@idComida", SqlDbType.Int).Value = idComida;
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
        //facade
        public void ModificarComida(string nombre, int idAlimento, int idComida, string cant, int idComidaAlimento)
        {
            string query = "UPDATE COMIDA SET nombre=@nombre WHERE idComida=@idComida";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@idComida", SqlDbType.Int).Value = idComida;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }

            query = "UPDATE COMIDA_INGREDIENTES SET idAlimento=@idAlimento, cantidad=@cant WHERE idComidaAlimento=@idComidaAlimento";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@idAlimento", SqlDbType.Int).Value = idAlimento;
                        cmd.Parameters.Add("@cant", SqlDbType.VarChar).Value = cant;
                        cmd.Parameters.Add("@idComidaAlimento", SqlDbType.Int).Value = idComidaAlimento;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }
        //facade
        public void EliminarComida(int idComida)
        {
            string query = "DELETE FROM COMIDA_INGREDIENTES WHERE idComida=@id";

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idComida;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }

            query = "DELETE FROM COMIDA WHERE idComida=@id";

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = idComida;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }
    }
    
}
