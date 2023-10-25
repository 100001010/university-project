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
            FileStream fs;
            string data = "1234567890abcdefghijklmnopqrstuvwxyz";

            if (File.Exists("test.txt"))
                File.Delete("test.txt");

            try
            {
                using (fs = new FileStream("test.txt",
                    FileMode.Create, FileAccess.Write))
                {
                    fs.Write(Encoding.Default.GetBytes(data), 0, data.Length);
                    MessageBox.Show("資料寫入完畢");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            byte[] data; //儲存資料
            int count = 1, pos = 0; //每次讀入的byte數、資料放置在陣列的位置
            int fileLength, len = 10;//檔案長度、每次要讀入資料的byte數
            string str;

            try
            {
                using (fs = new FileStream("test.txt", FileMode.Open,
                                            FileAccess.Read))
                {
                    fileLength = (int)fs.Length;
                    str = "檔案長度=" + fileLength.ToString() + "\r\n";
                    textBox1.AppendText(str);

                    if (fileLength <= 0)
                    {
                        MessageBox.Show("檔案長度=0");
                        fs.Close();
                        return;
                    }
                    data = new byte[fileLength];//配置陣列空間

                    if (fileLength < len) //如果檔案長度小於預設的讀入的byte數
                        len = fileLength;
                    //---------------------------------------
                    while (fileLength > 0)
                    {
                        count = fs.Read(data, pos, len); //讀入資料
                        str = String.Format("{0},{1}: {2}", count,
                            pos, Encoding.Default.GetString(data));

                        pos += count; // 下一次資料要放置在陣列的位置
                        fileLength -= count; //剩餘的檔案長度
                        if (fileLength < len)
                            len = fileLength;

                        textBox1.AppendText(str);
                        textBox1.AppendText("\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FileStream fs;
            byte b;
            int fileLength, pos;

            if (!File.Exists("test.txt"))
            {
                MessageBox.Show("檔案不存在");
                return;
            }

            try
            {
                using (fs = new FileStream("test.txt", FileMode.Open,
                                            FileAccess.Read))
                {
                    fileLength = (int)fs.Length;
                    textBox1.AppendText("檔案長度=" +
                                        fileLength.ToString() + "\r\n");

                    pos = (int)fs.Seek(3, SeekOrigin.Begin);
                    textBox1.AppendText("讀取位置=" + pos.ToString() + "\r\n");

                    textBox1.AppendText("讀取長度=" +
                                        (fileLength - pos).ToString() + "\r\n");
                    for (int i = 0; i < fileLength - pos; i++)
                    {
                        b = (byte)fs.ReadByte();
                        textBox1.AppendText((Convert.ToChar(b)).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
