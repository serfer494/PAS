using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloDatosGenerales
    {
        private string connectionString = "server=DESKTOP-RKNO24A; database=DBPAS; integrated security=true";
        public string ObtenerNombre(int id)
        {
            string query = "SELECT nombrePaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerGenero(int id)
        {
            string query = "SELECT generoPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerEstadoCivil(int id)
        {
            string query = "SELECT estadoCivilPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public DateTime ObtenerFechaNacimiento(int id)
        {
            string query = "SELECT fechaNacimientoPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        return Convert.ToDateTime(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                    DateTime dt = new DateTime();
                    return dt;
                }
            }
        }

        public string ObtenerEscolaridad(int id)
        {
            string query = "SELECT escolaridadPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerOcupacion(int id)
        {
            string query = "SELECT ocupacionPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerTelefono(int id)
        {
            string query = "SELECT telefonoPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerEmail(int id)
        {
            string query = "SELECT emailPaciente FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerMotivos(int id)
        {
            string query = "SELECT motivoConsulta FROM PACIENTE WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public void AgregarAntecedentesPatologicos(string diarrea, string flatulencias, string vomito, string masticacion, string colitis, string estrenimiento, string ansiedad, string dolorCabeza, string gastritis, string disfagia, string nauseas, string enfermedad, string medicamentos, string suplementos, string diureticos, string laxantes, string cirugia, int idPaciente)
        {
            string query = "INSERT INTO DATOSGNANTEPATO ([diarrea], [flatulencias], [vomito], [problemasMasticacion], " +
                "[colitis], [estrenimiento], [ansiedad], [dolorCabeza], [gastritis], [disfagia], [nauseas], [enfermedad], " +
                "[medicamentos], [suplementos], [diureticos], [laxantes], [cirugias], [idPaciente]) VALUES(@diarrea,@flatulencias," +
                "@vomito,@masticacion,@colitis,@estrenimiento,@ansiedad,@dolorCabeza,@gastritis,@disfagia,@nauseas," +
                "@enfermedad,@medicamentos,@suplementos,@diureticos,@laxantes,@cirugia,@idPaciente)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@diarrea", SqlDbType.VarChar).Value = diarrea;
                        cmd.Parameters.Add("@flatulencias", SqlDbType.VarChar).Value = flatulencias;
                        cmd.Parameters.Add("@vomito", SqlDbType.VarChar).Value = vomito;
                        cmd.Parameters.Add("@masticacion", SqlDbType.VarChar).Value = masticacion;
                        cmd.Parameters.Add("@colitis", SqlDbType.VarChar).Value = colitis;
                        cmd.Parameters.Add("@estrenimiento", SqlDbType.VarChar).Value = estrenimiento;
                        cmd.Parameters.Add("@ansiedad", SqlDbType.VarChar).Value = ansiedad;
                        cmd.Parameters.Add("@dolorCabeza", SqlDbType.VarChar).Value = dolorCabeza;
                        cmd.Parameters.Add("@gastritis", SqlDbType.VarChar).Value = gastritis;
                        cmd.Parameters.Add("@disfagia", SqlDbType.VarChar).Value = disfagia;
                        cmd.Parameters.Add("@nauseas", SqlDbType.VarChar).Value = nauseas;
                        cmd.Parameters.Add("@enfermedad", SqlDbType.VarChar).Value = enfermedad;
                        cmd.Parameters.Add("@medicamentos", SqlDbType.VarChar).Value = medicamentos;
                        cmd.Parameters.Add("@suplementos", SqlDbType.VarChar).Value = suplementos;
                        cmd.Parameters.Add("@diureticos", SqlDbType.VarChar).Value = diureticos;
                        cmd.Parameters.Add("@laxantes", SqlDbType.VarChar).Value = laxantes;
                        cmd.Parameters.Add("@cirugia", SqlDbType.VarChar).Value = cirugia;
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

        public string ObtenerDiarrea(int id)
        {
            string query = "SELECT diarrea FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerFlatulencias(int id)
        {
            string query = "SELECT flatulencias FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerVomito(int id)
        {
            string query = "SELECT vomito FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerMasticacion(int id)
        {
            string query = "SELECT problemasMasticacion FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerColitis(int id)
        {
            string query = "SELECT colitis FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerEstrenimiento(int id)
        {
            string query = "SELECT estrenimiento FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerAnsiedad(int id)
        {
            string query = "SELECT ansiedad FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerDolorCabeza(int id)
        {
            string query = "SELECT dolorCabeza FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerGastritis(int id)
        {
            string query = "SELECT gastritis FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerDisfagia(int id)
        {
            string query = "SELECT disfagia FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerNauseas(int id)
        {
            string query = "SELECT nauseas FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerEnfermedad(int id)
        {
            string query = "SELECT enfermedad FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerMedicamentos(int id)
        {
            string query = "SELECT medicamentos FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerSuplementos(int id)
        {
            string query = "SELECT suplementos FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerDiureticos(int id)
        {
            string query = "SELECT diureticos FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerLaxantes(int id)
        {
            string query = "SELECT laxantes FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public string ObtenerCirugia(int id)
        {
            string query = "SELECT cirugias FROM DATOSGNANTEPATO WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public void ModificarDatosGenerales(string nombre, string genero, string estadoCivil, DateTime fechaNacimiento, string escolaridad, string ocupacion, string telefono, string email, string motivos, int id)
        {
            string query = "UPDATE PACIENTE SET nombrePaciente=@nombre , generoPaciente=@genero , " +
                "estadoCivilPaciente=@estadoCivil , fechaNacimientoPaciente=@fechaNacimiento , " +
                "escolaridadPaciente=@escolaridad , ocupacionPaciente=@ocupacion , " +
                "telefonoPaciente=@telefono , emailPaciente=@email , motivoConsulta=@motivos" +
                " WHERE idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                        cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = genero;
                        cmd.Parameters.Add("@estadoCivil", SqlDbType.VarChar).Value = estadoCivil;
                        cmd.Parameters.Add("@fechaNacimiento", SqlDbType.Date).Value = fechaNacimiento;
                        cmd.Parameters.Add("@escolaridad", SqlDbType.VarChar).Value = escolaridad;
                        cmd.Parameters.Add("@ocupacion", SqlDbType.VarChar).Value = ocupacion;
                        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = telefono;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@motivos", SqlDbType.VarChar).Value = motivos;
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
