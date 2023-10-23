using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模板
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initial_GrayRank();
            Initial_All();
            Initial_PaintButton();
            Initial_PaintTool();
            TeCopyPicBut = copytoolStripButton4;
            TeCutPicBut = cuttoolStripButton4;
            TePastPicBut = pasttoolStripButton6;
            TePicTabCon = picthtabControl;
        }
        //vaule-------------------------------------------------------
        static TabPage1 tePa;
        static Bitmap OriImg;
        static int PicCou = 0;
        static Bitmap WaitPic;
        static int PaMo;
        static Bitmap ProPic;
        static Bitmap WaProPic;
        static Point PicSTPo;
        static TabControl TePictTabCon;
        static Bitmap picOut;
        static BitmapData DaIn;
        static BitmapData DaOut;
        static Pen myPen = new Pen(Color.Black, 1);
        static Pen myPen2 = new Pen(Color.Blue, 1);
        static Point Pic_START_Point;
        static Point MouSta;
        static Point MouEnd;
        static TabControl TePicTabCon;
        static ToolStripButton TeCutPicBut;
        static ToolStripButton TeCopyPicBut;
        static ToolStripButton TePastPicBut;
        //class--------------------------------------------------------
        public partial class TabPage1 : TabPage
        {
            public PictureBox PicBox;
            public Bitmap Picimg;
            public string Picpath = "";
            public TabPage1(Bitmap newPic, string filetitle)
            {
                this.AutoScroll = true;
                this.Text = filetitle.Remove(0, filetitle.LastIndexOf("\\") + 1);
                Picpath = filetitle;
                PicBox = new PictureBox();
                this.PicBox.Location = new System.Drawing.Point(0, 0);
                this.PicBox.SizeMode = PictureBoxSizeMode.Zoom;
                PicBox.Width = newPic.Width;
                PicBox.Height = newPic.Height;
                this.PicBox.BorderStyle = BorderStyle.FixedSingle;
                Picimg = newPic;
                PicBox.Image = Picimg;
                this.Controls.Add(PicBox);
                PicCou++;
                this.PicBox.MouseDown += new MouseEventHandler(Page_MouseDown);
                this.PicBox.MouseMove += new MouseEventHandler(Page_MouseMove);
                this.PicBox.MouseUp += new MouseEventHandler(Page_MouseUp);
            }
        }
        //function--------------------------------------------------------
        static void Page_MouseDown(object sender, MouseEventArgs e)
        {
            tePa = (TabPage1)TePicTabCon.SelectedTab;
            if (tePa.PicBox.Image != null && PaMo != 0 && e.Button == MouseButtons.Left)
            {
                MouSta.X = (int)((e.X * (double)tePa.PicBox.Image.Width) / (double)tePa.PicBox.Width);
                MouSta.Y = (int)((e.Y * (double)tePa.PicBox.Image.Height) / (double)tePa.PicBox.Height);
                if (TePastPicBut.Checked == true)
                {
                    int PasW = Clipboard.GetImage().Width;
                    int PasH = Clipboard.GetImage().Height;
                    if (MouSta.X < Pic_START_Point.X || MouSta.X > Pic_START_Point.X + PasW || MouSta.Y < Pic_START_Point.Y || MouSta.Y > Pic_START_Point.Y + PasH)
                    {
                        TePastPicBut.Checked = false;
                        PaMo = 0;
                        Pic_START_Point.X = 0;
                        Pic_START_Point.Y = 0;
                    }
                    ProPic = WaProPic;
                }

            }
        }
        static void Page_MouseMove(object sender, MouseEventArgs e)
        {
            tePa = (TabPage1)TePicTabCon.SelectedTab;
            if (tePa.PicBox.Image != null && PaMo!= 0 && e.Button == MouseButtons.Left)
            {
                MouEnd.X = (int)((e.X * (double)tePa.PicBox.Image.Width) / (double)tePa.PicBox.Width);
                MouEnd.Y = (int)((e.Y * (double)tePa.PicBox.Image.Height) / (double)tePa.PicBox.Height);
                int UpLeftside_X = MouEnd.X > MouSta.X ? MouSta.X : MouEnd.X;
                int UpLeftside_Y = MouEnd.Y > MouSta.Y ? MouSta.Y : MouEnd.Y;
                int DownRightside_X = MouEnd.X > MouSta.X ? MouEnd.X : MouSta.X;
                int DownRightside_Y = MouEnd.Y > MouSta.Y ? MouEnd.Y : MouSta.Y;
                ProPic = CopyNewBitmap(WaProPic);
                Graphics canvas_1 = Graphics.FromImage(ProPic);

                switch (PaMo)
                {
                    case 1:
                        Graphics canvas_2 = Graphics.FromImage(WaProPic);
                        canvas_2.DrawLine(myPen, MouSta, MouEnd);
                        tePa.PicBox.Image = WaProPic;
                        MouSta = MouEnd;
                        canvas_2.Dispose();
                        break;
                    case 2:
                        canvas_1.DrawLine(myPen, MouSta, MouEnd);
                        tePa.PicBox.Image = ProPic;
                        break;
                    case 3:
                        canvas_1.DrawEllipse(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        tePa.PicBox.Image = ProPic;
                        break;
                    case 4:
                        canvas_1.DrawRectangle(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        tePa.PicBox.Image = ProPic;
                        break;
                    case 5:
                        myPen2 = new Pen(Color.Blue, 5);
                        myPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                        canvas_1.DrawRectangle(myPen2, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        tePa.PicBox.Image = ProPic;
                        break;
                    case 6:
                        Pic_START_Point.X = MouEnd.X - MouSta.X;
                        Pic_START_Point.Y = MouEnd.Y - MouSta.Y;
                        canvas_1.DrawImageUnscaled(Clipboard.GetImage(), Pic_START_Point);
                        tePa.PicBox.Image = ProPic;
                        break;
                }
                canvas_1.Dispose();
            }
        }

        static void Page_MouseUp(object sender, MouseEventArgs e)
        {
            tePa = (TabPage1)TePicTabCon.SelectedTab;
            if (tePa.PicBox.Image != null && PaMo != 0 && e.Button == MouseButtons.Left)
            {
                tePa.PicBox.Image = WaProPic;
                Graphics canvas_1 = Graphics.FromImage(WaProPic);
                MouEnd.X = (int)(e.X * (double)tePa.PicBox.Image.Width / (double)tePa.Width);
                MouEnd.Y = (int)(e.Y * (double)tePa.PicBox.Image.Height / (double)tePa.Height);
                int UpLeftside_X = MouEnd.X > MouSta.X ? MouSta.X : MouEnd.X;
                int UpLeftside_Y = MouEnd.Y > MouSta.Y ? MouSta.Y : MouEnd.Y;
                int DownRightside_X = MouEnd.X > MouSta.X ? MouEnd.X : MouSta.X;
                int DownRightside_Y = MouEnd.Y > MouSta.Y ? MouEnd.Y : MouSta.Y;
                switch (PaMo)
                {
                    case 1:
                        break;
                    case 2:
                        canvas_1.DrawLine(myPen, MouSta, MouEnd);
                        break;
                    case 3:
                        canvas_1.DrawEllipse(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        break;
                    case 4:
                        canvas_1.DrawRectangle(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        break;
                    case 5:
                        if (UpLeftside_X < 0) UpLeftside_X = 0;
                        if (UpLeftside_Y < 0) UpLeftside_Y = 0;
                        if (DownRightside_X >= tePa.PicBox.Image.Width) DownRightside_X = tePa.PicBox.Image.Width - 1;
                        if (DownRightside_Y >= tePa.PicBox.Image.Height) DownRightside_Y = tePa.PicBox.Image.Height - 1;
                        int Ori_w = WaProPic.Width;
                        int Ori_h = WaProPic.Height;
                        BitmapData DataIn_1 = WaProPic.LockBits(new Rectangle(0, 0, Ori_w, Ori_h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                        int Copy_w = DownRightside_X - UpLeftside_X + 1;
                        int Copy_h = DownRightside_Y - UpLeftside_Y + 1;
                        Bitmap C_Picture = new Bitmap(Copy_w, Copy_h, PixelFormat.Format24bppRgb);
                        BitmapData NewData = C_Picture.LockBits(new Rectangle(0, 0, Copy_w, Copy_h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                        ProPic = new Bitmap(Ori_w, Ori_h, PixelFormat.Format24bppRgb);
                        BitmapData DataOut_1 = ProPic.LockBits(new Rectangle(0, 0, Ori_w, Ori_h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                        #region
                        unsafe
                        {
                            byte* In = (byte*)DataIn_1.Scan0.ToPointer();
                            byte* Out = (byte*)DataOut_1.Scan0.ToPointer();
                            byte* Copy = (byte*)NewData.Scan0.ToPointer();
                            for (int y = 0; y < Ori_h; y++)
                            {
                                for (int x = 0; x < Ori_w; x++)
                                {
                                    if (x >= UpLeftside_X && x < UpLeftside_X + Copy_w && y >= UpLeftside_Y && y < UpLeftside_Y + Copy_h)
                                    {
                                        Copy[0] = In[0];
                                        Copy[1] = In[1];
                                        Copy[2] = In[2];
                                        Copy += 3;
                                        if (TeCutPicBut.Checked == true)
                                        {
                                            Out[0] = 255;
                                            Out[1] = 255;
                                            Out[2] = 255;
                                        }
                                        else
                                        {
                                            Out[0] = In[0];
                                            Out[1] = In[1];
                                            Out[2] = In[2];
                                        }
                                    }
                                    else
                                    {
                                        Out[0] = In[0];
                                        Out[1] = In[1];
                                        Out[2] = In[2];
                                    }
                                    Out += 3;
                                    In += 3;
                                }
                                In += DataIn_1.Stride - DataIn_1.Width * 3;
                                Out += DataOut_1.Stride - DataOut_1.Width * 3;
                                if (y >= UpLeftside_Y && y < UpLeftside_Y + Copy_h)
                                {
                                    Copy += NewData.Stride - NewData.Width * 3;
                                }
                            }
                        }
                        #endregion
                        WaProPic.UnlockBits(DataIn_1);
                        C_Picture.UnlockBits(NewData);
                        ProPic.UnlockBits(DataOut_1);
                        canvas_1.Dispose();
                        Clipboard.SetImage(C_Picture);
                        tePa.PicBox.Image = ProPic;
                        WaProPic = ProPic;
                        TeCutPicBut.Checked = false;
                        TeCutPicBut.Checked = false;
                        PaMo = 0;
                        break;
                    case 6:
                        Graphics canvas_2 = Graphics.FromImage(ProPic);
                        canvas_2.DrawImageUnscaled(Clipboard.GetImage(), Pic_START_Point);
                        canvas_2.Dispose();
                        tePa.PicBox.Image = ProPic;
                        TeCutPicBut.Checked = false;
                        PaMo = 0;
                        WaProPic = ProPic;
                        break;
                }
            }
        }

        private void Create_Page(Bitmap newPic)//創建頁籤
        {
            picthtabControl.Visible = true;
            tePa = (TabPage1)picthtabControl.SelectedTab;
            string title = tePa.Picpath;
            TabPage1 newPage = new TabPage1(newPic, title + "*");
            picthtabControl.TabPages.Add(newPage);
            picthtabControl.SelectTab(newPage);
        }
        static Bitmap CopyNewBitmap(Image copy_img)
        {

            Bitmap TempPic = copy_img as Bitmap;
            int Copy_High = copy_img.Height;
            int Copy_Width = copy_img.Width;
            picOut = new Bitmap(Copy_Width, Copy_High, PixelFormat.Format24bppRgb);
            DaIn = TempPic.LockBits(new Rectangle(0, 0, Copy_Width, Copy_High), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            DaOut = picOut.LockBits(new Rectangle(0, 0, Copy_Width, Copy_High), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In = (byte*)(DaIn.Scan0.ToPointer());
                byte* Out = (byte*)(DaOut.Scan0.ToPointer());
                for (int y = 0; y < DaIn.Height; y++)
                {
                    for (int x = 0; x < DaIn.Width; x++)
                    {
                        Out[0] = In[0];
                        Out[1] = In[1];
                        Out[2] = In[2];
                        In += 3;
                        Out += 3;
                    }
                    Out += DaOut.Stride - DaOut.Width * 3;
                }
            }
            picOut.UnlockBits(DaOut);
            TempPic.UnlockBits(DaIn);
            return picOut;
        }
        private void All_EnableOpen()
        {
            另存新檔ToolStripMenuItem.Enabled = true;
            另存新檔ToolStripMenuItem.Enabled = true;
            關閉檔案ToolStripMenuItem.Enabled = true;
            結束ToolStripMenuItem.Enabled = true;
            process.Enabled = true;
            轉灰階ToolStripMenuItem.Enabled = true;

            畫ToolStripMenuItem.Enabled = true;
            WaProPic = new Bitmap(tePa.Picimg);
        }
        private void ImageAdjust()
        {
            tePa = (TabPage1)picthtabControl.SelectedTab;
            double ori_WHRatio = (double)tePa.Picimg.Height / (double)tePa.Picimg.Width;
            if (ori_WHRatio >= 1)
            {
                tePa.PicBox.Height = picthtabControl.Height - 26;
                tePa.PicBox.Width = (int)((double)(tePa.PicBox.Height) / ori_WHRatio);
            }
            else
            {
                tePa.PicBox.Width = picthtabControl.Width - 8;
                tePa.PicBox.Height = (int)((double)(tePa.PicBox.Width) * ori_WHRatio);
            }
        }
        private void Update_Status() 
        {
            if (picthtabControl.SelectedTab != null)
            {
                tePa = (TabPage1)picthtabControl.SelectedTab;
                size.Text = tePa.Picimg.Width + "x" + tePa.Picimg.Height;
                path1.Text = tePa.Picpath;
                toolStripStatusLabel2.Text = (int)((double)(tePa.PicBox.Width) / (double)(tePa.Picimg.Width) * 100) + "%";
                toolStripStatusLabel3.Text = tePa.PicBox.Image.PixelFormat.ToString();
            }
        }
        private void Initial_PaintTool()
        {
            cuttoolStripButton4.Checked = false;
            copytoolStripButton4.Checked = false;
            pasttoolStripButton6.Checked = false;
            colortoolStripButton7.Checked = false;
            pentoolStripButton8.Checked = false;
            linetoolStripButton9.Checked = false;
            circletoolStripButton10.Checked = false;
            rectoolStripButton11.Checked = false;
        }
        private void Initial_PaintButton()
        {
            畫ToolStripMenuItem.Enabled = false;
            cuttoolStripButton4.Enabled = false;
            cuttoolStripButton4.Enabled = false;
            colortoolStripButton7.Enabled = false;
            pentoolStripButton8.Enabled = false;
            linetoolStripButton9.Enabled = false;
            circletoolStripButton10.Enabled = false;
            rectoolStripButton11.Enabled = false;
        }
        private void Initial_All() 
        {
            另存新檔ToolStripMenuItem.Enabled = false;
            另存新檔ToolStripMenuItem.Enabled = false;
            關閉檔案ToolStripMenuItem.Enabled = false;
            結束ToolStripMenuItem.Enabled = false;
            畫ToolStripMenuItem.Enabled = false;
        }
        private void Initial_GrayRank()
        {
            process.Enabled = false;
            轉灰階ToolStripMenuItem.Enabled = false;
        }

        private void ChangeLineWidth(int Width_val)
        {
            L1toolStripMenuItem4.Checked = false;
            L2toolStripMenuItem5.Checked = false;
            L3toolStripMenuItem6.Checked = false;
            L4toolStripMenuItem7.Checked = false;
            L5toolStripMenuItem8.Checked = false;
            switch (Width_val)
            {
                case 1:
                    L1toolStripMenuItem4.Checked = true;
                    break;
                case 2:
                    L2toolStripMenuItem5.Checked = true;
                    break;
                case 3:
                    L3toolStripMenuItem6.Checked = true;
                    break;
                case 4:
                    L4toolStripMenuItem7.Checked = true;
                    break;
                case 5:
                    L5toolStripMenuItem8.Checked = true;
                    break;
            }
            myPen.Width = Width_val;
        }
        private void Initial_PencilStyle()
        {
            pa1toolStripMenuItem9.Checked = false;
            pa2toolStripMenuItem10.Checked = false;
            pa3toolStripMenuItem11.Checked = false;
            pa4toolStripMenuItem12.Checked = false;
            pa5toolStripMenuItem13.Checked = false;
        }
        //--------------------------------------------------------

        public Bitmap NewBitmap(Image Img)
        {
            Bitmap tempimage = Img as Bitmap;
            int h2 = Img.Height;
            int w2 = Img.Width;
            Bitmap outbmp = new Bitmap(w2, h2, PixelFormat.Format24bppRgb);
            BitmapData indata = tempimage.LockBits(new Rectangle(0, 0, w2, h2),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData outdata = outbmp.LockBits(new Rectangle(0, 0, w2, h2),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* pin = (byte*)indata.Scan0.ToPointer();
                byte* pout = (byte*)indata.Scan0.ToPointer();
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
        
        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.StartPosition = FormStartPosition.CenterScreen;
            aboutBox1.ShowDialog();
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*JPG)|*.JPG|PNG(*PNG)|*.PNG";
            openFileDialog1.Title = "開啟影像檔";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picthtabControl.Visible = true;
                Bitmap NewImg = new Bitmap(openFileDialog1.FileName);
                string Name = openFileDialog1.FileName;
                TabPage1 New_Page = new TabPage1(NewImg, Name);
                picthtabControl.TabPages.Add(New_Page);
                picthtabControl.SelectTab(New_Page);
                openFileDialog1.Dispose();
                tePa = (TabPage1)picthtabControl.SelectedTab;
                OriImg = new Bitmap(tePa.PicBox.Image);
                picthtabControl.Visible = true;
                All_EnableOpen();
                ImageAdjust();
                Update_Status();
                PaMo = 0;
                Initial_PaintTool();
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*JPG)|*.JPG";
            saveFileDialog1.Title = "另存新影像檔";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tePa = (TabPage1)picthtabControl.SelectedTab;
                tePa.Picimg.Save(saveFileDialog1.FileName);
                toolStripStatusLabel3.Text = saveFileDialog1.FileName;
            }
        }

        private void 關閉檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PicCou--;
            picthtabControl.TabPages.Remove(tePa);
            if (PicCou == 0)
            {
                Initial_All();
                Initial_GrayRank();
                Initial_PaintButton();
                Initial_PaintTool();
            }

        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            開啟舊檔ToolStripMenuItem_Click(sender,  e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            另存新檔ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            關閉檔案ToolStripMenuItem_Click( sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        private Bitmap bmpOut = null;
        private BitmapData dataIn;
         private BitmapData dataOut;
        private void changegrayscale(int flag)
        {
            tePa = (TabPage1)picthtabControl.SelectedTab;
            Bitmap tempPic = new Bitmap(tePa.Picimg);
            int height = tempPic.Height;
            int width = tempPic.Width;
            picOut = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            DaIn = tempPic.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            DaOut = picOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                double gray;
                byte* In = (byte*)(DaIn.Scan0.ToPointer());
                byte* Out = (byte*)(DaOut.Scan0.ToPointer());
                for (int y = 0; y < DaIn.Height; y++)
                {
                    for (int k = 0; k < DaIn.Width; k++)
                    {
                        if (flag == 1)
                        {
                            gray = (In[0] + In[1] + In[2]) / 3;
                        }
                        else
                        {
                            gray = 0.299 * In[2] + 0.587 * In[1] + 0.114 * In[0];
                        }
                        Out[0] = (byte)gray;
                        Out[1] = (byte)gray;
                        Out[2] = (byte)gray;
                        In += 3;
                        Out += 3;
                    }
                    In += DaIn.Stride - DaIn.Width * 3;
                    Out += DaOut.Stride - DaOut.Width * 3;
                }
                picOut.UnlockBits(DaOut);
                tempPic.UnlockBits(DaIn);
                Create_Page(picOut);
                ImageAdjust();
            }
        }

        private void 轉灰階ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changegrayscale(2);
            tePa = (TabPage1)picthtabControl.SelectedTab;
            tePa.Picpath = "轉換灰階--亮度法";
            tePa.Text = "亮度法";
            Update_Status();
        }

        private void 平均法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changegrayscale(2);
            tePa = (TabPage1)picthtabControl.SelectedTab;
            tePa.Picpath = "轉換灰階--平均法";
            tePa.Text = "平均法";
            Update_Status();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void 畫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuttoolStripButton4.Enabled = true;
            copytoolStripButton4.Enabled = true;
            pasttoolStripButton6.Enabled = true;
            colortoolStripButton7.Enabled = true;
            pentoolStripButton8.Enabled = true;
            linetoolStripButton9.Enabled = true;
            circletoolStripButton10.Enabled = true;
            rectoolStripButton11.Enabled = true;

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void tabControl1_MouseUp(object sender, MouseEventArgs e)
        {


        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (cuttoolStripButton4.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                PaMo = 5;
                Initial_PaintTool();
            }
            cuttoolStripButton4.Checked = !cuttoolStripButton4.Checked;
        }

        



        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void linetoolStripButton9_Click(object sender, EventArgs e)
        {
            if (linetoolStripButton9.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                PaMo = 2;
                Initial_PaintTool();
            }
            linetoolStripButton9.Checked = !linetoolStripButton9.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void copytoolStripButton4_Click(object sender, EventArgs e)
        {
            if (copytoolStripButton4.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                PaMo = 5;
                Initial_PaintTool();
            }
            copytoolStripButton4.Checked = !copytoolStripButton4.Checked;
        }

        private void pasttoolStripButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void pasttoolStripButton6_Click_1(object sender, EventArgs e)
        {
            if (pasttoolStripButton6.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                if (Clipboard.GetImage() == null)
                {
                    MessageBox.Show("剪貼簿沒有影像");
                }
                else
                {
                    PaMo = 6;
                    Initial_PaintTool();
                    PicSTPo.X = 0;
                    PicSTPo.Y = 0;
                    tePa = (TabPage1)picthtabControl.SelectedTab;
                    ProPic = CopyNewBitmap(tePa.PicBox.Image);
                    Graphics canvas_1 = Graphics.FromImage(ProPic);
                    canvas_1.DrawImageUnscaled(Clipboard.GetImage(), 0, 0);
                    tePa.PicBox.Image = ProPic;
                }
            }
            pasttoolStripButton6.Checked = !pasttoolStripButton6.Checked;
        }

        private void pentoolStripButton8_Click(object sender, EventArgs e)
        {
            if (pentoolStripButton8.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                PaMo = 1;
                Initial_PaintTool();
            }
            pentoolStripButton8.Checked = !pentoolStripButton8.Checked;
        }

        private void circletoolStripButton10_Click(object sender, EventArgs e)
        {
            if (circletoolStripButton10.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                PaMo = 3;
                Initial_PaintTool();
            }
            linetoolStripButton9.Checked = !linetoolStripButton9.Checked;
        }

        private void rectoolStripButton11_Click(object sender, EventArgs e)
        {
            if (rectoolStripButton11.Checked == true)
            {
                PaMo = 0;
            }
            else
            {
                PaMo = 4;
                Initial_PaintTool();
            }
            rectoolStripButton11.Checked = !rectoolStripButton11.Checked;
        }

        private void L1toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ChangeLineWidth(1);
        }

        private void L2toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ChangeLineWidth(2);
        }

        private void L3toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ChangeLineWidth(3);
        }

        private void L4toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ChangeLineWidth(4);
        }

        private void L5toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ChangeLineWidth(5);
        }

        private void pa1toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Initial_PencilStyle();
            pa1toolStripMenuItem9.Checked = true;
        }

        private void pa2toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Initial_PencilStyle();
            pa2toolStripMenuItem10.Checked = true;
        }

        private void pa3toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Initial_PencilStyle();
            pa3toolStripMenuItem11.Checked = true;
        }

        private void pa4toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Initial_PencilStyle();
            pa4toolStripMenuItem12.Checked = true;
        }

        private void pa5toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Initial_PencilStyle();
            pa5toolStripMenuItem13.Checked = true;
        }

        private void picthtabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
