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
            int age;  //年齡

            age = Convert.ToInt32(textBox1.Text);

            if (age < 18) //年齡小於18
            {
                MessageBox.Show("未滿18歲不能買酒");
            }
            else //年齡大於等於18
            {
                // 顯示與輸入數量先關的控制項
                label2.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int number; //購買數量

            number = Convert.ToInt32(textBox2.Text);

            label4.Text = (number * 32).ToString();
        }
    }
}
