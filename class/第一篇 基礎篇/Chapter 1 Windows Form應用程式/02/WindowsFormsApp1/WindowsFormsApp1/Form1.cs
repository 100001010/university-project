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
            string caption, text; //標題、資訊息
            DialogResult result;  //MessageBox回傳值

            text = textBox1.Text; //取得訊息
            caption = textBox2.Text;  //取得標題

            result = MessageBox.Show(text, caption,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            label3.Text = result.ToString();   //顯示回傳值      
        }
    }
}
