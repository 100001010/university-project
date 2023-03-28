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
        Random rd; //宣告亂數類別變數 rd

        public Form1()
        {
            InitializeComponent();

            rd = new Random(); //建立亂數產生器
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < 10; i++)
                textBox1.AppendText(rd.Next().ToString() + "\r\n");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < 10; i++)
                textBox1.AppendText(rd.Next(10).ToString() + "\r\n");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < 10; i++)
                textBox1.AppendText(rd.Next(10, 20).ToString() + "\r\n");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < 10; i++)
                textBox1.AppendText(rd.NextDouble().ToString() + "\r\n");
        }
    }
}
