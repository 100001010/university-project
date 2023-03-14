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
            int[,] stu = new int[3, 3];
            float[] avg;
            string str;

            avg = compute(stu); //設定分數與計算平均

            for (int i = 0; i < stu.GetLength(0); i++)
            {
                str = String.Format("第{0}位學生：" +
                    "國文 {1}, 英文 {2}, 數學 {3}, 平均 {4:f2}",
                    i + 1, stu[i, 0], stu[i, 1], stu[i, 2], avg[i]);
                textBox1.AppendText(str + "\r\n");
            }
        }

        //-------- 設定成績與計算平均 ----------
        float[] compute(int[,] stu)
        {
            float[] avg = { 0, 0, 0 }; //三人的平均分數
            Random rd = new Random();

            //以亂數設定分數
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    stu[i, j] = rd.Next(41) + 60;

            //計算個人總分與計算平均
            for (int i = 0; i < 3; i++)
            {
                //計算個人總分
                for (int j = 0; j < 3; j++)
                    avg[i] += stu[i, j];

                avg[i] /= 3.0f; //計算平均
            }

            return avg;
        }        
    }
}
