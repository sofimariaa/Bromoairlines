﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form5 form = new Form5();
            form.ShowDialog();
        }
    }
}
