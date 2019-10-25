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
    public partial class DatosxCita : Form
    {
        public DatosxCita()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPpal mp = new MenuPpal();
            this.Close();
            mp.Show();
        }
    }
}
