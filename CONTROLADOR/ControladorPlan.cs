using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorPlan
    {
        public string error = "";

        public List<string> ObtenerComidas()
        {
            try
            {
                var modeloPlan = new ModeloPlan();
                return modeloPlan.ObtenerComidas();
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
                var modeloPlan = new ModeloPlan();
                return modeloPlan.ObtenerIdComida(str);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetTable(int idComida)
        {
            try
            {
                var modeloPlan = new ModeloPlan();
                return modeloPlan.GetTable(idComida);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ObtenerAlimento(int id)
        {
            try
            {
                var modeloPlan = new ModeloPlan();
                return modeloPlan.ObtenerAlimento(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ObtenerCalorias(int id)
        {
            try
            {
                var modeloPlan = new ModeloPlan();
                return modeloPlan.ObtenerCalorias(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
