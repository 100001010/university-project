using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string strPath;
            DirectoryInfo di;

            strPath = "MyDir\\SubDir";

            try
            {
                if (Directory.Exists(strPath))
                {
                    MessageBox.Show("目錄已存在");
                    return;
                }

                di = Directory.CreateDirectory(strPath);
                MessageBox.Show("建立目錄完成");
            }
            catch (IOException ex)
            {
                MessageBox.Show("建立目錄錯誤");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string strPath = "MyDir\\SubDir";

            try
            {
                if (!Directory.Exists(strPath))
                {
                    MessageBox.Show("目錄不存在");
                    return;
                }
                Directory.Delete(strPath);
                MessageBox.Show("完成刪除目錄");
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法刪除目錄");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string strPath = @"..\..\";
            List<string> dirs;

            try
            {
                dirs = new List<string>(
                    Directory.EnumerateDirectories(strPath, "*.*",
                    SearchOption.AllDirectories));
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法列舉目錄");
                return;
            }

            foreach (var item in dirs)
                textBox1.AppendText(item.ToString() + "\r\n");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("SourceDir");

            if (di.Exists == false)
            {
                di.Create();
                DirectoryInfo dis = di.CreateSubdirectory("SubDir");
                MessageBox.Show("建立目錄Source與目錄SubDir成功");
            }
            else
                MessageBox.Show("目錄已存在");
              

            if (Directory.Exists("..\\TempDir") == false)
            {
                di.MoveTo("..\\TempDir");
                MessageBox.Show("移動目錄成功");
            }
            else
                MessageBox.Show("目錄已存在");
        }
    }
}
