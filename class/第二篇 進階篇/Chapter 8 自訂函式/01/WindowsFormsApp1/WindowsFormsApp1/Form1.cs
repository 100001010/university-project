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

        void compute()
        {
            float cTemp, fTemp; //攝氏溫度、華氏溫度

            cTemp = Convert.ToSingle(textBox1.Text);
            fTemp = cTemp * 1.8f + 32;
            label3.Text = "溫度：" + fTemp;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            compute(); //呼叫compute函式
            MessageBox.Show("轉換完畢");
        }
    }
}
