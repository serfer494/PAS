using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class ControladorCitas
    {

        public DateTime[] GetDates()
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                return modeloCitas.GetDates();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetTable(DateTime date)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                return modeloCitas.GetTable(date);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AgregarCita(DateTime fecha, string nombre, string apellido, string telefono, string hora)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                modeloCitas.AgregarCita(fecha, nombre, apellido, telefono, hora);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ModificarCita(DateTime fecha, string nombre, string apellido, string telefono, string hora, int id)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                modeloCitas.ModificarCita(fecha, nombre, apellido, telefono, hora, id);
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
                var modeloCitas = new ModeloCitas();
                return modeloCitas.ObtenerId(str);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EliminarCita(int id)
        {
            try
            {
                var modeloCitas = new ModeloCitas();
                modeloCitas.EliminarCita(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
