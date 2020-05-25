using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using CONTROLADOR;

namespace Ingeneria_Software
{
    /// <summary>
    /// En la pantalla Alimentos se encuentra la interfaz para agregar alimentos al sistema.
    /// </summary>
    public partial class Alimentos : Form
    {
        public Alimentos()
        {
            InitializeComponent();
        }
        int id;
        private void Alimentos_Load(object sender, EventArgs e)
        {
            var controladorAlimento = new ControladorAlimentos();
            dataGridView1.DataSource = controladorAlimento.GetTable();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var controladorAlimentos = new ControladorAlimentos();
                controladorAlimentos.AgregarAlimento(txtNombre.Text, txtEnergia.Text, txtHidratos.Text, txtGrasa.Text, txtProteinas.Text);
                if(controladorAlimentos.error != "")
                {
                    MessageBox.Show(controladorAlimentos.error);
                }
                else
                {
                    
                    dataGridView1.DataSource = controladorAlimentos.GetTable();
                    MessageBox.Show("Alimento agregado");
                    Limpiar();
                }
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(id > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que desea modificar este registro?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(res == DialogResult.OK)
                {
                    try
                    {
                        var controladorAlimentos = new ControladorAlimentos();
                        controladorAlimentos.ModificarAlimento(txtNombre.Text, txtEnergia.Text, txtHidratos.Text, txtGrasa.Text, txtProteinas.Text, id);
                        if (controladorAlimentos.error != "")
                        {
                            MessageBox.Show(controladorAlimentos.error);
                        }
                        else
                        {
                            
                            btnEliminar.Visible = false;
                            btnModificar.Visible = false;
                            dataGridView1.DataSource = controladorAlimentos.GetTable();
                            MessageBox.Show("Alimento modificado exitosamente");
                            Limpiar();
                        }

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro a modificar");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(id > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que quiere borrar el registro seleccionado?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(res == DialogResult.OK)
                {
                    try
                    {
                        var controladorAlimentos = new ControladorAlimentos();
                        controladorAlimentos.EliminarAlimento(id);
                        if(controladorAlimentos.error != "")
                        {
                            MessageBox.Show(controladorAlimentos.error);
                        }
                        else
                        {
                            
                            btnEliminar.Visible = false;
                            btnModificar.Visible = false;
                            dataGridView1.DataSource = controladorAlimentos.GetTable();
                            MessageBox.Show("Alimento eliminado exitosamente");
                            Limpiar();
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro a eliminar");
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string str = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                var controladorAlimento = new ControladorAlimentos();
                id = controladorAlimento.ObtenerId(str);
                if(id > 0)
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
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan letras y espacios al textbox.
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
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEnergia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHidratos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGrasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProteinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan letras o espacios al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEnergiaMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHidratosMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGrasaMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo solo permite que se introduzcan digitos al textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProteinasMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Este metodo limpia los campos.
        /// </summary>
        private void Limpiar()
        {
            id = 0;
            txtEnergia.Text = "";
            txtGrasa.Text = "";
            txtHidratos.Text = "";
            txtNombre.Text = "";
            txtProteinas.Text = "";
        }

        /// <summary>
        /// Rellena los campos con el item seleccionado.
        /// </summary>
        private void Rellenar()
        {
            var controladorCitas = new ControladorCitas();
            txtNombre.Text = controladorCitas.Obtener(id, "nombreAlimento", "ALIMENTO", "idAlimento");
            txtEnergia.Text = controladorCitas.Obtener(id, "energia", "ALIMENTO", "idAlimento");
            txtGrasa.Text = controladorCitas.Obtener(id, "grasa", "ALIMENTO", "idAlimento");
            txtHidratos.Text = controladorCitas.Obtener(id, "hidratosCarbono", "ALIMENTO", "idAlimento");
            txtProteinas.Text = controladorCitas.Obtener(id, "proteinas", "ALIMENTO", "idAlimento");
        }
    }
}
