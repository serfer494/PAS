using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeneria_Software
{
    public partial class Generales2 : Form
    {
        public Generales2()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new DatosGenerales());
        }

        private void AbrirFormHija(object form)
        {
            if (this.panelGenerales2.Controls.Count > 0)
            {
                this.panelGenerales2.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelGenerales2.Controls.Add(fh);
            this.panelGenerales2.Tag = fh;
            fh.Show();
            panelGenerales2.Visible = true;
        }

        private void sig_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Generales3());
        }
    }
}
