using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR
{
    /// <summary>
    /// La clase de Validacion tiene Longitudes minimas, maximas, caracteres que debe o no debe contener
    /// y fechas validas para los campos que hay que ingresar en el sistema.
    /// </summary>
    public class Validacion
    {
        /// <summary>
        /// El metodo Longitud mide la longitud de una cadena de texto.
        /// </summary>
        /// <param name="texto"> Es la cadena de texto a evaluar.</param>
        /// <param name="longitudMin"> Es la longitud minima que debe tener la cadena.</param>
        /// <param name="longitudMax"> Es la longitud maxima que debe tener la cadena.</param>
        /// <returns> Un verdadero si la cadena cumple con los limites. Un falso de lo contrario.</returns>
        public bool Longitud(string texto, int longitudMin, int longitudMax)
        {
            if(texto.Length >= longitudMin && texto.Length <= longitudMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo MayorA toma una cantidad y verifica si es mayor a un limite establecido.
        /// </summary>
        /// <param name="cantidad"> Es la cantidad a evaluar.</param>
        /// <param name="limite"> Numero al que "cantidad" debe ser mayor a.</param>
        /// <returns> Un verdadero si "cantidad" es mayor a "limite". Un falso en caso contrario.</returns>
        public bool MayorA(int cantidad, int limite)
        {
            if(cantidad > limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MayorA(Decimal cantidad, Decimal limite)
        {
            if (cantidad > limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MayorIgualA(Decimal cantidad, Decimal limite)
        {
            if (cantidad >= limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo MenorA toma una cantidad y verifica si es menor a un limite establecido.
        /// </summary>
        /// <param name="cantidad"> Es la cantidad a evaluar.</param>
        /// <param name="limite"> Numero al que "cantidad" debe ser menor a.</param>
        /// <returns> Un verdadero si "cantidad" es menor a "limite". Un falso en caso contrario.</returns>
        public bool MenorA(int cantidad, int limite)
        {
            if(cantidad < limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MenorA(Decimal cantidad, Decimal limite)
        {
            if (cantidad < limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MenorIgualA(Decimal cantidad, Decimal limite)
        {
            if (cantidad <= limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo ContieneMayusculas verifica si una cadena contiene letras mayusculas.
        /// </summary>
        /// <param name="texto"> La cadena a evaluar.</param>
        /// <returns> Un verdadero si la cadena contiene al menos una letra mayuscula. Un falso de lo contrario.</returns>
        public bool ContieneMayusculas(string texto)
        {
            if(texto.Any(Char.IsUpper) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo ContieneMinusculas verifica si una cadena contiene letras minusculas.
        /// </summary>
        /// <param name="texto"> La cadena a evaluar.</param>
        /// <returns> Un verdadero si la cadena contiene al menos una letra minuscula. Un falso de lo contrario.</returns>
        public bool ContieneMinusculas(string texto)
        {
            if (texto.Any(Char.IsLower) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo ContieneNumeros verifica si una cadena contiene numeros.
        /// </summary>
        /// <param name="texto"> La cadena a evaluar.</param>
        /// <returns> Un verdadero si la cadena contiene al menos un numero. Un falso de lo contrario.</returns>
        public bool ContieneNumeros(string texto)
        {
            if (texto.Any(Char.IsDigit) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo FechaMayorA toma una fecha y verifica que sea mayor a una fecha establecida.
        /// </summary>
        /// <param name="fecha"> La fecha a evaluar.</param>
        /// <param name="fechaLimite"> El parametro "fecha" debe ser mayor a este valor.</param>
        /// <returns> Un verdadero si la fecha es mayor al valor limite. Un falso de lo contrario.</returns>
        public bool FechaMayorA(DateTime fecha, DateTime fechaLimite)
        {
            if (fecha > fechaLimite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo FechaMenorA toma una fecha y verifica que sea menor a una fecha establecida.
        /// </summary>
        /// <param name="fecha"> La fecha a evaluar.</param>
        /// <param name="fechaLimite"> El parametro "fecha" debe ser menor a este valor.</param>
        /// <returns> Un verdadero si la fecha es menor al valor limite. Un falso de lo contrario.</returns>
        public bool FechaMenorA(DateTime fecha, DateTime fechaLimite)
        {
            if (fecha < fechaLimite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo FechaMayorIgualA toma una fecha y verifica que sea mayor o igual a una fecha establecida.
        /// </summary>
        /// <param name="fecha"> La fecha a evaluar.</param>
        /// <param name="fechaLimite"> El parametro "fecha" debe ser mayor o igual a este valor.</param>
        /// <returns> Un verdadero si la fecha es mayor o igual al valor limite. Un falso de lo contrario.</returns>
        public bool FechaMayorIgualA(DateTime fecha, DateTime fechaLimite)
        {
            if (fecha >= fechaLimite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// El metodo FechaMenorIgualA toma una fecha y verifica que sea menor o igual a una fecha establecida.
        /// </summary>
        /// <param name="fecha"> La fecha a evaluar.</param>
        /// <param name="fechaLimite"> El parametro "fecha" debe ser menor o igual a este valor.</param>
        /// <returns> Un verdadero si la fecha es menor o igual al valor limite. Un falso de lo contrario.</returns>
        public bool FechaMenorIgualA(DateTime fecha, DateTime fechaLimite)
        {
            if (fecha <= fechaLimite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
