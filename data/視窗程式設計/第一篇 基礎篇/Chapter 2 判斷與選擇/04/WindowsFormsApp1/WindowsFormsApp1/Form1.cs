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

            if (age < 18)
            {
                MessageBox.Show("未滿18歲不能買酒");
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //逐一檢查按鍵是否為0-9、enter、backspace
            if (e.KeyChar == (Char)48 || e.KeyChar == (Char)49 ||
                e.KeyChar == (Char)50 || e.KeyChar == (Char)51 ||
                e.KeyChar == (Char)52 || e.KeyChar == (Char)53 ||
                e.KeyChar == (Char)54 || e.KeyChar == (Char)55 ||
                e.KeyChar == (Char)56 || e.KeyChar == (Char)57 ||
                e.KeyChar == (Char)13 || e.KeyChar == (Char)8)
            {
                e.Handled = false;
            }
            else //不是的話，把其餘的按鍵設定為已經處理過了
            {
                e.Handled = true;
            }
        }
    }
}
