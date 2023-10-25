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

            ref_add(ref a); //呼叫自訂函式add()

            label6.Text = a.ToString();
        }

        //------- 參考呼叫 --------------
        void ref_add(ref int b) 
        {
            b += 5;
            label5.Text = b.ToString();
        }
    }
}
