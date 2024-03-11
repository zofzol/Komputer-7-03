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
    public partial class Form3 : Form
    {
        Form1 parent;
        double monitor_price;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            textBox1.ReadOnly = true;
        }


        private void KOMPUTER_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.SetTextBox1Text((monitor_price + parent.computer_price).ToString());
            parent.monitor_price = monitor_price;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    if (selectedItem.Text == "120 Hz")
                        monitor_price = 100;
                    if (selectedItem.Text == "144 Hz")
                        monitor_price = 200;
                    if (selectedItem.Text == "165 Hz")
                        monitor_price = 300;
                }
                textBox1.Text = monitor_price.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}