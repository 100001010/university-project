using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace CH1_1Console
{
    class Console_CH1_1 : Form  //繼承System.Windows.Forms的Form
    {
        Label label1;     //宣告label1為Label物件
        Label label2;     //宣告label2為Label物件
        Button button1;   //宣告button1為Button物件
        TextBox textBox1; //宣告textBox1為TextBox物件
        float cTemp, fTemp;
        string ST = "華氏溫度";
        public Console_CH1_1()
        {
            ///建構各物件
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            //設定各物件的屬性
            label1.Left = 56;
            label1.Top = 81;
            label1.Width = 123;
            label1.Height = 19;
            label1.Font = new Font("新細明體", 14.25F, FontStyle.Regular,GraphicsUnit.Point, ((byte)(136)));
            label1.Text = "輸入攝氏溫度";
            label1.AutoSize = true;
            label2.Left = 56;
            label2.Top = 321;
            label2.Width = 85;
            label2.Height = 19;
            label2.Font = new Font("新細明體", 14.25F, FontStyle.Regular,GraphicsUnit.Point, ((byte)(136)));
            label2.Text = ST;
            label2.AutoSize = true;
            button1.Left = 58;
            button1.Top = 201;
            button1.Width = 185;
            button1.Height = 35;
            button1.Text = "轉換";
            button1.Font = new Font("新細明體", 14.25F, FontStyle.Bold,GraphicsUnit.Point, ((byte)(136)));
            textBox1.Left = 283;
            textBox1.Top = 78;
            textBox1.Width = 100;
            textBox1.Height = 22;
            textBox1.Text = "";
            textBox1.Font = new Font("新細明體", 14.25F, FontStyle.Regular,GraphicsUnit.Point, ((byte)(136)));
            this.Width = 800;
            this.Height = 450;
            this.Text = "田咏帟";
            string path = "Y:\\ch1-1_console\\NewFolder1\\a4wtf-q8k1c-001.ico";            
            using (var stream = File.OpenRead(path))
            {
                this.Icon = new Icon(stream);
            }
            //在Form中加入各控制項物件
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(button1);
            this.Controls.Add(textBox1);

            //設定Button的Click事件函數
            button1.Click += new EventHandler(button1_Click_Event);
        }
        private void button1_Click_Event(Object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cTemp = Convert.ToSingle(textBox1.Text);
                fTemp = cTemp * 9 / 5 + 32;
                label2.Text = ST + " = " + Convert.ToString(fTemp);
            }
            else
                label2.Text = ST;
        }
    }
}