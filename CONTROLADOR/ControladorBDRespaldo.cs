using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorBDRespaldo
    {
        public string error = "";
        public void Respaldo(string nombre)
        {
            var modeloBDRespaldo = new ModeloBDRespaldo();
            error = modeloBDRespaldo.Respaldo(nombre);
        }

        public void Restaurar(string path)
        {
            var modeloBDRespaldo = new ModeloBDRespaldo();
            error = modeloBDRespaldo.Restaurar(path);
        }

        public void ProgramarDia()
        {
            var modeloBDRespaldo = new ModeloBDRespaldo();
            error = modeloBDRespaldo.ProgranarDia();
        }

        public void ProgramarSemana()
        {
            var modeloBDRespaldo = new ModeloBDRespaldo();
            error = modeloBDRespaldo.ProgranarSemana();
        }

        public void ProgramarMes()
        {
            var modeloBDRespaldo = new ModeloBDRespaldo();
            error = modeloBDRespaldo.ProgranarMes();
        }
    }
}
