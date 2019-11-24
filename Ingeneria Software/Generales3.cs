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
    public partial class Generales3 : Form
    {
        public Generales3(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        int id;

        private void Generales3_Load(object sender, EventArgs e)
        {

        }

        private void dieteticos_Click(object sender, EventArgs e)
        {

        }

        private void regre_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Generales2(id));
            
            
        }

        private void AbrirFormHija(object form)
        {
            if (this.panelGenerales3.Controls.Count > 0)
            {
                this.panelGenerales3.Controls.RemoveAt(0);
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelGenerales3.Controls.Add(fh);
            this.panelGenerales3.Tag = fh;
            fh.Show();
            panelGenerales3.Visible = true;
        }
    }
}
