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
    public partial class VerDatosGenerales2 : Form
    {
        public VerDatosGenerales2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPpal mp = new MenuPpal();
            this.Close();
            mp.Show();
        }
    }
}
