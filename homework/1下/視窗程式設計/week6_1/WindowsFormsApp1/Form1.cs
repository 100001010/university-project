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
            int instNum, sodaNum;  //泡麵數量、汽水數量
            int instPrice, sodaPrice; //泡麵單價、汽水單價
            int totalPrice;  //總金額

            instPrice = 25;  //泡麵單價
            sodaPrice = 30;  //汽水單價

            instNum = Convert.ToInt32(textBox1.Text);  //泡麵數量
            sodaNum = Convert.ToInt32(comboBox1.Text); //汽水數量

            //計算總金額
            totalPrice = instPrice * instNum + sodaPrice * sodaNum;

            label3.Text = "總金額：" + Convert.ToString(totalPrice);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.ShowDialog();

        }
    }
}
