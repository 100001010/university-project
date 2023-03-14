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
            Single avg; //平均
            int s1, s2; //兩個分數

            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);

            avg = compute(s1, s2); //呼叫compute計算平均

            if (avg == -1)
                label3.Text = "成績錯誤";
            else
                label3.Text = "平均=" + avg.ToString();
        }

        Single compute(int s1, int s2)
        {
            bool checkRange(int v) //區域函式
            {
                if (v < 0 || v > 100)
                    return false;
                else
                    return true;
            }

            //-------------------------------------
            if (!checkRange(s1) || !checkRange(s2))
                return -1;
            else
                return Convert.ToSingle(s1 + s2) / 2.0f;
        }
    }
}
