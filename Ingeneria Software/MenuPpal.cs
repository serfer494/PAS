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
using WindowsFormsApp1;
using MODELO;

namespace Ingeneria_Software
{
    //Strategy
    /// <summary>
    /// En la pantalla MenuPpal esta la interfaz principal del sistema, de donde se podra acceder a los
    ///  diferentes modulos del sistema.
    /// </summary>
    public partial class MenuPpal : Form
    {
        public MenuPpal(int tipo)
        {
            
            InitializeComponent();
            panel1.Visible = false;
            this.tipo = tipo;
            if(tipo == 2)
            {
                alimentos.Visible = false;
                Comidas.Visible = false;
                label1.Visible = false;
                cbxCliente.Visible = false;
                btnEliminar.Visible = false;
                btnSeleccionar.Visible = false;
                button2.Visible = false;
                btnDB.Visible = false;
            }
            
        }

        public MenuPpal()
        {

            InitializeComponent();
            panel1.Visible = false;
        }

        int tipo;
        private int id;

        private void AbrirFormHija(object form)
        {
            if (this.cont.Controls.Count>0)
            {
                this.cont.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.cont.Controls.Add(fh);
            this.cont.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void agenda_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Citas());
        }

        private void Bases_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void selec_Click(object sender, EventArgs e)
        {
            if(cbxCliente.SelectedIndex == 0)
            {
                NuevoCliente nc = new NuevoCliente();
                nc.Show();
            }
            else
            {
                
                
                panel1.Visible = true;
            }
            
        }

        private void alimentos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Alimentos());
        }

        private void Comidas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Comida());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DatosxCita(id));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cadena = cbxCliente.Text;
            AbrirFormHija(new Plan(cadena));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DatosGenerales(id));
        }

        private void cont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPpal_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine("Conexion aceptada");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            
            FillClients();
        }

        public void ActualizarClientes()
        {

        }

        public void FillClients()
        {
            cbxCliente.Items.Clear();
            cbxCliente.Text = "";
            cbxCliente.Items.Add("Nuevo cliente");
            string query = "SELECT nombrePaciente FROM PACIENTE";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cbxCliente.Items.Add(reader["nombrePaciente"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            string str = cbxCliente.SelectedItem.ToString();
            label2.Text = str;
            string query = "SELECT idPaciente FROM PACIENTE WHERE nombrePaciente=@nombre";
            using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = str;
                        id = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillClients();
        }

        private void MenuPpal_Activated(object sender, EventArgs e)
        {
            FillClients();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cbxCliente.SelectedIndex > 0)
            {
                DialogResult res = MessageBox.Show("Esta seguro que desea eliminar este cliente?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.OK)
                {
                    string query = "DELETE FROM DATOSCT WHERE idPaciente=@id";

                    using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                    {
                        try
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                        }
                    }

                    query = "DELETE FROM DATOSGNANTENOPATO WHERE idpaciente=@id";
                    using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                    {
                        try
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                        }
                    }

                    query = "DELETE FROM DATOSGNANTEPATO WHERE idPaciente=@id";
                    using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                    {
                        try
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                        }
                    }

                    query = "DELETE FROM DATOSGNINDBIO WHERE idPaciente=@id";
                    using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                    {
                        try
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                        }
                    }

                    query = "DELETE FROM DATOSGNINDDIE WHERE idPaciente=@id";
                    using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                    {
                        try
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                        }
                    }

                    query = "DELETE FROM PACIENTE WHERE idPaciente=@id";
                    using (SqlConnection conexion = new SqlConnection(Conexion.ObtenerConexion()))
                    {
                        try
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                            {
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.ToString());
                        }
                    }
                    FillClients();
                    cbxCliente.SelectedIndex = 0;
                    MessageBox.Show("Cliente eliminado");
                    AbrirFormHija(new Form1());
                }
                    
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
                cbxCliente.SelectedIndex = 0;
            }
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            BDRespaldo respaldo = new BDRespaldo(tipo);
            respaldo.ShowDialog(this);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Inicio inicio = new Inicio();
                inicio.Show();
                this.Close();
            }
        }
    }
}
