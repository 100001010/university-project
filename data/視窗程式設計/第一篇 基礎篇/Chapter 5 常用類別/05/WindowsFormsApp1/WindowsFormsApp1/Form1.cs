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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2000, 11, 25);
            DateTime dt1, dt2;
            int v;
            string str;

            textBox1.Clear();

            dt1 = dt.AddDays(10); //加10天
            textBox1.AppendText(dt1.ToString() + "\r\n");

            //日期比較
            v = dt.CompareTo(new DateTime(1999, 1, 1));
            textBox1.AppendText(v.ToString() + "\r\n");

            //字串轉日期時間
            dt2 = DateTime.Parse("2018/7/25T14:20:30");
            textBox1.AppendText(dt2.ToString() + "\r\n");

            //日期時間相減
            textBox1.AppendText(dt1.Subtract(dt).ToString() + "\r\n");

            //顯示短時間
            str = dt2.ToShortTimeString();
            textBox1.AppendText(str + "\r\n");
        }
    }
}
