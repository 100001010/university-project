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
        bool fg = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            fg = checkBox1.Checked;
            checkBox1.Text = "fg=" + fg.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sum = 0; //總和
            int i = 1;

            textBox1.Clear();
            do
            {
                sum += i;
                textBox1.AppendText(sum.ToString() + "\r\n");
                i++;
                Application.DoEvents();
            } while (fg == true && i <= 10);
        }
    }
}
