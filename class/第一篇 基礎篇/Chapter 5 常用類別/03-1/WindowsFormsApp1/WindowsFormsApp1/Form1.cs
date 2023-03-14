using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool fgKeyUp = true; //是否放開按鍵
        int dBlood = 100, hBlood = 100; //噴火龍與英雄的血       
        int heroState = 0; // 英雄, 0:放鬆、1：抵擋、2：攻擊
        int dinosaurState = 0; // 噴火龍, 0:放鬆、1：抵擋、2：攻擊
        Random rd;
        PictureBox[] picHero = new PictureBox[3]; //英雄3張圖片
        PictureBox[] picDinosaur = new PictureBox[3]; //噴火龍3張圖片

        public Form1()
        {
            InitializeComponent();

            rd = new Random(); //建立亂數產生器
           
            for (int i = 0; i < 3; i++) //載入噴火龍與英雄的圖片
            {
                picDinosaur[i] = new PictureBox();
                picDinosaur[i].Image = Image.FromFile("d" + i.ToString() + ".png");

                picHero[i] = new PictureBox();
                picHero[i].Image = Image.FromFile("h" + i.ToString() + ".png");

                picHero[i].SizeMode = PictureBoxSizeMode.AutoSize;
                picDinosaur[i].SizeMode = PictureBoxSizeMode.AutoSize;
            }

            //遊戲剛開始，噴火龍與英雄的初始影像
            pictureBox1.Image = picDinosaur[0].Image;
            pictureBox2.Image = picHero[0].Image;

        }

        //----------------- 顯示噴火龍影像 -----------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            //以亂數決定顯示那張噴火龍影像
            dinosaurState = rd.Next(0, 5);

            if (dinosaurState > 2) //增加噴火龍防守的機會
                dinosaurState = 1;

            pictureBox1.Image = picDinosaur[dinosaurState].Image;
        }
    }
}
