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

        private void Button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string str;

            for (int i = 1; i <= 10; i++)
            {
                str = "第 " + i.ToString() + " 次: " + sum.ToString() +
                    "+" + i.ToString() + "=" + (sum += i).ToString() + "\r\n";

                textBox1.AppendText(str);
            }

            label2.Text = sum.ToString();
        }
    }
}
