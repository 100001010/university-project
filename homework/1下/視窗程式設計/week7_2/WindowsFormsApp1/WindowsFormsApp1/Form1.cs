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
        int gender = 0; //性別，預設為女生
        bool fgVel = false; //是否自備交通工具，預設為否
        bool fgHDC = false; //是否役畢，預設為否
        int age = 0; //年齡

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            gender = 1; //男生
            groupBox3.Visible = true; //需要填寫是否役畢
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            gender = 0; //女生
            groupBox3.Visible = false;   //不需要填寫是否役畢
        }

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            fgHDC = true; //役畢
        }

        private void RadioButton4_Click(object sender, EventArgs e)
        {
            fgHDC = false; //尚未役畢
        }

        private void RadioButton5_Click(object sender, EventArgs e)
        {
            fgVel = true; //自備交通工具
        }

        private void RadioButton6_Click(object sender, EventArgs e)
        {
            fgVel = false; //沒有自備交通工具
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try   //檢查年齡輸入
            {
                age = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("輸入錯誤");
                textBox1.Text = "0";
                return;
            }

            //--------------- 開始檢查條件 -----------------
            if (gender == 0) //女生
            {   //檢查年齡
                if (age < 20 || age > 35)
                    MessageBox.Show("年齡不符合資格");
                else
                { //檢查交通工具狀況
                    if (fgVel == true)
                        MessageBox.Show("資格符合");
                    else
                        MessageBox.Show("沒有自備交通工具，資格不符合");
                }
            }
            else  //男生
            { //檢查役畢情況
                if (fgHDC == false)
                    MessageBox.Show("尚未役畢，資格不符");
                else
                { //檢查年齡
                    if (age < 20 || age > 35)
                        MessageBox.Show("年齡不符合資格");
                    else
                    { //檢查交通工具狀況
                        if (fgVel == true)
                            MessageBox.Show("資格符合");
                        else
                            MessageBox.Show("沒有自備交通工具，資格不符合");
                    }
                }
            }
        }
    }
}
