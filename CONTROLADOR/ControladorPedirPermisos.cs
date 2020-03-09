using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador de Pedir Permisos comprueba los datos para autorizar el registro
    /// de un nuevo usuario del sistema.
    /// </summary>
    public class ControladorPedirPermisos
    {
        public bool ComprobarAutorizacion(string usuario, string contrasena)
        {
            
                        try
                        {
                            var modeloPedirPermisos = new ModeloPedirPermisos();
                            return modeloPedirPermisos.ComprobarAutorizacion(usuario, contrasena);
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                    

        }
    }
}
