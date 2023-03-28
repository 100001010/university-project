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
        enum days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        string[] week = {"星期一","星期二","星期三","星期四",
                           "星期五","星期六","星期日" };

        public Form1()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";

            switch (comboBox1.SelectedIndex)
            {
                case (int)days.Mon:
                    str = week[(int)days.Mon];
                    break;

                case (int)days.Tue:
                    str = week[(int)days.Tue];
                    break;

                case (int)days.Wed:
                    str = week[(int)days.Wed];
                    break;

                case (int)days.Thu:
                    str = week[(int)days.Thu];
                    break;

                case (int)days.Fri:
                    str = week[(int)days.Fri];
                    break;

                case (int)days.Sat:
                    str = week[(int)days.Sat];
                    break;

                case (int)days.Sun:
                    str = week[(int)days.Sun];
                    break;
            }

            label2.Text = "您選擇了：" + str;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            days d;

            d = days.Sat; //取出值

            textBox1.AppendText(d.ToString() + " ");
            textBox1.AppendText(Convert.ToInt32(d).ToString()+"\r\n");
        }
    }
}
