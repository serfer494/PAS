using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Ingeneria_Software
{
    public partial class MenuPpal : Form
    {
        public MenuPpal()
        {
            
            InitializeComponent();
            panel1.Visible = false;

        }

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
            panel1.Visible = true;
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
            AbrirFormHija(new DatosxCita());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Plan());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DatosGenerales());
        }

        private void cont_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
