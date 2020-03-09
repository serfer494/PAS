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
    /// <summary>
    /// En la pantalla de citas se pueden agregar, modificar o eliminar citas.
    /// </summary>
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        
        private DateTime date;
        private int id = 0;
        private int numeros = 0;

        private void Citas_Load(object sender, EventArgs e)
        {
            GetDates();
            date = monthMod.SelectionStart;
            var controladorCitas = new ControladorCitas();
            dataGridView1.DataSource = controladorCitas.GetTable(date);
            
        }

        /// <summary>
        /// Carga las citas de la base de datos
        /// </summary>
        private void GetDates()
        {
            var controladorCitas = new ControladorCitas();
            monthMod.BoldedDates = controladorCitas.GetDates();
        }

        
        /// <summary>
        /// Agrega una nueva cita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNueva_Click(object sender, EventArgs e)
        {
            var controladorCitas = new ControladorCitas();
            controladorCitas.AgregarCita(dtpFecha.Value, txtNombre.Text, txtApellido.Text, mtxtTelefono.Text, mtxtHora.Text);
            if(controladorCitas.error != "")
            {
                MessageBox.Show(controladorCitas.error);
            }
            else
            {
                GetDates();
                dataGridView1.DataSource = controladorCitas.GetTable(date);
                MessageBox.Show("Cita agregada exitosamente");
                Limpiar();
            }
            
        }

        private void monthMod_DateSelected(object sender, DateRangeEventArgs e)
        {
            var controladorCitas = new ControladorCitas();
            date = monthMod.SelectionStart;
            dataGridView1.DataSource = controladorCitas.GetTable(date);
        }

        /// <summary>
        /// Modifica una cita.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro que quiere modificar la cita seleccionada?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                var controladorCitas = new ControladorCitas();
                controladorCitas.ModificarCita(dtpFecha.Value, txtNombre.Text, txtApellido.Text, mtxtTelefono.Text, mtxtHora.Text, id);
                if (controladorCitas.error != "")
                {
                    MessageBox.Show(controladorCitas.error);
                }
                else
                {
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    GetDates();
                    dataGridView1.DataSource = controladorCitas.GetTable(date);
                    MessageBox.Show("Cita modificada exitosamente");
                    Limpiar();
                }
            }
            
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string hora = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            var controladorCitas = new ControladorCitas();
            id = controladorCitas.ObtenerId(hora);
            if(id > 0)
            {
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                Rellenar();
            }
            else
            {
                Limpiar();
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
            }
        }

        /// <summary>
        /// Elimina una cita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        { 
            if(id > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que quiere borrar la cita seleccionada?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    var controladorCitas = new ControladorCitas();
                    controladorCitas.EliminarCita(id);
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                    Limpiar();
                    GetDates();
                    dataGridView1.DataSource = controladorCitas.GetTable(date);
                    MessageBox.Show("Cita eliminada exitosamente");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita");
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
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
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
        /// Permite que se introduzcan letras o digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo letras y espacios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreMod_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtApellidoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefonoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan letras o digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHoraMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Limpia los campos.
        /// </summary>
        private void Limpiar()
        {
            id = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtTelefono.Text = "";
            mtxtHora.Text = "";
        }

        /// <summary>
        /// Rellena los campos.
        /// </summary>
        private void Rellenar()
        {
            var controladorCitas = new ControladorCitas();
            txtNombre.Text = controladorCitas.Obtener(id, "nombre", "AGENDA", "idAgenda");
            txtApellido.Text = controladorCitas.Obtener(id, "apellido", "AGENDA", "idAgenda");
            mtxtTelefono.Text = controladorCitas.Obtener(id, "telefono", "AGENDA", "idAgenda");
            mtxtHora.Text = controladorCitas.Obtener(id, "hora", "AGENDA", "idAgenda");
            dtpFecha.Value = controladorCitas.ObtenerFecha(id, "fechaAgenda", "AGENDA", "idAgenda");
        }

        private void mtxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                numeros++;
            }

            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Cancel || e.KeyChar == '8')
            {
                e.Handled = true;
                numeros--;
            }
        }


        private void mtxtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                numeros++;
            }

            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Cancel || e.KeyChar == '8')
            {
                e.Handled = true;
                numeros--;
            }
        }
    }
}
