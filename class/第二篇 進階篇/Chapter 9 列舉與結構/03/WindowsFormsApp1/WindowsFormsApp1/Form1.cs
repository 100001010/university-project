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
        enum status { none = 0, stereo = 1, repeat = 2, bass = 4 };
        status stus = status.none;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            stus = status.none;

            if (checkBox1.Checked)
                stus |= status.stereo;

            if (checkBox2.Checked)
                stus |= status.repeat;

            if (checkBox3.Checked)
                stus |= status.bass;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string str = "";
            int st = (int)stus;

            if ((st & (int)status.stereo) == (int)status.stereo)
                str += "立體聲,";

            if ((st & (int)status.repeat) == (int)status.repeat)
                str += "循環,";

            if ((st & (int)status.bass) == (int)status.bass)
                str += "重音";

            label1.Text = "狀態：" + str;
        }
    }
}
