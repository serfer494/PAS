using Ingeneria_Software;
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
using System.IO;
using iText.Html2pdf;
using System.Collections;

namespace WindowsFormsApp1
{
    /// <summary>
    /// En esta pantalla se crea el plan alimenticio.
    /// </summary>
    public partial class Plan : Form
    {
        int caloriasLunes = 0;
        int caloriasMartes = 0;
        int caloriasMiercoles = 0;
        int caloriasJueves = 0;
        int caloriasViernes = 0;
        int caloriasSabado = 0;
        int caloriasDomingo = 0;
        Stack pilaLunesDesayuno = new Stack();
        Stack pilaLunesColacion = new Stack();
        Stack pilaLunesComida = new Stack();
        Stack pilaLunesColacion2 = new Stack();
        Stack pilaLunesCena = new Stack();
        Stack pilaMartesDesayuno = new Stack();
        Stack pilaMartesColacion = new Stack();
        Stack pilaMartesComida = new Stack();
        Stack pilaMartesColacion2 = new Stack();
        Stack pilaMartesCena = new Stack();
        Stack pilaMiercolesDesayuno = new Stack();
        Stack pilaMiercolesColacion = new Stack();
        Stack pilaMiercolesComida = new Stack();
        Stack pilaMiercolesColacion2 = new Stack();
        Stack pilaMiercolesCena = new Stack();
        Stack pilaJuevesDesayuno = new Stack();
        Stack pilaJuevesColacion = new Stack();
        Stack pilaJuevesComida = new Stack();
        Stack pilaJuevesColacion2 = new Stack();
        Stack pilaJuevesCena = new Stack();
        Stack pilaViernesDesayuno = new Stack();
        Stack pilaViernesColacion = new Stack();
        Stack pilaViernesComida = new Stack();
        Stack pilaViernesColacion2 = new Stack();
        Stack pilaViernesCena = new Stack();
        Stack pilaSabadoDesayuno = new Stack();
        Stack pilaSabadoColacion = new Stack();
        Stack pilaSabadoComida = new Stack();
        Stack pilaSabadoColacion2 = new Stack();
        Stack pilaSabadoCena = new Stack();
        Stack pilaDomingoDesayuno = new Stack();
        Stack pilaDomingoColacion = new Stack();
        Stack pilaDomingoComida = new Stack();
        Stack pilaDomingoColacion2 = new Stack();
        Stack pilaDomingoCena = new Stack();
        string nombrePaciente;
        public Plan(string cadena)
        {
            InitializeComponent();
            if (cadena == "Nuevo cliente") nombrePaciente = "";
            else nombrePaciente = cadena;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RellenarComidas();
            pilaLunesDesayuno.Push(0);
            pilaLunesColacion.Push(0);
            pilaLunesComida.Push(0);
            pilaLunesColacion2.Push(0);
            pilaLunesCena.Push(0);
            pilaMartesDesayuno.Push(0);
            pilaMartesColacion.Push(0);
            pilaMartesComida.Push(0);
            pilaMartesColacion2.Push(0);
            pilaMartesCena.Push(0);
            pilaMiercolesDesayuno.Push(0);
            pilaMiercolesColacion.Push(0);
            pilaMiercolesComida.Push(0);
            pilaMiercolesColacion2.Push(0);
            pilaMiercolesCena.Push(0);
            pilaJuevesDesayuno.Push(0);
            pilaJuevesColacion.Push(0);
            pilaJuevesComida.Push(0);
            pilaJuevesColacion2.Push(0);
            pilaJuevesCena.Push(0);
            pilaViernesDesayuno.Push(0);
            pilaViernesColacion.Push(0);
            pilaViernesComida.Push(0);
            pilaViernesColacion2.Push(0);
            pilaViernesCena.Push(0);
            pilaSabadoDesayuno.Push(0);
            pilaSabadoColacion.Push(0);
            pilaSabadoComida.Push(0);
            pilaSabadoColacion2.Push(0);
            pilaSabadoCena.Push(0);
            pilaDomingoDesayuno.Push(0);
            pilaDomingoColacion.Push(0);
            pilaDomingoComida.Push(0);
            pilaDomingoColacion2.Push(0);
            pilaDomingoCena.Push(0);
        }

