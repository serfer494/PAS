using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace Ingeneria_Software
{
    /// <summary>
    /// En esta pantalla se solicitan las credenciales de un usuario autorizado para agregar otro usuario.
    /// </summary>
    public partial class PedirPermisos : Form
    {
        public PedirPermisos()
        {
            InitializeComponent();
        }
        public bool autorizado = false;
        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            var controladorPedirPermisos = new ControladorPedirPermisos();
            if(controladorPedirPermisos.ComprobarAutorizacion(txtUsuario.Text, txtContrasena.Text) == true)
            {
                autorizado = true;
            }
            else
            {
                autorizado = false;
            }
        }
    }
}
