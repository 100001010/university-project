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

        T compMax<T>(T a, T b)
        {
            dynamic a1, b1;
            a1 = a;
            b1 = b;

            if (a1 > b1)
                return a1;
            else
                return b1;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float m;

            m = compMax<float>(5.6f, 3.2f);

            label1.Text = "大數=" + m.ToString();
        }
    }
}