        private void RellenarComidas()
        {
            cmbLunesDesayuno.Items.Add("Ninguno");
            cmbLunesColacion.Items.Add("Ninguno");
            cmbLunesComida.Items.Add("Ninguno");
            cmbLunesColacion2.Items.Add("Ninguno");
            cmbLunesCena.Items.Add("Ninguno");
            cmbMartesDesayuno.Items.Add("Ninguno");
            cmbMartesColacion.Items.Add("Ninguno");
            cmbMartesComida.Items.Add("Ninguno");
            cmbMartesColacion2.Items.Add("Ninguno");
            cmbMartesCena.Items.Add("Ninguno");
            cmbMiercolesDesayuno.Items.Add("Ninguno");
            cmbMiercolesColacion.Items.Add("Ninguno");
            cmbMiercolesComida.Items.Add("Ninguno");
            cmbMiercolesColacion2.Items.Add("Ninguno");
            cmbMiercolesCena.Items.Add("Ninguno");
            cmbJuevesDesayuno.Items.Add("Ninguno");
            cmbJuevesColacion.Items.Add("Ninguno");
            cmbJuevesComida.Items.Add("Ninguno");
            cmbJuevesColacion2.Items.Add("Ninguno");
            cmbJuevesCena.Items.Add("Ninguno");
            cmbViernesDesayuno.Items.Add("Ninguno");
            cmbViernesColacion.Items.Add("Ninguno");
            cmbViernesComida.Items.Add("Ninguno");
            cmbViernesColacion2.Items.Add("Ninguno");
            cmbViernesCena.Items.Add("Ninguno");
            cmbSabadoDesayuno.Items.Add("Ninguno");
            cmbSabadoColacion.Items.Add("Ninguno");
            cmbSabadoComida.Items.Add("Ninguno");
            cmbSabadoColacion2.Items.Add("Ninguno");
            cmbSabadoCena.Items.Add("Ninguno");
            cmbDomingoDesayuno.Items.Add("Ninguno");
            cmbDomingoColacion.Items.Add("Ninguno");
            cmbDomingoComida.Items.Add("Ninguno");
            cmbDomingoColacion2.Items.Add("Ninguno");
            cmbDomingoCena.Items.Add("Ninguno");
            var controladorPlan = new ControladorPlan();
            List<string> comida = new List<string>();
            comida = controladorPlan.ObtenerComidas();
            foreach (string itemComida in comida)
            {
                cmbLunesDesayuno.Items.Add(itemComida);
                cmbLunesColacion.Items.Add(itemComida);
                cmbLunesComida.Items.Add(itemComida);
                cmbLunesColacion2.Items.Add(itemComida);
                cmbLunesCena.Items.Add(itemComida);
                cmbMartesDesayuno.Items.Add(itemComida);
                cmbMartesColacion.Items.Add(itemComida);
                cmbMartesComida.Items.Add(itemComida);
                cmbMartesColacion2.Items.Add(itemComida);
                cmbMartesCena.Items.Add(itemComida);
                cmbMiercolesDesayuno.Items.Add(itemComida);
                cmbMiercolesColacion.Items.Add(itemComida);
                cmbMiercolesComida.Items.Add(itemComida);
                cmbMiercolesColacion2.Items.Add(itemComida);
                cmbMiercolesCena.Items.Add(itemComida);
                cmbJuevesDesayuno.Items.Add(itemComida);
                cmbJuevesColacion.Items.Add(itemComida);
                cmbJuevesComida.Items.Add(itemComida);
                cmbJuevesColacion2.Items.Add(itemComida);
                cmbJuevesCena.Items.Add(itemComida);
                cmbViernesDesayuno.Items.Add(itemComida);
                cmbViernesColacion.Items.Add(itemComida);
                cmbViernesComida.Items.Add(itemComida);
                cmbViernesColacion2.Items.Add(itemComida);
                cmbViernesCena.Items.Add(itemComida);
                cmbSabadoDesayuno.Items.Add(itemComida);
                cmbSabadoColacion.Items.Add(itemComida);
                cmbSabadoComida.Items.Add(itemComida);
                cmbSabadoColacion2.Items.Add(itemComida);
                cmbSabadoCena.Items.Add(itemComida);
                cmbDomingoDesayuno.Items.Add(itemComida);
                cmbDomingoColacion.Items.Add(itemComida);
                cmbDomingoComida.Items.Add(itemComida);
                cmbDomingoColacion2.Items.Add(itemComida);
                cmbDomingoCena.Items.Add(itemComida);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuPpal mp = new MenuPpal(1);
            this.Close();
            mp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool ChecarComidasCmb()
        {
            if(rtxtLunesDesayuno.Text != "" && rtxtLunesColacion.Text != "" && rtxtLunesComida.Text != "" &&
               rtxtLunesColacion2.Text != "" && rtxtLunesCena.Text != "" && rtxtMartesDesayuno.Text != "" &&
               rtxtMartesColacion.Text != "" && rtxtMartesComida.Text != "" && rtxtMartesColacion2.Text != "" &&
               rtxtMartesCena.Text != "" && rtxtMiercolesDesayuno.Text != "" && rtxtMiercolesColacion.Text != "" &&
               rtxtMiercolesComida.Text != "" && rtxtMiercolesColacion2.Text != "" && rtxtMiercolesCena.Text != "" && 
               rtxtJuevesDesayuno.Text != "" && rtxtJuevesColacion.Text != "" && rtxtJuevesComida.Text != "" &&
               rtxtJuevesColacion2.Text != "" && rtxtJuevesCena.Text != "" && rtxtViernesDesayuno.Text != "" &&
               rtxtViernesColacion.Text != "" && rtxtViernesComida.Text != "" && rtxtViernesColacion2.Text != "" &&
               rtxtViernesCena.Text != "" && rtxtSabadoDesayuno.Text != "" && rtxtSabadoColacion.Text != "" &&
               rtxtSabadoComida.Text != "" && rtxtSabadoColacion2.Text != "" && rtxtSabadoCena.Text != "" && 
               rtxtDomingoDesayuno.Text != "" && rtxtDomingoColacion.Text != "" && rtxtDomingoComida.Text != "" &&
               rtxtDomingoColacion2.Text != "" && rtxtDomingoCena.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ChecarRecomendaciones()
        {
            if(rtxtRecordatorio.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ChecarComidasCmb())
            {
                if (dtpFecha.Value.DayOfWeek.ToString() == "Monday")
                {
                    string diaSemana = dtpFecha.Value.DayOfWeek.ToString();
                    string dia = dtpFecha.Value.Day.ToString();
                    int mes = dtpFecha.Value.Month;
                    int anno = dtpFecha.Value.Year;
                    string diaDomingo = dtpFecha.Value.AddDays(6).Day.ToString();
                    int diaDomingoMes = dtpFecha.Value.AddDays(6).Month;
                    string fecha = "Del lunes " + dia + " de " + Mes(mes) + " al domingo " + diaDomingo + " de " + Mes(diaDomingoMes);
                    string archivo = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    string fileName = @"./Planes/" + nombrePaciente + "/" + archivo + ".html";
                    string directorio = @"./Planes/" + nombrePaciente;
                    if (Directory.Exists(directorio))
                    {
                        CrearPlan(fileName, fecha, archivo);
                        MessageBox.Show("Plan alimenticio creado");
                    }
                    else
                    {
                        Directory.CreateDirectory(directorio);
                        CrearPlan(fileName, fecha, archivo);
                        MessageBox.Show("Plan alimenticio creado");
                    }
                }
                else
                {
                    MessageBox.Show("Eliga el dia lunes en el que se empezara el plan alimenticio");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos de comida");
            }
        }

        private void CrearPlan(string fileName, string fecha, string archivo)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("<!DOCTYPE html>\n<html>\n\t<head>\n\t\t<meta charset=\"utf-8\">\n\t\t<title>" +
                    "Prueba de archivo</title>\n\t</head>");
                sw.WriteLine("\t<body>\n\t\t" +
                    "<p style=\"text-align: right\">" + fecha + "</p>" +
                    "<h1>Lunes</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtLunesDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtLunesColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtLunesComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtLunesColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtLunesCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t" +
                    "<h1>Martes</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtMartesDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtMartesColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtMartesComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtMartesColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtMartesCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t" +
                    "<h1>Miercoles</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtMiercolesDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtMiercolesColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtMiercolesComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtMiercolesColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtMiercolesCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t" +
                    "<h1>Jueves</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtJuevesDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtJuevesColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtJuevesComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtJuevesColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtJuevesCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t" +
                    "<h1>Viernes</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtViernesDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtViernesColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtViernesComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtViernesColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtViernesCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t" +
                    "<h1>Sabado</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtSabadoDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtSabadoColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtSabadoComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtSabadoColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtSabadoCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t" +
                    "<h1>Domingo</h1>\n\t\t" +
                    "<h4>Desayuno</h4>" +
                    rtxtDomingoDesayuno.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtDomingoColacion.Text.Replace("\n", "<br>") +
                    "<h4>Comida</h4>" +
                    rtxtDomingoComida.Text.Replace("\n", "<br>") +
                    "<h4>Colacion</h4>" +
                    rtxtDomingoColacion2.Text.Replace("\n", "<br>") +
                    "<h4>Cena</h4>" +
                    rtxtDomingoCena.Text.Replace("\n", "<br>") +
                    "<div style=\"page-break-after: always;\"></div>\n\t\t");
                if (ChecarRecomendaciones())
                {
                    sw.WriteLine("<h2>Recomendaciones</h2>" +
                    rtxtRecordatorio.Text.Replace("\n", "<br>") +
                    "</body>\n</html>");
                }
                else
                {
                    sw.WriteLine("</body>\n</html>");
                }
                    
            }
            var outputPath = @"./Planes/" + nombrePaciente + "/" + archivo + ".pdf";
            using (FileStream htmlSource = File.Open(fileName, FileMode.Open))
            using (FileStream pdfDest = File.Open(outputPath, FileMode.OpenOrCreate))
            {
                ConverterProperties converterProperties = new ConverterProperties();
                HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtxtRecordatorio.AppendText("========\nHola mundo\n");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rtxtRecordatorio.Undo();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            rtxtRecordatorio.AppendText("========\nHola mundo\n");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            rtxtRecordatorio.Undo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtRecordatorio.Text);
        }

        private void btnAgregarLunesDesayuno_Click(object sender, EventArgs e)
        {
            if(cmbLunesDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbLunesDesayuno.SelectedItem.ToString());
                string comida = cmbLunesDesayuno.SelectedItem.ToString();
                rtxtLunesDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasLunes += caloriasAux;
                pilaLunesDesayuno.Push(caloriasAux);
                lblLunesCal.Text = caloriasLunes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private int ObtenerCaloriasTotales(int id)
        {
            var controladorPlan = new ControladorPlan();
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla(id);
            int calorias = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                calorias += controladorPlan.ObtenerCalorias(Convert.ToInt32(tabla.Rows[i][0])) * Convert.ToInt32(tabla.Rows[i][1]);
            }
            return calorias;
        }

        private string ObtenerTexto(int id, string comida)
        {
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla(id);
            string cadena = "==================\n" + comida.ToUpper() + "\n";
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                cadena += ObtenerAlimento(Convert.ToInt32(tabla.Rows[i][0])) + ": " + tabla.Rows[i][1].ToString() + " gramos\n";
            }
            return cadena;
        }

        private string ObtenerAlimento(int id)
        {
            var controladorPlan = new ControladorPlan();
            return controladorPlan.ObtenerAlimento(id);
        }

        private void cmbLunesDesayuno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int ObtenerIdComida(string str)
        {
            var controladorPlan = new ControladorPlan();
            return controladorPlan.ObtenerIdComida(str);
        }

        private DataTable ObtenerTabla(int id)
        {
            var controladorPlan = new ControladorPlan();
            return controladorPlan.GetTable(id);
        }

        private void btnMostrarLunesDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtLunesDesayuno.Text);
        }

