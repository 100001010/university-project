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
            StreamReader sr;
            char c;
            string str;

            textBox1.Clear();
            using (sr = new StreamReader("test.txt"))
            {
                c = Convert.ToChar(sr.Peek());
                textBox1.AppendText(c.ToString() + "\r\n");

                str = sr.ReadLine();
                textBox1.AppendText(str.ToString() + "\r\n");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string fileName = "test1.txt";
            StreamReader sr;
            string data;

            textBox1.Clear();
            using (sr = new StreamReader(fileName))
            {
                while (sr.Peek() >= 0)
                {
                    data = sr.ReadLine();
                    textBox1.AppendText(data);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string fileName = "test1.txt";
            StreamReader sr;
            string data;

            textBox1.Clear();
            using (sr = new StreamReader(fileName))
            {
                data = sr.ReadToEnd();
                textBox1.AppendText(data);
            }
        }
    }
}
