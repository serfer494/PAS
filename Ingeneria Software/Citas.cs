using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace Ingeneria_Software
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        
        private DateTime date;
        private int id = 0;

        private void Citas_Load(object sender, EventArgs e)
        {
            GetDates();
            date = monthMod.SelectionStart;
            var controladorCitas = new ControladorCitas();
            dataGridView1.DataSource = controladorCitas.GetTable(date);
            
        }

        private void GetDates()
        {
            var controladorCitas = new ControladorCitas();
            monthMod.BoldedDates = controladorCitas.GetDates();
        }

        

        private void btnNueva_Click(object sender, EventArgs e)
        {
            var controladorCitas = new ControladorCitas();
            controladorCitas.AgregarCita(monthNuevo.SelectionStart, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtHora.Text);
            GetDates();
            dataGridView1.DataSource = controladorCitas.GetTable(date);
        }

        private void monthMod_DateSelected(object sender, DateRangeEventArgs e)
        {
            var controladorCitas = new ControladorCitas();
            date = monthMod.SelectionStart;
            dataGridView1.DataSource = controladorCitas.GetTable(date);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var controladorCitas = new ControladorCitas();
            controladorCitas.ModificarCita(dtpFecha.Value, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtHora.Text, id);
            id = 0;
            txtNombreMod.Text = "";
            txtApellidoMod.Text = "";
            txtTelefonoMod.Text = "";
            txtHoraMod.Text = "";
            GetDates();
            dataGridView1.DataSource = controladorCitas.GetTable(date);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string hora = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            var controladorCitas = new ControladorCitas();
            id = controladorCitas.ObtenerId(hora);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
            var controladorCitas = new ControladorCitas();
            controladorCitas.EliminarCita(id);
            id = 0;
            txtNombreMod.Text = "";
            txtApellidoMod.Text = "";
            txtTelefonoMod.Text = "";
            txtHoraMod.Text = "";
            GetDates();
            dataGridView1.DataSource = controladorCitas.GetTable(date);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void txtNombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHoraMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }
    }
}
