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
            string strPath1 = @"aa\bb\cc.txt";
            string strPath2 = @"aa\bb\dd";
            string result;

            textBox1.Clear();
            //更改、加入附檔名
            result = Path.ChangeExtension(strPath1, ".bak");
            textBox1.AppendText(result + "\r\n");
            result = Path.ChangeExtension(strPath2, ".jpg");
            textBox1.AppendText(result + "\r\n");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string[] strArr = { "aa", "bb", "cc.txt" };
            string strPath, str;

            // 將多個字串合併為一個路徑
            strPath = Path.Combine(strArr);
            textBox1.Clear();
            textBox1.AppendText("合併字串成為路徑：" + strPath + "\r\n");
            // 只取出路徑
            str = Path.GetDirectoryName(strPath);
            textBox1.AppendText("取出路徑：" + str + "\r\n");
            // 只取出檔案的副檔名
            str = Path.GetExtension(strPath);
            textBox1.AppendText("副檔名：" + str + "\r\n");
            // 取出完整檔名
            str = Path.GetFileName(strPath);
            textBox1.AppendText("完整檔名：" + str + "\r\n");
            // 只取出主檔名
            str = Path.GetFileNameWithoutExtension(strPath);
            textBox1.AppendText("主檔名：" + str + "\r\n");
            str = Path.GetFullPath(strPath);
            textBox1.AppendText("完整路徑：" + str + "\r\n");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string str;
            bool fg;

            textBox1.Clear();
            str = Path.GetTempPath();
            textBox1.AppendText("取得暫存目錄：" + str + "\r\n");

            str = Path.GetPathRoot(str);
            textBox1.AppendText("根目錄：" + str + "\r\n");

            str = Path.GetRandomFileName();
            textBox1.AppendText("取得隨機的檔名：" + str + "\r\n");

            fg = Path.HasExtension(@"c:\aa\bb\cc.txt");
            textBox1.AppendText("是否有副檔名：" + fg.ToString() + "\r\n");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string str;

            textBox1.Clear();
            str = Environment.GetFolderPath(
                Environment.SpecialFolder.DesktopDirectory);
            textBox1.AppendText(str + "\r\n");

            str = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
            textBox1.AppendText(str + "\r\n");

            str = Environment.GetFolderPath(
                Environment.SpecialFolder.MyMusic);
            textBox1.AppendText(str + "\r\n");

            str = Environment.GetFolderPath(
                Environment.SpecialFolder.MyPictures);
            textBox1.AppendText(str + "\r\n");

            str = Environment.GetFolderPath(
                Environment.SpecialFolder.CommonDocuments);
            textBox1.AppendText(str + "\r\n");
        }
    }
}
