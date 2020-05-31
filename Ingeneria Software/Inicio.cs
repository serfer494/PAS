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
    /// En la pantalla Inicio podemos ingresar al sistema usando un usuario ya registrado, o podemos crear
    /// uno seleccionando Registrar.
    /// </summary>
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void jalo_Click(object sender, EventArgs e)
        {
            //MenuPpal mp = new MenuPpal();          
            //mp.Show();
            var controladorInicio = new ControladorInicio();
            controladorInicio.Login(txtUsuario.Text, txtContraseña.Text);
            if (controladorInicio.mensaje != "")
            {
                MessageBox.Show("Error: " + controladorInicio.mensaje);
            }
            else
            {
                MessageBox.Show("Autentificacion exitosa");
                int tipo;
                tipo = controladorInicio.ObtenerTipo(txtUsuario.Text);
                MenuPpal mp = new MenuPpal(tipo, txtUsuario.Text);
                mp.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario ru = new RegistrarUsuario();
            ru.Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
