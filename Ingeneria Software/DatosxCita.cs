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

namespace Ingeneria_Software
{
    public partial class DatosxCita : Form
    {
        public DatosxCita(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private string connectionString = "server=DESKTOP-RKNO24A; database=DBPAS; integrated security=true";
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
            using (SqlConnection conexion = new SqlConnection(connectionString))
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
            dataGridView1.DataSource = GetTable();
        }

        private DataTable GetTable()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT peso AS 'Peso', imc AS 'IMC', porcGrasa AS '% Grasa', porcMusculo AS '% Musculo', " +
                "grasaVisceral AS 'Grasa Visceral', cmb AS 'CMB', cirCadera AS 'Cir. Cadera', cirCintura AS 'Cir. Cintura', " +
                "bodyAge AS 'Body Age', fechaCita AS 'Fecha de la cita' FROM DATOSCT, PACIENTE WHERE DATOSCT.idPaciente=@id AND " +
                "PACIENTE.idPaciente=@id";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {                        
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        SqlDataReader reader = cmd.ExecuteReader();
                        tabla.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            return tabla;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DATOSCT ([grasaVisceral], [cmb], [cirCadera], [bodyAge], [cirCintura], [porcMusculo], " +
                "[porcGrasa], [imc], [peso], [fechaCita], [idPaciente]) VALUES(@grasavis,@cmb,@cirCad,@bodyage,@circin," +
                "@porcmus,@porcgra,@imc,@peso,@cita,@idpac)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@grasavis", SqlDbType.Float).Value = txtGrasaVis.Text;
                        cmd.Parameters.Add("@cmb", SqlDbType.Float).Value = txtCMB.Text;
                        cmd.Parameters.Add("@cirCad", SqlDbType.Float).Value = txtCirCad.Text;
                        cmd.Parameters.Add("@bodyage", SqlDbType.Int).Value = Convert.ToInt32(txtBodyAge.Text);
                        cmd.Parameters.Add("@circin", SqlDbType.Float).Value = txtCirCin.Text;
                        cmd.Parameters.Add("@porcmus", SqlDbType.Int).Value = Convert.ToInt32(txtMusculoPorc.Text);
                        cmd.Parameters.Add("@porcgra", SqlDbType.Int).Value = Convert.ToInt32(txtGrasaPorc.Text);
                        cmd.Parameters.Add("@imc", SqlDbType.Float).Value = txtIMC.Text;
                        cmd.Parameters.Add("@peso", SqlDbType.Float).Value = txtPeso.Text;
                        cmd.Parameters.Add("@cita", SqlDbType.DateTime2).Value = dtpFecha.Value;
                        cmd.Parameters.Add("@idpac", SqlDbType.Int).Value = id;

                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            Console.WriteLine("Filas insertadas");
                        }
                        else
                        {
                            Console.WriteLine("No se insertaron las filas");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            txtBodyAge.Text = "";
            txtCirCad.Text = "";
            txtCirCin.Text = "";
            txtCMB.Text = "";
            txtGrasaPorc.Text = "";
            txtGrasaVis.Text = "";
            txtIMC.Text = "";
            txtMusculoPorc.Text = "";
            txtPeso.Text = "";

            dataGridView1.DataSource = GetTable();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = "UPDATE DATOSCT SET grasaVisceral=@grasavis , cmb=@cmb , cirCadera=@cirCad , " +
                "bodyAge=@bodyage , cirCintura=@circin , porcMusculo=@porcmus , porcGrasa=@porcgra , " +
                "imc=@imc , peso=@peso , fechaCita=@cita WHERE idPaciente=@idpac AND idDatosCt=@idDatos";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@grasavis", SqlDbType.Float).Value = txtGrasaVisMod.Text;
                        cmd.Parameters.Add("@cmb", SqlDbType.Float).Value = txtCMBMod.Text;
                        cmd.Parameters.Add("@cirCad", SqlDbType.Float).Value = txtCirCadMod.Text;
                        cmd.Parameters.Add("@bodyage", SqlDbType.Int).Value = Convert.ToInt32(txtBodyAgeMod.Text);
                        cmd.Parameters.Add("@circin", SqlDbType.Float).Value = txtCirCinMod.Text;
                        cmd.Parameters.Add("@porcmus", SqlDbType.Int).Value = Convert.ToInt32(txtMusculoPorcMod.Text);
                        cmd.Parameters.Add("@porcgra", SqlDbType.Int).Value = Convert.ToInt32(txtGrasaPorcMod.Text);
                        cmd.Parameters.Add("@imc", SqlDbType.Float).Value = txtIMCMod.Text;
                        cmd.Parameters.Add("@peso", SqlDbType.Float).Value = txtPesoMod.Text;
                        cmd.Parameters.Add("@cita", SqlDbType.DateTime).Value = dtpFechaMod.Value;
                        cmd.Parameters.Add("@idpac", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@idDatos", SqlDbType.Int).Value = idCita;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            txtBodyAgeMod.Text = "";
            txtCirCadMod.Text = "";
            txtCirCinMod.Text = "";
            txtCMBMod.Text = "";
            txtGrasaPorcMod.Text = "";
            txtGrasaVisMod.Text = "";
            txtIMCMod.Text = "";
            txtMusculoPorcMod.Text = "";
            txtPesoMod.Text = "";
            dataGridView1.DataSource = GetTable();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM DATOSCT WHERE idPaciente=@idpac AND idDatosCt=@idcita";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@idpac", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@idcita", SqlDbType.Int).Value = idCita;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
            txtBodyAgeMod.Text = "";
            txtCirCadMod.Text = "";
            txtCirCinMod.Text = "";
            txtCMBMod.Text = "";
            txtGrasaPorcMod.Text = "";
            txtGrasaVisMod.Text = "";
            txtIMCMod.Text = "";
            txtMusculoPorcMod.Text = "";
            txtPesoMod.Text = "";
            dataGridView1.DataSource = GetTable();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DateTime date = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[9].Value);
            string query = "SELECT idDatosCt FROM DATOSCT WHERE idPaciente=@id AND fechaCita=@fecha";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = date;
                        idCita = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }
    }
}
