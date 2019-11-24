using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ModeloNuevoCliente
    {
        private string connectionString = "server=DESKTOP-RKNO24A; database=DBPAS; integrated security=true";
        public void AgregarNuevoCliente(string nombre, string genero, string estadoCivil, DateTime fechaNacimiento, string escolaridad, string ocupacion, string telefono, string email, string motivos)
        {
            string query = "INSERT INTO PACIENTE ([nombrePaciente], [generoPaciente], " +
                "[estadoCivilPaciente], [fechaNacimientoPaciente], [escolaridadPaciente], [ocupacionPaciente], " +
                "[telefonoPaciente], [emailPaciente], [motivoConsulta]) VALUES(@nombre,@genero,@estadoCivil," +
                "@fechaNacimiento,@escolaridad,@ocupacion,@telefono,@email,@motivos)";
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
}
