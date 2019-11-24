using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorNuevoCliente
    {
        public void AgregarNuevoCliente(string nombre, string genero, string estadoCivil, DateTime fechaNacimiento, string escolaridad, string ocupacion, string telefono, string email, string motivos)
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
    }
}
