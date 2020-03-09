using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase controlador "Registrar usuarios" valida que la informacion de los campos 
    /// sean correctos para poder ingresar un usuario a la tabla "Usuarios" en la base de datos "DBPAS" destinada al sistema.
    /// De acuerdo a las caracteristicas de la clase "Validacion".
    /// </summary>
    public class ControladorRegistrarUsuario
    {
        string mensaje;

        public string AgregarUsuario(string usuario, string contrasena, int tipo)
        {
            var validac = new Validacion();
            if(validac.Longitud(usuario, 4, 15) == true)
            {
                if(validac.Longitud(contrasena, 8, 25) == true)
                {
                    if(validac.ContieneMinusculas(contrasena) == true && validac.ContieneMayusculas(contrasena) == true && validac.ContieneNumeros(contrasena) == true)
                    {
                        try
                        {
                            var mru = new ModeloRegistrarUsuario();
                            mensaje = mru.AgregarUsuario(usuario, contrasena, tipo);
                            return mensaje;
                        }
                        catch (Exception ex)
                        {
                            return ex.ToString();
                        }
                    }
                    else
                    {
                        return "La contraseña debe de tener caracteres en mayusculas, caracteres en minusculas y numeros";
                    }
                }
                else
                {
                    return "la contraseña debe de tener al menos 8 caracteres";
                }
            }
            else
            {
                return "El usuario debe de tener al menos 4 caracteres";
            }
        }

       public bool RevisarSiYaExiste(string usuario)
       {
            try
            {
                var mru = new ModeloRegistrarUsuario();
                return mru.RevisarSiYaExiste(usuario);
            }
            catch (Exception ex)
            {
                return true;
            }
       }
    }
}
