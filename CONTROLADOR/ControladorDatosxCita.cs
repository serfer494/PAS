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
            if(validac.Longitud(grasaVis, 1, 4) && validac.Longitud(CMB, 1, 4) && validac.Longitud(cirCad, 1, 5) && validac.Longitud(bodyAge, 1, 2) && validac.Longitud(cirCin, 1, 5) && validac.Longitud(musculoPorc, 1, 4) && validac.Longitud(grasaPorc, 1, 4) && validac.Longitud(IMC, 1, 4) && validac.Longitud(peso, 1, 5))
            {
                if (validac.MayorIgualA(Convert.ToDecimal(grasaVis), 5) && validac.MayorIgualA(Convert.ToDecimal(CMB), 10) && validac.MayorIgualA(Convert.ToDecimal(cirCad), 40) && validac.MayorIgualA(Convert.ToInt32(bodyAge), 12) && validac.MayorIgualA(Convert.ToDecimal(cirCin), 40) && validac.MayorIgualA(Convert.ToDecimal(musculoPorc), 20) && validac.MayorIgualA(Convert.ToDecimal(grasaPorc), 10) && validac.MayorIgualA(Convert.ToDecimal(IMC), 16) && validac.MayorIgualA(Convert.ToDecimal(peso), 30))
                {
                    if(validac.MenorIgualA(Convert.ToDecimal(peso), 200) && validac.MenorIgualA(Convert.ToDecimal(grasaPorc), 50) && validac.MenorIgualA(Convert.ToDecimal(musculoPorc), 60) && validac.MenorIgualA(Convert.ToInt32(bodyAge), 90) && validac.MenorIgualA(Convert.ToInt32(IMC), 50) && validac.MenorIgualA(Convert.ToInt32(grasaVis), 50) && validac.MenorIgualA(Convert.ToInt32(CMB), 40) && validac.MenorIgualA(Convert.ToInt32(cirCad), 150) && validac.MenorIgualA(Convert.ToInt32(cirCin), 150))
                    {
                        bool pesoPunto = false;
                        bool cirCaderaPunto = false ;
                        bool cirCinturaPunto = false;
                        bool grasaVisPunto = false;
                        bool CMBPunto = false;
                        bool IMCPunto = false;
                        bool musculoPorcPunto = false;
                        bool grasaPorcPunto = false;

                        if (peso.Contains('.'))
                        {
                            if (Punto(peso, 1, 2) == true) pesoPunto = true;
                        }
                        if (cirCad.Contains('.'))
                        {
                            if (Punto(cirCad, 1, 2) == true) cirCaderaPunto = true;
                        }
                        if (cirCin.Contains('.'))
                        {
                            if (Punto(cirCin, 1, 2) == true) cirCinturaPunto = true;
                        }
                        if (grasaVis.Contains('.'))
                        {
                            if (Punto(grasaVis, 1, 1) == true) grasaVisPunto = true;
                        }
                        if (CMB.Contains('.'))
                        {
                            if (Punto(CMB, 1, 1) == true) CMBPunto = true;
                        }
                        if (IMC.Contains('.'))
                        {
                            if (Punto(IMC, 1, 1) == true) IMCPunto = true;
                        }
                        if (musculoPorc.Contains('.'))
                        {
                            if (Punto(musculoPorc, 1, 1) == true) musculoPorcPunto = true;
                        }
                        if (grasaPorc.Contains('.'))
                        {
                            if (Punto(grasaPorc, 1, 1) == true) grasaPorcPunto = true;
                        }
                        if ((peso.Contains('.') && pesoPunto == true) && (cirCad.Contains('.') && cirCaderaPunto == true && cirCin.Contains('.') && cirCinturaPunto == true && grasaVis.Contains('.') && grasaVisPunto == true && CMB.Contains('.') && CMBPunto == true && IMC.Contains('.') && IMCPunto == true && musculoPorc.Contains('.') && musculoPorcPunto == true && grasaPorc.Contains('.') && grasaPorcPunto == true))
                        {
                            var modelodc = new ModeloDatosxCita();
                            
                            {
                                try
                                {
                                    modelodc = new ModeloDatosxCita();
                                    modelodc.AgregarDatosCita(grasaVis, CMB, cirCad, bodyAge, cirCin, musculoPorc, grasaPorc, IMC, peso, fecha, id);
                                }
                                catch (Exception ex)
                                {
                                    error = modelodc.error;
                                    return;
                                }
                            }
                            
                        }
                        else if((peso.Contains('.') && pesoPunto == false) || (cirCad.Contains('.') && cirCaderaPunto == false) || (cirCin.Contains('.') && cirCinturaPunto == false) || (grasaVis.Contains('.') && grasaVisPunto == false) || (CMB.Contains('.') && CMBPunto == false) || (IMC.Contains('.') && IMCPunto == false) || (musculoPorc.Contains('.') && musculoPorcPunto == false) || (grasaPorc.Contains('.') && grasaPorcPunto == false))
                        {
                            error = "Revise el formato correcto en la parte derecha de los campos.";
                            return;
                        }
                        else
                        {
                            var modelodc = new ModeloDatosxCita();
                            
                            {
                                try
                                {
                                    modelodc = new ModeloDatosxCita();
                                    modelodc.AgregarDatosCita(grasaVis, CMB, cirCad, bodyAge, cirCin, musculoPorc, grasaPorc, IMC, peso, fecha, id);
                                }
                                catch (Exception ex)
                                {
                                    error = modelodc.error;
                                    return;
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        error = "Las cantidades deben de estar dentro de los rangos permitidos";
                        return;
                    }
                }
                else
                {
                    error = "Las cantidades deben de estar dentro de los rangos permitidos";
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
            if (validac.Longitud(grasaVis, 1, 4) && validac.Longitud(CMB, 1, 4) && validac.Longitud(cirCad, 1, 5) && validac.Longitud(bodyAge, 1, 2) && validac.Longitud(cirCin, 1, 5) && validac.Longitud(musculoPorc, 1, 4) && validac.Longitud(grasaPorc, 1, 4) && validac.Longitud(IMC, 1, 4) && validac.Longitud(peso, 1, 5))
            {
                if (validac.MayorIgualA(Convert.ToDecimal(grasaVis), 5) && validac.MayorIgualA(Convert.ToDecimal(CMB), 10) && validac.MayorIgualA(Convert.ToDecimal(cirCad), 40) && validac.MayorIgualA(Convert.ToInt32(bodyAge), 12) && validac.MayorIgualA(Convert.ToDecimal(cirCin), 40) && validac.MayorIgualA(Convert.ToDecimal(musculoPorc), 20) && validac.MayorIgualA(Convert.ToDecimal(grasaPorc), 10) && validac.MayorIgualA(Convert.ToDecimal(IMC), 16) && validac.MayorIgualA(Convert.ToDecimal(peso), 30))
                {
                    if (validac.MenorIgualA(Convert.ToDecimal(peso), 200) && validac.MenorIgualA(Convert.ToDecimal(grasaPorc), 50) && validac.MenorIgualA(Convert.ToDecimal(musculoPorc), 60) && validac.MenorIgualA(Convert.ToInt32(bodyAge), 90) && validac.MenorIgualA(Convert.ToInt32(IMC), 50) && validac.MenorIgualA(Convert.ToInt32(grasaVis), 50) && validac.MenorIgualA(Convert.ToInt32(CMB), 40) && validac.MenorIgualA(Convert.ToInt32(cirCad), 150) && validac.MenorIgualA(Convert.ToInt32(cirCin), 150))
                    {
                        bool pesoPunto = false;
                        bool cirCaderaPunto = false;
                        bool cirCinturaPunto = false;
                        bool grasaVisPunto = false;
                        bool CMBPunto = false;
                        bool IMCPunto = false;
                        bool musculoPorcPunto = false;
                        bool grasaPorcPunto = false;

                        if (peso.Contains('.'))
                        {
                            if (Punto(peso, 1, 2) == true) pesoPunto = true;
                        }
                        if (cirCad.Contains('.'))
                        {
                            if (Punto(cirCad, 1, 2) == true) cirCaderaPunto = true;
                        }
                        if (cirCin.Contains('.'))
                        {
                            if (Punto(cirCin, 1, 2) == true) cirCinturaPunto = true;
                        }
                        if (grasaVis.Contains('.'))
                        {
                            if (Punto(grasaVis, 1, 1) == true) grasaVisPunto = true;
                        }
                        if (CMB.Contains('.'))
                        {
                            if (Punto(CMB, 1, 1) == true) CMBPunto = true;
                        }
                        if (IMC.Contains('.'))
                        {
                            if (Punto(IMC, 1, 1) == true) IMCPunto = true;
                        }
                        if (musculoPorc.Contains('.'))
                        {
                            if (Punto(musculoPorc, 1, 1) == true) musculoPorcPunto = true;
                        }
                        if (grasaPorc.Contains('.'))
                        {
                            if (Punto(grasaPorc, 1, 1) == true) grasaPorcPunto = true;
                        }
                        if ((peso.Contains('.') && pesoPunto == true) && (cirCad.Contains('.') && cirCaderaPunto == true && cirCin.Contains('.') && cirCinturaPunto == true && grasaVis.Contains('.') && grasaVisPunto == true && CMB.Contains('.') && CMBPunto == true && IMC.Contains('.') && IMCPunto == true && musculoPorc.Contains('.') && musculoPorcPunto == true && grasaPorc.Contains('.') && grasaPorcPunto == true))
                        {
                            if (validac.FechaMayorIgualA(fecha, DateTime.Today))
                            {
                                try
                                {
                                    var modelodc = new ModeloDatosxCita();
                                    modelodc.ModificarDatosCita(grasaVis, CMB, cirCad, bodyAge, cirCin, musculoPorc, grasaPorc, IMC, peso, id, idCita);
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
                        else if ((peso.Contains('.') && pesoPunto == false) || (cirCad.Contains('.') && cirCaderaPunto == false) || (cirCin.Contains('.') && cirCinturaPunto == false) || (grasaVis.Contains('.') && grasaVisPunto == false) || (CMB.Contains('.') && CMBPunto == false) || (IMC.Contains('.') && IMCPunto == false) || (musculoPorc.Contains('.') && musculoPorcPunto == false) || (grasaPorc.Contains('.') && grasaPorcPunto == false))
                        {
                            error = "Revise el formato correcto en la parte derecha de los campos.";
                            return;
                        }
                        else
                        {
                            if (validac.FechaMayorIgualA(fecha, DateTime.Today))
                            {
                                try
                                {
                                    var modelodc = new ModeloDatosxCita();
                                    modelodc.ModificarDatosCita(grasaVis, CMB, cirCad, bodyAge, cirCin, musculoPorc, grasaPorc, IMC, peso, id, idCita);
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
                    }
                    else
                    {
                        error = "Las cantidades deben de estar dentro de los rangos permitidos";
                        return;
                    }
                }
                else
                {
                    error = "Las cantidades deben de estar dentro de los rangos permitidos";
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

        public bool Punto(string cantidad, int Min, int Max)
        {
            string[] variableArray;

            variableArray = cantidad.Split('.');
            if (variableArray[1].Length == Max || variableArray[1].Length == Min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
