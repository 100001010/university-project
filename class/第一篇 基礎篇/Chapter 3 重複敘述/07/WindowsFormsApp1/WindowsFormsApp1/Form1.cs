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
        bool fg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            fg = true;

            while (fg == true)
            {
                i++;
                label1.Text = i.ToString();
                if (i == 10000) //i值等於10000
                    i = 0;     // 就將i值歸 0

                Application.DoEvents(); //讓表單能收到訊息
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            fg = false;
        }
    }
}
