﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_windows_forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 j8 = new Form8();
            j8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 j8 = new Form8();
            j8.Show();
        }
    }
}
