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
            DateTime dStart = new DateTime(2018, 12, 13);
            DateTime dEnd = new DateTime(2018, 12, 18);

            monthCalendar1.SelectionStart = dStart;
            monthCalendar1.SelectionEnd = dEnd;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime impDate = new System.DateTime(2018, 12, 26);

            monthCalendar1.AddBoldedDate(impDate);
            monthCalendar1.UpdateBoldedDates();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text = monthCalendar1.SelectionStart.
                                          ToShortDateString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            monthCalendar1.CalendarDimensions = new Size(4, 3);
        }

        private void MonthCalendar1_DateChanged(object sender, 
            DateRangeEventArgs e)
        {
            string str1, str2;

            str1 = String.Format("開始：{0}", monthCalendar1.
                              SelectionStart.ToShortDateString());

            str2 = String.Format("結束：{0}", monthCalendar1.
                                SelectionEnd.ToShortDateString());
            label1.Text = str1;
            label2.Text = str2;
        }
    }
}
