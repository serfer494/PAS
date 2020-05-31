using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloBDRespaldo
    {
        string connectionString = "server=localhost; database=msdb; integrated security=true";
        public string Respaldo(string nombre)
        {
            string query = @"BACKUP DATABASE DBPAS TO DISK = 'C:\DBPAS\" + nombre + "'";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteScalar();
                        return "";
                    }
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public string Restaurar(string path)
        {
            string query1 = "USE master";
            string query2 = "ALTER DATABASE DBPAS SET Single_User WITH Rollback Immediate";
            string query3 = @"RESTORE DATABASE DBPAS FROM DISK = '" + path + "' WITH REPLACE";
            string query4 = "ALTER DATABASE DBPAS SET Multi_User;";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query1, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(query2, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(query3, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(query4, conexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public string ProgranarDia()
        {
            
            string cadena = "";
            string query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupDaily' , @enabled = 1;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteScalar();
                        cadena = "";
                    }
                }
                catch (Exception ex)
                {
                    cadena = ex.Message;
                }
            }
            if(cadena == "")
            {
                query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupWeekly' , @enabled = 0;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.ExecuteScalar();
                            cadena = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        cadena = ex.Message;
                    }
                }
            }
            if (cadena == "")
            {
                query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupMonthly' , @enabled = 0;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.ExecuteScalar();
                            cadena = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        cadena = ex.Message;
                    }
                }
            }
            return cadena;
        }

        public string ProgranarSemana()
        {
            string cadena = "";
            string query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupDaily' , @enabled = 0;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteScalar();
                        cadena = "";
                    }
                }
                catch (Exception ex)
                {
                    cadena = ex.Message;
                }
            }
            if (cadena == "")
            {
                query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupWeekly' , @enabled = 1;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.ExecuteScalar();
                            cadena = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        cadena = ex.Message;
                    }
                }
            }
            if (cadena == "")
            {
                query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupMonthly' , @enabled = 0;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.ExecuteScalar();
                            cadena = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        cadena = ex.Message;
                    }
                }
            }
            return cadena;
        }

        public string ProgranarMes()
        {
            string cadena = "";
            string query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupDaily' , @enabled = 0;";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.ExecuteScalar();
                        cadena = "";
                    }
                }
                catch (Exception ex)
                {
                    cadena = ex.Message;
                }
            }
            if (cadena == "")
            {
                query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupWeekly' , @enabled = 0;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.ExecuteScalar();
                            cadena = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        cadena = ex.Message;
                    }
                }
            }
            if (cadena == "")
            {
                query = @"EXEC dbo.sp_update_job @job_name = N'PASBackupMonthly' , @enabled = 1;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    try
                    {
                        conexion.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conexion))
                        {
                            cmd.ExecuteScalar();
                            cadena = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        cadena = ex.Message;
                    }
                }
            }
            return cadena;
        }
    }
}
