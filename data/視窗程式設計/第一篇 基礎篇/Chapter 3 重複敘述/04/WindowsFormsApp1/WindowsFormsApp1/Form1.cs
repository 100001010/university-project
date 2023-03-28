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
            string str = "";
            int p; //乘積

            for (int i = 1; i <= 9; i++)  //被乘數
            {
                for (int j = 1; j <= 9; j++)  //乘數
                {
                    p = i * j;
                    //串接顯示的項目
                    str += i.ToString() + "×" + j.ToString() +
                        "=" + p.ToString() + ", ";
                }
                textBox1.AppendText(str + "\r\n"); //輸出一列乘法
                str = ""; //清除舊的內容
            }
        }
    }
}
