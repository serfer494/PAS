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
    /// La clase controlador "Comida" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD del modelo correspondiente
    /// en la tabla "Comida_ingredientes y Comida" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorComida
    {
        public string error = "";

        public List<string> ObtenerAlimentos()
        {
            try
            {
                var modeloComida = new ModeloComida();
                return modeloComida.ObtenerAlimentos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerIdAlimento(string str)
        {
            try
            {
                var modeloComida = new ModeloComida();
                return modeloComida.ObtenerIdAlimento(str);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Facade
        public void AgregarComida(string nombre, int id1, int id2, int id3, int id4, int id5, string cant1, string cant2, string cant3, string cant4, string cant5)
        {
            bool novacio1 = false;
            bool novacio2 = false;
            bool novacio3 = false;
            bool novacio4 = false;
            bool novacio5 = false;
            bool positivo = true;
            bool noIgual = true;
            var validac = new Validacion();
            if (validac.Longitud(nombre, 1, 50))
            {
                if((validac.Longitud(id1.ToString(), 1, 50) && validac.Longitud(cant1, 1, 5) && validac.MayorA(id1, 0)) || (validac.Longitud(id2.ToString(), 1, 50) && validac.Longitud(cant2, 1, 5) && validac.MayorA(id2, 0)) || (validac.Longitud(id3.ToString(), 1, 50) && validac.Longitud(cant3, 1, 5) && validac.MayorA(id3, 0)) || (validac.Longitud(id4.ToString(), 1, 50) && validac.Longitud(cant4, 1, 5) && validac.MayorA(id4, 0)) || (validac.Longitud(id5.ToString(), 1, 50) && validac.Longitud(cant5, 1, 5) && validac.MayorA(id5, 0)))
                {
                    if (validac.Longitud(id1.ToString(), 1, 50) && validac.Longitud(cant1, 1, 5)) novacio1 = true;
                    if (validac.Longitud(id2.ToString(), 1, 50) && validac.Longitud(cant2, 1, 5)) novacio2 = true;
                    if (validac.Longitud(id3.ToString(), 1, 50) && validac.Longitud(cant3, 1, 5)) novacio3 = true;
                    if (validac.Longitud(id4.ToString(), 1, 50) && validac.Longitud(cant4, 1, 5)) novacio4 = true;
                    if (validac.Longitud(id5.ToString(), 1, 50) && validac.Longitud(cant5, 1, 5)) novacio5 = true;
                    if (novacio1 == true && Convert.ToInt32(cant1) == 0) positivo = false;
                    if (novacio2 == true && Convert.ToInt32(cant2) == 0) positivo = false;
                    if (novacio3 == true && Convert.ToInt32(cant3) == 0) positivo = false;
                    if (novacio4 == true && Convert.ToInt32(cant4) == 0) positivo = false;
                    if (novacio5 == true && Convert.ToInt32(cant5) == 0) positivo = false;
                    if (novacio1 == true && novacio2 == true && id1 == id2) noIgual = false;
                    if (novacio1 == true && novacio3 == true && id1 == id3) noIgual = false;
                    if (novacio1 == true && novacio4 == true && id1 == id4) noIgual = false;
                    if (novacio1 == true && novacio5 == true && id1 == id5) noIgual = false;
                    if (novacio2 == true && novacio3 == true && id2 == id3) noIgual = false;
                    if (novacio2 == true && novacio4 == true && id2 == id4) noIgual = false;
                    if (novacio2 == true && novacio5 == true && id2 == id5) noIgual = false;
                    if (novacio3 == true && novacio4 == true && id3 == id4) noIgual = false;
                    if (novacio3 == true && novacio5 == true && id3 == id5) noIgual = false;
                    if (novacio4 == true && novacio5 == true && id4 == id5) noIgual = false;
                    if (positivo == true && noIgual == true)
                    {
                        try
                        {
                            var modeloComida = new ModeloComida();
                            modeloComida.AgregarComida(nombre, id1, id2, id3, id4, id5, cant1, cant2, cant3, cant4, cant5);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        error = "Las cantidades deben ser mayor a 0 y no puede haber alimentos iguales";
                        return;

                    }
                    
                }
                else
                {
                    error = "Se debe seleccionar al menos un alimento valido y una cantidad";
                    return;
                }
            }
            else
            {
                error = "El campo \"Nombre\" no puede estar vacio";
                return;
            }
        }

        public DataTable GetTable()
        {
            try
            {
                var modeloComida = new ModeloComida();
                return modeloComida.GetTable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerIdComida(string str)
        {
            try
            {
                var modeloComida = new ModeloComida();
                return modeloComida.ObtenerIdComida(str);
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

        public int ObtenerIdComidaIngrediente(int idAlimento, int idComida)
        {
            try
            {
                var modeloComida = new ModeloComida();
                return modeloComida.ObtenerIdComidaIngrediente(idAlimento, idComida);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Facade
        public void ModificarComida(string nombre, int idAlimento, int idComida, string cant, int idComidaAlimento)
        {
            bool novacio1 = false;
            bool novacio2 = false;
            bool novacio3 = false;
            bool novacio4 = false;
            bool novacio5 = false;
            bool positivo = true;
            if (nombre != "")
            {
                if ((idAlimento != 0 && cant != ""))
                {
                    if (idAlimento != 0 && cant != "") novacio1 = true;
                    if (novacio1 == true && Convert.ToInt32(cant) == 0) positivo = false;
                    if(positivo == true)
                    {
                        try
                        {
                            var modeloComida = new ModeloComida();
                            modeloComida.ModificarComida(nombre, idAlimento, idComida, cant, idComidaAlimento);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        error = "Las cantidades deben ser mayor a 0";
                        return;
                    }
                }
                else
                {
                    error = "Se debe seleccionar un alimento valido y una cantidad";
                    return;
                }
            }
            else
            {
                error = "El campo \"Nombre\" no puede estar vacio";
                return;
            }
        }
        //Facade
        public void EliminarComida(int idComida)
        {
            try
            {
                var modeloComida = new ModeloComida();
                modeloComida.EliminarComida(idComida);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
