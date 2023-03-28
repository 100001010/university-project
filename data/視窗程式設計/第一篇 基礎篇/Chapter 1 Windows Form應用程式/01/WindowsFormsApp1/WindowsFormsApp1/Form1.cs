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
            float cTemp, fTemp; //攝氏溫度、華氏溫度

            cTemp = Convert.ToSingle(textBox1.Text);

            fTemp = cTemp * 9 / 5 + 32;

            fTemp = cTemp * 1.8f + 32;

            label3.Text = Convert.ToString(fTemp);
        }
    }
}
