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
    /// La clase controlador "Alimentos" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD del modelo correspondiente
    /// en la tabla "Alimento" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorAlimentos
    {
        public string error = "";
        //Facade

        public static int PruebasAlimentos(string port)
        {
            if (!port.StartsWith("COM"))
            {
                throw new FormatException("Port is not in a correct format.");
            }
            else
            {
                const int lastIndexOfPrefix = 3;
                string portNumber = port.Substring(lastIndexOfPrefix);
                return int.Parse(portNumber);
            }
        }
        public void AgregarAlimento(string nombre, string energia, string hidratos, string grasa, string proteinas)
        {
            var validac = new Validacion();
            if(validac.Longitud(nombre, 1, 50) && validac.Longitud(energia, 1, 6) && validac.Longitud(hidratos, 1, 5) && validac.Longitud(grasa, 1, 5) && validac.Longitud(proteinas, 1, 5))
            {
                if (validac.MayorA(Convert.ToInt32(energia), 0) && validac.MayorA(Convert.ToInt32(hidratos), 0) && validac.MayorA(Convert.ToInt32(grasa), 0) && validac.MayorA(Convert.ToInt32(proteinas), 0))
                {
                    try
                    {
                        var modeloAlimento = new ModeloAlimento();
                        modeloAlimento.AgregarAlimento(nombre, energia, hidratos, grasa, proteinas);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    error = "Los campos despues de nombre deben ser mayores a cero";
                    return;
                }
            }
            else
            {
                error = "Los campos con * son obligatorios";
                return;
            }
            
        }
        public DataTable GetTable()
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.GetTable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Facade
        public void ModificarAlimento(string nombre, string energia, string hidratos, string grasa, string proteinas, int id)
        {
            
                if (nombre.Length > 0 && energia.Length > 0 && hidratos.Length > 0
                    && grasa.Length > 0 && proteinas.Length > 0)
                {
                    if (Convert.ToInt32(energia) > 0 && Convert.ToInt32(hidratos) > 0 && Convert.ToInt32(grasa) > 0 &&
                        Convert.ToInt32(proteinas) > 0)
                    {
                        try
                        {
                            var modeloAlimento = new ModeloAlimento();
                            modeloAlimento.ModificarAlimento(nombre, energia, hidratos, grasa, proteinas, id);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        error = "Los campos despues de \"Nombre\" deben de" +
                        " ser mayor a 0";
                        return;
                    }

                }
                else
                {
                    error = "Los campos no deben de estar vacios";
                    return;
                }
            
            
        }
        //Facade
        public void EliminarAlimento(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                modeloAlimento.EliminarAlimento(id);
                if(modeloAlimento.error != "")
                {
                    error = modeloAlimento.error;
                    return;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        //command
        public int ObtenerId(string str)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.ObtenerId(str);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //command
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
        //command  
    }
}
