using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Out_of_office_confirmation_software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\status.txt", "在席中");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\status.txt", "退席中");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\status.txt", "外出中");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\status.txt", textBox1.Text);
        }
    }
}
