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
            numericUpDown1.Maximum = 5;
            numericUpDown1.Minimum = 0;
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = (decimal)0.2;

            numericUpDown1.Enabled = true;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }
    }
}
