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

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Down";
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Mouse Enter";
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Leave";
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "Mouse Up";
        }

        private void Label2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "Mouse Click";
        }

        private void Label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "Mouse Double Click";
        }

        private void Label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = (++count).ToString();
        }

        private void Label4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Mouse Hover";
        }
    }
}
