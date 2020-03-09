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
    /// En esta pantalla podemos registrar un nuevo usuario.
    /// </summary>
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
            cbxTipo.SelectedIndex = 0;
        }

        string mensaje;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var cru = new ControladorRegistrarUsuario();
            if(cbxTipo.SelectedIndex == 0)
            {
                if(PedirAutorizacion() == true)
                {
                    if (cru.RevisarSiYaExiste(txtUsuario.Text) == false)
                    {
                        mensaje = cru.AgregarUsuario(txtUsuario.Text, txtContrasena.Text, cbxTipo.SelectedIndex + 1);
                        if (mensaje == "")
                        {
                            MessageBox.Show("Usuario agregado exitosamente");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error: " + mensaje);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ese usuario ya existe");
                    }
                }
            }
            else
            {
                mensaje = cru.AgregarUsuario(txtUsuario.Text, txtContrasena.Text, cbxTipo.SelectedIndex + 1);
                if (mensaje == "")
                {
                    MessageBox.Show("Usuario agregado exitosamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error: " + mensaje);
                }
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public bool PedirAutorizacion()
        {
            PedirPermisos pP = new PedirPermisos();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (pP.ShowDialog(this) == DialogResult.OK)
            {
                if(pP.autorizado == true)
                {
                    MessageBox.Show("Autorizado!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        private void Limpiar()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            cbxTipo.SelectedIndex = 0;
        }
    }
}
