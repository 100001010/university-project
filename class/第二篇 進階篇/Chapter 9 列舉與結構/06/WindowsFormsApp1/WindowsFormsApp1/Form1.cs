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
        enum PEOPLE { John, Mary, Leo }; //三個摘水果的人

        // ============== 定義計算水果的結構 ==================
        struct _FRUIT
        {
            int guava; //芭樂
            int tomato; //番茄
            int orange; //柳丁

            //建構函式
            public _FRUIT(int gu = 0, int to = 0, int or = 0)
            {
                guava = gu;
                tomato = to;
                orange = or;
            }

            //增加摘的水果
            public void add(int gu = 0, int to = 0, int or = 0)
            {
                guava = gu;
                tomato = to;
                orange = or;
            }

            public int getTotal() //計算所摘的水果總數
            {
                return guava + tomato + orange;
            }

            public int getGuava() //取得芭樂數量
            {
                return guava;
            }

            public int getTomato() //取得番茄數量
            {
                return tomato;
            }

            public int getOrange() //取得柳丁數量
            {
                return orange;
            }
        }

        //=============== 定義摘水果的結構  ================
        struct _ORCHARD
        {
            _FRUIT[] fruit; //摘水果的人數與摘水果的資料

            //建構函式
            public _ORCHARD(int peo = 1)
            {
                if (peo < 1)  //至少1人
                    peo = 1;
                fruit = new _FRUIT[peo];
            }

            //記錄某人所摘的水果
            public void add(PEOPLE no, int gu, int to, int ro)
            {
                fruit[(int)no].add(gu, to, ro);
            }

            //取得某人摘水果的總數
            public void getFruit(PEOPLE no, ref int total)
            {
                total = fruit[(int)no].getTotal();
            }

            public int countGuava() //計算所有人摘的芭樂總數
            {
                int num = 0;

                for (int i = 0; i < fruit.Length; i++)
                    num += fruit[i].getGuava();
                return num;
            }

            public int countTomato() //計算所有人摘的番茄總數
            {
                int num = 0;

                for (int i = 0; i < fruit.Length; i++)
                    num += fruit[i].getTomato();
                return num;
            }

            public int countOrange() //計算所有人摘的柳丁總數
            {
                int num = 0;

                for (int i = 0; i < fruit.Length; i++)
                    num += fruit[i].getOrange();
                return num;
            }
        }

        //====================================================
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _ORCHARD orchard = new _ORCHARD(3);
            int gu, to, or; //芭樂、番茄、柳丁
            int total = 0; //總數
            string strPeo = "", strFru = "";

            // John摘的水果
            gu = Convert.ToInt32(textBox1.Text);
            to = Convert.ToInt32(textBox2.Text);
            or = Convert.ToInt32(textBox3.Text);
            orchard.add(PEOPLE.John, gu, to, or);
            orchard.getFruit(PEOPLE.John, ref total);
            strPeo = String.Format("{0}一共摘了{1}水果, \r\n",
                                   PEOPLE.John, total);

            // Mary摘的水果
            gu = Convert.ToInt32(textBox4.Text);
            to = Convert.ToInt32(textBox5.Text);
            or = Convert.ToInt32(textBox6.Text);
            orchard.add(PEOPLE.Mary, gu, to, or);
            orchard.getFruit(PEOPLE.Mary, ref total);
            strPeo += String.Format("{0}一共摘了{1}水果, \r\n",
                                   PEOPLE.Mary, total);

            // Leo摘的水果
            gu = Convert.ToInt32(textBox7.Text);
            to = Convert.ToInt32(textBox8.Text);
            or = Convert.ToInt32(textBox9.Text);
            orchard.add(PEOPLE.Leo, gu, to, or);
            orchard.getFruit(PEOPLE.Leo, ref total);
            strPeo += String.Format("{0}一共摘了{1}水果。\r\n",
                                   PEOPLE.Leo, total);

            strFru = String.Format("芭樂共摘了{0}個，番茄共摘了{1}個，" +
                               "柳丁共摘了{2}個", orchard.countGuava(),
                         orchard.countTomato(), orchard.countOrange());

            textBox10.AppendText(strPeo); //個人摘水果的數量
            textBox10.AppendText(strFru); //各種水果的數量
        }
    }
}