        private void btnEliminarLunesDesayuno_Click(object sender, EventArgs e)
        {
            if(pilaLunesDesayuno.Count > 1)
            {
                caloriasLunes -= Convert.ToInt32(pilaLunesDesayuno.Pop());
                lblLunesCal.Text = caloriasLunes.ToString();
                rtxtLunesDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnAgregarLunesColacion_Click(object sender, EventArgs e)
        {
            if (cmbLunesColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbLunesColacion.SelectedItem.ToString());
                string comida = cmbLunesColacion.SelectedItem.ToString();
                rtxtLunesColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasLunes += caloriasAux;
                pilaLunesColacion.Push(caloriasAux);
                lblLunesCal.Text = caloriasLunes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarLunesComida_Click(object sender, EventArgs e)
        {
            if (cmbLunesComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbLunesComida.SelectedItem.ToString());
                string comida = cmbLunesComida.SelectedItem.ToString();
                rtxtLunesComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasLunes += caloriasAux;
                pilaLunesComida.Push(caloriasAux);
                lblLunesCal.Text = caloriasLunes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarLunesColacion2_Click(object sender, EventArgs e)
        {
            if (cmbLunesColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbLunesColacion2.SelectedItem.ToString());
                string comida = cmbLunesColacion2.SelectedItem.ToString();
                rtxtLunesColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasLunes += caloriasAux;
                pilaLunesColacion2.Push(caloriasAux);
                lblLunesCal.Text = caloriasLunes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarLunesCena_Click(object sender, EventArgs e)
        {
            if (cmbLunesCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbLunesCena.SelectedItem.ToString());
                string comida = cmbLunesCena.SelectedItem.ToString();
                rtxtLunesCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasLunes += caloriasAux;
                pilaLunesCena.Push(caloriasAux);
                lblLunesCal.Text = caloriasLunes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMartesDesayuno_Click(object sender, EventArgs e)
        {
            if (cmbMartesDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMartesDesayuno.SelectedItem.ToString());
                string comida = cmbMartesDesayuno.SelectedItem.ToString();
                rtxtMartesDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMartes += caloriasAux;
                pilaMartesDesayuno.Push(caloriasAux);
                lblMartesCal.Text = caloriasMartes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMartesColacion_Click(object sender, EventArgs e)
        {
            if (cmbMartesColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMartesColacion.SelectedItem.ToString());
                string comida = cmbMartesColacion.SelectedItem.ToString();
                rtxtMartesColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMartes += caloriasAux;
                pilaMartesColacion.Push(caloriasAux);
                lblMartesCal.Text = caloriasMartes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMartesComida_Click(object sender, EventArgs e)
        {
            if (cmbMartesComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMartesComida.SelectedItem.ToString());
                string comida = cmbMartesComida.SelectedItem.ToString();
                rtxtMartesComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMartes += caloriasAux;
                pilaMartesComida.Push(caloriasAux);
                lblMartesCal.Text = caloriasMartes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMartesColacion2_Click(object sender, EventArgs e)
        {
            if (cmbMartesColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMartesColacion2.SelectedItem.ToString());
                string comida = cmbMartesColacion2.SelectedItem.ToString();
                rtxtMartesColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMartes += caloriasAux;
                pilaMartesColacion2.Push(caloriasAux);
                lblMartesCal.Text = caloriasMartes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMartesCena_Click(object sender, EventArgs e)
        {
            if (cmbMartesCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMartesCena.SelectedItem.ToString());
                string comida = cmbMartesCena.SelectedItem.ToString();
                rtxtMartesCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMartes += caloriasAux;
                pilaMartesCena.Push(caloriasAux);
                lblMartesCal.Text = caloriasMartes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMiercolesDesayuno_Click(object sender, EventArgs e)
        {
            if (cmbMiercolesDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMiercolesDesayuno.SelectedItem.ToString());
                string comida = cmbMiercolesDesayuno.SelectedItem.ToString();
                rtxtMiercolesDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMiercoles += caloriasAux;
                pilaMiercolesDesayuno.Push(caloriasAux);
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMiercolesColacion_Click(object sender, EventArgs e)
        {
            if (cmbMiercolesColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMiercolesColacion.SelectedItem.ToString());
                string comida = cmbMiercolesColacion.SelectedItem.ToString();
                rtxtMiercolesColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMiercoles += caloriasAux;
                pilaMiercolesColacion.Push(caloriasAux);
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMiercolesComida_Click(object sender, EventArgs e)
        {
            if (cmbMiercolesComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMiercolesComida.SelectedItem.ToString());
                string comida = cmbMiercolesComida.SelectedItem.ToString();
                rtxtMiercolesComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMiercoles += caloriasAux;
                pilaMiercolesComida.Push(caloriasAux);
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMiercolesColacion2_Click(object sender, EventArgs e)
        {
            if (cmbMiercolesColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMiercolesColacion2.SelectedItem.ToString());
                string comida = cmbMiercolesColacion2.SelectedItem.ToString();
                rtxtMiercolesColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMiercoles += caloriasAux;
                pilaMiercolesColacion2.Push(caloriasAux);
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarMiercolesCena_Click(object sender, EventArgs e)
        {
            if (cmbMiercolesCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbMiercolesCena.SelectedItem.ToString());
                string comida = cmbMiercolesCena.SelectedItem.ToString();
                rtxtMiercolesCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasMiercoles += caloriasAux;
                pilaMiercolesCena.Push(caloriasAux);
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarViernesDesayuno_Click(object sender, EventArgs e)
        {
            if (cmbViernesDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbViernesDesayuno.SelectedItem.ToString());
                string comida = cmbViernesDesayuno.SelectedItem.ToString();
                rtxtViernesDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasViernes += caloriasAux;
                pilaViernesDesayuno.Push(caloriasAux);
                lblViernesCal.Text = caloriasViernes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarJuevesDesayuno_Click(object sender, EventArgs e)
        {
            if (cmbJuevesDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbJuevesDesayuno.SelectedItem.ToString());
                string comida = cmbJuevesDesayuno.SelectedItem.ToString();
                rtxtJuevesDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasJueves += caloriasAux;
                pilaJuevesDesayuno.Push(caloriasAux);
                lblJuevesCal.Text = caloriasJueves.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarJuevesColacion_Click(object sender, EventArgs e)
        {
            if (cmbJuevesColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbJuevesColacion.SelectedItem.ToString());
                string comida = cmbJuevesColacion.SelectedItem.ToString();
                rtxtJuevesColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasJueves += caloriasAux;
                pilaJuevesColacion.Push(caloriasAux);
                lblJuevesCal.Text = caloriasJueves.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarJuevesComida_Click(object sender, EventArgs e)
        {
            if (cmbJuevesComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbJuevesComida.SelectedItem.ToString());
                string comida = cmbJuevesComida.SelectedItem.ToString();
                rtxtJuevesComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasJueves += caloriasAux;
                pilaJuevesComida.Push(caloriasAux);
                lblJuevesCal.Text = caloriasJueves.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarJuevesColacion2_Click(object sender, EventArgs e)
        {
            if (cmbJuevesColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbJuevesColacion2.SelectedItem.ToString());
                string comida = cmbJuevesColacion2.SelectedItem.ToString();
                rtxtJuevesColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasJueves += caloriasAux;
                pilaJuevesColacion2.Push(caloriasAux);
                lblJuevesCal.Text = caloriasJueves.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarJuevesCena_Click(object sender, EventArgs e)
        {
            if (cmbJuevesCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbJuevesCena.SelectedItem.ToString());
                string comida = cmbJuevesCena.SelectedItem.ToString();
                rtxtJuevesCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasJueves += caloriasAux;
                pilaJuevesCena.Push(caloriasAux);
                lblJuevesCal.Text = caloriasJueves.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarViernesColacion_Click(object sender, EventArgs e)
        {
            if (cmbViernesColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbViernesColacion.SelectedItem.ToString());
                string comida = cmbViernesColacion.SelectedItem.ToString();
                rtxtViernesColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasViernes += caloriasAux;
                pilaViernesColacion.Push(caloriasAux);
                lblViernesCal.Text = caloriasViernes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarViernesComida_Click(object sender, EventArgs e)
        {
            if (cmbViernesComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbViernesComida.SelectedItem.ToString());
                string comida = cmbViernesComida.SelectedItem.ToString();
                rtxtViernesComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasViernes += caloriasAux;
                pilaViernesComida.Push(caloriasAux);
                lblViernesCal.Text = caloriasViernes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarViernesColacion2_Click(object sender, EventArgs e)
        {
            if (cmbViernesColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbViernesColacion2.SelectedItem.ToString());
                string comida = cmbViernesColacion2.SelectedItem.ToString();
                rtxtViernesColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasViernes += caloriasAux;
                pilaViernesColacion2.Push(caloriasAux);
                lblViernesCal.Text = caloriasViernes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarViernesCena_Click(object sender, EventArgs e)
        {
            if (cmbViernesCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbViernesCena.SelectedItem.ToString());
                string comida = cmbViernesCena.SelectedItem.ToString();
                rtxtViernesCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasViernes += caloriasAux;
                pilaViernesCena.Push(caloriasAux);
                lblViernesCal.Text = caloriasViernes.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarSabadoDesayuno_Click(object sender, EventArgs e)
        {
            if (cmbSabadoDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbSabadoDesayuno.SelectedItem.ToString());
                string comida = cmbSabadoDesayuno.SelectedItem.ToString();
                rtxtSabadoDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasSabado += caloriasAux;
                pilaSabadoDesayuno.Push(caloriasAux);
                lblSabadoCal.Text = caloriasSabado.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarSabadoColacion_Click(object sender, EventArgs e)
        {
            if (cmbSabadoColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbSabadoColacion.SelectedItem.ToString());
                string comida = cmbSabadoColacion.SelectedItem.ToString();
                rtxtSabadoColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasSabado += caloriasAux;
                pilaSabadoColacion.Push(caloriasAux);
                lblSabadoCal.Text = caloriasSabado.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarSabadoComida_Click(object sender, EventArgs e)
        {
            if (cmbSabadoComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbSabadoComida.SelectedItem.ToString());
                string comida = cmbSabadoComida.SelectedItem.ToString();
                rtxtSabadoComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasSabado += caloriasAux;
                pilaSabadoComida.Push(caloriasAux);
                lblSabadoCal.Text = caloriasSabado.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarSabadoColacion2_Click(object sender, EventArgs e)
        {
            if (cmbSabadoColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbSabadoColacion2.SelectedItem.ToString());
                string comida = cmbSabadoColacion2.SelectedItem.ToString();
                rtxtSabadoColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasSabado += caloriasAux;
                pilaSabadoColacion2.Push(caloriasAux);
                lblSabadoCal.Text = caloriasSabado.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarSabadoCena_Click(object sender, EventArgs e)
        {
            if (cmbSabadoCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbSabadoCena.SelectedItem.ToString());
                string comida = cmbSabadoCena.SelectedItem.ToString();
                rtxtSabadoCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasSabado += caloriasAux;
                pilaSabadoCena.Push(caloriasAux);
                lblSabadoCal.Text = caloriasSabado.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarDomingoDesayuno_Click(object sender, EventArgs e)
        {
            if (cmbDomingoDesayuno.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbDomingoDesayuno.SelectedItem.ToString());
                string comida = cmbDomingoDesayuno.SelectedItem.ToString();
                rtxtDomingoDesayuno.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasDomingo += caloriasAux;
                pilaDomingoDesayuno.Push(caloriasAux);
                lblDomingoCal.Text = caloriasDomingo.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarDomingoColacion_Click(object sender, EventArgs e)
        {
            if (cmbDomingoColacion.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbDomingoColacion.SelectedItem.ToString());
                string comida = cmbDomingoColacion.SelectedItem.ToString();
                rtxtDomingoColacion.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasDomingo += caloriasAux;
                pilaDomingoColacion.Push(caloriasAux);
                lblDomingoCal.Text = caloriasDomingo.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarDomingoComida_Click(object sender, EventArgs e)
        {
            if (cmbDomingoComida.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbDomingoComida.SelectedItem.ToString());
                string comida = cmbDomingoComida.SelectedItem.ToString();
                rtxtDomingoComida.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasDomingo += caloriasAux;
                pilaDomingoComida.Push(caloriasAux);
                lblDomingoCal.Text = caloriasDomingo.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarDomingoColacion2_Click(object sender, EventArgs e)
        {
            if (cmbDomingoColacion2.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbDomingoColacion2.SelectedItem.ToString());
                string comida = cmbDomingoColacion2.SelectedItem.ToString();
                rtxtDomingoColacion2.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasDomingo += caloriasAux;
                pilaDomingoColacion2.Push(caloriasAux);
                lblDomingoCal.Text = caloriasDomingo.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnAgregarDomingoCena_Click(object sender, EventArgs e)
        {
            if (cmbDomingoCena.SelectedIndex > 0)
            {
                int id = ObtenerIdComida(cmbDomingoCena.SelectedItem.ToString());
                string comida = cmbDomingoCena.SelectedItem.ToString();
                rtxtDomingoCena.AppendText(ObtenerTexto(id, comida));
                int caloriasAux = ObtenerCaloriasTotales(id);
                caloriasDomingo += caloriasAux;
                pilaDomingoCena.Push(caloriasAux);
                lblDomingoCal.Text = caloriasDomingo.ToString();
            }
            else
            {
                MessageBox.Show("Elegir una comida");
            }
        }

        private void btnEliminarLunesColacion_Click(object sender, EventArgs e)
        {
            if (pilaLunesColacion.Count > 1)
            {
                caloriasLunes -= Convert.ToInt32(pilaLunesColacion.Pop());
                lblLunesCal.Text = caloriasLunes.ToString();
                rtxtLunesColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarLunesComida_Click(object sender, EventArgs e)
        {
            if (pilaLunesComida.Count > 1)
            {
                caloriasLunes -= Convert.ToInt32(pilaLunesComida.Pop());
                lblLunesCal.Text = caloriasLunes.ToString();
                rtxtLunesComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarLunesColacion2_Click(object sender, EventArgs e)
        {
            if (pilaLunesColacion2.Count > 1)
            {
                caloriasLunes -= Convert.ToInt32(pilaLunesColacion2.Pop());
                lblLunesCal.Text = caloriasLunes.ToString();
                rtxtLunesColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarLunesCena_Click(object sender, EventArgs e)
        {
            if (pilaLunesCena.Count > 1)
            {
                caloriasLunes -= Convert.ToInt32(pilaLunesCena.Pop());
                lblLunesCal.Text = caloriasLunes.ToString();
                rtxtLunesCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMartesDesayuno_Click(object sender, EventArgs e)
        {
            if (pilaMartesDesayuno.Count > 1)
            {
                caloriasMartes -= Convert.ToInt32(pilaMartesDesayuno.Pop());
                lblMartesCal.Text = caloriasMartes.ToString();
                rtxtMartesDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMartesColacion_Click(object sender, EventArgs e)
        {
            if (pilaMartesColacion.Count > 1)
            {
                caloriasMartes -= Convert.ToInt32(pilaMartesColacion.Pop());
                lblMartesCal.Text = caloriasMartes.ToString();
                rtxtMartesColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMartesComida_Click(object sender, EventArgs e)
        {
            if (pilaMartesComida.Count > 1)
            {
                caloriasMartes -= Convert.ToInt32(pilaMartesComida.Pop());
                lblMartesCal.Text = caloriasMartes.ToString();
                rtxtMartesComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMartesColacion2_Click(object sender, EventArgs e)
        {
            if (pilaMartesColacion2.Count > 1)
            {
                caloriasMartes -= Convert.ToInt32(pilaMartesColacion2.Pop());
                lblMartesCal.Text = caloriasMartes.ToString();
                rtxtMartesColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMartesCena_Click(object sender, EventArgs e)
        {
            if (pilaMartesCena.Count > 1)
            {
                caloriasMartes -= Convert.ToInt32(pilaMartesCena.Pop());
                lblMartesCal.Text = caloriasMartes.ToString();
                rtxtMartesCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMiercolesDesayuno_Click(object sender, EventArgs e)
        {
            if (pilaMiercolesDesayuno.Count > 1)
            {
                caloriasMiercoles -= Convert.ToInt32(pilaMiercolesDesayuno.Pop());
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
                rtxtMiercolesDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMiercolesColacion_Click(object sender, EventArgs e)
        {
            if (pilaMiercolesColacion.Count > 1)
            {
                caloriasMiercoles -= Convert.ToInt32(pilaMiercolesColacion.Pop());
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
                rtxtMiercolesColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMiercolesComida_Click(object sender, EventArgs e)
        {
            if (pilaMiercolesComida.Count > 1)
            {
                caloriasMiercoles -= Convert.ToInt32(pilaMiercolesComida.Pop());
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
                rtxtMiercolesComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMiercolesColacion2_Click(object sender, EventArgs e)
        {
            if (pilaMiercolesColacion2.Count > 1)
            {
                caloriasMiercoles -= Convert.ToInt32(pilaMiercolesColacion2.Pop());
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
                rtxtMiercolesColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarMiercolesCena_Click(object sender, EventArgs e)
        {
            if (pilaMiercolesCena.Count > 1)
            {
                caloriasMiercoles -= Convert.ToInt32(pilaMiercolesCena.Pop());
                lblMiercolesCal.Text = caloriasMiercoles.ToString();
                rtxtMiercolesCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarJuevesDesayuno_Click(object sender, EventArgs e)
        {
            if (pilaJuevesDesayuno.Count > 1)
            {
                caloriasJueves -= Convert.ToInt32(pilaJuevesDesayuno.Pop());
                lblJuevesCal.Text = caloriasJueves.ToString();
                rtxtJuevesDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarJuevesColacion_Click(object sender, EventArgs e)
        {
            if (pilaJuevesColacion.Count > 1)
            {
                caloriasJueves -= Convert.ToInt32(pilaJuevesColacion.Pop());
                lblJuevesCal.Text = caloriasJueves.ToString();
                rtxtJuevesColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarJuevesComida_Click(object sender, EventArgs e)
        {
            if (pilaJuevesComida.Count > 1)
            {
                caloriasJueves -= Convert.ToInt32(pilaJuevesComida.Pop());
                lblJuevesCal.Text = caloriasJueves.ToString();
                rtxtJuevesComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarJuevesColacion2_Click(object sender, EventArgs e)
        {
            if (pilaJuevesColacion2.Count > 1)
            {
                caloriasJueves -= Convert.ToInt32(pilaJuevesColacion2.Pop());
                lblJuevesCal.Text = caloriasJueves.ToString();
                rtxtJuevesColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarJuevesCena_Click(object sender, EventArgs e)
        {
            if (pilaJuevesCena.Count > 1)
            {
                caloriasJueves -= Convert.ToInt32(pilaJuevesCena.Pop());
                lblJuevesCal.Text = caloriasJueves.ToString();
                rtxtJuevesCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarViernesDesayuno_Click(object sender, EventArgs e)
        {
            if (pilaViernesDesayuno.Count > 1)
            {
                caloriasViernes -= Convert.ToInt32(pilaViernesDesayuno.Pop());
                lblViernesCal.Text = caloriasViernes.ToString();
                rtxtViernesDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarViernesColacion_Click(object sender, EventArgs e)
        {
            if (pilaViernesColacion.Count > 1)
            {
                caloriasViernes -= Convert.ToInt32(pilaViernesColacion.Pop());
                lblViernesCal.Text = caloriasViernes.ToString();
                rtxtViernesColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarViernesComida_Click(object sender, EventArgs e)
        {
            if (pilaViernesComida.Count > 1)
            {
                caloriasViernes -= Convert.ToInt32(pilaViernesComida.Pop());
                lblViernesCal.Text = caloriasViernes.ToString();
                rtxtViernesComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarViernesColacion2_Click(object sender, EventArgs e)
        {
            if (pilaViernesColacion2.Count > 1)
            {
                caloriasViernes -= Convert.ToInt32(pilaViernesColacion2.Pop());
                lblViernesCal.Text = caloriasViernes.ToString();
                rtxtViernesColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarViernesCena_Click(object sender, EventArgs e)
        {
            if (pilaViernesCena.Count > 1)
            {
                caloriasViernes -= Convert.ToInt32(pilaViernesCena.Pop());
                lblViernesCal.Text = caloriasViernes.ToString();
                rtxtViernesCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarSabadoDesayuno_Click(object sender, EventArgs e)
        {
            if (pilaSabadoDesayuno.Count > 1)
            {
                caloriasSabado -= Convert.ToInt32(pilaSabadoDesayuno.Pop());
                lblSabadoCal.Text = caloriasSabado.ToString();
                rtxtSabadoDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarSabadoColacion_Click(object sender, EventArgs e)
        {
            if (pilaSabadoColacion.Count > 1)
            {
                caloriasSabado -= Convert.ToInt32(pilaSabadoColacion.Pop());
                lblSabadoCal.Text = caloriasSabado.ToString();
                rtxtSabadoColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarSabadoComida_Click(object sender, EventArgs e)
        {
            if (pilaSabadoComida.Count > 1)
            {
                caloriasSabado -= Convert.ToInt32(pilaSabadoComida.Pop());
                lblSabadoCal.Text = caloriasSabado.ToString();
                rtxtSabadoComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarSabadoColacion2_Click(object sender, EventArgs e)
        {
            if (pilaSabadoColacion2.Count > 1)
            {
                caloriasSabado -= Convert.ToInt32(pilaSabadoColacion2.Pop());
                lblSabadoCal.Text = caloriasSabado.ToString();
                rtxtSabadoColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarSabadoCena_Click(object sender, EventArgs e)
        {
            if (pilaSabadoCena.Count > 1)
            {
                caloriasSabado -= Convert.ToInt32(pilaSabadoCena.Pop());
                lblSabadoCal.Text = caloriasSabado.ToString();
                rtxtSabadoCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarDomingoDesayuno_Click(object sender, EventArgs e)
        {
            if (pilaDomingoDesayuno.Count > 1)
            {
                caloriasDomingo -= Convert.ToInt32(pilaDomingoDesayuno.Pop());
                lblDomingoCal.Text = caloriasDomingo.ToString();
                rtxtDomingoDesayuno.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarDomingoColacion_Click(object sender, EventArgs e)
        {
            if (pilaDomingoColacion.Count > 1)
            {
                caloriasDomingo -= Convert.ToInt32(pilaDomingoColacion.Pop());
                lblDomingoCal.Text = caloriasDomingo.ToString();
                rtxtDomingoColacion.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarDomingoComida_Click(object sender, EventArgs e)
        {
            if (pilaDomingoComida.Count > 1)
            {
                caloriasDomingo -= Convert.ToInt32(pilaDomingoComida.Pop());
                lblDomingoCal.Text = caloriasDomingo.ToString();
                rtxtDomingoComida.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarDomingoColacion2_Click(object sender, EventArgs e)
        {
            if (pilaDomingoColacion2.Count > 1)
            {
                caloriasDomingo -= Convert.ToInt32(pilaDomingoColacion2.Pop());
                lblDomingoCal.Text = caloriasDomingo.ToString();
                rtxtDomingoColacion2.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnEliminarDomingoCena_Click(object sender, EventArgs e)
        {
            if (pilaDomingoCena.Count > 1)
            {
                caloriasDomingo -= Convert.ToInt32(pilaDomingoCena.Pop());
                lblDomingoCal.Text = caloriasDomingo.ToString();
                rtxtDomingoCena.Undo();
            }
            else
            {
                MessageBox.Show("No hay elementos que quitar");
            }
        }

        private void btnMostrarLunesColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtLunesColacion.Text);
        }

        private void btnMostrarLunesComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtLunesComida.Text);
        }

        private void btnMostrarLunesColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtLunesColacion2.Text);
        }

        private void btnMostrarLunesCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtLunesCena.Text);
        }

        private void btnMostrarMartesDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMartesDesayuno.Text);
        }

        private void btnMostrarMartesColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMartesColacion.Text);
        }

        private void btnMostrarMartesComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMartesComida.Text);
        }

        private void btnMostrarMartesColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMartesColacion2.Text);
        }

        private void btnMostrarMartesCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMartesCena.Text);
        }

        private void btnMostrarMiercolesDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMiercolesDesayuno.Text);
        }

        private void btnMostrarMiercolesColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMiercolesColacion.Text);
        }

        private void btnMostrarMiercolesComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMiercolesComida.Text);
        }

        private void btnMostrarMiercolesColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMiercolesColacion2.Text);
        }

        private void btnMostrarMiercolesCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtMiercolesCena.Text);
        }

        private void btnMostrarJuevesDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtJuevesDesayuno.Text);
        }

        private void btnMostrarJuevesColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtJuevesColacion.Text);
        }

        private void btnMostrarJuevesComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtJuevesComida.Text);
        }

        private void btnMostrarJuevesColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtJuevesColacion2.Text);
        }

        private void btnMostrarJuevesCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtJuevesCena.Text);
        }

        private void btnMostrarViernesDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtViernesDesayuno.Text);
        }

        private void btnMostrarViernesColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtViernesColacion.Text);
        }

        private void btnMostrarViernesComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtViernesComida.Text);
        }

        private void btnMostrarViernesColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtViernesColacion2.Text);
        }

        private void btnMostrarViernesCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtViernesCena.Text);
        }

        private void btnMostrarSabadoDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtSabadoDesayuno.Text);
        }

        private void btnMostrarSabadoColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtSabadoColacion.Text);
        }

        private void btnMostrarSabadoComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtSabadoComida.Text);
        }

        private void btnMostrarSabadoColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtSabadoColacion2.Text);
        }

        private void btnMostrarSabadoCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtSabadoCena.Text);
        }

        private void btnMostrarDomingoDesayuno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtDomingoDesayuno.Text);
        }

        private void btnMostrarDomingoColacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtDomingoColacion.Text);
        }

        private void btnMostrarDomingoComida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtDomingoComida.Text);
        }

        private void btnMostrarDomingoColacion2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtDomingoColacion2.Text);
        }

        private void btnMostrarDomingoCena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtxtDomingoCena.Text);
        }

        private string Mes(int numeroMes)
        {
            switch (numeroMes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: return "";
            }
        }
    }
}
