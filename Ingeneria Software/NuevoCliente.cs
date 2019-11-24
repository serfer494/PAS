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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var controladorNuevoCliente = new ControladorNuevoCliente();
            controladorNuevoCliente.AgregarNuevoCliente(txtNombre.Text, txtGenero.Text, txtEstadoCivil.Text, dtpFechaNac.Value, txtEscolaridad.Text, txtOcupacion.Text, txtTelefono.Text, txtEmail.Text, rtxtMotivos.Text);
            txtNombre.Text = "";
            txtGenero.Text = "";
            txtEstadoCivil.Text = "";
            txtEscolaridad.Text = "";
            txtOcupacion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            rtxtMotivos.Text = "";
            MessageBox.Show("Cliente agregado");
            MenuPpal menu = new MenuPpal();
            menu.FillClients();
        }
    }
}
