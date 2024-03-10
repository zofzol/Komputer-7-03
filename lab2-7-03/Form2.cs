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
        private List<int> list = new List<int>();

        public Form1 Form1 { get; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            Form1 = form1;
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
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
                    break;
                case 1: // Option 2
                    textBox1.Text = "500";
                    break;
                case 2: // Option 3
                    textBox1.Text = "750";
                    break;
                default:
                    textbox1.Text = ""; // Clear text if no option is selected
                    break;
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.Text = "200";


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

        }
    }
}
