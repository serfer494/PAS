﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    /// <summary>
    /// El modelo "Datos por cita" se encarga de realizar el CRUD para los registros de la tabla
    /// "DatosCt" de la base de datos "BDPAS" destinada al sistema.
    /// </summary>
    public class ModeloDatosxCita
    {
        public void AgregarDatosCita(string grasaVis, string CMB, string cirCad, string bodyAge, string cirCin, string musculoPorc, string grasaPorc, string IMC, string peso, DateTime fecha, int id)
        {
            string query = "INSERT INTO DATOSCT ([grasaVisceral], [cmb], [cirCadera], [bodyAge], [cirCintura], [porcMusculo], " +
                "[porcGrasa], [imc], [peso], [fechaCita], [idPaciente]) VALUES(@grasavis,@cmb,@cirCad,@bodyage,@circin," +
                "@porcmus,@porcgra,@imc,@peso,@cita,@idpac)";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@grasavis", SqlDbType.Float).Value = grasaVis;
                        cmd.Parameters.Add("@cmb", SqlDbType.Float).Value = CMB;
                        cmd.Parameters.Add("@cirCad", SqlDbType.Float).Value = cirCad;
                        cmd.Parameters.Add("@bodyage", SqlDbType.Int).Value = Convert.ToInt32(bodyAge);
                        cmd.Parameters.Add("@circin", SqlDbType.Float).Value = cirCin;
                        cmd.Parameters.Add("@porcmus", SqlDbType.Int).Value = Convert.ToInt32(musculoPorc);
                        cmd.Parameters.Add("@porcgra", SqlDbType.Int).Value = Convert.ToInt32(grasaPorc);
                        cmd.Parameters.Add("@imc", SqlDbType.Float).Value = IMC;
                        cmd.Parameters.Add("@peso", SqlDbType.Float).Value = peso;
                        cmd.Parameters.Add("@cita", SqlDbType.DateTime2).Value = fecha;
                        cmd.Parameters.Add("@idpac", SqlDbType.Int).Value = id;

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

        public void ModificarDatosCita(string grasaVis, string CMB, string cirCad, string bodyAge, string cirCin, string musculoPorc, string grasaPorc, string IMC, string peso, DateTime fecha, int id, int idCita)
        {
            string query = "UPDATE DATOSCT SET grasaVisceral=@grasavis , cmb=@cmb , cirCadera=@cirCad , " +
                "bodyAge=@bodyage , cirCintura=@circin , porcMusculo=@porcmus , porcGrasa=@porcgra , " +
                "imc=@imc , peso=@peso , fechaCita=@cita WHERE idPaciente=@idpac AND idDatosCt=@idDatos";

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@grasavis", SqlDbType.Float).Value = grasaVis;
                        cmd.Parameters.Add("@cmb", SqlDbType.Float).Value = CMB;
                        cmd.Parameters.Add("@cirCad", SqlDbType.Float).Value = cirCad;
                        cmd.Parameters.Add("@bodyage", SqlDbType.Int).Value = Convert.ToInt32(bodyAge);
                        cmd.Parameters.Add("@circin", SqlDbType.Float).Value = cirCin;
                        cmd.Parameters.Add("@porcmus", SqlDbType.Int).Value = Convert.ToInt32(musculoPorc);
                        cmd.Parameters.Add("@porcgra", SqlDbType.Int).Value = Convert.ToInt32(grasaPorc);
                        cmd.Parameters.Add("@imc", SqlDbType.Float).Value = IMC;
                        cmd.Parameters.Add("@peso", SqlDbType.Float).Value = peso;
                        cmd.Parameters.Add("@cita", SqlDbType.DateTime).Value = fecha;
                        cmd.Parameters.Add("@idpac", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@idDatos", SqlDbType.Int).Value = idCita;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }

        public void EliminarDatosCita(int id, int idCita)
        {
            string query = "DELETE FROM DATOSCT WHERE idPaciente=@idpac AND idDatosCt=@idcita";

            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@idpac", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@idcita", SqlDbType.Int).Value = idCita;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }

        public DataTable GetTable(int id)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT peso AS 'Peso', imc AS 'IMC', porcGrasa AS '% Grasa', porcMusculo AS '% Musculo', " +
                "grasaVisceral AS 'Grasa Visceral', cmb AS 'CMB', cirCadera AS 'Cir. Cadera', cirCintura AS 'Cir. Cintura', " +
                "bodyAge AS 'Body Age', fechaCita AS 'Fecha de la cita' FROM DATOSCT, PACIENTE WHERE DATOSCT.idPaciente=@id AND " +
                "PACIENTE.idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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

        public int ObtenerId(int id, DateTime date)
        {
            string query = "SELECT idDatosCt FROM DATOSCT WHERE idPaciente=@id AND fechaCita=@fecha";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = date;
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
