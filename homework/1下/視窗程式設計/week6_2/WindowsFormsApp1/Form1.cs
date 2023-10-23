using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label4.Text = e.KeyCode.ToString();
            label7.Text = e.KeyValue.ToString();
            label8.Text = e.KeyData.ToString();

            label14.Text = Convert.ToString(++count);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label5.Text = Convert.ToString(e.KeyChar);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label6.Text = Convert.ToString(e.KeyData);

            count = 0;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
