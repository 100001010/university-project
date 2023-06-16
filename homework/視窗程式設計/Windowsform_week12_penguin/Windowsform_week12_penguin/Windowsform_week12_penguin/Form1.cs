using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsform_week12_penguin
{
    public partial class Form1 : Form
    {   
        private Bitmap BmpOut;
        private BitmapData DataIn1;
        private BitmapData DataOut;

        static int countimage = 0;
        static TabPage1 tempTabPage1;
        static Bitmap bmpimage;
        private int piantingmode;
       // Graphics drawing = Graphics.FromImage(bmpimage);
        private Point cutphoto;
        private Bitmap bmptemp;
        private Point beging;
        private Point ending;

        public Form1()
        {
            InitializeComponent();
            filemenu();
            procmenu();
        }
        public Bitmap NewBitmap(Image Img)
        {
            Bitmap tempimage = Img as Bitmap;
            int h2 = Img.Height;
            int w2 = Img.Width;
            Bitmap outbmp = new Bitmap(w2, h2, PixelFormat.Format24bppRgb);
            BitmapData indata = tempimage.LockBits(new Rectangle(0,0,w2,h2),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData outdata = outbmp.LockBits(new Rectangle(0, 0, w2, h2),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* pin= (byte*)indata.Scan0.ToPointer();
                byte* pout= (byte*)indata.Scan0.ToPointer();
                for (int y = 0; y < indata.Height; y++)
                {
                    for (int x = 0; x < indata.Width; x++)
                    {
                        pout[0] = pin[0];
                        pout[1] = pin[1];
                        pout[2] = pin[2];
                        pin += 3;
                        pout += 3;
                    }
                    pin += indata.Stride - indata.Width * 3;
                    pout += outdata.Stride - outdata.Width * 3;
                }
            }
            outbmp.UnlockBits(outdata);
            tempimage.UnlockBits(indata);
            return outbmp;
        }
        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;   
            aboutBox1.ShowDialog();
        }
        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
            openFileDialog1.Title = "open picture file";
            openFileDialog1.CheckFileExists = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tabControl1.Visible = true;
                Bitmap Theimage = new Bitmap(openFileDialog1.FileName);
                string title1 = openFileDialog1.FileName;
                TabPage1 theimage = new TabPage1(Theimage, title1); 
                pic1.Image = Image.FromFile(openFileDialog1.FileName);
                tabControl1.TabPages.Add(theimage);
                tabControl1.SelectTab(theimage);
                openFileDialog1.Dispose();
                tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
                bmpimage = new Bitmap(tempTabPage1.pictureBox1.Image);
                tabControl1.Visible = true;
                draw.Enabled = true;
                save.Enabled = true;
                close.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton2.Text = "save a new file";
                toolStripButton3.Text = "close file";
                c1.Enabled=true;
                c2.Enabled=true;
                statusshow();
                piantingmode = 0;
                offturn();
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (countimage == 0)
            {
                MessageBox.Show("you have mot open the file yet");
            }
            else
            {
                saveFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
                saveFileDialog1.Title = "save a new file";
                tempTabPage1=(TabPage1)tabControl1.SelectedTab;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                tempTabPage1.theseImage.Save(saveFileDialog1.FileName);       
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            { 
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                countimage--;
                if (tabControl1.SelectedTab == null)
                {
                    tabControl1.Visible = false;
                    filemenu();
                    procmenu();

                }
                else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                }
            }
            pic1.Image = null;
            save.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            c1.Enabled = false;
            c2.Enabled = false;
            draw.Enabled = false;
            cut.Enabled = false;
            paste.Enabled = false;
            copy.Enabled = false;
            circle.Enabled = false;
            square.Enabled = false;
            color.Enabled = false;
            pen.Enabled = false;
            slash.Enabled = false;
            lineall.Enabled = false;
            dash.Enabled = false;
        }
        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void pic1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
            openFileDialog1.Title = "open picture file";
            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tabControl1.Visible = true;
                Bitmap Theimage = new Bitmap(openFileDialog1.FileName);
                string title1 = openFileDialog1.FileName;
                TabPage1 theimage = new TabPage1(Theimage, title1);
                pic1.Image = Image.FromFile(openFileDialog1.FileName);
                tabControl1.TabPages.Add(theimage);
                tabControl1.SelectTab(theimage);
                openFileDialog1.Dispose();
                tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
                bmpimage = new Bitmap(tempTabPage1.pictureBox1.Image);
                filemenu();
                procmenu();
                tabControl1.Visible = true;
                draw.Enabled = true;
                save.Enabled = true;
                close.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton2.Text = "save a new file";
                toolStripButton3.Text = "close file";
                draw.Enabled = true;
                changeToolStripMenuItem.Enabled = true;
                c1.Enabled = true;
                c2.Enabled = true;
                statusshow();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (countimage == 0)
            {
                MessageBox.Show("you have mot open the file yet");
            }
            else
            {
                saveFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
                saveFileDialog1.Title = "save a new file";
                tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tempTabPage1.theseImage.Save(saveFileDialog1.FileName);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                countimage--;
                if (tabControl1.SelectedTab == null)
                {
                    tabControl1.Visible = false;
                    filemenu();
                    procmenu();

                }
                else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                }
            }
            pic1.Image = null;
            save.Enabled = false;
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            c1.Enabled = false;
            c2.Enabled = false;
            draw.Enabled = false;
            cut.Enabled = false;
            paste.Enabled = false;
            copy.Enabled = false;
            circle.Enabled = false;
            square.Enabled = false;
            color.Enabled = false;
            pen.Enabled = false;
            slash.Enabled = false;
            lineall.Enabled = false;
            dash.Enabled = false;
            changeToAshToolStripMenuItem.Enabled = false;
        }
        private void Grayseting(int flag)
        {
            tempTabPage1 = (TabPage1)tabControl1.SelectedTab;    
            Bitmap BmpInt1 = new Bitmap(pic1.Image);
            int ht = BmpInt1.Height;
            int wt = BmpInt1.Width;

            BmpOut = new Bitmap(wt,ht, PixelFormat.Format24bppRgb);
            DataIn1 = BmpInt1.LockBits(new Rectangle(0, 0, wt, ht), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            DataOut = BmpOut.LockBits(new Rectangle(0, 0, wt, ht), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                double graynumber;
                byte* pictureIn = (byte*)DataIn1.Scan0.ToPointer();
                byte* pictureOut = (byte*)DataOut.Scan0.ToPointer();    
                for(int i=0;i< DataIn1.Height;i++)
                {
                    for(int l=0;l< DataIn1.Width;l++)
                    {
                        if (flag == 1)
                            graynumber = (pictureIn[0] + pictureIn[1] + pictureIn[2]) / 3;
                        else
                            graynumber = 0.299 * pictureIn[2] + 0.587 * pictureIn[1] + 0.114 * pictureIn[0];
                        pictureOut[0]= (byte)graynumber;    
                        pictureOut[1] = (byte)graynumber;
                        pictureOut[2] = (byte)graynumber;
                        pictureIn += 3;
                        pictureOut += 3;
                    }
                    pictureIn += DataIn1.Stride - DataIn1.Width * 3;
                    pictureOut += DataOut.Stride - DataOut.Width * 3;
                }
            }
            BmpOut.UnlockBits(DataOut);
            BmpInt1.UnlockBits(DataIn1);
            tempTabPage1.theseImage = BmpOut;
            pic1.Image= BmpOut; 
        }

        private void filemenu()
        {
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            save.Enabled = false;
            close.Enabled = false;
            draw.Enabled = false;
            changeToolStripMenuItem.Enabled = false;
            c1.Enabled = false;
            c2.Enabled = false;
        }
        private void procmenu()
        {
            draw.Enabled = false;
            cut.Enabled = false;
            paste.Enabled = false;
            copy.Enabled = false;
            circle.Enabled = false;
            square.Enabled = false;
            color.Enabled = false;
            pen.Enabled = false;
            slash.Enabled = false;
            lineall.Enabled = false;
            dash.Enabled = false;
        }
        
        private void asaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grayseting(1);
        }
        private void asasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grayseting(2);
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click_1(object sender, EventArgs e)
        {

        }
        private void newpage(Bitmap newmap1)
        {
            tabControl1.Visible = true;
            tempTabPage1=(TabPage1)tabControl1.SelectedTab;
            string titlename = tempTabPage1.path1;
            TabPage1 mineTabpage = new TabPage1(newmap1, titlename + "*");
            
            tabControl1.TabPages.Add(mineTabpage);
            tabControl1.SelectTab(mineTabpage);
        }
        public partial class TabPage1 : TabPage
        {
            public PictureBox pictureBox1;
            public Bitmap theseImage;
            public string path1 = "";
            public TabPage1(Bitmap newMap, string filename)
            {
                this.AutoScroll= true;
                this.Text = filename.Remove(0, filename.LastIndexOf("\\") + 1);
                path1= filename;
                pictureBox1 = new PictureBox();
                this.pictureBox1.Location= new System.Drawing.Point(0,0);
                this.pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
                pictureBox1.Width = newMap.Width;
                pictureBox1.Height = newMap.Height;
                this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                theseImage = newMap;
                pictureBox1.Image = theseImage;
                this.Controls.Add(pictureBox1);
                countimage++;
                this.pictureBox1.MouseDown += new MouseEventHandler(PictureBox_MouseDown);
                this.pictureBox1.MouseMove += new MouseEventHandler(PictureBox_MouseMove);
                this.pictureBox1.MouseUp += new MouseEventHandler(PictureBox_MouseUp);
            }
        }

        private void ShowImage()
        {
            if (tabControl1.SelectedTab != null)
            {
                tempTabPage1=(TabPage1)tabControl1.SelectedTab;       
            }
            tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
            double ro =(double)tempTabPage1.theseImage.Height/(double)tempTabPage1.theseImage.Width;

            if (ro >= 1)
            {
                tempTabPage1.pictureBox1.Height = tabControl1.Height - 26;
                tempTabPage1.pictureBox1.Width = (int)((double)(tempTabPage1.pictureBox1.Height) / ro);
            }
            else
            {
                tempTabPage1.pictureBox1.Width = tabControl1.Width - 8;
                tempTabPage1.pictureBox1.Height= (int)((double)(tempTabPage1.pictureBox1.Width) / ro);
            }
        }

        private void statusshow()
        {
            if (tabControl1.SelectedTab != null)
            {
                tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
                LA1.Text = tempTabPage1.theseImage.Width + "x"+
                tempTabPage1.theseImage.Height;
                LA2.Text = tempTabPage1.path1;
                LA3.Text = (int)((double)(tempTabPage1.pictureBox1.Width) / (double)(tempTabPage1.theseImage.Width) * 100) + "%";
                LA4.Text=tempTabPage1.pictureBox1.Image.PixelFormat.ToString();
            }
        }
        private void statusclose()
        {
            LA1.Text = "";
            LA2.Text = "";
            LA3.Text = "";
            LA4.Text = "";
        }
        private void tabcontrol1indexselectedchange(object sender, EventArgs e)
        {
            statusshow();
        }

        private void dashstyle()
        {
            solidToolStripMenuItem.Checked = false;
            dotLineToolStripMenuItem.Checked = false;
            dashLineToolStripMenuItem.Checked = false;
            dashDotLineToolStripMenuItem.Checked = false;
            dashDotDotLineToolStripMenuItem.Checked = false;
        }
        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencil.DashStyle= System.Drawing.Drawing2D.DashStyle.Solid;
            dashstyle();
            solidToolStripMenuItem.Checked = true;
        }

        private void piantingmenu()
        {
            big1.Checked=false;
            big2.Checked=false;
            big3.Checked=false;
            big4.Checked=false;
            big5.Checked=false;
            solidToolStripMenuItem.Checked=false;
            dotLineToolStripMenuItem.Checked = false;
            dashLineToolStripMenuItem.Checked= false;
            dashDotLineToolStripMenuItem.Checked=false;
            dashDotDotLineToolStripMenuItem.Checked = false;
            dashstyle();
        }

        private void offturn()
        {
            pen.Checked= false;
            slash.Checked = false;
            circle.Checked = false;
            square.Checked = false;
            cut.Checked = false;
            copy.Checked = false;
            paste.Checked = false;
            tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
            Bitmap bmp = new Bitmap(tempTabPage1.theseImage);  
        }
        private void draw_Click(object sender, EventArgs e)
        {
            cut.Enabled = true;
            paste.Enabled = true;
            copy.Enabled = true;
            circle.Enabled = true;
            square.Enabled = true;
            color.Enabled = true;
            pen.Enabled = true;
            slash.Enabled = true;
            lineall.Enabled = true;
            dash.Enabled = true;
            big1.Checked = true;
            solidToolStripMenuItem.Checked=true;
            tempTabPage1 = (TabPage1)tabControl1.SelectedTab;
            Bitmap bmp = new Bitmap(tempTabPage1.theseImage);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private Pen pencil = new Pen(Color.Black, 1);
        private void color_Click(object sender, EventArgs e)
        {
            piantcolor.AllowFullOpen= true;
            piantcolor.FullOpen= true;
            if (piantcolor.ShowDialog() == DialogResult.OK)
            {
                pencil.Color=piantcolor.Color;
            
            }
        }

        private void penchange(int Value)
        {
            big1.Checked = false;
            big2.Checked = false;
            big3.Checked = false;
            big4.Checked = false;
            big5.Checked = false;
            switch (Value)
            {
                case 1:
                    big1.Checked=true;
                    break;
                case 2: 
                    big2.Checked=true; 
                    break;
                case 3:
                    big3.Checked=true;
                    break;
                case 4: 
                    big4.Checked=true;
                    break;
                case 5:
                    big5.Checked=true;
                    break;
            }
            pen.Width = Value;  
        }

        private void big1_Click(object sender, EventArgs e)
        {
            penchange(1);
        }

        private void big2_Click(object sender, EventArgs e)
        {
            penchange(2);
        }

        private void big3_Click(object sender, EventArgs e)
        {
            penchange(3);
        }

        private void big4_Click(object sender, EventArgs e)
        {
            penchange(4);
        }

        private void big5_Click(object sender, EventArgs e)
        {
            penchange(5);
        }

        private void dotLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            dashstyle();
            dotLineToolStripMenuItem.Checked = true;
        }

        private void dashLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            dashstyle();
            dashLineToolStripMenuItem.Checked = true;
        }

        private void dashDotLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            dashstyle();
            dashDotLineToolStripMenuItem.Checked = true;
        }

        private void dashDotDotLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            dashstyle();
            dashDotDotLineToolStripMenuItem.Checked = true;
        }

        private void pen_Click(object sender, EventArgs e)
        {
            if (pen.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                piantingmode= 1;
                offturn();
            }
            pen.Checked=!pen.Checked;
        }

        private void slash_Click(object sender, EventArgs e)
        {
            if (slash.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                piantingmode = 2;
                offturn();
            }
            slash.Checked = !slash.Checked;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            if (circle.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                piantingmode = 3;
                offturn();
            }
            circle.Checked = !circle.Checked;
        }

        private void square_Click(object sender, EventArgs e)
        {
            if (square.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                piantingmode = 4;
                offturn();
            }
            square.Checked = !square.Checked;
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (cut.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                piantingmode = 5;
                offturn();
            }
            cut.Checked = !cut.Checked;
        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (copy.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                piantingmode = 6;
                offturn();
            }
            copy.Checked = !copy.Checked;
        }


        private void paste_Click(object sender, EventArgs e)
        {
            if (paste.Checked == true)
            {
                piantingmode = 0;
            }
            else
            {
                if (Clipboard.GetImage() == null)
                {
                    MessageBox.Show("have not any photo inside here");
                }
                else
                {
                    piantingmode = 7;
                    offturn();
                    cutphoto.X = 0;
                    cutphoto.Y = 0;
                    bmptemp = NewBitmap(pic1.Image);
                    Graphics paint1 = Graphics.FromImage(bmptemp);
                    paint1.DrawImageUnscaled(Clipboard.GetImage(), 0, 0);
                    pic1.Image= bmptemp;
                }
            }
            paste.Checked = !paste.Checked;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pic1.Image != null && piantingmode != 0 && e.Button == MouseButtons.Left)
            {
                beging.X = (int)(e.X * (pic1.Image.Width) / (pic1.Width));
                beging.Y = (int)(e.Y * (pic1.Image.Height) / (pic1.Height));
                if (paste.Checked == true)
                {
                    int cutweight = Clipboard.GetImage().Width;
                    int cutheight = Clipboard.GetImage().Height;
                    if (beging.X < cutphoto.X || beging.X > cutphoto.X + cutweight || beging.Y < cutphoto.Y || beging.Y > cutphoto.Y + cutheight)
                    {
                        paste.Checked = false;
                        piantingmode = 0;
                        cutphoto.X = 0;
                        cutphoto.Y=0;
                    }
                    bmptemp = bmpimage;
                }
            }
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pic1.Image != null && piantingmode != 0 && e.Button == MouseButtons.Left)
            {
                ending.X = (int)(e.X * (pic1.Image.Width) / (pic1.Width));
                ending.Y = (int)(e.Y * (pic1.Image.Height) / (pic1.Height));
                int leftX = ending.X > beging.X ? beging.X : ending.X;
                int leftY = ending.Y > beging.Y ? beging.Y : ending.Y;
                int rightX = ending.X > beging.X ? ending.X : beging.X;
                int rightY = ending.Y > beging.Y ? ending.Y : beging.Y;
                bmptemp = NewBitmap(bmpimage);
                Graphics painter = Graphics.FromImage(bmptemp);
                switch (piantingmode)
                {
                    case 1:
                        Graphics painter1 = Graphics.FromImage(bmpimage);
                        painter1.DrawLine(pencil, beging, ending);
                        pic1.Image = bmpimage;
                        beging = ending;
                        painter1.Dispose();
                        break;

                    case 2:
                        painter.DrawLine(pencil, beging, ending);
                        pic1.Image = bmptemp;
                        break;
                    
                    case 3:
                        painter.DrawEllipse(pencil, leftX, leftY, rightX - leftX + 1, rightY - leftY + 1);
                        pic1.Image = bmptemp;
                        break;

                    case 4:
                        painter.DrawRectangle(pencil, leftX, leftY, rightX - leftX + 1, rightY - leftY + 1);
                        pic1.Image = bmptemp;
                        break;

                    case 5:
                        Pen penp2 = new Pen(Color.Blue, 1);
                        penp2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                        painter.DrawRectangle(penp2, leftX, leftY, rightX - leftX + 1, rightY - leftY + 1);
                        pic1.Image = bmptemp;
                        break;

                    case 6:
                        cutphoto.X = ending.X - beging.X;
                        cutphoto.Y = ending.Y - beging.Y;
                        painter.DrawImageUnscaled(Clipboard.GetImage(), cutphoto);
                        pic1.Image = bmptemp;
                        break;
                }
            }
        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pic1.Image != null && piantingmode != 0 && e.Button == MouseButtons.Left)
            {
                pic1.Image = bmpimage;
                Graphics painter1 = Graphics.FromImage(bmpimage);
                ending.X = (int)(e.X * (pic1.Image.Width) / (pic1.Width));
                ending.Y = (int)(e.Y * (pic1.Image.Height) / (pic1.Height));
                int leftX = ending.X > beging.X ? beging.X : ending.X;
                int leftY = ending.Y > beging.Y ? beging.Y : ending.Y;
                int rightX = ending.X > beging.X ? ending.X : beging.X;
                int rightY = ending.Y > beging.Y ? ending.Y : beging.Y;
                switch (piantingmode)
                {
                    case 1:
                        break;
                    case 2:
                        painter1.DrawLine(pencil, beging, ending);
                        break;
                    case 3:
                        painter1.DrawEllipse(pencil, leftX, leftY, rightX - leftX + 1, rightY - leftY + 1);
                        break;
                    case 4:
                        painter1.DrawRectangle(pencil, leftX, leftY, rightX - leftX + 1, rightY - leftY + 1);
                        break;
                    case 5:
                        if(leftX < 0) leftX= 0;
                        if(leftY < 0) leftY= 0;
                        if(rightX >= pic1.Image.Width)rightX= pic1.Image.Width-1;
                        if(rightY >= pic1.Image.Height)rightY= pic1.Image.Height-1;
                        int wh = bmpimage.Width;
                        int ht = bmpimage.Height;
                        BitmapData indata = bmpimage.LockBits(new Rectangle(0, 0, wh, ht), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb); 
                        int cwh = rightX - leftX+1;
                        int cht = rightY - leftY+1;
                        Bitmap copyimage = new Bitmap (cwh, cht, PixelFormat.Format24bppRgb);
                        BitmapData copydata = copyimage.LockBits(new Rectangle(0, 0, cwh, cht), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                        bmptemp = new Bitmap(wh, ht, PixelFormat.Format24bppRgb);
                        BitmapData outdata = bmptemp.LockBits(new Rectangle(0, 0, wh, ht), ImageLockMode.WriteOnly,PixelFormat.Format24bppRgb);

                        unsafe
                        {
                            byte* pin = (byte*)indata.Scan0.ToPointer();
                            byte* pcopy= (byte*)copydata.Scan0.ToPointer();
                            byte* ptemp= (byte*)outdata.Scan0.ToPointer();
                            for (int y = 0; y < ht; y++)
                            {
                                for (int x = 0; x < wh; x++)
                                {
                                    if (x >= leftX && x < leftX + cwh && y >= leftY && y < leftY + cht)
                                    {
                                        pcopy[0] = pin[0];
                                        pcopy[1] = pin[1];
                                        pcopy[2] = pin[2];
                                        pcopy += 3;
                                        if (cut.Checked == true)
                                        {
                                            ptemp[0] = 255;
                                            ptemp[1] = 255;
                                            ptemp[2] = 255;
                                        }
                                        else
                                        {
                                            ptemp[0] = pin[0];
                                            ptemp[1] = pin[1];
                                            ptemp[2] = pin[2];
                                        }
                                    }
                                    else
                                    {
                                        ptemp[0] = pin[0];
                                        ptemp[1] = pin[1];
                                        ptemp[2] = pin[2];
                                    }
                                    ptemp += 3;
                                    pin += 3;
                                }
                                pin += indata.Stride - indata.Width * 3;
                                ptemp += outdata.Stride - outdata.Width * 3;
                                if (y >= leftY && y < leftY + cht)
                                    pcopy += copydata.Stride - copydata.Width * 3;
                            }
                        }
                        bmpimage.UnlockBits(indata);
                        copyimage.UnlockBits(copydata);
                        bmptemp.UnlockBits(outdata);
                        painter1.Dispose();
                        Clipboard.SetImage(copyimage);
                        pic1.Image= bmptemp;
                        cut.Checked= false;
                        copy.Checked= false;
                        piantingmode = 0;
                        break;

                    case 6:
                        Graphics painter = Graphics.FromImage(bmptemp);
                        painter.DrawImageUnscaled(Clipboard.GetImage(), cutphoto);
                        pic1.Image= bmptemp;
                        paste.Checked= false;
                        piantingmode = 0;
                        break;
                }
            }
        }

        static void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        static void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {

        }
        static void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
