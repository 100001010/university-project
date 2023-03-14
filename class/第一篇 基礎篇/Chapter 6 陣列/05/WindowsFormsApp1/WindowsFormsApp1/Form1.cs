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
            int[] array = { 4, 12, 87, 45, 14, 13, 56, 9, 33, 6, 21, 8 };
            int len; //儲存陣列長度
            int val; //使用者輸入的值

            //取出使用者輸入的值：,這裡並沒有做例外處理。
            val = Convert.ToInt32(textBox1.Text);
            len = array.Length;  //取得陣列arr的長度

            for (int i = 0; i < len; i++)
                if (val == array[i])
                {
                    label2.Text = "找到了，第" + (i + 1).ToString() + "個";
                    return;
                }

            label2.Text = "找不到";
        }
    }
}
