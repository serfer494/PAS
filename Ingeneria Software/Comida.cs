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
    /// En la pantalla de comida se pueden agregar, modificar o eliminar los diferentes platillos que se
    /// encuentran en el sistema
    /// </summary>
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }

        int id1 = 0;
        int id2 = 0;
        int id3 = 0;
        int id4 = 0;
        int id5 = 0;
        int idMod1 = 0;
        int idMod2 = 0;
        int idMod3 = 0;
        int idMod4 = 0;
        int idMod5 = 0;
        int idComida = 0;
        int idAlimento = 0;
        int idComidaAlimento = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Es el constructor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Comida_Load(object sender, EventArgs e)
        {
            cbxAlimento1.Items.Add("Ninguno");
            cbxAlimento2.Items.Add("Ninguno");
            cbxAlimento3.Items.Add("Ninguno");
            cbxAlimento4.Items.Add("Ninguno");
            cbxAlimento5.Items.Add("Ninguno");
            cbxAlimento1Mod.Items.Add("Ninguno");
            var controladorComida = new ControladorComida();
            List<string> comida = new List<string>();
            comida = controladorComida.ObtenerAlimentos();
            foreach(string itemComida in comida)
            {
                cbxAlimento1.Items.Add(itemComida);
                cbxAlimento2.Items.Add(itemComida);
                cbxAlimento3.Items.Add(itemComida);
                cbxAlimento4.Items.Add(itemComida);
                cbxAlimento5.Items.Add(itemComida);
                cbxAlimento1Mod.Items.Add(itemComida);
            }
            Limpiar();
            dgvAlimento.DataSource = controladorComida.GetTable();
            this.Activate();
            this.BringToFront();
            this.Focus();
        }

        private void cbxAlimento1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxAlimento1.SelectedIndex == 0)
            {
                id1 = 0;
            }
            else
            {
                string str = cbxAlimento1.SelectedItem.ToString();
                var controladorComida = new ControladorComida();
                id1 = controladorComida.ObtenerIdAlimento(str);
            }
            
        }

        private void cbxAlimento2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAlimento2.SelectedIndex == 0)
            {
                id2 = 0;
            }
            else
            {
                string str = cbxAlimento2.SelectedItem.ToString();
                var controladorComida = new ControladorComida();
                id2 = controladorComida.ObtenerIdAlimento(str);
            }
        }

        private void cbxAlimento3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAlimento3.SelectedIndex == 0)
            {
                id3 = 0;
            }
            else
            {
                string str = cbxAlimento3.SelectedItem.ToString();
                var controladorComida = new ControladorComida();
                id3 = controladorComida.ObtenerIdAlimento(str);
            }
        }

        private void cbxAlimento4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAlimento4.SelectedIndex == 0)
            {
                id4 = 0;
            }
            else
            {
                string str = cbxAlimento4.SelectedItem.ToString();
                var controladorComida = new ControladorComida();
                id4 = controladorComida.ObtenerIdAlimento(str);
            }
        }

        private void cbxAlimento5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAlimento5.SelectedIndex == 0)
            {
                id5 = 0;
            }
            else
            {
                string str = cbxAlimento5.SelectedItem.ToString();
                var controladorComida = new ControladorComida();
                id5 = controladorComida.ObtenerIdAlimento(str);
            }
        }

        /// <summary>
        /// Agrega un nuevo platillo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(id1 != 0 && txtPorcion1.Text == "" || id2 != 0 && txtPorcion2.Text == "" || id3 != 0 && txtPorcion3.Text == "" || id4 != 0 && txtPorcion4.Text == "" || id5 != 0 && txtPorcion5.Text == "")
            {
                MessageBox.Show("Se debe introducir una cantidad junto con el alimento");
            }
            else
            {
                var controladorComida = new ControladorComida();
                controladorComida.AgregarComida(txtNombre.Text, id1, id2, id3, id4, id5, txtPorcion1.Text, txtPorcion2.Text, txtPorcion3.Text, txtPorcion4.Text, txtPorcion5.Text);
                if (controladorComida.error == "")
                {

                    dgvAlimento.DataSource = controladorComida.GetTable();
                    MessageBox.Show("Comida Agregada");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(controladorComida.error);
                }
            }
        }

        private void dgvAlimento_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string str = dgvAlimento.Rows[dgvAlimento.SelectedRows[0].Index].Cells[0].Value.ToString();
                var controladorComida = new ControladorComida();
                idComida = controladorComida.ObtenerIdComida(str);
                str = dgvAlimento.Rows[dgvAlimento.SelectedRows[0].Index].Cells[1].Value.ToString();
                idAlimento = controladorComida.ObtenerIdAlimento(str);
                idComidaAlimento = controladorComida.ObtenerIdComidaIngrediente(idAlimento, idComida);
                if(idComida > 0)
                {
                    Rellenar();
                    btnEliminar.Visible = true;
                    btnModificar.Visible = true;
                }
                else
                {
                    Limpiar();
                    btnEliminar.Visible = false;
                    btnModificar.Visible = false;
                }
                Console.WriteLine(idComida);
                Console.WriteLine(idAlimento);
                Console.WriteLine(idComidaAlimento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Modifica un platillo existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(idComidaAlimento > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que desea modificar esta comida?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    var controladorComida = new ControladorComida();
                    string str = cbxAlimento1Mod.SelectedItem.ToString();
                    idAlimento = controladorComida.ObtenerIdAlimento(str);
                    controladorComida.ModificarComida(txtNombreMod.Text, idAlimento, idComida, txtPorcion1Mod.Text, idComidaAlimento);
                    if(controladorComida.error != "")
                    {
                        MessageBox.Show(controladorComida.error);
                    }
                    else
                    {
                        
                        dgvAlimento.DataSource = controladorComida.GetTable();
                        btnEliminar.Visible = false;
                        btnModificar.Visible = false;
                        MessageBox.Show("Comida modificada exitosamente");
                        Limpiar();
                        idComidaAlimento = 0;
                        idComida = 0;
                        idAlimento = 0;
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("Seleccione una comida a modificar");
            }
        }

        /// <summary>
        /// Elimina un platillo existente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(idComidaAlimento > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que quiere borrar la comida seleccionada?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    var controladorComida = new ControladorComida();
                    controladorComida.EliminarComida(idComida);
                    if(controladorComida.error != "")
                    {
                        MessageBox.Show(controladorComida.error);
                    }
                    else
                    {
                        
                        dgvAlimento.DataSource = controladorComida.GetTable();
                        btnEliminar.Visible = false;
                        btnModificar.Visible = false;
                        MessageBox.Show("Comida borrada exitosamente");
                        Limpiar();
                        idComida = 0;
                        idComidaAlimento = 0;
                        idAlimento = 0;
                    }
                    
                }                   
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar");
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
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcion3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcion4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcion5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite que se introduzcan solo digitos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPorcion1Mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreMod_TextChanged(object sender, EventArgs e)
        {
            
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

        private void label22_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Limpia los campos.
        /// </summary>
        private void Limpiar()
        {

            cbxAlimento1.SelectedIndex = 0;
            cbxAlimento2.SelectedIndex = 0;
            cbxAlimento3.SelectedIndex = 0;
            cbxAlimento4.SelectedIndex = 0;
            cbxAlimento5.SelectedIndex = 0;
            cbxAlimento1Mod.SelectedIndex = 0;
            txtPorcion1.Text = "";
            txtPorcion2.Text = "";
            txtPorcion3.Text = "";
            txtPorcion4.Text = "";
            txtPorcion5.Text = "";
            txtPorcion1Mod.Text = "";
        }

        /// <summary>
        /// Rellena los campos.
        /// </summary>
        private void Rellenar()
        {
            var controladorComida = new ControladorComida();
            txtNombreMod.Text = controladorComida.Obtener(idComida, "nombre", "COMIDA", "idComida");
            string alimento = controladorComida.Obtener(idAlimento, "nombreAlimento", "Alimento", "idAlimento");
            int indice = 0;
            foreach(string item in cbxAlimento1Mod.Items)
            {
                if(item == alimento)
                {
                    indice = cbxAlimento1Mod.Items.IndexOf(alimento);
                    break;
                }
            }
            cbxAlimento1Mod.SelectedIndex = indice;
            txtPorcion1Mod.Text = controladorComida.Obtener(idComidaAlimento, "cantidad", "COMIDA_INGREDIENTES", "idComidaAlimento");
        }
    }
}
