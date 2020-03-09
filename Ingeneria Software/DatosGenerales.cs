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
    /// En la pantalla DatosGenerales se pueden guardar los datos generales del pacientes y antecedentes
    /// patologicos
    /// </summary>
    public partial class DatosGenerales : Form
    {
        public DatosGenerales(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;

        private void next_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Generales2(id));
        }

        private void AbrirFormHija(object form)
        {
            if (this.panelDatosGenerales.Controls.Count > 0)
            {
                this.panelDatosGenerales.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDatosGenerales.Controls.Add(fh);
            this.panelDatosGenerales.Tag = fh;
            fh.Show();
            panelDatosGenerales.Visible = true;
        }

        private void DatosGenerales_Load(object sender, EventArgs e)
        {
            var controladorDatosGenerales = new ControladorDatosGenerales();
            txtNombre.Text = controladorDatosGenerales.ObtenerNombre(id);
            txtGenero.Text = controladorDatosGenerales.ObtenerGenero(id);
            txtEstadoCivil.Text = controladorDatosGenerales.ObtenerEstadoCivil(id);
            dtpFechaNac.Value = controladorDatosGenerales.ObtenerFechaNacimiento(id);
            txtEscolaridad.Text = controladorDatosGenerales.ObtenerEscolaridad(id);
            txtOcupacion.Text = controladorDatosGenerales.ObtenerOcupacion(id);
            txtTelefono.Text = controladorDatosGenerales.ObtenerTelefono(id);
            txtEmail.Text = controladorDatosGenerales.ObtenerEmail(id);
            rtxtMotivos.Text = controladorDatosGenerales.ObtenerMotivos(id);
            txtDiarrea.Text = controladorDatosGenerales.ObtenerDiarrea(id);
            txtFlatulencias.Text = controladorDatosGenerales.ObtenerFlatulencias(id);
            txtVomito.Text = controladorDatosGenerales.ObtenerVomito(id);
            txtMasticacion.Text = controladorDatosGenerales.ObtenerMasticacion(id);
            txtColitis.Text = controladorDatosGenerales.ObtenerColitis(id);
            txtEstrenimiento.Text = controladorDatosGenerales.ObtenerEstrenimiento(id);
            txtAnsiedad.Text = controladorDatosGenerales.ObtenerAnsiedad(id);
            txtDolorCabeza.Text = controladorDatosGenerales.ObtenerDolorCabeza(id);
            txtGastritis.Text = controladorDatosGenerales.ObtenerGastritis(id);
            txtDisfagia.Text = controladorDatosGenerales.ObtenerDisfagia(id);
            txtNauseas.Text = controladorDatosGenerales.ObtenerNauseas(id);
            txtEnfermedad.Text = controladorDatosGenerales.ObtenerEnfermedad(id);
            txtMedicamentos.Text = controladorDatosGenerales.ObtenerMedicamentos(id);
            txtSuplementos.Text = controladorDatosGenerales.ObtenerSuplementos(id);
            txtDiureticos.Text = controladorDatosGenerales.ObtenerDiureticos(id);
            txtLaxantes.Text = controladorDatosGenerales.ObtenerLaxantes(id);
            txtCirugia.Text = controladorDatosGenerales.ObtenerCirugia(id);
        }

        private void btnAPAgregar_Click(object sender, EventArgs e)
        {
            var controladorDatosGenerales = new ControladorDatosGenerales();
            controladorDatosGenerales.AgregarAntecedentesPatologicos(txtDiarrea.Text, txtFlatulencias.Text, txtVomito.Text, txtMasticacion.Text, txtColitis.Text, txtEstrenimiento.Text, txtAnsiedad.Text, txtDolorCabeza.Text, txtGastritis.Text, txtDisfagia.Text, txtNauseas.Text, txtEnfermedad.Text, txtMedicamentos.Text, txtSuplementos.Text, txtDiureticos.Text, txtLaxantes.Text, txtCirugia.Text, id);
            if(controladorDatosGenerales.error != "")
            {
                MessageBox.Show(controladorDatosGenerales.error);
            }
            else
            {
                MessageBox.Show("Datos agregados exitosamente");
            }
        }

        private void btnDatosPersonalesMod_Click(object sender, EventArgs e)
        {
            var controladorDatosGenerales = new ControladorDatosGenerales();
            controladorDatosGenerales.ModificarDatosGenerales(txtNombre.Text, txtGenero.Text, txtEstadoCivil.Text, dtpFechaNac.Value, txtEscolaridad.Text, txtOcupacion.Text, txtTelefono.Text, txtEmail.Text, rtxtMotivos.Text, id);
            if(controladorDatosGenerales.error != "")
            {
                MessageBox.Show(controladorDatosGenerales.error);
            }
            else
            {
                MessageBox.Show("Usuario modificado exitosamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var controladorDatosGenerales = new ControladorDatosGenerales();
            controladorDatosGenerales.ModificarAntecedentesPatologicos(txtDiarrea.Text, txtFlatulencias.Text, txtVomito.Text, txtMasticacion.Text, txtColitis.Text, txtEstrenimiento.Text, txtAnsiedad.Text, txtDolorCabeza.Text, txtGastritis.Text, txtDisfagia.Text, txtNauseas.Text, txtEnfermedad.Text, txtMedicamentos.Text, txtSuplementos.Text, txtDiureticos.Text, txtLaxantes.Text, txtCirugia.Text, id);
            if (controladorDatosGenerales.error != "")
            {
                MessageBox.Show(controladorDatosGenerales.error);
            }
            else
            {
                MessageBox.Show("Datos modificados exitosamente");
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEscolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y los caracteres @, -, _ y .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiarrea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVomito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtColitis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAnsiedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGastritis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNauseas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFlatulencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMasticacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEstrenimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDolorCabeza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDisfagia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtxtMotivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEnfermedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMedicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSuplementos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiureticos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLaxantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCirugia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
