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
        string out_file="./status.txt";

        public Form1()
        {
            InitializeComponent();
        }

        //在席中のボタン動作
        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@out_file, "在席中");

            //英訳判定
            if (checkBox2.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, "[In table that caught]");
            }

            //追記判定
            if (checkBox3.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, textBox1.Text);
            }
        }

        //退席中のボタン動作
        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@out_file, "退席中");

            //英訳判定
            if (checkBox2.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, "[away from the keyboard]");
            }

            //追記判定
            if (checkBox3.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, textBox1.Text);
            }
        }

        //外出中のボタン動作
        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@out_file, "外出中");

            //英訳判定
            if (checkBox2.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, "[Now absent]");
            }

            //追記判定
            if (checkBox3.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@out_file, textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@out_file, "仕事中");

            //英訳判定
            if (checkBox2.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, "[working now]");
            }

            //追記判定
            if (checkBox3.Checked)
            {
                //改行判定
                if (checkBox1.Checked)
                {
                    File.AppendAllText(@out_file, Environment.NewLine);
                }
                File.AppendAllText(@out_file, textBox1.Text);
            }
        }

    }
}
