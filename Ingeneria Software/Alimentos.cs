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
                    txtGrasa.Text = "";
                    txtEnergia.Text = "";
                    txtHidratos.Text = "";
                    txtNombre.Text = "";
                    txtProteinas.Text = "";
            
                    dataGridView1.DataSource = controladorAlimentos.GetTable();
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
                        controladorAlimentos.ModificarAlimento(txtNombreMod.Text, txtEnergiaMod.Text, txtHidratosMod.Text, txtGrasaMod.Text, txtProteinasMod.Text, id);
                        if (controladorAlimentos.error != "")
                        {
                            MessageBox.Show(controladorAlimentos.error);
                        }
                        else
                        {
                            id = 0;
                            txtEnergiaMod.Text = "";
                            txtGrasaMod.Text = "";
                            txtHidratosMod.Text = "";
                            txtNombreMod.Text = "";
                            txtProteinasMod.Text = "";

                            dataGridView1.DataSource = controladorAlimentos.GetTable();
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
                            id = 0;
                            txtEnergiaMod.Text = "";
                            txtGrasaMod.Text = "";
                            txtHidratosMod.Text = "";
                            txtNombreMod.Text = "";
                            txtProteinasMod.Text = "";
                            dataGridView1.DataSource = controladorAlimentos.GetTable();
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
                txtNombreMod.Text = controladorAlimento.ObtenerNombre(id);
                txtEnergiaMod.Text = controladorAlimento.ObtenerEnergia(id).ToString();
                txtHidratosMod.Text = controladorAlimento.ObtenerHidratos(id).ToString();
                txtGrasaMod.Text = controladorAlimento.ObtenerGrasa(id).ToString();
                txtProteinasMod.Text = controladorAlimento.ObtenerProteinas(id).ToString();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnergia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHidratos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGrasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProteinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnergiaMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHidratosMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGrasaMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProteinasMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
