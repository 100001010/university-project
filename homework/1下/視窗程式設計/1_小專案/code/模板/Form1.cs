using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模板
{
    public partial class Form1 : Form
    {
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int horizontal = 10;
        int vertical = 10;
        bool start = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start)
            {
                if (pictureBox1.Left + horizontal < 0 || pictureBox1.Right + horizontal > ClientSize.Width)
                {
                    horizontal = -horizontal;
                }
                if (pictureBox1.Top + vertical < 30 )
                {
                    vertical = -vertical;
                }

                pictureBox1.Left += horizontal;
                pictureBox1.Top += vertical;
            }
            if(pictureBox1.Bottom >= pictureBox2.Bottom && pictureBox1.Left<=pictureBox2.Left && pictureBox1.Right >= pictureBox2.Right)
            {
                vertical = -vertical + 1;
                
            }
                
            //pictureBox1.Top += vertical;
            if(pictureBox1.Bottom + vertical > ClientSize.Height)
            {
                pictureBox1.Top = 100;
                start = false;
                    if (MessageBox.Show("再玩一次?", "你輸了", MessageBoxButtons.YesNo).ToString() == "Yes")
                    {
                    pictureBox1.Left= 100;
                    
                    horizontal = new Random().Next(0, 10);
                    vertical = 10-horizontal;
                    start = true;
                    pictureBox2.Top = ClientSize.Height - 50;
                }
                
            }

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }
        int num = 30;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:

                    if ((pictureBox2.Left + num > 0 && pictureBox2.Right + num < ClientSize.Width))
                        pictureBox2.Left += num;
                    break;

                case Keys.Left:
                    if ((pictureBox2.Left - num > 0 && pictureBox2.Right - num < ClientSize.Width))
                        pictureBox2.Left -= num;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            horizontal = new Random().Next(0,10);
            vertical = 10-horizontal;
            start = true;
            pictureBox2.Top = ClientSize.Height - 50;

        }
    }
}