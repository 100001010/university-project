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
            string strFileName = @"test1.txt";
            string[] strWrite = { "12345", "67890" };
            string[] strRead;

            try
            {     //寫入資料
                File.AppendAllLines(strFileName, strWrite);
                MessageBox.Show("完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show("寫入資料錯誤");
            }

            try
            {    // 讀取資料
                strRead = File.ReadAllLines(strFileName);
                foreach (var item in strRead)
                    textBox1.AppendText(item + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取資料錯誤");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string strFileName = "test2.txt";
            FileStream fs = null;
            string str = "File.Open";

            try
            {
                fs = File.Open(strFileName, FileMode.Create,
                                            FileAccess.Write);
                MessageBox.Show("開啟檔案。");
                fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
                MessageBox.Show("寫入資料。");
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤。");
                return;
            }
            finally
            {
                fs.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            string str = "File.Create";

            //使用Create方法建立檔案並寫入資料。
            fs = File.Create("test3.txt", 256,
                              FileOptions.SequentialScan);
            fs.Write(Encoding.UTF8.GetBytes(str), 0, str.Length);
            fs.Close();
            MessageBox.Show("建立檔案並寫入資料成功。");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string strSource = "test1.txt"; //來源檔案
            string strTarget = "copy.txt";  //目的檔案

            if (!File.Exists(strSource)) //先檢查檔案是否存在
            {
                MessageBox.Show("檔案不存在，無法進行拷貝");
                return;
            }

            try
            {
                File.Copy(strSource, strTarget);
                if (File.Exists(strTarget)) //檢查拷貝的檔案是否存在
                    MessageBox.Show("檔案拷貝成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("拷貝檔案失敗");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string strDelete = "copy.txt";

            if (!File.Exists(strDelete))
                MessageBox.Show("檔案不存在。");
            else
            {
                try
                {
                    File.Delete(strDelete);
                    if (!File.Exists(strDelete))
                        MessageBox.Show("檔案刪除成功。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("無法刪除檔案");
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string strSource = "test1.txt";
            string strTarget = "..\\move.txt";

            if (!File.Exists(strSource))
                MessageBox.Show("檔案不存在。");
            else
            {
                try
                {
                    File.Move(strSource, strTarget);
                    if (File.Exists(strTarget))
                        MessageBox.Show("檔案移動成功。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("檔案已存在，或檔案無法移動");
                }
            }
        }
    }
}
