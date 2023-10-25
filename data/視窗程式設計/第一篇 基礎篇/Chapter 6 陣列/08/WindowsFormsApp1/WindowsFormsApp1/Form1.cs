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
        int[] stu_num = { 3, 2, 4 };

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Height = 25;
            }

            //設定每一欄位的寬度
            for (int i = 0; i < 5; i++)
                dataGridView1.Columns[i].Width = 70;

            //輸入班級編號
            dataGridView1.Rows[0].Cells[0].Value = "一";
            dataGridView1.Rows[1].Cells[0].Value = "二";
            dataGridView1.Rows[2].Cells[0].Value = "三";

            //設定dataGridView1的寬與高
            dataGridView1.Width = dataGridView1.Columns[0].Width * 8;
            dataGridView1.Height = dataGridView1.Rows[0].Height * 5;

            //將不可輸入的儲存格設定為淺灰色、唯獨
            dataGridView1.Columns[5].DefaultCellStyle.BackColor =
                                                 Color.LightGray;
            dataGridView1.Rows[0].Cells[4].ReadOnly = true;
            dataGridView1.Rows[0].Cells[4].Style.BackColor =
                                                 Color.LightGray;
            for (int i = 3; i <= 4; i++)
            {
                dataGridView1.Rows[1].Cells[i].ReadOnly = true;
                dataGridView1.Rows[1].Cells[i].Style.BackColor =
                                                   Color.LightGray;
            }

            for (int i = 0; i < 3; i++)
                for (int j = 1; j <= stu_num[i]; j++)
                    dataGridView1.Rows[i].Cells[j].Value = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[][] clas = new int[3][];
            Single avg;

            clas[0] = new int[3];
            clas[1] = new int[2];
            clas[2] = new int[4];

            //讀取使用者輸入的成績，並儲存到clas陣列
            try
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < stu_num[i]; j++)
                        clas[i][j] = Convert.ToInt32(
                           dataGridView1.Rows[i].Cells[j + 1].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("輸入錯誤");
                return;
            }

            //計算平均
            for (int i = 0; i < 3; i++)
            {
                avg = 0;
                for (int j = 0; j < stu_num[i]; j++)
                    avg += clas[i][j];

                avg /= stu_num[i];
                dataGridView1.Rows[i].Cells[5].Value = avg;
            }
        }
    }
}
