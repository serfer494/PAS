using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador "Datos por cita" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD del modelo correspondiente
    /// en la tabla "DatosCT" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorDatosxCita
    {
        public string error = "";
        public void AgregarDatosCita(string grasaVis, string CMB, string cirCad, string bodyAge, string cirCin, string musculoPorc, string grasaPorc, string IMC, string peso, DateTime fecha, int id)
        {
            var validac = new Validacion();
            if(validac.Longitud(grasaVis, 1, 5) && validac.Longitud(CMB, 1, 5) && validac.Longitud(cirCad, 1, 5) && validac.Longitud(bodyAge, 1, 3) && validac.Longitud(cirCin, 1, 5) && validac.Longitud(musculoPorc, 1, 3) && validac.Longitud(grasaPorc, 1, 3) && validac.Longitud(IMC, 1, 5) && validac.Longitud(peso, 1, 5))
            {
                if (validac.MayorA(Convert.ToInt32(grasaVis), 0) && validac.MayorA(Convert.ToInt32(CMB), 0) && validac.MayorA(Convert.ToInt32(cirCad), 0) && validac.MayorA(Convert.ToInt32(bodyAge), 0) && validac.MayorA(Convert.ToInt32(cirCin), 0) && validac.MayorA(Convert.ToInt32(musculoPorc), 0) && validac.MayorA(Convert.ToInt32(grasaPorc), 0) && validac.MayorA(Convert.ToInt32(IMC), 0) && validac.MayorA(Convert.ToInt32(peso), 0))
                {
                    if(validac.MenorA(Convert.ToInt32(peso), 801) && validac.MenorA(Convert.ToInt32(grasaPorc), 101) && validac.MenorA(Convert.ToInt32(musculoPorc), 101) && validac.MenorA(Convert.ToInt32(bodyAge), 101))
                    {
                        if (validac.FechaMayorIgualA(fecha, DateTime.Today))
                        {
                            try
                            {
                                var modelodc = new ModeloDatosxCita();
                                modelodc.AgregarDatosCita(grasaVis, CMB, cirCad, bodyAge, cirCin, musculoPorc, grasaPorc, IMC, peso, fecha, id);
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                        }
                        else
                        {
                            error = "Fecha invalida";
                            return;
                        }
                    }
                    else
                    {
                        error = "Alguna cantidad paso el rango establecido";
                        return;
                    }
                }
                else
                {
                    error = "Las cantidades deben ser mayor a cero";
                    return;
                }
            }
            else
            {
                error = "Los campos con * no deben estar vacios";
                return;
            }
        }

        public void ModificarDatosCita(string grasaVis, string CMB, string cirCad, string bodyAge, string cirCin, string musculoPorc, string grasaPorc, string IMC, string peso, DateTime fecha, int id, int idCita)
        {
            var validac = new Validacion();
            if (validac.Longitud(grasaVis, 1, 5) && validac.Longitud(CMB, 1, 5) && validac.Longitud(cirCad, 1, 5) && validac.Longitud(bodyAge, 1, 3) && validac.Longitud(cirCin, 1, 5) && validac.Longitud(musculoPorc, 1, 3) && validac.Longitud(grasaPorc, 1, 3) && validac.Longitud(IMC, 1, 5) && validac.Longitud(peso, 1, 5))
            {
                if (validac.MayorA(Convert.ToInt32(grasaVis), 0) && validac.MayorA(Convert.ToInt32(CMB), 0) && validac.MayorA(Convert.ToInt32(cirCad), 0) && validac.MayorA(Convert.ToInt32(bodyAge), 0) && validac.MayorA(Convert.ToInt32(cirCin), 0) && validac.MayorA(Convert.ToInt32(musculoPorc), 0) && validac.MayorA(Convert.ToInt32(grasaPorc), 0) && validac.MayorA(Convert.ToInt32(IMC), 0) && validac.MayorA(Convert.ToInt32(peso), 0))
                {
                    if (validac.FechaMayorIgualA(fecha, DateTime.Today))
                    {
                        try
                        {
                            var modelodc = new ModeloDatosxCita();
                            modelodc.ModificarDatosCita(grasaVis, CMB, cirCad, bodyAge, cirCin, musculoPorc, grasaPorc, IMC, peso, fecha, id, idCita);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        error = "Fecha invalida";
                        return;
                    }
                }
                else
                {
                    error = "Las cantidades deben ser mayor a cero";
                    return;
                }
            }
            else
            {
                error = "Los campos con * no deben estar vacios";
                return;
            }
        }

        public void EliminarDatosCita(int id, int idCita)
        {
            try
            {
                var modelodc = new ModeloDatosxCita();
                modelodc.EliminarDatosCita(id, idCita);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetTable(int id)
        {
            try
            {
                var modelodc = new ModeloDatosxCita();
                return modelodc.GetTable(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerId(int id, DateTime date)
        {
            try
            {
                var modelodc = new ModeloDatosxCita();
                return modelodc.ObtenerId(id, date);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Obtener(int id, string campo, string tabla, string campoID)
        {
            try
            {
                var obtener = new Obtener();
                return obtener.ObtenerTexto(id, campo, tabla, campoID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
