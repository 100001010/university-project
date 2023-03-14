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
            string picPath; //存放圖示的路徑
            Image img;

            picPath = Application.ExecutablePath;
            for (int i = 0; i < 6; i++)  //尋找存放圖片的目錄
                picPath = System.IO.Directory.GetParent(picPath).
                                                    ToString();
            picPath += @"\pic\";

            //----- 建立男性和女性的小圖示 ------------------
            img = Image.FromFile(picPath + "icon3.png");
            imageList1.Images.Add(img);
            img = Image.FromFile(picPath + "icon4.png");
            imageList1.Images.Add(img);
            listView1.SmallImageList = imageList1;

            //-----  建立核取方塊的小圖示  ---------------
            img = Image.FromFile(picPath + "icon7.png");
            imageList2.Images.Add(img);
            img = Image.FromFile(picPath + "icon8.png");
            imageList2.Images.Add(img);
            listView1.StateImageList = imageList2;

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //---------  建立三個欄位  ----------            
            listView1.Columns.Add("姓名", 120);
            listView1.Columns.Add("住址", 150);
            listView1.Columns.Add("電話", 100);

            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string[] name = { "張三郎", "真美麗", "王小明" };
            string[] address = { "民生路225號", "愛國西路1號",
                                 "中央路120號"};
            string[] phone = { "22576267" , "22661878" ,
                               "0938123456"};

            listView1.CheckBoxes = true; //使用核取方塊

            for (int i = 0; i < 3; i++)
            {                
                listView1.Items.Add(name[i]); //姓名                  
                listView1.Items[i].SubItems.Add(address[i]); //住址
                listView1.Items[i].SubItems.Add(phone[i]); //電話
                listView1.Items[i].StateImageIndex = 0; //非勾選狀態
            }

            listView1.Items[0].ImageIndex = 0; //男性icon
            listView1.Items[1].ImageIndex = 1; //女icon           
            listView1.Items[2].ImageIndex = 0; //男icon

            button3.Enabled = false;
        }

        private void ListView1_ItemChecked(object sender, 
            ItemCheckedEventArgs e)
        {
            textBox1.Clear();

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                foreach (ListViewItem.ListViewSubItem str in
                                                   item.SubItems)
                    textBox1.AppendText(str.Text.ToString() + "  ");
                textBox1.AppendText("\r\n");
            }
        }
    }
}
