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
    public partial class DatosGenerales : Form
    {
        public DatosGenerales()
        {
            InitializeComponent();
        }
        

        private void next_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Generales2());
        }

        private void AbrirFormHija(object form)
        {
            if (this.panelDatosGenerales.Controls.Count > 0)
            {
                this.panelDatosGenerales.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelDatosGenerales.Controls.Add(fh);
            this.panelDatosGenerales.Tag = fh;
            fh.Show();
            panelDatosGenerales.Visible = true;
        }
    }
}
