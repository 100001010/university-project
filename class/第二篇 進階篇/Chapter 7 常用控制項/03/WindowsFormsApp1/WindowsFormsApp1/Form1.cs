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

        private void LinkLabel1_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Links[0].LinkData = "www.google.com";

            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            linkLabel1.LinkVisited = true;
        }
    }
}
