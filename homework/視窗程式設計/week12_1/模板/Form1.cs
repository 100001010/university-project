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

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "BMP(*BMP)*|BMP|JPEG(*.JPG)|*.JPG";
            openFileDialog1.Title = "openfile";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                另存新檔ToolStripMenuItem.Enabled = true;
                關閉檔案ToolStripMenuItem.Enabled = true;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton2.Text = "另存新檔";
                toolStripButton3.Text = "關閉檔案";
                path1.Text = openFileDialog1.FileName;
                process.Enabled = true; 


            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG(*.JPG)|*.JPG|BMP(*BMP)*|BMP";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void 關閉檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            另存新檔ToolStripMenuItem.Enabled = false;
            關閉檔案ToolStripMenuItem.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            path1.Text = "";

        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            開啟舊檔ToolStripMenuItem_Click(sender,  e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            另存新檔ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            關閉檔案ToolStripMenuItem_Click( sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
