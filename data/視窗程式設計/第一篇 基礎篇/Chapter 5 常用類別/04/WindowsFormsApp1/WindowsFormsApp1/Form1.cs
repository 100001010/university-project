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
            DateTime dt = new DateTime(2012, 1, 1);
            DateTime dt1 = new DateTime(2012, 1, 1, 14, 23, 45);
            TimeZone tz = TimeZone.CurrentTimeZone;

            textBox1.Clear();
            textBox1.AppendText(dt.Date.ToString() + "\r\n");
            textBox1.AppendText(dt1.TimeOfDay.ToString() + "\r\n");
            textBox1.AppendText(tz.StandardName.ToString() + "\r\n");
            textBox1.AppendText(DateTime.Now.ToString() + "\r\n");
            textBox1.AppendText(dt1.Year.ToString() + "\r\n");
        }
    }
}
