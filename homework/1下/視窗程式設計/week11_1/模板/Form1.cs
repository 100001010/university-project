using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模板
{
    public partial class Form1 : Form
    {
        int[] score = new int[5];
        bool fgOK = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                fgOK = true; 
                if (score[3] < 60) 
                    textBox4.ForeColor = Color.Red;
                else               
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
                fgOK = true; 
                if (score[4] < 60) 
                    textBox5.ForeColor = Color.Red;
                else                
                    textBox5.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                fgOK = false;
                MessageBox.Show("輸入錯誤");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                String str;

                if (fgOK == false)
                    return;

                textBox6.Clear();
                
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

            for (int i = 0; i < 5; i++)      
                avg += score[i];

            avg /= 5.0f;  
            label7.Text = "平均=" + avg.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
