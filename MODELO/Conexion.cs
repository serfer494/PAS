using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    /// <summary>
    /// El modelo "Conexion" establece la conexion que se va a usar para trabajar los modelos con la base de
    /// datos "BDPAS".
    /// </summary>
    public class Conexion
    {
        private static string connectionString = "server=DESKTOP-J7FIT5H; database=DBPAS; integrated security=true";

        public static string ObtenerConexion()
        {
            return connectionString;
        }
    }
}
