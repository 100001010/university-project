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
        public Form1()
        {
            InitializeComponent();
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;

            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;

            label1.Text = String.Format("R: {0}", r);
            label4.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void HScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;

            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;

            label2.Text = String.Format("G: {0}", g);
            label4.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void HScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;

            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;

            label3.Text = String.Format("B: {0}", b);
            label4.BackColor = Color.FromArgb(255, r, g, b);
        }
    }
}
