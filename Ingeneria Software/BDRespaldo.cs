using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;

namespace Ingeneria_Software
{
    public partial class BDRespaldo : Form
    {
        int usuario;
        public BDRespaldo(int numUsuario)
        {
            InitializeComponent();
            usuario = numUsuario;
            if (usuario != 0) btnRestaurar.Visible = false;
            this.Activate();
            this.BringToFront();
            this.Focus();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "DBPAS" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bak";
            var controladorBDRespaldo = new ControladorBDRespaldo();
            if (Directory.Exists(@"C:\DBPAS"))
            {
                controladorBDRespaldo.Respaldo(nombreArchivo);
                if (controladorBDRespaldo.error == "")
                {
                    MessageBox.Show("Base de datos guardada en C:\\PASDB");
                }
                else
                {
                    MessageBox.Show("Error: " + controladorBDRespaldo.error);
                }
            }
            else
            {
                Directory.CreateDirectory(@"C:\DBPAS");
                
                controladorBDRespaldo.Respaldo(nombreArchivo);
                if (controladorBDRespaldo.error == "")
                {
                    MessageBox.Show("Base de datos guardada en C:\\PASDB");
                }
                else
                {
                    MessageBox.Show("Error: " + controladorBDRespaldo.error);
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos bak (*.bak)|*.bak";
            if (Directory.Exists(@"C:\DBPAS")) ofd.InitialDirectory = @"C:\DBPAS";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                var controladorBDRespaldo = new ControladorBDRespaldo();
                controladorBDRespaldo.Restaurar(path);
                if(controladorBDRespaldo.error == "")
                {
                    MessageBox.Show("Base de datos restaurada");
                }
                else
                {
                    MessageBox.Show("Error: " + controladorBDRespaldo.error);
                }
            }
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            if (rbtnDia.Checked)
            {
                var controladorBDRespaldo = new ControladorBDRespaldo();
                controladorBDRespaldo.ProgramarDia();
                if (controladorBDRespaldo.error == "") MessageBox.Show("La base de datos se respaldara cada dia");
                else MessageBox.Show(controladorBDRespaldo.error);
            }
            else if(rbtnSemana.Checked)
            {
                var controladorBDRespaldo = new ControladorBDRespaldo();
                controladorBDRespaldo.ProgramarSemana();
                if (controladorBDRespaldo.error == "") MessageBox.Show("La base de datos se respaldara cada semana");
                else MessageBox.Show(controladorBDRespaldo.error);
            }
            else if (rbtnMes.Checked)
            {
                var controladorBDRespaldo = new ControladorBDRespaldo();
                controladorBDRespaldo.ProgramarMes();
                if (controladorBDRespaldo.error == "") MessageBox.Show("La base de datos se respaldara cada mes");
                else MessageBox.Show(controladorBDRespaldo.error);
            }
            else
            {
                MessageBox.Show("Seleccione una opcion");
            }
        }
    }
}
