using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
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
        //--------------------------------------------------
        static TabPage tePa;


        //--------------------------------------------------
        private void AllEnable()
        {
            SaveFileTSM.Enabled = true;
            SaveFileTSB.Enabled = true;
            CloseFileTSB.Enabled = true;
            CloseFileTSM.Enabled = true;
            ProcessTSM.Enabled = true;
            轉灰階TSM.Enabled = true;
            SaveFileTSB.Text = "另存新影像檔(Ctrl+S)";
            CloseFileTSB.Text = "關閉影像檔(Ctrl+C)";
            小畫家ToolStripMenuItem.Enabled = true;
            WaitProcess_Picture = new Bitmap(temp_Page.Picture_img);
        }
        //--------------------------------------------------
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.ShowDialog();
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "BMP(*BMP)|*.BMP|JPEG(*JPG)|*.JPG|PNG(*PNG)|*.PNG";
            openFileDialog.Title = "開啟影像檔";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tabControl.Visible = true;
                Bitmap NewImg = new Bitmap(openFileDialog.FileName);
                string Name = openFileDialog.FileName;
                TabPage New_Page = new TabPage(NewImg, Name);
                tabControl.TabPages.Add(New_Page);
                tabControl.SelectTab(New_Page);
                openFileDialog.Dispose();
                tePa = (TabPage)tabControl.SelectedTab;
                Ori_img = new Bitmap(tePa.Picture_Box.Image);
                tabControl.Visible = true;
                All_EnableOpen();
                ImageAdjust();
                Update_Status();
                Paint_Mode = 0;
                Initial_PaintTool();
            }
        }
    }
}
