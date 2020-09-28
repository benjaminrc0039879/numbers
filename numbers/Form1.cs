using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.141592653589793;
            richTextBox1.AppendText(pi.ToString("n3") + "\n");
            richTextBox1.AppendText(pi.ToString("n5") + "\n");
            richTextBox1.AppendText(pi.ToString("n15") + "\n");
            double c = 299792458;
            richTextBox1.AppendText(c.ToString("n0") + "\n");
            richTextBox1.AppendText(c.ToString("n16") + "\n");
            richTextBox1.AppendText(c.ToString("n3") + "\n");
            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }
            string s2 = "3.2";
            try
            {
                int it = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + " is not an integer");
            }
            string s3 = "pi";
            try { double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i1 = 3 * 4;
            int i2 = 12 / 4;
            int i3 = 15 / 4;
            int i4 = 15 % 4;
            int i5 = 2 + (3 * 4) / (2 - 4);
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;

        }
    }
}
