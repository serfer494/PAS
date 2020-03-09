using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador "Nuevo Cliente" valida que la informacion de los campos 
    /// sean correctos para poder ingresar un registro
    /// en la tabla "Paciente" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorNuevoCliente
    {
        public string error = "";

        public void AgregarNuevoCliente(string nombre, string genero, string estadoCivil, DateTime fechaNacimiento, string escolaridad, string ocupacion, string telefono, string email, string motivos)
        {
            //Patron de creacion
            string telefonovar = telefono;
            string replacedString = telefono.Replace("(", "");
            telefonovar = replacedString.Replace(")", "");
            telefonovar = telefonovar.Replace("-", "");
            telefonovar = telefonovar.Replace(" ", "");
            var validac = new Validacion();
            var fechahoy = DateTime.Today;
            var fechalimite = new DateTime(1900, 1, 1);
            if (validac.Longitud(nombre, 1, 50) && validac.Longitud(genero, 1, 10) && validac.Longitud(estadoCivil, 1, 10) && validac.Longitud(escolaridad, 1, 50) && validac.Longitud(ocupacion, 1, 50) && validac.Longitud(motivos, 1, 100))
            {

                if (validac.FechaMayorA(fechaNacimiento, fechalimite) && validac.FechaMenorA(fechaNacimiento, fechahoy))
                {
                    if (validac.Longitud(telefonovar, 1, 10))
                    {
                        if (validac.Longitud(telefonovar, 7, 10))
                        {
                            if (email == "")
                            {
                                try
                                {
                                    var modeloNuevoCliente = new ModeloNuevoCliente();
                                    modeloNuevoCliente.AgregarNuevoCliente(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos);
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
                                            var modeloNuevoCliente = new ModeloNuevoCliente();
                                            modeloNuevoCliente.AgregarNuevoCliente(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos);
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
                                var modeloNuevoCliente = new ModeloNuevoCliente();
                                modeloNuevoCliente.AgregarNuevoCliente(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos);
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
                                        var modeloNuevoCliente = new ModeloNuevoCliente();
                                        modeloNuevoCliente.AgregarNuevoCliente(nombre, genero, estadoCivil, fechaNacimiento, escolaridad, ocupacion, telefono, email, motivos);
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
                error = "Los campos Nombre, Genero, Estado Civil, Escolaridad, Ocupacion y Motivos de Consulta no deben estar vacios";
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
