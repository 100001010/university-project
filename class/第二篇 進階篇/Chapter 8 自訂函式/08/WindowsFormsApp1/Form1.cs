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
            float top, bottom, ht; //上底、下底、高
            float area; //面積

            top = Convert.ToSingle(textBox1.Text);
            bottom = Convert.ToSingle(textBox2.Text);
            ht = Convert.ToSingle(textBox3.Text);

            area = trapezoid(height: ht, bBase: bottom, tBase: top);
            label4.Text = "面積=" + area.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            float area;

            area = trapezoid(height: 12, bBase: 24);
            label4.Text = "面積=" + area.ToString();
        }

        float trapezoid(float tBase=15, float bBase=20, float height=10)
        {
            float area; //面積

            area = (tBase + bBase) * height / 2.0f;
            return area;
        }        
    }
}
