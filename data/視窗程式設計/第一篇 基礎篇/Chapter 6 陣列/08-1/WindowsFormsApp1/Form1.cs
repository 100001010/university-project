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
        int[] stu_num; //尚不知道有多少班、每班有多少人

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[][] clas = new int[3][]; //3個班級

            clas[0] = new int[3];  //一班有3人
            clas[1] = new int[2];  //二班有2人
            clas[2] = new int[4];  //三班有4人

            //--- 此時已經知道有3班，各班有3、2、4個人 ----
            // -- 所以這時才開始配置3個長度的容量 ------
            stu_num = new int[clas.Length];

            // ---使用Getlength方法取得各班人數 -------
            for (int i = 0; i < stu_num.Length; i++)
                stu_num[i] = clas[i].GetLength(0);

            foreach (var item in stu_num)
                textBox1.AppendText(item.ToString()+"\n");
        }
    }
}
