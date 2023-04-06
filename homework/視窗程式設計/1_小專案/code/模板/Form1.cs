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
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Left + horizontal < 0 || pictureBox1.Right + horizontal > ClientSize.Width)
            {
                horizontal = -horizontal;
            }
            if (pictureBox1.Top + vertical < 30 || pictureBox1.Bottom + vertical > ClientSize.Height)
            {
                vertical= -vertical;
            }

            pictureBox1.Left += horizontal;
            pictureBox1.Top+= vertical;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}