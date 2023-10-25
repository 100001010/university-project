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
            label1.ContextMenuStrip = contextMenuStrip1;
        }

        private void ESubItem2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "狀態：" +
                                         eSubItem2.Text;
            if (eSubItem2.Text == "開始")
                eSubItem2.Text = "暫停";
            else
                eSubItem2.Text = "開始";
        }

        private void ToolStripContainer1_ContentPanel_MouseMove(
                               object sender, MouseEventArgs e)
        {
            string str;

            str = String.Format("X={0}, Y={1}", e.Location.X,
                                                  e.Location.Y);
            toolStripStatusLabel1.Text = str;
        }

        private void CSubItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "更改";
        }

        private void CSubItem2_Click(object sender, EventArgs e)
        {
            label1.Text = "label1";
        }

        private void FSubItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("建立新檔");
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("開啟舊檔");
        }
    }
}