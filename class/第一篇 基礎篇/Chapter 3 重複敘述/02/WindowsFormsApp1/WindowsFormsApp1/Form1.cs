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
            for (int i = 0, j = 255; i <= 255; i++, j--)
            {
                textBox1.BackColor = Color.FromArgb(255, j, i);
                Refresh(); //表單重繪
                System.Threading.Thread.Sleep(10); //暫停0.01秒
            }
        }
    }
}
