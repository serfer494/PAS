using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorAlimentos
    {
        public string error = ""; 
        public void AgregarAlimento(string nombre, string energia, string hidratos, string grasa, string proteinas)
        {
            if(nombre.Length > 0 && energia.Length > 0 && hidratos.Length > 0 
                && grasa.Length > 0 && proteinas.Length > 0)
            {
                if (Convert.ToInt32(energia) > 0 && Convert.ToInt32(hidratos) > 0 && Convert.ToInt32(grasa) > 0 &&
                    Convert.ToInt32(proteinas) > 0)
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

        public void EliminarAlimento(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                modeloAlimento.EliminarAlimento(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

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

        public string ObtenerNombre(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.ObtenerNombre(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerEnergia(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.ObtenerEnergia(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerHidratos(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.ObtenerHidratos(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerGrasa(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.ObtenerGrasa(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerProteinas(int id)
        {
            try
            {
                var modeloAlimento = new ModeloAlimento();
                return modeloAlimento.ObtenerProteinas(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
