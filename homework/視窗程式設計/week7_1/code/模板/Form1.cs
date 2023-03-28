using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模板
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.ShowDialog();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "MouseClick";
        }

        private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "MouseDoubleClick";
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "MouseDown";
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "MouseEnter";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "MouseLeave";

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "MouseUp";
        }
        int n = 0;
        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = Convert.ToString(n++);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "MouseHover";
        }
    }
}
