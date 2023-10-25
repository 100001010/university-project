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
        int move = 10; //球每次的移動量

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ovalShape1.Left <= 0)
                move = -move; //改變移動量的正負號

            if (ovalShape1.Left + ovalShape1.Width >= ClientSize.Width)
                move = -move;  //改變移動量的正負號

            ovalShape1.Left += move;  //移動球的位置 
        }
    }
}
