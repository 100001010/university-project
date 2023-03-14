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
            int[] array = { 27, 22, 29, 15, 18 };
            int length; //陣列長度
            int temp;
            string str = "";

            foreach (var item in array) //將陣列裡的元素串成一列
                str += item.ToString() + ",";
            textBox1.AppendText("陣列原始資料：" + str + "\r\n");

            length = array.Length; //取得陣列的長度
            textBox1.AppendText("陣列長度=" + length.ToString() +
                "\r\n");

            // 氣泡排序法
            for (int i = 0; i < length - 1; i++)
                for (int j = length - 1; j >= i + 1; j--)
                    if (array[j] < array[j - 1])
                    {   //透過變數temp，進行兩數交換
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }

            str = "";
            foreach (var item in array) //將陣列裡的元素串成一列
                str += item.ToString() + ",";
            textBox1.AppendText("排序後，陣列資料：" + str + "\r\n");
        }
    }
}
