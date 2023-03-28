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

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void RadioButton4_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void RadioButton5_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void RadioButton6_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void RadioButton7_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void ListView1_SelectedIndexChanged(object sender, 
            EventArgs e)
        {
            //當在ListViw1中，所有選取的項目的索引有所改變的時候，
            //會觸發此事件。

            ListView lv;

            if (!radioButton1.Checked)
                return;

            lv = (ListView)sender; //將sender轉型為ListView

            textBox1.Clear();

            //從所有被選取的項目集合中，逐一取出來並指定給item
            foreach (ListViewItem item in lv.SelectedItems)
            {
                //將item中所有的欄位裡的資料串在一起顯示
                foreach (ListViewItem.ListViewSubItem str in item.SubItems)
                    textBox1.AppendText(str.Text.ToString() + "  ");
                textBox1.AppendText("\r\n");
            }
        }

        private void ListView1_ItemSelectionChanged(object sender, 
            ListViewItemSelectionChangedEventArgs e)
        {
            if (!radioButton2.Checked)
                return;

            textBox1.Clear();

            //此事件在項目的選取狀態改變的時候會被觸發，所以要先篩選
            //此項目是被"選取"的狀態，而不是在"非選取"的狀態。
            if (e.IsSelected)
            {
                //先顯示編號
                textBox1.AppendText(e.ItemIndex.ToString() + " ");

                //顯示項目的三個欄位的內容
                for (int i = 0; i < e.Item.SubItems.Count; i++)
                    textBox1.AppendText(e.Item.SubItems[i].Text.
                        ToString() + "  ");

                textBox1.AppendText("\r\n");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            //取得選取的數量
            textBox1.AppendText("選取數：" +
                        listView1.SelectedItems.Count.ToString() + "\r\n");
            textBox1.AppendText("欄位數：" +
                        listView1.Columns.Count.ToString() + "\r\n");

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                foreach (ListViewItem.ListViewSubItem str in item.SubItems)
                    textBox1.AppendText(str.Text.ToString() + "  ");
                textBox1.AppendText("\r\n");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 刪除所有選擇的項目
            foreach (int no in listView1.SelectedIndices)
                listView1.Items[no].Remove();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //移除第1項目
            listView1.Items.Remove(listView1.Items[0]);
        }

        private void Button4_Click(object sender, EventArgs e)
        {            
            listView1.Clear();
        }
    }
}
