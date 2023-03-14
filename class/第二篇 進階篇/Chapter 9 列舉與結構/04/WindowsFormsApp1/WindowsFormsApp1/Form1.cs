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
        public const int MAX_NUM = 3; //最多3位學生

        struct _STU //定義學生資料的結構
        {
            public int id;       //學號
            public string name;  //姓名
            public int age;      //年齡
            public int chin;     //中文
            public int eng;      //英文
            public int math;     //數學
        }

        _STU[] stut = new _STU[MAX_NUM]; //五位學生
        int stuNum; //目前的學生人數

        //================== 程式初始化 =======================
        void initial()
        {
            stuNum = 0; //剛開始學生人數=0

            for (int i = 0; i < MAX_NUM; i++)
            {
                stut[i].id = i + 1;
                stut[i].name = "None";
                stut[i].age = 0;
                stut[i].chin = 0;
                stut[i].eng = 0;
                stut[i].math = 0;
            }
        }

        //--------------- 清除資料  ---------------------------
        void clear()
        {
            textBox1.Text = "無名氏";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

            comboBox1.SelectedIndex = 0;
        }

        //-------------- 新增學生資料 -------------------------
        void add()
        {
            /* 此函式沒有處理錯誤的輸入，請讀者練習輸入錯誤處理 */
            stut[stuNum].id = stuNum + 1;
            stut[stuNum].name = textBox1.Text;
            stut[stuNum].age = Convert.ToInt32(comboBox1.Text);
            stut[stuNum].chin = Convert.ToInt32(textBox2.Text);
            stut[stuNum].eng = Convert.ToInt32(textBox3.Text);
            stut[stuNum].math = Convert.ToInt32(textBox4.Text);

            label2.Text = stut[stuNum].id.ToString();
            stuNum++; //學生數加1
            showData(stuNum);
        }

        //--------------- 顯示新增的資料 ----------------------
        void showData(int no)
        {
            string str = "";

            no--;
            str = String.Format("[新增] 學號：{0}, 姓名：{1}, " +
                "年齡：{2}, 國文：{3}, 英文：{4}, 數學：{5}\r\n",
                stut[no].id, stut[no].name, stut[no].age,
                stut[no].chin, stut[no].eng, stut[no].math);

            textBox5.AppendText(str);
        }

        //--------------- 計算平均 -------------------------------
        float[] compute(_STU[] stut, float[] avg)
        {
            float[] avg1 = new float[3]; //各科平均

            // 計算個人平均
            for (int i = 0; i < stut.Length; i++)
            {
                avg[i] += stut[i].chin + stut[i].eng + stut[i].math;
                avg[i] /= 3.0f;
            }

            // 計算各科平均
            for (int i = 0; i < stut.Length; i++)
            {
                avg1[0] += stut[i].chin;
                avg1[1] += stut[i].eng;
                avg1[2] += stut[i].math;
            }

            for (int i = 0; i < avg1.Length; i++)
                avg1[i] /= 3.0f;

            return avg1;
        }

        //----------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            initial(); //初始化
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (stuNum + 1 > 3)
                MessageBox.Show("人數已滿");
            else
                add(); //新增資料
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clear(); //清除資料
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            float[] avg = { 0, 0, 0 }; //個人平均
            float[] avg1; //各科平均
            string str = "";

            avg1 = compute(stut, avg);

            str = "[三人平均] ";
            for (int i = 0; i < stut.Length; i++)
                str += String.Format("{0}={1:###.##}, ",stut[i].name,avg[i]);

            textBox5.AppendText(str + "\r\n");

            //----------  計算各科平均------------------------------         
            str = String.Format("[三科平均] 國文={0:###.##}, 英文={1:###.##},"
                             + " 英文={2:###.##}", avg1[0], avg1[1], avg1[2]);

            textBox5.AppendText(str + "\r\n");
        }
    }
}
