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
        bool fg = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            fg = true;
            textBox1.Focus(); //讓textBox1自動取得焦點
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            fg = false;
            textBox2.Focus(); // 讓textBox2自動取得焦點
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            fg = true;
            radioButton1.Checked = true;
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            fg = false;
            radioButton2.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sum = 0; //總和
            int val;
            string str;

            textBox3.Clear(); //清除所有的資料

            for (int i = 1; i <= 10; i++)
            {
                if (fg == true) //選擇了"continue"
                {
                    val = Convert.ToInt32(textBox1.Text);

                    if (i == val)  //若i等於設定值
                        continue;  //跳過此次剩下的程式碼68-72行
                }
                else        //選擇了"break"
                {
                    val = Convert.ToInt32(textBox2.Text);

                    if (i == val) //若i等於設定值
                        break;    //離開迴圈
                }
                //-------------------------------------
                sum += i; //累加
                str = "i=" + i.ToString() + ",sum= " +
                    sum.ToString() + "\r\n";

                textBox3.AppendText(str);
            }
        }
    }
}
