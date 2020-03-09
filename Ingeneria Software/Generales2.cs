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
    /// En esta pantalla se pueden ingresar la segunda parto de los datos generales del usuario, como los
    ///  antecedentes generales, antecedentes patologicos y e indicadores bioquimicos.
    /// </summary>
    public partial class Generales2 : Form
    {
        public Generales2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;
        
        private void back_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DatosGenerales(id));
        }

        private void AbrirFormHija(object form)
        {
            if (this.panelGenerales2.Controls.Count > 0)
            {
                this.panelGenerales2.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelGenerales2.Controls.Add(fh);
            this.panelGenerales2.Tag = fh;
            fh.Show();
            panelGenerales2.Visible = true;
        }

        private void sig_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Generales3(id));
        }

        private void creati_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAFAgregar_Click(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            controladorGenerales2.AgregarAntecedentesFamiliares(txtDiabetes.Text, txtCancer.Text, txtObesidad.Text, txtHipertension.Text, txtEnfTir.Text, txtHiperlipidemias.Text, txtOtra.Text, id);
            if(controladorGenerales2.error != "")
            {
                MessageBox.Show(controladorGenerales2.error);
            }
            else
            {
                MessageBox.Show("Datos agregados exitosamente");
            }
        }

        private void btnAFModificar_Click(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            controladorGenerales2.ModificarAntecedentesFamiliares(txtDiabetes.Text, txtCancer.Text, txtObesidad.Text, txtHipertension.Text, txtEnfTir.Text, txtHiperlipidemias.Text, txtOtra.Text, id);
            if (controladorGenerales2.error != "")
            {
                MessageBox.Show(controladorGenerales2.error);
            }
            else
            {
                MessageBox.Show("Datos modificados exitosamente");
            }
        }

        private void btnANPAgregar_Click(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            controladorGenerales2.AgregarAntecedentesNoPatologicos(txtEjercicio.Text, txtDuracion.Text, txtFrecuencia.Text, txtAlcohol.Text, txtTabaco.Text, txtToxicomanias.Text, id);
            if (controladorGenerales2.error != "")
            {
                MessageBox.Show(controladorGenerales2.error);
            }
            else
            {
                MessageBox.Show("Datos agregados exitosamente");
            }
        }

        private void btnANPModificar_Click(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            controladorGenerales2.ModificarAntecedentesNoPatologicos(txtEjercicio.Text, txtDuracion.Text, txtFrecuencia.Text, txtAlcohol.Text, txtTabaco.Text, txtToxicomanias.Text, id);
            if (controladorGenerales2.error != "")
            {
                MessageBox.Show(controladorGenerales2.error);
            }
            else
            {
                MessageBox.Show("Datos modificados exitosamente");
            }

        }

        private void btnIBAgregar_Click(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            controladorGenerales2.AgregarIndicadoresBioquimicos(txtTrigliceridos.Text, txtHemoglobina.Text, txtColesterol.Text, txtGlucosa.Text, txtCreatinina.Text, txtNitrogenoUreico.Text, id);
            if (controladorGenerales2.error != "")
            {
                MessageBox.Show(controladorGenerales2.error);
            }
            else
            {
                MessageBox.Show("Datos agregados exitosamente");
            }
        }

        private void btnIBModificar_Click(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            controladorGenerales2.ModificarIndicadoresBioquimicos(txtTrigliceridos.Text, txtHemoglobina.Text, txtColesterol.Text, txtGlucosa.Text, txtCreatinina.Text, txtNitrogenoUreico.Text, id);
            if (controladorGenerales2.error != "")
            {
                MessageBox.Show(controladorGenerales2.error);
            }
            else
            {
                MessageBox.Show("Datos modificados exitosamente");
            }

        }

        private void Generales2_Load(object sender, EventArgs e)
        {
            var controladorGenerales2 = new ControladorGenerales2();
            txtDiabetes.Text = controladorGenerales2.ObtenerTexto(id, "diabetes", "DATOSGNANTEPATO");
            txtCancer.Text = controladorGenerales2.ObtenerTexto(id, "cancer", "DATOSGNANTEPATO");
            txtObesidad.Text = controladorGenerales2.ObtenerTexto(id, "obesidad", "DATOSGNANTEPATO");
            txtHipertension.Text = controladorGenerales2.ObtenerTexto(id, "hipertension", "DATOSGNANTEPATO");
            txtEnfTir.Text = controladorGenerales2.ObtenerTexto(id, "enfermedadesTir", "DATOSGNANTEPATO");
            txtHiperlipidemias.Text = controladorGenerales2.ObtenerTexto(id, "hiperlipidemias", "DATOSGNANTEPATO");
            txtOtra.Text = controladorGenerales2.ObtenerTexto(id, "otra", "DATOSGNANTEPATO");
            txtEjercicio.Text = controladorGenerales2.ObtenerTexto(id, "ejercicio", "DATOSGNANTENOPATO");
            txtDuracion.Text = controladorGenerales2.ObtenerTexto(id, "duracion", "DATOSGNANTENOPATO");
            txtFrecuencia.Text = controladorGenerales2.ObtenerTexto(id, "frecuencia", "DATOSGNANTENOPATO");
            txtAlcohol.Text = controladorGenerales2.ObtenerTexto(id, "alcohol", "DATOSGNANTENOPATO");
            txtTabaco.Text = controladorGenerales2.ObtenerTexto(id, "tabaco", "DATOSGNANTENOPATO");
            txtToxicomanias.Text = controladorGenerales2.ObtenerTexto(id, "toxicomanias", "DATOSGNANTENOPATO");
            txtTrigliceridos.Text = controladorGenerales2.ObtenerTexto(id, "trigliceridos", "DATOSGNINDBIO");
            txtHemoglobina.Text = controladorGenerales2.ObtenerTexto(id, "hemoglobina", "DATOSGNINDBIO");
            txtColesterol.Text = controladorGenerales2.ObtenerTexto(id, "colesterol", "DATOSGNINDBIO");
            txtGlucosa.Text = controladorGenerales2.ObtenerTexto(id, "glucosa", "DATOSGNINDBIO");
            txtCreatinina.Text = controladorGenerales2.ObtenerTexto(id, "creatinina", "DATOSGNINDBIO");
            txtNitrogenoUreico.Text = controladorGenerales2.ObtenerTexto(id, "nitUreico", "DATOSGNINDBIO");
        }

        private void txtDiabetes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCancer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtObesidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHipertension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnfTir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHiperlipidemias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEjercicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAlcohol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTabaco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtToxicomanias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTrigliceridos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHemoglobina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtColesterol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGlucosa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCreatinina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNitrogenoUreico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
