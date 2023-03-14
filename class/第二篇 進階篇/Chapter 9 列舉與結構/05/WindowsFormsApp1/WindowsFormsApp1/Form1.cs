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
        struct _CUBOID1
        {
            public int length; //寬
            public int deep;  //長
            public int height; //高   

            public int volume()
            {
                int v;

                v = length * deep * height;
                return v;
            }
        }

        //----------------------------------------------------
        struct _CUBOID2
        {
            static int length = 1; //寬
            static int deep = 1;  //長
            static int height = 1; //高  

            public void setDimension(int l = 1, int d = 1, int h = 1)
            {
                length = l;
                deep = d;
                height = h;
            }

            public int volume()
            {
                int v;

                v = length * deep * height;
                return v;
            }
        }

        //----------------------------------------------------
        struct _CUBOID3
        {
            int length; //寬
            int deep;  //長
            int height; //高

            //結構建構函式
            public _CUBOID3(int l = 1, int d = 1, int h = 1)
            {
                length = l;
                deep = d;
                height = h;
            }

            // 計算設定長寬高
            public void setDimension(int l = 1, int d = 1, int h = 1)
            {
                length = l;
                deep = d;
                height = h;
            }

            //計算體積
            public int volume()
            {
                int v;

                v = length * deep * height;
                return v;
            }
        }

        //====================================================
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _CUBOID1 cuboid1;
            int v;

            cuboid1.length = 8;
            cuboid1.deep = 9;
            cuboid1.height = 10;
            v = cuboid1.volume();
            label1.Text = "體積=" + v.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _CUBOID2 cuboid2;
            int v;

            cuboid2.setDimension(l: 5, d: 6, h: 7);
            v = cuboid2.volume();
            label1.Text = "體積=" + v.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _CUBOID3 cuboid3;
            int v;

            cuboid3 = new _CUBOID3(3, 4, 5);
            v = cuboid3.volume();
            label1.Text = "體積=" + v.ToString();
        }
    }
}
