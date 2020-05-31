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
    /// En la pantalla DatosxCita se ingresan los datos del paciente cuando va a la cita.
    /// </summary>
    public partial class DatosxCita : Form
    {
        public DatosxCita(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        int id;
        int idCita;
        DateTime fechaCita;

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPpal mp = new MenuPpal();
            this.Close();
            mp.Show();
        }

        private void newIMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosxCita_Load(object sender, EventArgs e)
        {
            var controladordc = new ControladorDatosxCita();
            dataGridView1.DataSource = controladordc.GetTable(id);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var controladordc = new ControladorDatosxCita();
                controladordc.AgregarDatosCita(txtGrasaVis.Text, txtCMB.Text, txtCirCad.Text, txtBodyAge.Text, txtCirCin.Text, txtMusculoPorc.Text, txtGrasaPorc.Text, txtIMC.Text, txtPeso.Text, DateTime.Now, id);
                if (controladordc.error != "")
                {
                    MessageBox.Show(controladordc.error);
                }
                else
                {
                    
                    dataGridView1.DataSource = controladordc.GetTable(id);
                    
                    MessageBox.Show("Datos agregados exitosamente");
                    Limpiar();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que quiere modificar el registro seleccionado?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        var controladordc = new ControladorDatosxCita();
                        controladordc.ModificarDatosCita(txtGrasaVis.Text, txtCMB.Text, txtCirCad.Text, txtBodyAge.Text, txtCirCin.Text, txtMusculoPorc.Text, txtGrasaPorc.Text, txtIMC.Text, txtPeso.Text, DateTime.Now, id, idCita);
                        if (controladordc.error != "")
                        {
                            MessageBox.Show(controladordc.error);
                        }
                        else
                        {
                            
                            dataGridView1.DataSource = controladordc.GetTable(id);
                            MessageBox.Show("Registro modificado exitosamente");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que quiere borrar el registro seleccionado?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        var controladordc = new ControladorDatosxCita();
                        controladordc.EliminarDatosCita(id, idCita);
                        if (controladordc.error != "")
                        {
                            MessageBox.Show(controladordc.error);
                        }
                        else
                        {
                            
                            dataGridView1.DataSource = controladordc.GetTable(id);
                            MessageBox.Show("Registro eliminado exitosamente");
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
            DateTime date = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[9].Value);
            try
            {
                var controladordc = new ControladorDatosxCita();
                idCita = controladordc.ObtenerId(id, date);
                if(idCita > 0)
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Limpiar()
        {
            txtBodyAge.Text = "";
            txtCirCad.Text = "";
            txtCirCin.Text = "";
            txtCMB.Text = "";
            txtGrasaPorc.Text = "";
            txtGrasaVis.Text = "";
            txtIMC.Text = "";
            txtMusculoPorc.Text = "";
            txtPeso.Text = "";
        }

        public void Rellenar()
        {
            var controladordc = new ControladorDatosxCita();
            txtBodyAge.Text = controladordc.Obtener(idCita, "bodyAge", "DATOSCT", "idDatosCt");
            txtCirCad.Text = controladordc.Obtener(idCita, "cirCadera", "DATOSCT", "idDatosCt");
            txtCirCin.Text = controladordc.Obtener(idCita, "cirCintura", "DATOSCT", "idDatosCt");
            txtCMB.Text = controladordc.Obtener(idCita, "cmb", "DATOSCT", "idDatosCt");
            txtGrasaPorc.Text = controladordc.Obtener(idCita, "porcGrasa", "DATOSCT", "idDatosCt");
            txtGrasaVis.Text = controladordc.Obtener(idCita, "grasaVisceral", "DATOSCT", "idDatosCt");
            txtIMC.Text = controladordc.Obtener(idCita, "imc", "DATOSCT", "idDatosCt");
            txtMusculoPorc.Text = controladordc.Obtener(idCita, "porcMusculo", "DATOSCT", "idDatosCt");
            txtPeso.Text = controladordc.Obtener(idCita, "peso", "DATOSCT", "idDatosCt");
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPeso.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtIMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtIMC.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtGrasaPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtGrasaPorc.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtMusculoPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMusculoPorc.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtGrasaVis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtGrasaVis.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCMB.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCirCad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCirCad.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCirCin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCirCin.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void txtBodyAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
