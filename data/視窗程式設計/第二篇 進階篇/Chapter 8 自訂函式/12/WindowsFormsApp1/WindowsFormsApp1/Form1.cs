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

        void exchange<T>(ref T a, ref T b)
        {
            T tmp;

            tmp = a;
            a = b;
            b = tmp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 5, b = 8;

            exchange<int>(ref a, ref b);
            label1.Text = String.Format("a={0}, b={1}", a, b);
        }
    }
}
