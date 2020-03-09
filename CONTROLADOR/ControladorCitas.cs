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
    /// La clase controlador "Citas" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD del modelo en la tabla "Agenda" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorCitas
    {
        public string error = "";
        public DateTime[] GetDates()
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                return modeloCitas.GetDates();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetTable(DateTime date)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                return modeloCitas.GetTable(date);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Facade
        public void AgregarCita(DateTime fecha, string nombre, string apellido, string telefono, string hora)
        {
            string telefonovar = telefono;
            string replacedString = telefono.Replace("(", "");
            telefonovar = replacedString.Replace(")", "");
            telefonovar = telefonovar.Replace("-", "");
            telefonovar = telefonovar.Replace(" ", "");
            string horavar = hora;
            horavar = horavar.Replace(":", "");
            horavar = horavar.Replace(" ", "");
            var validac = new Validacion();

            if (validac.Longitud(nombre, 1, 50) == true && validac.Longitud(apellido, 1, 50) == true && validac.Longitud(hora, 1, 50) == true)
            {
                if (validac.Longitud(horavar, 4, 4))
                {
                    string izq = horavar.Substring(0,2);
                    string der = horavar.Substring(2, 2);
                    if (izq.IndexOf('0') == 0) izq = izq.Substring(1,1);
                    if (der.IndexOf('0') == 0) der = der.Substring(1, 1);
                    if (validac.MenorA(Convert.ToInt32(izq), 24) && (validac.MenorA(Convert.ToInt32(der), 60)))
                    {
                        if (validac.FechaMayorIgualA(fecha, DateTime.Today))
                        {
                            if (validac.Longitud(telefonovar, 1, 10))
                            {
                                if (validac.Longitud(telefonovar, 7, 10))
                                {
                                    try
                                    {
                                        var modeloCitas = new ModeloCitas();
                                        modeloCitas.AgregarCita(fecha, nombre, apellido, telefono, hora);
                                    }
                                    catch (Exception ex)
                                    {
                                        throw new Exception(ex.Message);
                                    }
                                }
                                else
                                {
                                    error = "Telefono debe tener entre 7 y 10 numeros";
                                    return;
                                }
                            }
                            else
                            {
                                try
                                {
                                    var modeloCitas = new ModeloCitas();
                                    modeloCitas.AgregarCita(fecha, nombre, apellido, telefono, hora);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
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
                        error = "Hora invalida";
                    }
                }
                else
                {
                    error = "Hora invalida";
                    return;
                }
            }
            else
            {
                error = "Los campos con * son obligatorios";
                return;
            }
        }
        //Facade
        public void ModificarCita(DateTime fecha, string nombre, string apellido, string telefono, string hora, int id)
        {
            string horavar = hora;
            string telefonovar = telefono;
            string replacedString = telefono.Replace("(", "");
            telefonovar = replacedString.Replace(")", "");
            telefonovar = telefonovar.Replace("-", "");
            telefonovar = telefonovar.Replace(" ", "");
            horavar = horavar.Replace(":", "");
            horavar = horavar.Replace(" ", "");
            var validac = new Validacion();
            if (validac.Longitud(nombre, 1, 50) == true && validac.Longitud(apellido, 1, 50) == true && validac.Longitud(hora, 1, 50) == true)
            {
                if (validac.Longitud(horavar, 4, 4))
                {
                    string izq = horavar.Substring(0, 2);
                    string der = horavar.Substring(2, 2);
                    if (izq.IndexOf('0') == 0) izq = izq.Substring(1, 1);
                    if (der.IndexOf('0') == 0) der = der.Substring(1, 1);
                    if (validac.MenorA(Convert.ToInt32(izq), 24) && (validac.MenorA(Convert.ToInt32(der), 60)))
                    {
                        if (validac.FechaMayorIgualA(fecha, DateTime.Today))
                        {
                            if (validac.Longitud(telefonovar, 1, 10))
                            {
                                if (validac.Longitud(telefonovar, 7, 10))
                                {
                                    try
                                    {
                                        var modeloCitas = new ModeloCitas();
                                        modeloCitas.ModificarCita(fecha, nombre, apellido, telefono, hora, id);
                                    }
                                    catch (Exception ex)
                                    {
                                        throw new Exception(ex.Message);
                                    }
                                }
                                else
                                {
                                    error = "Telefono debe tener entre 7 y 10 numeros";
                                    return;
                                }
                            }
                            else
                            {
                                try
                                {
                                    var modeloCitas = new ModeloCitas();
                                    modeloCitas.ModificarCita(fecha, nombre, apellido, telefono, hora, id);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
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
                        error = "Hora invalida";
                        return;
                    }
                }
                else
                {
                    error = "Hora invalida";
                    return;
                }
            }
            else
            {
                error = "Los campos Nombre, Apellido y Hora no deben estar vacios";
                return;
            }
        }
        //command

        public int ObtenerId(string str)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                return modeloCitas.ObtenerId(str);
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

        public DateTime ObtenerFecha(int id, string campo, string tabla, string campoID)
        {
            try
            {
                var obtener = new Obtener();
                return obtener.ObtenerFecha(id, campo, tabla, campoID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Facade
        public void EliminarCita(int id)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                modeloCitas.EliminarCita(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
