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

            sum = compute(10); //呼叫遞迴函式
            textBox1.AppendText("總和=" + sum.ToString() + "\r\n");
        }

        int compute(int num)
        {
            textBox1.AppendText(num.ToString() + "\r\n");

            if (num == 1) //終止遞迴的條件
                return 1;
            else
                return compute(num - 1) + num;
        }
    }
}
