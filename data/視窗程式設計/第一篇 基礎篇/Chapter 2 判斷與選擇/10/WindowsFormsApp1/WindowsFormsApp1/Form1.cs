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

        private void Button2_Click(object sender, EventArgs e)
        {
            Close(); //結束程式
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int month, day; //月份、日期

            try
            {
                month = Convert.ToInt32(textBox1.Text);
                day = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }

            if (month < 1 || month > 12)
            {
                MessageBox.Show("輸入1-12月");
                return;
            }

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day < 1 || day > 31)
                    {
                        MessageBox.Show("輸入1-31日");
                        return;
                    }
                    break;
            }

            switch (month)  //檢查小月的天數
            {
                case 2:
                    if (day < 1 || day > 28)
                    {
                        MessageBox.Show("輸1-28日");
                        return;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 1 || day > 30)
                    {
                        MessageBox.Show("輸入1-30日");
                        return;
                    }
                    break;
            }

            //--------------- 判斷星座 ------------------
            switch (month)
            {
                case 1:
                    if (day < 21)
                        label3.Text = "摩羯座";
                    else
                        label3.Text = "水瓶座";
                    break;
                case 2:
                    if (day < 19)
                        label3.Text = "水瓶座";
                    else
                        label3.Text = "雙魚座";
                    break;
                case 3:
                    if (day < 21)
                        label3.Text = "雙魚座";
                    else
                        label3.Text = "牡羊座";
                    break;
                case 4:
                    if (day < 20)
                        label3.Text = "牡羊座";
                    else
                        label3.Text = "金牛座";
                    break;
                case 5:
                    if (day < 21)
                        label3.Text = "金牛座";
                    else
                        label3.Text = "雙子座";
                    break;
                case 6:
                    if (day < 22)
                        label3.Text = "雙子座";
                    else
                        label3.Text = "巨蟹座";
                    break;
                case 7:
                    if (day < 23)
                        label3.Text = "巨蟹座";
                    else
                        label3.Text = "獅子座";
                    break;
                case 8:
                    if (day < 23)
                        label3.Text = "獅子座";
                    else
                        label3.Text = "處女座";
                    break;
                case 9:
                    if (day < 23)
                        label3.Text = "處女座";
                    else
                        label3.Text = "天秤座";
                    break;
                case 10:
                    if (day < 24)
                        label3.Text = "天秤座";
                    else
                        label3.Text = "天蠍座";
                    break;
                case 11:
                    if (day < 23)
                        label3.Text = "天蠍座";
                    else
                        label3.Text = "射手座";
                    break;
                case 12:
                    if (day < 22)
                        label3.Text = "射手座";
                    else
                        label3.Text = "摩羯座";
                    break;
            }
        }
    }
}
