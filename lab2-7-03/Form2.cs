using System;
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
    public partial class Form2 : Form
    {
        Form1 parent;
        double proc_price = 0;
        double drive_price = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.Text = "1000";
            drive_price = 1000;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.SetTextBox1Text((proc_price + drive_price + parent.monitor_price).ToString());
            parent.computer_price = proc_price + drive_price;
        }

        private void KOMPUTER_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index of the ComboBox
            int selectedIndex = comboBox1.SelectedIndex;

            // Set the value in text1 based on the selected index
            switch (selectedIndex)
            {
                case 0: // Option 1
                    textBox1.Text = "250";
                    proc_price = 250;

                    break;
                case 1: // Option 2
                    textBox1.Text = "500";
                    proc_price = 500;
                    break;
                case 2: // Option 3
                    textBox1.Text = "750";
                    proc_price = 750;
                    break;
                default:

                    textBox1.Text = ""; // Clear text if no option is selected

                    textBox1.Text = ""; // Clear text if no option is selected

                    break;
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.Text = "200";
            proc_price = 200;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "500";
            drive_price = 500;
        }
    }
}