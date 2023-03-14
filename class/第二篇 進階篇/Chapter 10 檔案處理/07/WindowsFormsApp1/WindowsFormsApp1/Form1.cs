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
            StreamWriter sw;
            StreamReader sr;
            Random rd = new Random();
            int c;

            using (sw = new StreamWriter("test.txt"))
            {
                while ((c = Convert.ToChar(rd.Next(65, 91))) != 'A')
                {
                    sw.Write(Convert.ToChar(c));
                }
            }

            textBox2.Clear();
            using (sr = new StreamReader("test.txt"))
            {
                while ((c = sr.Read()) != -1)
                    textBox2.AppendText(Convert.ToChar(c).ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            StreamReader sr;
            int c;
            char[] ch = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            using (sw = new StreamWriter("test1.txt"))
            {
                sw.Write(ch, 3, 5);
            }

            textBox2.Clear();
            using (sr = new StreamReader("test1.txt"))
            {
                while ((c = sr.Read()) != -1)
                    textBox2.AppendText(Convert.ToChar(c).ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            string str;
            string[] strArr;
            FileStream fs = new FileStream("test2.txt",
                            FileMode.Append, FileAccess.Write);

            str = textBox1.Text;
            if (str.Length == 0)
            {
                fs.Close();
                return;
            }

            using (sw = new StreamWriter(fs, Encoding.UTF8, 512))
            {
                sw.WriteLine(str);
            }

            textBox2.Clear();
            try
            {
                strArr = File.ReadAllLines("test2.txt");
                foreach (var item in strArr)
                    textBox2.AppendText(item + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取資料失敗");
            }
        }
    }
}
