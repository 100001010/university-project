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

            maskedTextBox2.ValidatingType = typeof(DateTime);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = textBox1.Text;
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, 
            MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "輸入錯誤";
                toolTip1.Show("輸入資料已滿", maskedTextBox1, 0,
                                                    -100, 2000);
            }
            else
            {
                if (e.Position == maskedTextBox1.Mask.Length)
                {
                    toolTip1.ToolTipTitle = "輸入錯誤";
                    toolTip1.Show("資料末端", maskedTextBox1, 0,
                                                    -100, 2000);
                }
                else
                {
                    toolTip1.ToolTipTitle = "輸入錯誤";
                    toolTip1.Show("輸入格式錯誤", maskedTextBox1, 0,
                                                        -100, 2000);
                }
            }
        }

        private void MaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(maskedTextBox1);
        }

        private void MaskedTextBox2_TypeValidationCompleted(object sender, 
            TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "錯誤的日期";
                toolTip1.Show("日期錯誤： mm/dd/yyyy.", maskedTextBox2,
                                                        0, -100, 2000);
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate < DateTime.Now)
                {
                    toolTip1.ToolTipTitle = "錯誤的日期";
                    toolTip1.Show("日期必須大於今天", maskedTextBox2, 0,
                                                           -100, 2000);
                    e.Cancel = true;
                }
            }
        }

        private void MaskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(maskedTextBox2);
        }
    }
}
