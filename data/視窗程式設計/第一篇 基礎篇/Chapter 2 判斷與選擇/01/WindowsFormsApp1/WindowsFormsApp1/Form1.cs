﻿using System;
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
            int age;  //年齡

            age = Convert.ToInt32(textBox1.Text);

            if (age < 18)
            {
                MessageBox.Show("未滿18歲不能買酒");
            }
        }
    }
}
