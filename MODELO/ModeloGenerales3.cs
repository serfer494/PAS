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
    /// El modelo de "Generales 3" se encarga de realizar el CRUD para los registros de la tabla de 
    /// "DatosGnIndDie" de la base de datos "BDPAS" destinada al sisema.
    /// </summary>
    public class ModeloGenerales3
    {
        //Proxy
        //facade
        public void AgregarIndicadoresDieteticos(string comidasDia, string quienComida, string comeFuera, string AlimentosPref, string agua, string alergias, string notas, string recordatorio, int id)
        {
            string query = "SELECT idPaciente FROM DATOSGNINDDIE WHERE idPaciente=@id";
            int idforanea = 0;
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                        idforanea = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());

                }
            }

            if (idforanea != id)
            {
                query = "INSERT INTO DATOSGNINDDIE ([numComidas], [comidaPrep], [fueraCasa], [aliPreferidos], [agua], " +
                "[alergias], [notas], [rec24horas], [idPaciente]) VALUES(@numComidas,@comidaPrep,@fueraCasa,@aliPreferidos,@agua,@alergias,@notas," +
                "@rec24horas, @id)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@numComidas", SqlDbType.VarChar).Value = comidasDia;
                            cmd.Parameters.Add("@comidaPrep", SqlDbType.VarChar).Value = quienComida;
                            cmd.Parameters.Add("@fueraCasa", SqlDbType.VarChar).Value = comeFuera;
                            cmd.Parameters.Add("@aliPreferidos", SqlDbType.VarChar).Value = AlimentosPref;
                            cmd.Parameters.Add("@agua", SqlDbType.VarChar).Value = agua;
                            cmd.Parameters.Add("@alergias", SqlDbType.VarChar).Value = alergias;
                            cmd.Parameters.Add("@notas", SqlDbType.VarChar).Value = notas;
                            cmd.Parameters.Add("@rec24horas", SqlDbType.VarChar).Value = recordatorio;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
            else
            {
                query = "UPDATE DATOSGNINDDIE SET numComidas=@numComidas , comidaPrep=@comidaPrep , " +
                "fueraCasa=@fueraCasa , aliPreferidos=@aliPreferidos , " +
                "agua=@agua , alergias=@alergias , notas=@notas , " +
                "rec24horas=@rec24horas" +
                " WHERE idPaciente=@id";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@numComidas", SqlDbType.VarChar).Value = comidasDia;
                            cmd.Parameters.Add("@comidaPrep", SqlDbType.VarChar).Value = quienComida;
                            cmd.Parameters.Add("@fueraCasa", SqlDbType.VarChar).Value = comeFuera;
                            cmd.Parameters.Add("@aliPreferidos", SqlDbType.VarChar).Value = AlimentosPref;
                            cmd.Parameters.Add("@agua", SqlDbType.VarChar).Value = agua;
                            cmd.Parameters.Add("@alergias", SqlDbType.VarChar).Value = alergias;
                            cmd.Parameters.Add("@notas", SqlDbType.VarChar).Value = notas;
                            cmd.Parameters.Add("@rec24horas", SqlDbType.VarChar).Value = recordatorio;
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
        }
        //facade
        public void ModificarIndicadoresDieteticos(string comidasDia, string quienComida, string comeFuera, string AlimentosPref, string agua, string alergias, string notas, string recordatorio, int id)
        {
            string query = "UPDATE DATOSGNINDDIE SET numComidas=@numComidas , comidaPrep=@comidaPrep , " +
                "fueraCasa=@fueraCasa , aliPreferidos=@aliPreferidos , " +
                "agua=@agua , alergias=@alergias , notas=@notas , " +
                "rec24horas=@rec24horas" +
                " WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@numComidas", SqlDbType.VarChar).Value = comidasDia;
                        cmd.Parameters.Add("@comidaPrep", SqlDbType.VarChar).Value = quienComida;
                        cmd.Parameters.Add("@fueraCasa", SqlDbType.VarChar).Value = comeFuera;
                        cmd.Parameters.Add("@aliPreferidos", SqlDbType.VarChar).Value = AlimentosPref;
                        cmd.Parameters.Add("@agua", SqlDbType.VarChar).Value = agua;
                        cmd.Parameters.Add("@alergias", SqlDbType.VarChar).Value = alergias;
                        cmd.Parameters.Add("@notas", SqlDbType.VarChar).Value = notas;
                        cmd.Parameters.Add("@rec24horas", SqlDbType.VarChar).Value = recordatorio;
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

        public string ObtenerTexto(int id, string campo)
        {
            string query = "SELECT " + campo + " FROM DATOSGNINDDIE WHERE idPaciente=@id";
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
    }
}
