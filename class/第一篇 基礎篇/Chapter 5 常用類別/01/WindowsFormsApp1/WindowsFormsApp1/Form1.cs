using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            double a;
            a = Abs(-3);
            textBox1.AppendText("Abs(-3)= " + a.ToString() + "\r\n");
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            double a;
            a = Acos(0);
            textBox1.AppendText("Acos(0)= " + a.ToString() + "\r\n");
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            double a;
            a = Ceiling(3.3);
            textBox1.AppendText("Ceiling(3.3)= " + a.ToString() + "\r\n");
        }

        private void RadioButton4_Click(object sender, EventArgs e)
        {
            int a;
            a = DivRem(5, 3, out int r);
            textBox1.AppendText("5/3= " + a.ToString() + "..." +
                r.ToString() + "\r\n");
        }

        private void RadioButton5_Click(object sender, EventArgs e)
        {
            double a;
            a = Exp(0);
            textBox1.AppendText("Exp(0)= " + a.ToString() + "\r\n");
        }

        private void RadioButton6_Click(object sender, EventArgs e)
        {
            double a;
            a = Floor(3.7);
            textBox1.AppendText("Floor(3.7)= " + a.ToString() + "\r\n");
        }

        private void RadioButton7_Click(object sender, EventArgs e)
        {
            double a;
            a = Log(2);
            textBox1.AppendText("Log(2)= " + a.ToString() + "\r\n");
        }

        private void RadioButton8_Click(object sender, EventArgs e)
        {
            double a;
            a = Log10(2);
            textBox1.AppendText("Log10(2)= " + a.ToString() + "\r\n");
        }

        private void RadioButton9_Click(object sender, EventArgs e)
        {
            int a;
            a = Max(3, 10);
            textBox1.AppendText("Max(3,10)= " + a.ToString() + "\r\n");
        }

        private void RadioButton10_Click(object sender, EventArgs e)
        {
            int a;
            a = Min(3, 10);
            textBox1.AppendText("Min(3,10)= " + a.ToString() + "\r\n");
        }

        private void RadioButton11_Click(object sender, EventArgs e)
        {
            double a;
            a = Pow(2, 5);
            textBox1.AppendText("Pow(2, 5)= " + a.ToString() + "\r\n");
        }

        private void RadioButton12_Click(object sender, EventArgs e)
        {
            double a;
            a = Round(3.7);
            textBox1.AppendText("Round(3.7)= " + a.ToString() + "\r\n");
        }

        private void RadioButton13_Click(object sender, EventArgs e)
        {
            int a;
            a = Sign(-2);
            textBox1.AppendText("Sign(-2)= " + a.ToString() + "\r\n");
        }

        private void RadioButton14_Click(object sender, EventArgs e)
        {
            double a;
            a = Sqrt(2);
            textBox1.AppendText("Sqrt(2)= " + a.ToString() + "\r\n");
        }

        private void RadioButton15_Click(object sender, EventArgs e)
        {
            double a;
            a = Truncate(2.7);
            textBox1.AppendText("STruncate(2.7)= " + a.ToString() + "\r\n");
        }
    }
}
