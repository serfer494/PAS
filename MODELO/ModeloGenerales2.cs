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
    /// El modelo de "Generales 2" se encarga de realizar el CRUD para los registros de la tabla de 
    /// "DatosGnAntePato, DatosGnAnteNoPato y DatosGnIndBio" de la base de datos "BDPAS" destinada al sisema.
    /// </summary>
    public class ModeloGenerales2
    {
        //Proxy
        //facade
        public void AgregarAntecedentesFamiliares(string diabetes, string cancer, string obesidad, string hipertension, string enfTir, string hiperlipidemias, string otra, int idPaciente)
        {
            string query = "SELECT idPaciente FROM DATOSGNANTEPATO WHERE idpaciente=@id";
            int idforanea=0;
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idPaciente;
                        idforanea = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    
                }
            }

            if(idforanea != idPaciente)
            {
                query = "INSERT INTO DATOSGNANTEPATO ([diabetes], [cancer], [obesidad], [hipertension], [enfermedadesTir], " +
                "[hiperlipidemias], [otra], [idPaciente]) VALUES(@diabetes,@cancer,@obesidad,@hipertension,@enfTir,@hiperlipidemias,@otra," +
                "@idPaciente)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = diabetes;
                            cmd.Parameters.Add("@cancer", SqlDbType.VarChar).Value = cancer;
                            cmd.Parameters.Add("@obesidad", SqlDbType.VarChar).Value = obesidad;
                            cmd.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = hipertension;
                            cmd.Parameters.Add("@enfTir", SqlDbType.VarChar).Value = enfTir;
                            cmd.Parameters.Add("@hiperlipidemias", SqlDbType.VarChar).Value = hiperlipidemias;
                            cmd.Parameters.Add("@otra", SqlDbType.VarChar).Value = otra;
                            cmd.Parameters.Add("@idPaciente", SqlDbType.Int).Value = idPaciente;
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
                query = "UPDATE DATOSGNANTEPATO SET diabetes=@diabetes , cancer=@cancer , " +
                "obesidad=@obesidad , hipertension=@hipertension , " +
                "enfermedadesTir=@enfTir , hiperlipidemias=@hiperlipidemias , " +
                "otra=@otra" +
                " WHERE idPaciente=@idPaciente";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = diabetes;
                            cmd.Parameters.Add("@cancer", SqlDbType.VarChar).Value = cancer;
                            cmd.Parameters.Add("@obesidad", SqlDbType.VarChar).Value = obesidad;
                            cmd.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = hipertension;
                            cmd.Parameters.Add("@enfTir", SqlDbType.VarChar).Value = enfTir;
                            cmd.Parameters.Add("@hiperlipidemias", SqlDbType.VarChar).Value = hiperlipidemias;
                            cmd.Parameters.Add("@otra", SqlDbType.VarChar).Value = otra;
                            cmd.Parameters.Add("@idPaciente", SqlDbType.Int).Value = idPaciente;
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
        public void ModificarAntecedentesFamiliares(string diabetes, string cancer, string obesidad, string hipertension, string enfTir, string hiperlipidemias, string otra, int idPaciente)
        {
            string query = "UPDATE DATOSGNANTEPATO SET diabetes=@diabetes , cancer=@cancer , " +
                "obesidad=@obesidad , hipertension=@hipertension , " +
                "enfermedadesTir=@enfTir , hiperlipidemias=@hiperlipidemias , " +
                "otra=@otra" +
                " WHERE idPaciente=@idPaciente";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@diabetes", SqlDbType.VarChar).Value = diabetes;
                        cmd.Parameters.Add("@cancer", SqlDbType.VarChar).Value = cancer;
                        cmd.Parameters.Add("@obesidad", SqlDbType.VarChar).Value = obesidad;
                        cmd.Parameters.Add("@hipertension", SqlDbType.VarChar).Value = hipertension;
                        cmd.Parameters.Add("@enfTir", SqlDbType.VarChar).Value = enfTir;
                        cmd.Parameters.Add("@hiperlipidemias", SqlDbType.VarChar).Value = hiperlipidemias;
                        cmd.Parameters.Add("@otra", SqlDbType.VarChar).Value = otra;
                        cmd.Parameters.Add("@idPaciente", SqlDbType.VarChar).Value = idPaciente;
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
        public void AgregarAntecedentesNoPatologicos(string ejercicio, string duracion, string frecuencia, string alcohol, string tabaco, string toxicomanias, int id)
        {
            string query = "SELECT idpaciente FROM DATOSGNANTENOPATO WHERE idpaciente=@id";
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
                query = "INSERT INTO DATOSGNANTENOPATO ([ejercicio], [duracion], [frecuencia], [alcohol], [tabaco], " +
                "[toxicomanias], [idpaciente]) VALUES(@ejercicio,@duracion,@frecuencia,@alcohol,@tabaco,@toxicomanias,@id)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@ejercicio", SqlDbType.VarChar).Value = ejercicio;
                            cmd.Parameters.Add("@duracion", SqlDbType.VarChar).Value = duracion;
                            cmd.Parameters.Add("@frecuencia", SqlDbType.VarChar).Value = frecuencia;
                            cmd.Parameters.Add("@alcohol", SqlDbType.VarChar).Value = alcohol;
                            cmd.Parameters.Add("@tabaco", SqlDbType.VarChar).Value = tabaco;
                            cmd.Parameters.Add("@toxicomanias", SqlDbType.VarChar).Value = toxicomanias;
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
                query = "UPDATE DATOSGNANTENOPATO SET ejercicio=@ejercicio , duracion=@duracion , " +
                "frecuencia=@frecuencia , alcohol=@alcohol , " +
                "tabaco=@tabaco , toxicomanias=@toxicomanias" +
                " WHERE idPaciente=@id";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@ejercicio", SqlDbType.VarChar).Value = ejercicio;
                            cmd.Parameters.Add("@duracion", SqlDbType.VarChar).Value = duracion;
                            cmd.Parameters.Add("@frecuencia", SqlDbType.VarChar).Value = frecuencia;
                            cmd.Parameters.Add("@alcohol", SqlDbType.VarChar).Value = alcohol;
                            cmd.Parameters.Add("@tabaco", SqlDbType.VarChar).Value = tabaco;
                            cmd.Parameters.Add("@toxicomanias", SqlDbType.VarChar).Value = toxicomanias;
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
        public void ModificarAntecedentesNoPatologicos(string ejercicio, string duracion, string frecuencia, string alcohol, string tabaco, string toxicomanias, int id)
        {
            string query = "UPDATE DATOSGNANTENOPATO SET ejercicio=@ejercicio , duracion=@duracion , " +
                "frecuencia=@frecuencia , alcohol=@alcohol , " +
                "tabaco=@tabaco , toxicomanias=@toxicomanias" +
                " WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@ejercicio", SqlDbType.VarChar).Value = ejercicio;
                        cmd.Parameters.Add("@duracion", SqlDbType.VarChar).Value = duracion;
                        cmd.Parameters.Add("@frecuencia", SqlDbType.VarChar).Value = frecuencia;
                        cmd.Parameters.Add("@alcohol", SqlDbType.VarChar).Value = alcohol;
                        cmd.Parameters.Add("@tabaco", SqlDbType.VarChar).Value = tabaco;
                        cmd.Parameters.Add("@toxicomanias", SqlDbType.VarChar).Value = toxicomanias;
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
        public void AgregarIndicadoresBioquimicos(string trigliceridos, string hemoglobina, string colesterol, string glucosa, string creatinina, string nitUreico, int id)
        {
            string query = "SELECT idPaciente FROM DATOSGNINDBIO WHERE idPaciente=@id";
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
                query = "INSERT INTO DATOSGNINDBIO ([trigliceridos], [hemoglobina], [colesterol], [glucosa], [creatinina], " +
                "[nitUreico], [idPaciente]) VALUES(@trigliceridos,@hemoglobina,@colesterol,@glucosa,@creatinina,@nitUreico,@id)";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@trigliceridos", SqlDbType.VarChar).Value = trigliceridos;
                            cmd.Parameters.Add("@hemoglobina", SqlDbType.VarChar).Value = hemoglobina;
                            cmd.Parameters.Add("@colesterol", SqlDbType.VarChar).Value = colesterol;
                            cmd.Parameters.Add("@glucosa", SqlDbType.VarChar).Value = glucosa;
                            cmd.Parameters.Add("@creatinina", SqlDbType.VarChar).Value = creatinina;
                            cmd.Parameters.Add("@nitUreico", SqlDbType.VarChar).Value = nitUreico;
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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
                query = "UPDATE DATOSGNINDBIO SET trigliceridos=@trigliceridos , hemoglobina=@hemoglobina , " +
                "colesterol=@colesterol , glucosa=@glucosa , " +
                "creatinina=@creatinina , nitUreico=@nitUreico" +
                " WHERE idPaciente=@id";
                using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.Parameters.Add("@trigliceridos", SqlDbType.VarChar).Value = trigliceridos;
                            cmd.Parameters.Add("@hemoglobina", SqlDbType.VarChar).Value = hemoglobina;
                            cmd.Parameters.Add("@colesterol", SqlDbType.VarChar).Value = colesterol;
                            cmd.Parameters.Add("@glucosa", SqlDbType.VarChar).Value = glucosa;
                            cmd.Parameters.Add("@creatinina", SqlDbType.VarChar).Value = creatinina;
                            cmd.Parameters.Add("@nitUreico", SqlDbType.VarChar).Value = nitUreico;
                            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
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
        public void ModificarIndicadoresBioquimicos(string trigliceridos, string hemoglobina, string colesterol, string glucosa, string creatinina, string nitUreico, int id)
        {
            string query = "UPDATE DATOSGNINDBIO SET trigliceridos=@trigliceridos , hemoglobina=@hemoglobina , " +
                "colesterol=@colesterol , glucosa=@glucosa , " +
                "creatinina=@creatinina , nitUreico=@nitUreico" +
                " WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@trigliceridos", SqlDbType.VarChar).Value = trigliceridos;
                        cmd.Parameters.Add("@hemoglobina", SqlDbType.VarChar).Value = hemoglobina;
                        cmd.Parameters.Add("@colesterol", SqlDbType.VarChar).Value = colesterol;
                        cmd.Parameters.Add("@glucosa", SqlDbType.VarChar).Value = glucosa;
                        cmd.Parameters.Add("@creatinina", SqlDbType.VarChar).Value = creatinina;
                        cmd.Parameters.Add("@nitUreico", SqlDbType.VarChar).Value = nitUreico;
                        cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }

        public string ObtenerTexto(int id, string campo, string basedeDatos)
        {
            string query = "SELECT "+campo+" FROM "+basedeDatos+" WHERE idPaciente=@id";
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
