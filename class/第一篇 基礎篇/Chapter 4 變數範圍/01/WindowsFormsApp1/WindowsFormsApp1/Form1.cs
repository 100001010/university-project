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
        int a = 3; //全域變數

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 1; //區域變數

            a += 2;
            label1.Text = "區域變數a=" + a.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            a += 5;
            label2.Text = "全域變數a=" + a.ToString();
        }
    }
}
