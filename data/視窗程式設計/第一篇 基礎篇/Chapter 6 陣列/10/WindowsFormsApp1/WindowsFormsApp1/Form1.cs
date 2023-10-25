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
        Button[,] btns = new Button[3, 3]; //宣告按鈕陣列

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int w_h = 50;  //按鈕的寬與高
            int gap = w_h + 20; //放置按鈕的位置，20為按鈕之間的間距。

            // 幫每一個按鈕進行設定
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    btns[i,j] = new Button();
                    btns[i,j].Tag = i * 3 + j; //設定按鈕唯一的編號
                    btns[i,j].Text = btns[i,j].Tag.ToString();
                    btns[i,j].Width = w_h;     //設定按鈕的寬
                    btns[i,j].Height = w_h;    //設定按鈕的高
                    btns[i,j].Location = new Point(70 + j * gap,
                        70 + i * gap);
                    btns[i,j].Click += MyClick; //設定按鈕的Click事件
                    this.Controls.Add(btns[i,j]);  //把按鈕加入表單
                }
        }

        //----- 自訂按鈕的MyClick事件  -----------
        private void MyClick(object sender, EventArgs e)
        {
            string str;

            // 將sender轉型成按鈕型別，並取得其Tag的資料
            str = ((Button)sender).Tag.ToString();
            label1.Text = str;
        }
    }
}
