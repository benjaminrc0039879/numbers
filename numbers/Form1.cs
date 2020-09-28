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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
