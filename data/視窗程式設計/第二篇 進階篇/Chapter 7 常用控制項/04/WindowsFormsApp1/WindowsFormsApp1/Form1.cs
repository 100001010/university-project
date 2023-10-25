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
        LinkLabel linkLabel1 = null;

        public Form1()
        {
            InitializeComponent();            

            // 設定linkLabel1的外觀
            linkLabel1 = new LinkLabel();
            linkLabel1.Font = new Font("微軟正黑體", 12);
            linkLabel1.Size = new Size(250, 16);
            linkLabel1.AutoSize = true;
            linkLabel1.Text = "Home  Visit  Youtube";
            linkLabel1.Location = new Point(50, 30);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            // 將linkLabel1加到Form1
            Controls.Add(linkLabel1);

            //第1個為錯誤的超連結
            linkLabel1.Links.Add(0, 4, "home.com"); 
            //第2個連結
            linkLabel1.Links.Add(6, 5, "www.google.com");
            //第3個連結至Youtube
            linkLabel1.Links.Add(13, 7, "www.youtube.com");

            //將第2個超連結設定為無效
            linkLabel1.Links[1].Enabled = false; 

            linkLabel1.LinkClicked +=
                new LinkLabelLinkClickedEventHandler(MyLinkClicked);
        }

        void MyLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string str;

            linkLabel1.Links[linkLabel1.Links.IndexOf(e.Link)].Visited =
                true;

            str = e.Link.LinkData.ToString();
            if (str != null && str.StartsWith("www"))
                System.Diagnostics.Process.Start(str);
            else
                MessageBox.Show("錯誤的超連結：" + str);
        }
    }
}
