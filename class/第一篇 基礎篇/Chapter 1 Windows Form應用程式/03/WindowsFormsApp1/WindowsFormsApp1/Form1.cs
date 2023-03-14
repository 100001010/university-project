using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string account, password;

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = "帳號：" + account;
            label2.Text = "密碼：" + password;
        }

        public Form1()
        {
            InitializeComponent();

            account = Interaction.InputBox("輸入帳號", "登入",
                "Mary", -1, -1);

            password = Interaction.InputBox("輸入密碼", "登入",
                "", -1, -1);
        }
    }
}
