using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sofiBromo
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form7 form = new Form7();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();   
            form.ShowDialog();
        }
    }
}
