using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador "Datos Generales" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD del modelo correspondiente
    /// en la tabla "Paciente y DatosGnAntePato" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorDatosGenerales
    {
        public string error = "";
        //command

        public string ObtenerNombre(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerNombre(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //command

        public string ObtenerGenero(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerGenero(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //command

        public string ObtenerEstadoCivil(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerEstadoCivil(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DateTime ObtenerFechaNacimiento(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerFechaNacimiento(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //command

        public string ObtenerEscolaridad(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerEscolaridad(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //command

        public string ObtenerOcupacion(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerOcupacion(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
                //command

        public string ObtenerTelefono(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerTelefono(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerEmail(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerEmail(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerMotivos(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerMotivos(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Facade
        public void AgregarAntecedentesPatologicos(string diarrea, string flatulencias, string vomito, string masticacion, string colitis, string estrenimiento, string ansiedad, string dolorCabeza, string gastritis, string disfagia, string nauseas, string enfermedad, string medicamentos, string suplementos, string diureticos, string laxantes, string cirugia, int idPaciente)
        {
            if (diarrea != "" && flatulencias != "" && vomito != "" && masticacion != "" && colitis != "" && estrenimiento != "" && ansiedad != "" && dolorCabeza != "" && gastritis != "" && disfagia != "" && nauseas != "" && enfermedad != "" && medicamentos != "" && suplementos != "" && diureticos != "" && laxantes != "" && cirugia != "")
            {
                try
                {
                    var modeloDatosGenerales = new ModeloDatosGenerales();
                    modeloDatosGenerales.AgregarAntecedentesPatologicos(diarrea, flatulencias, vomito, masticacion, colitis, estrenimiento, ansiedad, dolorCabeza, gastritis, disfagia, nauseas, enfermedad, medicamentos, suplementos, diureticos, laxantes, cirugia, idPaciente);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                error = "Los campos no deben estar vacios";
                return;
            }
        }

        public string ObtenerDiarrea(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerDiarrea(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerFlatulencias(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerFlatulencias(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerVomito(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerVomito(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerMasticacion(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerMasticacion(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerColitis(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerColitis(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerEstrenimiento(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerEstrenimiento(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerAnsiedad(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerAnsiedad(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerDolorCabeza(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerDolorCabeza(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerGastritis(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerGastritis(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerDisfagia(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerDisfagia(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerNauseas(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerNauseas(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerEnfermedad(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerEnfermedad(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerMedicamentos(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerMedicamentos(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerSuplementos(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerSuplementos(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerDiureticos(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerDiureticos(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerLaxantes(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerLaxantes(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerCirugia(int id)
        {
            try
            {
                var modeloDatosGenerales = new ModeloDatosGenerales();
                return modeloDatosGenerales.ObtenerCirugia(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarDatosGenerales(string nombre, string genero, string estadoCivil, DateTime fechaNacimiento, string escolaridad, string ocupacion, string telefono, string email, string motivos, int id)
        {
            string telefonovar = telefono;
            string replacedString = telefono.Replace("(", "");
            telefonovar = replacedString.Replace(")", "");
            telefonovar = telefonovar.Replace("-", "");
            telefonovar = telefonovar.Replace(" ", "");
            var validac = new Validacion();
            var fechahoy = DateTime.Today;
            var fechalimite = new DateTime(1900, 1, 1);
            if(validac.Longitud(nombre, 2, 50) && validac.Longitud(genero, 1, 10) && validac.Longitud(estadoCivil, 1, 10) && validac.Longitud(escolaridad, 1, 50) && validac.Longitud(ocupacion, 1, 50) && validac.Longitud(motivos, 1, 100))
            {
                if(validac.FechaMayorA(fechaNacimiento, fechalimite) && validac.FechaMenorA(fechaNacimiento, fechahoy))
                {
                    if (validac.Longitud(telefonovar, 1, 10))
                    {
                        if (validac.Longitud(telefonovar, 7, 10))
                        {
                            if (email == "")
                            {
                                try
                                {
                                    var modeloDatosGenerales = new ModeloDatosGenerales();
                                    modeloDatosGenerales.ModificarDatosGenerales(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos, id);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception(ex.Message);
                                }
                            }
                            else
                            {
                                if (email.Contains("@"))
                                {
                                    if (IsValidEmail(email))
                                    {
                                        try
                                        {
                                            var modeloDatosGenerales = new ModeloDatosGenerales();
                                            modeloDatosGenerales.ModificarDatosGenerales(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos, id);
                                        }
                                        catch (Exception ex)
                                        {
                                            throw new Exception(ex.Message);
                                        }
                                    }
                                    else
                                    {
                                        error = "Email no valido";
                                        return;
                                    }
                                }
                                else
                                {
                                    error = "Correo no valido";
                                    return;
                                }
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
                        if (email == "")
                        {
                            try
                            {
                                var modeloDatosGenerales = new ModeloDatosGenerales();
                                modeloDatosGenerales.ModificarDatosGenerales(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos, id);
                            }
                            catch (Exception ex)
                            {
                                throw new Exception(ex.Message);
                            }
                        }
                        else
                        {
                            if (email.Contains("@"))
                            {
                                if (IsValidEmail(email))
                                {
                                    try
                                    {
                                        var modeloDatosGenerales = new ModeloDatosGenerales();
                                        modeloDatosGenerales.ModificarDatosGenerales(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos, id);
                                    }
                                    catch (Exception ex)
                                    {
                                        throw new Exception(ex.Message);
                                    }
                                }
                                else
                                {
                                    error = "Email no valido";
                                    return;
                                }
                            }
                            else
                            {
                                error = "Correo no valido";
                                return;
                            }
                        }
                    }
                }
                else
                {
                    error = "Fecha de nacimiento no valida";
                    return;
                }
            }
            else
            {
                if(validac.Longitud(nombre, 1, 1))
                {
                    error = "El campo de Nombre debe de tener al menos 2 caracteres";
                    return;
                }
                else
                {
                    error = "Los campos Nombre, Genero, Estado Civil, Escolaridad, Ocupacion y Motivos de Consulta no deben estar vacios";
                    return;
                }
            }
        }
        //Facade
        public void ModificarAntecedentesPatologicos(string diarrea, string flatulencias, string vomito, string masticacion, string colitis, string estrenimiento, string ansiedad, string dolorCabeza, string gastritis, string disfagia, string nauseas, string enfermedad, string medicamentos, string suplementos, string diureticos, string laxantes, string cirugia, int idPaciente)
        {
            if(diarrea != "" && flatulencias != "" && vomito != "" && masticacion != "" && colitis != "" && estrenimiento != "" && ansiedad != "" && dolorCabeza != "" && gastritis != "" && disfagia != "" && nauseas != "" && enfermedad != "" && medicamentos != "" && suplementos != "" && diureticos != "" && laxantes != "" && cirugia != "")
            {
                try
                {
                    var modeloDatosGenerales = new ModeloDatosGenerales();
                    modeloDatosGenerales.ModificarAntecedentesPatologicos(diarrea, flatulencias, vomito, masticacion, colitis, estrenimiento, ansiedad, dolorCabeza, gastritis, disfagia, nauseas, enfermedad, medicamentos, suplementos, diureticos, laxantes, cirugia, idPaciente);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                error = "Los campos no deben estar vacios";
                return;
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
