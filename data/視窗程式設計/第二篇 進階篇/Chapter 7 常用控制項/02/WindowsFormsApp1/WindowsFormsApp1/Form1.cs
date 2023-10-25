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

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 顯示Value屬性
            label1.Text = dateTimePicker1.Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // 自訂顯示格式
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Value = new DateTime(2010, 12, 15, 14, 20, 45);
            dateTimePicker1.CustomFormat = "'Today is:' ddd/dd/MMM" +
                                           "/yyyy, H:mm:ss";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 顯示小時
            label2.Text = dateTimePicker1.Value.Hour.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DateTimePicker dtPicker;

            dtPicker = new DateTimePicker(); //動態產生DateTimePicker
            // 設定初始值
            dtPicker.Value = new DateTime(2010, 12, 15, 14, 20, 45);
            dtPicker.Location = new Point(20, 50);
            this.Controls.Add(dtPicker);
        }
    }
}
