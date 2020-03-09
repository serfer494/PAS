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
    /// El modelo "Citas" se encarga de realizar el CRUD para los registros de la tabla
    /// "Agenda" de la base de datos "BDPAS" destinada al sistema.
    /// </summary>
    public class ModeloCitas
    {
        //Proxy
        public DateTime[] GetDates()
        {
            List<DateTime> list = new List<DateTime>();
            DateTime[] VacationDates = { };
            string query = "SELECT fechaAgenda FROM AGENDA";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            DateTime date = Convert.ToDateTime(ds.Tables[0].Rows[i][0].ToString());
                            list.Add(date);

                        }
                    }
                    return list.ToArray();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    DateTime[] fecha = new DateTime[0];
                    return fecha;
                }
            }
        }
        //Singleton
        public DataTable GetTable(DateTime date)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT nombre AS 'Nombre', apellido AS 'Apellido', telefono AS 'Telefono', " +
                "hora AS 'Hora' FROM AGENDA WHERE fechaAgenda=@fecha";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = date;
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
        public void AgregarCita(DateTime fecha, string nombre, string apellido, string telefono, string hora)
        {
            string query = "INSERT INTO AGENDA ([fechaAgenda], [nombre], " +
                "[apellido], [telefono], [hora]) VALUES(@fecha,@nombre," +
                "@apellido,@telefono,@hora)";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefono;
                        cmd.Parameters.Add("@hora", SqlDbType.VarChar).Value = hora;
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
        //facade
        public void ModificarCita(DateTime fecha, string nombre, string apellido, string telefono, string hora, int id)
        {
            string query = "UPDATE AGENDA SET nombre=@nombre , apellido=@apellido , telefono=@telefono , " +
                "hora=@hora , fechaAgenda=@nuevaFecha WHERE idAgenda=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefono;
                        cmd.Parameters.Add("@hora", SqlDbType.VarChar).Value = hora;
                        cmd.Parameters.Add("@nuevaFecha", SqlDbType.Date).Value = fecha;
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
        
        public int ObtenerId(string str)
        {
            string query = "SELECT idAgenda FROM AGENDA WHERE hora=@hora";
            string hora = str;
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@hora", SqlDbType.VarChar).Value = hora;
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
        public void EliminarCita(int id)
        {
            string query = "DELETE FROM AGENDA WHERE idAgenda=@id";

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
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }
    }
}
