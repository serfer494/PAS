using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador "Datos Generales 2" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD de la tabla "DatosGnAntePato, DatosGnAnteNoPato y DatosGnIndBio" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorGenerales2
    {
        public string error = "";
        //Facade
        public void AgregarAntecedentesFamiliares(string diabetes, string cancer, string obesidad, string hipertension, string enfTir, string hiperlipidemias, string otra, int idPaciente)
        {
            if(diabetes != "" && cancer != "" && obesidad != "" && hipertension != "" && enfTir != "" && hiperlipidemias != "")
            {
                try
                {
                    var modeloGenerales2 = new ModeloGenerales2();
                    modeloGenerales2.AgregarAntecedentesFamiliares(diabetes, cancer, obesidad, hipertension, enfTir, hiperlipidemias, otra, idPaciente);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                error = "Los campos Diabetes, Cancer, Obesidad, Hipertension, Enfermedades Tiroideas e Hiperlipidemias no deben estar vacios";
                return;
            }
        }
        //Facade
        public void ModificarAntecedentesFamiliares(string diabetes, string cancer, string obesidad, string hipertension, string enfTir, string hiperlipidemias, string otra, int idPaciente)
        {
            if (diabetes != "" && cancer != "" && obesidad != "" && hipertension != "" && enfTir != "" && hiperlipidemias != "")
            {
                try
                {
                    var modeloGenerales2 = new ModeloGenerales2();
                    modeloGenerales2.ModificarAntecedentesFamiliares(diabetes, cancer, obesidad, hipertension, enfTir, hiperlipidemias, otra, idPaciente);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                error = "Los campos Diabetes, Cancer, Obesidad, Hipertension, Enfermedades Tiroideas e Hiperlipidemias no deben estar vacios";
                return;
            }
        }
        //Facade
        public void AgregarAntecedentesNoPatologicos(string ejercicio, string duracion, string frecuencia, string alcohol, string tabaco, string toxicomanias, int id)
        {
            if(ejercicio != "" && duracion != "" && frecuencia != "" && alcohol != "" && tabaco != "" && toxicomanias != "")
            {
                try
                {
                    var modeloGenerales2 = new ModeloGenerales2();
                    modeloGenerales2.AgregarAntecedentesNoPatologicos(ejercicio, duracion, frecuencia, alcohol, tabaco, toxicomanias, id);
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
        //Facade
        public void ModificarAntecedentesNoPatologicos(string ejercicio, string duracion, string frecuencia, string alcohol, string tabaco, string toxicomanias, int id)
        {
            if (ejercicio != "" && duracion != "" && frecuencia != "" && alcohol != "" && tabaco != "" && toxicomanias != "")
            {
                try
                {
                    var modeloGenerales2 = new ModeloGenerales2();
                    modeloGenerales2.ModificarAntecedentesNoPatologicos(ejercicio, duracion, frecuencia, alcohol, tabaco, toxicomanias, id);
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
        //Facade
        public void AgregarIndicadoresBioquimicos(string trigliceridos, string hemoglobina, string colesterol, string glucosa, string creatinina, string nitUreico, int id)
        {
            if(trigliceridos != "" && hemoglobina != "" && colesterol != "" && glucosa != "" && creatinina != "" && nitUreico != "")
            {
                try
                {
                    var modeloGenerales2 = new ModeloGenerales2();
                    modeloGenerales2.AgregarIndicadoresBioquimicos(trigliceridos, hemoglobina, colesterol, glucosa, creatinina, nitUreico, id);
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
        //Facade
        public void ModificarIndicadoresBioquimicos(string trigliceridos, string hemoglobina, string colesterol, string glucosa, string creatinina, string nitUreico, int id)
        {
            if (trigliceridos != "" && hemoglobina != "" && colesterol != "" && glucosa != "" && creatinina != "" && nitUreico != "")
            {
                if(Convert.ToInt32(trigliceridos) != 0 && Convert.ToInt32(hemoglobina) != 0 && Convert.ToInt32(colesterol) != 0 && Convert.ToInt32(glucosa) != 0 && Convert.ToInt32(creatinina) != 0 && Convert.ToInt32(nitUreico) != 0)
                {
                    try
                    {
                        var modeloGenerales2 = new ModeloGenerales2();
                        modeloGenerales2.ModificarIndicadoresBioquimicos(trigliceridos, hemoglobina, colesterol, glucosa, creatinina, nitUreico, id);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                else
                {
                    error = "Los valores deben ser mayores a 0";
                    return;
                }
            }
            else
            {
                error = "Los campos no deben estar vacios";
                return;
            }
        }

        public string ObtenerTexto(int id, string campo, string basedeDatos)
        {
            try
            {
                var modeloGenerales2 = new ModeloGenerales2();
                return modeloGenerales2.ObtenerTexto(id, campo, basedeDatos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
