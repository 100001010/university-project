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
            FileInfo fi;
            List<FileInfo> strList;
            DirectoryInfo di;

            textBox1.Clear();
            fi = new FileInfo("WindowsFormsApp1.exe");
            if (fi.Exists)
                textBox1.AppendText("檔案存在\r\n");
            else
                textBox1.AppendText("檔案不存在\rr\n");

            textBox1.AppendText("目前的路徑：\r\n" +
                                     fi.DirectoryName);
            di = fi.Directory;
            strList = new List<FileInfo>(di.EnumerateFiles());
            textBox1.AppendText("\r\n===========\r\n" +
                                "目錄下的檔案：\r\n");
            foreach (var item in strList)
                textBox1.AppendText(item.Name + "\r\n");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileInfo fi;

            fi = new FileInfo("WindowsFormsApp1.exe");
            textBox1.Clear();
            textBox1.AppendText("檔案長度=" + fi.Length.ToString() +
                                 " bytes");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("test1.txt");
            StreamWriter sw = null;
            string str;

            if (!fi.Exists) //檔案不存在
            {
                using (sw = fi.CreateText()) //建立新檔
                {
                    sw.WriteLine("建立新檔");
                }
            }

            using (sw = fi.AppendText()) //新增日期時間
            {
                str = DateTime.Now.ToString();
                sw.WriteLine(str);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("test2.txt");
            string str = "1234567890";
            FileStream fs;
            byte[] str1;

            if (fi.Exists) //若檔案存在，則先刪除檔案
                fi.Delete();

            using (fs = fi.Create())
            {
                fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
            }

            fi.Refresh();
            using (fs = fi.Open(FileMode.Open, FileAccess.Read))
            {
                str1 = new byte[fi.Length];
                fs.Read(str1, 0, (int)(fi.Length));
                textBox1.AppendText(Encoding.Default.GetString(str1));
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("test2.txt");
            FileStream fs;
            string str = "abcde";

            try
            {
                using (fs = fi.OpenWrite())
                {
                    //寫入str的"bcd"
                    fs.Write(Encoding.Default.GetBytes(str), 1, 3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("test1.txt");
            FileInfo f;

            try
            {
                f = fi.Replace("test2.txt", "test2.txt.bak");
                textBox1.AppendText(f.Name.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }
    }
}
