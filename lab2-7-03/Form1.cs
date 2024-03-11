using Microsoft.VisualBasic.Devices;

namespace lab2_7_03
{
    public partial class Form1 : Form
    {
        public double computer_price = 0;
        public double monitor_price = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            Form3 mon = new Form3(this);
            mon.Show();
        }
        private void Komputer_Click(object sender, EventArgs e)
        {
            Form2 komp = new Form2(this);
            komp.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void SetTextBox1Text(string text)
        {
            textBox1.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}