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
        int[] score = new int[5]; //儲存5個成績
        bool fgOK = true; //輸入的成績是否正確

        public Form1()
        {
            InitializeComponent();
        }

            private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[0] = Convert.ToInt32(textBox1.Text);
                fgOK = true; //可以順利轉成整數
                if (score[0] < 60) //不及格以紅色顯示
                    textBox1.ForeColor = Color.Red;
                else               //及格以黑色顯示
                    textBox1.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[1] = Convert.ToInt32(textBox2.Text);
                fgOK = true;  //可以順利轉成整數
                if (score[1] < 60) //不及格以紅色顯示
                    textBox2.ForeColor = Color.Red;
                else               //及格以黑色顯示
                    textBox2.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[2] = Convert.ToInt32(textBox3.Text);
                fgOK = true;  //可以順利轉成整數
                if (score[2] < 60) //不及格以紅色顯示
                    textBox3.ForeColor = Color.Red;
                else               //及格以黑色顯示 
                    textBox3.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[3] = Convert.ToInt32(textBox4.Text);
                fgOK = true;  //可以順利轉成整數
                if (score[3] < 60)  //不及格以紅色顯示
                    textBox4.ForeColor = Color.Red;
                else                //及格以黑色顯示 
                    textBox4.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                score[4] = Convert.ToInt32(textBox5.Text);
                fgOK = true;  //可以順利轉成整數
                if (score[4] < 60)  //不及格以紅色顯示
                    textBox5.ForeColor = Color.Red;
                else                //及格以黑色顯示 
                    textBox5.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                String str;

                if (fgOK == false) //如果有任何一個成績有問題
                    return;

                textBox6.Clear();
                //將5個成績顯示上在textBox6
                for (int i = 0; i < 5; i++)
                {
                    str = "第" + (i + 1).ToString() + "筆成績=" +
                        score[i].ToString();
                    textBox6.AppendText(str + "\r\n");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Single avg = 0;

            if (fgOK == false)
            {
                MessageBox.Show("成績有錯誤");
                return;
            }

            for (int i = 0; i < 5; i++)  //加總5個成績         
                avg += score[i];

            avg /= 5.0f;  //計算平均
            label6.Text = "平均=" + avg.ToString();
        }
    }
}
