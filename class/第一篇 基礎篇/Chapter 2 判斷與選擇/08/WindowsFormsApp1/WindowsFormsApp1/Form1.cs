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

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string bankNo; //儲存銀行代號

            if (e.KeyChar == 13) //按了Enter
            {
                bankNo = textBox1.Text;

                switch (bankNo)
                {
                    case "816":
                        label3.Text = "安泰商業銀行";
                        break;

                    case "021":
                        label3.Text = "花旗商業銀行";
                        break;

                    case "700":
                        label3.Text = "郵局";
                        break;

                    case "004":
                        label3.Text = "臺灣銀行";
                        break;

                    default:
                        MessageBox.Show("查無此銀行，請重新輸入");
                        label3.Text = "";
                        break;
                }
            }
        }
    }
}
