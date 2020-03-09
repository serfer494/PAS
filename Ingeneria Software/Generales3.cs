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
    /// En la pantalla Generales3 se pueden ingresar los indicadores dieteticos del usuario.
    /// </summary>
    public partial class Generales3 : Form
    {
        public Generales3(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;

        private void Generales3_Load(object sender, EventArgs e)
        {
            Rellenar();
        }

        private void dieteticos_Click(object sender, EventArgs e)
        {
            var controladorGenerales3 = new ControladorGenerales3();
            controladorGenerales3.AgregarIndicadoresDieteticos(txtComidasDia.Text, txtQuienComida.Text, txtComeFuera.Text, txtAlimentosPref.Text, txtAgua.Text, txtAlergias.Text, txtNotas.Text, txtRecordatorio.Text, id);
            if(controladorGenerales3.error != "")
            {
                MessageBox.Show(controladorGenerales3.error);
            }
            else
            {
                MessageBox.Show("Datos agregados exitosamente");
            }
        }

        private void regre_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Generales2(id));
            
            
        }

        private void AbrirFormHija(object form)
        {
            if (this.panelGenerales3.Controls.Count > 0)
            {
                this.panelGenerales3.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelGenerales3.Controls.Add(fh);
            this.panelGenerales3.Tag = fh;
            fh.Show();
            panelGenerales3.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var controladorGenerales3 = new ControladorGenerales3();
            controladorGenerales3.ModificarIndicadoresDieteticos(txtComidasDia.Text, txtQuienComida.Text, txtComeFuera.Text, txtAlimentosPref.Text, txtAgua.Text, txtAlergias.Text, txtNotas.Text, txtRecordatorio.Text, id);
            if (controladorGenerales3.error != "")
            {
                MessageBox.Show(controladorGenerales3.error);
            }
            else
            {
                MessageBox.Show("Datos modificados exitosamente");
            }

        }

        private void txtComidasDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuienComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComeFuera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAlimentosPref_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAgua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAlergias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRecordatorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Rellenar()
        {
            var controladorgenerales3 = new ControladorGenerales3();
            txtAgua.Text = controladorgenerales3.Obtener(id, "agua", "DATOSGNINDDIE", "idPaciente");
            txtAlergias.Text = controladorgenerales3.Obtener(id, "alergias", "DATOSGNINDDIE", "idPaciente");
            txtAlimentosPref.Text = controladorgenerales3.Obtener(id, "aliPreferidos", "DATOSGNINDDIE", "idPaciente");
            txtComeFuera.Text = controladorgenerales3.Obtener(id, "fueraCasa", "DATOSGNINDDIE", "idPaciente");
            txtNotas.Text = controladorgenerales3.Obtener(id, "notas", "DATOSGNINDDIE", "idPaciente");
            txtRecordatorio.Text = controladorgenerales3.Obtener(id, "agua", "DATOSGNINDDIE", "idPaciente");
            txtQuienComida.Text = controladorgenerales3.Obtener(id, "agua", "DATOSGNINDDIE", "idPaciente");
            txtComidasDia.Text = controladorgenerales3.Obtener(id, "numComidas", "DATOSGNINDDIE", "idPaciente");
        }
    }
}
