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
        int[] array = { 1, 2, 3, 4, 5, 6 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int length, new_length; //陣列長度, 新的陣列長度
            int no; //使用者輸入的陣列插入位置
            int val, j; //使用者輸入的值
            int[] tmp; //暫存陣列

            length = array.Length; //取得陣列長度

            no = Convert.ToInt32(textBox1.Text);
            val = Convert.ToInt32(textBox2.Text);

            if ((no - 1) < -1 || (no - 1) >= length)
            {
                MessageBox.Show("超過範圍");
                return;
            }

            // 配置記憶體給臨時陣列tmp
            new_length = length + 1;
            tmp = new int[new_length];

            //將插入點之前的元素拷貝到tmp
            for (int i = 0; i < no; i++)
                tmp[i] = array[i];

            // 插入值
            tmp[no] = val;

            //將插入點之後的元素拷貝到tmp
            j = no + 1;
            for (int i = no; i < length; i++, j++)
                tmp[j] = array[i];

            //增加陣列array的大小，以符合插入元素後的陣列
            Array.Resize(ref array, new_length);

            //將tmp陣列拷貝到array陣列
            for (int i = 0; i < new_length; i++)
                array[i] = tmp[i];

            foreach (var item in array)
                textBox3.AppendText(item.ToString() + "\r\n");

            textBox3.AppendText("陣列長度=" + 
                array.Length.ToString() + "\r\n");
        }
    }
}
