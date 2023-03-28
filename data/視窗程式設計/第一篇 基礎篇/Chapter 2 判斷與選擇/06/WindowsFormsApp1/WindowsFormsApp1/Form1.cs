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
            decimal a = 1, b = 1, c; //分別為被除數、除數、商
            bool fgError; //表示是否輸入值有出現錯誤的情形

            try // 讀取使用者輸入的被除數與除數
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                fgError = false;
            }
            catch (FormatException ex)
            { //資料型別錯誤
                textBox3.AppendText(ex.Message + "\r\n"); //顯示錯誤訊息
                a = 1; //重新設定a的初始值
                b = 1; //重新設定b的初始值
                fgError = true;
            }
            finally
            {
                //顯示a、b的值
                textBox3.AppendText("a=" + a.ToString() + "\r\n");
                textBox3.AppendText("b=" + b.ToString() + "\r\n");
            }

            //=============== 做除法運算 ==================
            if (fgError == false) //如果沒有發生輸入錯誤
                try
                {
                    c = a / b;
                    label3.Text = c.ToString(); //顯示商
                }
                catch (DivideByZeroException ex)
                { //除0錯誤
                    textBox3.AppendText(ex.Message + "\r\n");
                    //重新設定初始值
                    label3.Text = ""; //清除上一次的結果
                    b = 1;
                    textBox2.Text = b.ToString();
                }
        }
    }
}
