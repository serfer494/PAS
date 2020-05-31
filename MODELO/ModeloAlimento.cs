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
    /// El modelo "Alimento" se encarga de realizar el CRUD para los registros de la tabla
    /// "Alimento" de la base de datos "BDPAS" destinada al sistema.
    /// </summary>
    public class ModeloAlimento
    {
        public string error = "";
        //Proxy
        
        //facade
        public void AgregarAlimento(string nombre, string energia, string hidratos, string grasa, string proteinas)
        {
            string query = "INSERT INTO ALIMENTO ([nombreAlimento], [energia], " +
                "[hidratosCarbono], [grasa], [proteinas]) VALUES(@nombre,@energia," +
                "@hidratos,@grasa,@proteinas)";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@energia", SqlDbType.Int).Value = Convert.ToInt32(energia);
                        cmd.Parameters.Add("@hidratos", SqlDbType.Int).Value = Convert.ToInt32(hidratos);
                        cmd.Parameters.Add("@grasa", SqlDbType.Int).Value = Convert.ToInt32(grasa);
                        cmd.Parameters.Add("@proteinas", SqlDbType.Int).Value = Convert.ToInt32(proteinas);
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

        public bool VerificarRepetido(string nombre)
        {
            int contador = 0;
            string query = "SELECT nombreAlimento FROM ALIMENTO WHERE nombreAlimento=@nombre";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            contador++;
                        }
                    }
                    if (contador > 0)
                    {
                        error = "";
                        return true;
                    }
                    else
                    {
                        error = "";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    Console.WriteLine(ex.ToString());
                    return true;
                }
            }
        }
        
        public bool VerificarMismo(int id, string nombre)
        {
            int contador = 0;
            string query = "SELECT idAlimento, nombreAlimento FROM ALIMENTO WHERE idAlimento=@id AND nombreAlimento=@nombre";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
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
                        error = "Ese alimento ya existe";
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    error = ex.ToString();
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
        }
        //Singleton
        public DataTable GetTable()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT nombreAlimento AS 'Nombre', hidratosCarbono AS 'Hidratos de carbono', energia AS 'Energia', " +
                "grasa AS 'Grasa', proteinas AS 'Proteinas' FROM ALIMENTO";
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
        //facade
        public void ModificarAlimento(string nombre, string energia, string hidratos, string grasa, string proteinas, int id)
        {
            string query = "UPDATE ALIMENTO SET hidratosCarbono=@hidratos , energia=@energia , nombreAlimento=@nombre , " +
                "grasa=@grasa , proteinas=@proteinas WHERE idAlimento=@id";

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@energia", SqlDbType.Int).Value = Convert.ToInt32(energia);
                        cmd.Parameters.Add("@hidratos", SqlDbType.Int).Value = Convert.ToInt32(hidratos);
                        cmd.Parameters.Add("@grasa", SqlDbType.Int).Value = Convert.ToInt32(grasa);
                        cmd.Parameters.Add("@proteinas", SqlDbType.Int).Value = Convert.ToInt32(proteinas);
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public void EliminarAlimento(int id)
        {
            string query = "DELETE FROM ALIMENTO WHERE idAlimento=@id";

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    error = "No se puede eliminar alimento porque esta siendo usando por alguna comida";
                    return;
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }

        public int ObtenerId(string str)
        {
            string query = "SELECT idAlimento FROM ALIMENTO WHERE nombreAlimento=@nombre";
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

        public int ObtenerEnergia(int id)
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

        public int ObtenerHidratos(int id)
        {
            string query = "SELECT hidratosCarbono FROM ALIMENTO WHERE idAlimento=@id";
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

        public int ObtenerGrasa(int id)
        {
            string query = "SELECT grasa FROM ALIMENTO WHERE idAlimento=@id";
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

        public int ObtenerProteinas(int id)
        {
            string query = "SELECT proteinas FROM ALIMENTO WHERE idAlimento=@id";
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
