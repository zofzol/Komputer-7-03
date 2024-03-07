using Microsoft.VisualBasic.Devices;

namespace lab2_7_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

    }
}
