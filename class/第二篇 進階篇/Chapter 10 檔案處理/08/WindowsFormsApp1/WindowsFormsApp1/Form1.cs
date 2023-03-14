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
using System.IO.Compression;

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
            string sourcePath; //壓縮目錄
            string extractPath = @".\extract";

            //設定壓縮目錄
            sourcePath = Application.StartupPath + @"\source";

            if (File.Exists("a.zip")) //壓縮檔若已存在，先刪除。
                File.Delete("a.zip");

            try
            {   // 建立壓縮檔
                ZipFile.CreateFromDirectory(sourcePath, "a.zip");
                textBox1.AppendText("建立壓縮檔完成\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //------ 解壓縮 --------------------------
            if (Directory.Exists(extractPath))
                Directory.Delete(extractPath, true);

            try
            {   // 建立壓縮檔
                ZipFile.ExtractToDirectory("a.zip", extractPath);
                textBox1.AppendText("解壓縮檔完成\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileStream fs;  //壓縮檔資料流
            ZipArchive zip; //
            ZipArchiveEntry entry; //用於建立壓縮檔內的項目
            StreamWriter sw;

            try
            {
                using (fs = new FileStream("test.zip", FileMode.Create))
                {
                    using (zip = new ZipArchive(fs, ZipArchiveMode.Update))
                    {
                        entry = zip.CreateEntry("123.txt");
                        using (sw = new StreamWriter(entry.Open()))
                        {
                            textBox1.Clear();
                            textBox1.AppendText("這是寫入到123.txt的資料");
                            sw.Write(textBox1.Text);
                            textBox1.AppendText("\r\n建立壓縮檔案完成\r\n");
                        }
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
            ZipArchive zip;
            List<ZipArchiveEntry> list;

            if (!File.Exists("a.zip")) //檢查button1所產生的
            {                         //壓縮檔a.zip是否存在
                MessageBox.Show("壓縮檔不存在");
                return;
            }

            textBox1.Clear();
            try
            {
                using (zip = ZipFile.OpenRead("a.zip"))
                {
                    list = new List<ZipArchiveEntry>(zip.Entries);
                    textBox1.AppendText("壓縮檔內包含了以下檔案：\r\n");
                    foreach (var item in list)
                        textBox1.AppendText(item.Name + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
