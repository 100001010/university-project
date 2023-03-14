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
        enum days
        {
            Monday = 4, Tuesday = 3, Wednesday = 5, Thursday = 7,
            Friday = 2, Saturday = 6, Sunday = 8
        };

        int hour = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                hour += (int)days.Monday;
            else
                hour -= (int)days.Monday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
                (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                hour += (int)days.Tuesday;
            else
                hour -= (int)days.Tuesday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
              (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                hour += (int)days.Wednesday;
            else
                hour -= (int)days.Wednesday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
              (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                hour += (int)days.Thursday;
            else
                hour -= (int)days.Thursday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
              (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                hour += (int)days.Friday;
            else
                hour -= (int)days.Friday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
              (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                hour += (int)days.Saturday;
            else
                hour -= (int)days.Saturday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
              (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                hour += (int)days.Sunday;
            else
                hour -= (int)days.Sunday;

            label2.Text = "本周上班時數=" + hour.ToString() + ", 薪資=" +
              (Convert.ToInt32(textBox1.Text) * hour).ToString();
        }
    }
}
