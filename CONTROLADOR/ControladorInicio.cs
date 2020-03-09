using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    ///La clase controlador "Inicio" valida que la informacion de los campos
    /// sean correctos para poder ingresar al sistema de acuerdo ala informacion de la tabla
    /// en la tabla "Usuarios" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorInicio
    {
        public string mensaje = "";
        public string Login(string usuario, string password)
        {
            try
            {
                var modeloInicio = new ModeloInicio();
                mensaje = modeloInicio.Login(usuario, password);
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public int ObtenerTipo(string usuario)
        {
            try
            {
                var modeloInicio = new ModeloInicio();
                return modeloInicio.ObtenerTipo(usuario);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
