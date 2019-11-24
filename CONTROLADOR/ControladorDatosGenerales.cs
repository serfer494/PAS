using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorDatosGenerales
    {
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

        public void AgregarAntecedentesPatologicos(string diarrea, string flatulencias, string vomito, string masticacion, string colitis, string estrenimiento, string ansiedad, string dolorCabeza, string gastritis, string disfagia, string nauseas, string enfermedad, string medicamentos, string suplementos, string diureticos, string laxantes, string cirugia, int idPaciente)
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
    }
}
