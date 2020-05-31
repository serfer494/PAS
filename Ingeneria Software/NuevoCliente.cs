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
    /// En la pantalla NuevoCliente podemos crear un nuevo cliente en el sistema ingresando sus datos.
    /// </summary>
    public partial class NuevoCliente : Form
    {
        private string usuario;
        public NuevoCliente(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var controladorNuevoCliente = new ControladorNuevoCliente();
            controladorNuevoCliente.AgregarNuevoCliente(txtNombre.Text, txtGenero.Text, txtEstadoCivil.Text, dtpFechaNac.Value, txtEscolaridad.Text, txtOcupacion.Text, mtxtTelefono.Text, txtEmail.Text, rtxtMotivos.Text);
            if(controladorNuevoCliente.error != "")
            {
                MessageBox.Show(controladorNuevoCliente.error);
            }
            else
            {
                txtNombre.Text = "";
                txtGenero.Text = "";
                txtEstadoCivil.Text = "";
                txtEscolaridad.Text = "";
                txtOcupacion.Text = "";
                mtxtTelefono.Text = "";
                txtEmail.Text = "";
                rtxtMotivos.Text = "";
                MessageBox.Show("Cliente agregado");
                MenuPpal menu = new MenuPpal(1, usuario);
                menu.FillClients();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEscolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void rtxtMotivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
