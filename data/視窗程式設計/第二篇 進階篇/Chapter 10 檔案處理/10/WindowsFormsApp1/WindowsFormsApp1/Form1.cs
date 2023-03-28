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
            BinaryWriter bw;

            try
            {
                using (fs = File.Create("binary.txt"))
                {
                    bw = new BinaryWriter(fs);

                    bw.Write('a');
                    bw.Write((Int16)123);
                    bw.Write("ABC");
                    bw.Write(true);
                    bw.Write('\n');
                    bw.Close();
                    fs.Close();
                    MessageBox.Show("寫入二進位檔完成");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法建立二進位檔");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            char ch;
            Int16 int16;
            string str;
            bool fg;

            try
            {
                using (fs = File.Open("binary.txt", FileMode.Open,
                          FileAccess.Read))
                {
                    br = new BinaryReader(fs);

                    ch = br.ReadChar();
                    int16 = br.ReadInt16();
                    str = br.ReadString();
                    fg = br.ReadBoolean();
                    br.Close();
                    fs.Close();
                    textBox1.AppendText(String.Format("{0}{1}{2}{3}",
                        ch, int16, str, fg));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法開啟檔案");
            }
        }
    }
}
