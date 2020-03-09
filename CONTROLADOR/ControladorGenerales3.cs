using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador "Datos Generales 3" valida que la informacion de los campos 
    /// sean correctos para poder usar el CRUD de la tabla "DatosGnIndDie" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorGenerales3
    {
        public string error = "";
        //Facade
        public void AgregarIndicadoresDieteticos(string comidasDia, string quienComida, string comeFuera, string AlimentosPref, string agua, string alergias, string notas, string recordatorio, int id)
        {
            var validac = new Validacion();
            if (validac.Longitud(comidasDia, 1, 50) && validac.Longitud(quienComida, 1, 20) && validac.Longitud(comeFuera, 1, 10) && validac.Longitud(AlimentosPref, 1, 100) && validac.Longitud(agua, 1, 50) && validac.Longitud(alergias, 1, 50))
            {
                try
                {
                    var modeloGenerales3 = new ModeloGenerales3();
                    modeloGenerales3.AgregarIndicadoresDieteticos(comidasDia, quienComida, comeFuera, AlimentosPref, agua, alergias, notas, recordatorio, id);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                error = "Los campos con * son necesarios";
                return;
            }
        }
        //Facade
        public void ModificarIndicadoresDieteticos(string comidasDia, string quienComida, string comeFuera, string AlimentosPref, string agua, string alergias, string notas, string recordatorio, int id)
        {
            var validac = new Validacion();
            if (validac.Longitud(comidasDia, 1, 50) && validac.Longitud(quienComida, 1, 20) && validac.Longitud(comeFuera, 1, 10) && validac.Longitud(AlimentosPref, 1, 100) && validac.Longitud(agua, 1, 50) && validac.Longitud(alergias, 1, 50))
            {
                try
                {
                    var modeloGenerales3 = new ModeloGenerales3();
                    modeloGenerales3.ModificarIndicadoresDieteticos(comidasDia, quienComida, comeFuera, AlimentosPref, agua, alergias, notas, recordatorio, id);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                error = "Los campos Comidas al Dia, Quien Prepara su Comida, Come Fuera, Alimentos Preferidos, Agua, y Alergias / Intolerancias a Comidas no deben estar vacios";
                return;
            }
        }

        public string ObtenerTexto(int id, string campo)
        {
            try
            {
                var modeloGenerales3 = new ModeloGenerales3();
                return modeloGenerales3.ObtenerTexto(id, campo);
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
