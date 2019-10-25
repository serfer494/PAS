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

namespace Ingeneria_Software
{
    public partial class Alimentos : Form
    {
        public Alimentos()
        {
            InitializeComponent();
        }
        private string connectionString = "server=DESKTOP-RKNO24A; database=DBPAS; integrated security=true";
        private string provider;
        //private string connectionString;
        DbProviderFactory factory;
        private DbConnection connection;
        private string nombre;
        private string energia;
        private string hidratos;
        private string grasa;
        private string proteinas;
        private void Alimentos_Load(object sender, EventArgs e)
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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {          
            string query = "INSERT INTO ALIMENTO ([nombreAlimento], [energia], " +
                "[hidratosCarbono], [grasa], [proteinas]) VALUES(@nombre,@energia," +
                "@hidratos,@grasa,@proteinas)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                        cmd.Parameters.Add("@energia", SqlDbType.Int).Value = Convert.ToInt32(txtEnergia.Text);
                        cmd.Parameters.Add("@hidratos", SqlDbType.Int).Value = Convert.ToInt32(txtHidratos.Text);
                        cmd.Parameters.Add("@grasa", SqlDbType.Int).Value = Convert.ToInt32(txtGrasa.Text);
                        cmd.Parameters.Add("@proteinas", SqlDbType.Int).Value = Convert.ToInt32(txtProteinas.Text);
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if(rowsAdded > 0)
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
        }
    }
}
