﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_7_03
{
    public partial class Form3 : Form
    {
        public Form1 Form1 { get; }

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form1)
        {
            InitializeComponent();
             Form1 = form1;
        }

        private void KOMPUTER_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
