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
            int a = 5;

            label4.Text = a.ToString();

            add(a); //呼叫自訂函式add()

            label6.Text = a.ToString();
        }

        //------- 傳值呼叫 --------------
        void add(int a)
        {
            a += 5;
            label5.Text = a.ToString();
        }
    }
}
