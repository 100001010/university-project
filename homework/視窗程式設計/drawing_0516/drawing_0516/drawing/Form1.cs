using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work2023
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
            TempCopy_Picture_Button = Copy_picture_Button;
            TempCut_Picture_Button = Cut_picture_Button;
            TempPaste_Picture_Button = Paste_picture_Button;
            TempPicture_TabControl = Picture_tabControl;
        }
        private void Initial_All() //初始化存檔關檔小畫家功能
        {
            SaveFileTSM.Enabled = false;
            SaveFileTSB.Enabled = false;
            CloseFileTSM.Enabled = false;
            CloseFileTSB.Enabled = false;
            小畫家ToolStripMenuItem.Enabled = false;
            SaveFileTSB.Text = "";
            CloseFileTSB.Text = "";
        }

        private void Initial_PaintButton()//小畫家按鍵初始化
        {
            小畫家ToolStripMenuItem.Enabled = false;
            Cut_picture_Button.Enabled = false;
            Copy_picture_Button.Enabled = false;
            Paste_picture_Button.Enabled = false;
            Color_Change_Button.Enabled = false;
            Pencil_Button.Enabled = false;
            SLine_Button.Enabled = false;
            Circle_Button.Enabled = false;
            Square_Button.Enabled = false;
            LineWidth_DropDownButton1.Enabled = false;
            PencilStyle_DropDownButton2.Enabled = false;
            LineWidth_x1_ToolStripMenuItem.Checked = false;
            LineWidth_x2_ToolStripMenuItem.Checked = false;
            LineWidth_x3_ToolStripMenuItem.Checked = false;
            LineWidth_x4_ToolStripMenuItem.Checked = false;
            LineWidth_x5_ToolStripMenuItem.Checked = false;
            Initial_PencilStyle();
        }

        private void Initial_GrayRank()//初始化處理選項 
        {
            ProcessTSM.Enabled = false;
            轉灰階TSM.Enabled = false;
        }

        private void All_EnableOpen()
        {
            SaveFileTSM.Enabled = true;
            SaveFileTSB.Enabled = true;
            CloseFileTSB.Enabled = true;
            CloseFileTSM.Enabled = true;
            ProcessTSM.Enabled = true;
            轉灰階TSM.Enabled = true;
            SaveFileTSB.Text = "另存新影像檔(Ctrl+S)";
            CloseFileTSB.Text = "關閉影像檔(Ctrl+C)";
            小畫家ToolStripMenuItem.Enabled = true;
            WaitProcess_Picture = new Bitmap(temp_Page.Picture_img);
        }
        static Bitmap pictureOut;//處理完成的圖檔
        static BitmapData DataIn;//來源資料指標
        static BitmapData DataOut;//目的資料指標

        static int Picture_Count = 0;//計算圖片數量
        static TabPage1 temp_Page;//暫存修改用頁籤
        static Bitmap Ori_img;

        static int Paint_Mode;//小畫家模式
        static Bitmap Process_Picture;//處理中影像
        static Bitmap WaitProcess_Picture;//待處理影像

        static Pen myPen = new Pen(Color.Black, 1);//畫筆初始設定為黑色、寬度為1

        static Point Pic_START_Point;
        static Point MouseStart;//滑鼠起始座標
        static Point MouseEnd;//滑鼠終止座標

        static TabControl TempPicture_TabControl;
        static ToolStripButton TempCut_Picture_Button;
        static ToolStripButton TempCopy_Picture_Button;
        static ToolStripButton TempPaste_Picture_Button;

        private void Create_Page(Bitmap newPic)//創建頁籤
        {
            Picture_tabControl.Visible = true;
            temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
            string title = temp_Page.Pic_path;
            TabPage1 newPage = new TabPage1(newPic, title + "*");
            Picture_tabControl.TabPages.Add(newPage);
            Picture_tabControl.SelectTab(newPage);
        }

        public partial class TabPage1 :TabPage
        {
            public PictureBox Picture_Box;//圖框
            public Bitmap Picture_img;//圖片
            public string Pic_path = "";//圖片路徑
            public TabPage1(Bitmap newPic,string filetitle)
            {
                this.AutoScroll = true;
                this.Text = filetitle.Remove(0, filetitle.LastIndexOf("\\") + 1);
                Pic_path = filetitle;
                Picture_Box = new PictureBox();
                this.Picture_Box.Location = new System.Drawing.Point(0, 0);
                this.Picture_Box.SizeMode = PictureBoxSizeMode.Zoom;
                Picture_Box.Width = newPic.Width;
                Picture_Box.Height = newPic.Height;
                this.Picture_Box.BorderStyle = BorderStyle.FixedSingle;
                Picture_img = newPic;
                Picture_Box.Image = Picture_img;
                this.Controls.Add(Picture_Box);
                Picture_Count++;
                this.Picture_Box.MouseDown += new MouseEventHandler(Page_MouseDown);
                this.Picture_Box.MouseMove += new MouseEventHandler(Page_MouseMove);
                this.Picture_Box.MouseUp += new MouseEventHandler(Page_MouseUp);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.StartPosition = FormStartPosition.CenterScreen;
            aboutBox.ShowDialog();
        }

        private void OpenFileTSM_Click(object sender, EventArgs e)//檔案開啟舊檔
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*JPG)|*.JPG|PNG(*PNG)|*.PNG";
            openFileDialog1.Title = "開啟影像檔";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Picture_tabControl.Visible = true;
                Bitmap NewImg = new Bitmap(openFileDialog1.FileName);
                string Name = openFileDialog1.FileName;
                TabPage1 New_Page = new TabPage1(NewImg, Name);
                Picture_tabControl.TabPages.Add(New_Page);
                Picture_tabControl.SelectTab(New_Page);
                openFileDialog1.Dispose();
                temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
                Ori_img = new Bitmap(temp_Page.Picture_Box.Image);
                Picture_tabControl.Visible = true;
                All_EnableOpen();
                ImageAdjust();
                Update_Status();
                Paint_Mode = 0;
                Initial_PaintTool();
            }
        }

        private void Update_Status() //更新當前圖片資料
        {
            if (Picture_tabControl.SelectedTab != null)
            {
                temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
                Img_Size_Status.Text = temp_Page.Picture_img.Width + "x" + temp_Page.Picture_img.Height;
                NowPic_Path.Text = temp_Page.Pic_path;
                ChangeSize_Percent.Text = (int)((double)(temp_Page.Picture_Box.Width) / (double)(temp_Page.Picture_img.Width) * 100) + "%";
                Picture_Format_Status.Text = temp_Page.Picture_Box.Image.PixelFormat.ToString();
            }
        }
        private void ImageAdjust()
        {
            temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
            double ori_WHRatio = (double)temp_Page.Picture_img.Height / (double)temp_Page.Picture_img.Width;
            if (ori_WHRatio >= 1)
            {
                temp_Page.Picture_Box.Height = Picture_tabControl.Height - 26;
                temp_Page.Picture_Box.Width = (int)((double)(temp_Page.Picture_Box.Height)/ori_WHRatio);
            }
            else
            {
                temp_Page.Picture_Box.Width=Picture_tabControl.Width- 8;
                temp_Page.Picture_Box.Height = (int)((double)(temp_Page.Picture_Box.Width) * ori_WHRatio);
            }
        }
        private void SaveFileTSM_Click(object sender, EventArgs e)//檔案存檔
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "BMP(*BMP)|*.BMP|JPEG(*JPG)|*.JPG";
            saveFileDialog1.Title = "另存新影像檔";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
                temp_Page.Picture_img.Save(saveFileDialog1.FileName);
                Picture_Format_Status.Text = saveFileDialog1.FileName;
            }
        }

        private void CloseFileTSM_Click(object sender, EventArgs e)//檔案關檔
        {
            Picture_Count--;
            Picture_tabControl.TabPages.Remove(temp_Page);
            if (Picture_Count == 0)
            {
                Initial_All();
                Initial_GrayRank();
                Initial_PaintButton();
                Initial_PaintTool();
            }       
        }

        private void ESCTSM_Click(object sender, EventArgs e)//檔案關閉程式
        {
            Close();
        }

        

        


        private void OpenFileTSB_Click(object sender, EventArgs e)//工具列開檔
        {
            OpenFileTSM_Click(sender, e);
        }

        private void SaveFileTSB_Click(object sender, EventArgs e)//工具列存檔
        {
            SaveFileTSM_Click(sender, e);
        }

        private void CloseFileTSB_Click(object sender, EventArgs e)//工具列關檔
        {
            CloseFileTSM_Click(sender, e);
        }

        private void 平均法TSM_Click(object sender, EventArgs e)
        {
            GrayRank(1);//平均法
            temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
            temp_Page.Pic_path = "轉換灰階--平均法";
            temp_Page.Text = "平均法";
            Update_Status();
        }

        private void 亮度法TSM_Click(object sender, EventArgs e)
        {
            GrayRank(2);//亮度法
            temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
            temp_Page.Pic_path = "轉換灰階--亮度法";
            temp_Page.Text = "亮度法";
            Update_Status();
        }

       
        private void GrayRank(int flag)
        {
            temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
            Bitmap tempPic = new Bitmap(temp_Page.Picture_img);
            int height = tempPic.Height;
            int width = tempPic.Width;
            pictureOut = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            DataIn = tempPic.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            DataOut = pictureOut.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                double gray;
                byte* In = (byte*)(DataIn.Scan0.ToPointer());
                byte* Out = (byte*)(DataOut.Scan0.ToPointer());
                for(int y = 0; y < DataIn.Height; y++)
                {
                    for(int k = 0; k < DataIn.Width; k++)
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
                    In += DataIn.Stride - DataIn.Width * 3;
                    Out += DataOut.Stride - DataOut.Width * 3;
                }
                pictureOut.UnlockBits(DataOut);
                tempPic.UnlockBits(DataIn);
                Create_Page(pictureOut);
                ImageAdjust();
            }
        }

        private void PathstatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 小畫家ToolStripMenuItem_Click(object sender, EventArgs e)//小畫家按鍵開啟
        {
            Cut_picture_Button.Enabled = true;
            Copy_picture_Button.Enabled = true;
            Paste_picture_Button.Enabled = true;
            Color_Change_Button.Enabled = true;
            Pencil_Button.Enabled = true;
            SLine_Button.Enabled = true;
            Circle_Button.Enabled = true;
            Square_Button.Enabled = true;
            LineWidth_DropDownButton1.Enabled = true;
            PencilStyle_DropDownButton2.Enabled = true;
            直線ToolStripMenuItem.Checked = true;
            LineWidth_x1_ToolStripMenuItem.Checked = true;
            temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
            Bitmap tempPic = new Bitmap(temp_Page.Picture_img);
            
        }

        
        private void Color_Change_Button_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;//允許使用者用對話方塊來定義顏色
            colorDialog1.FullOpen = true;//可以看見定義色彩的控制項
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                myPen.Color = colorDialog1.Color; 
            }
        }

        private void ChangeLineWidth(int Width_val)//更改筆寬
        {
            LineWidth_x1_ToolStripMenuItem.Checked = false;
            LineWidth_x2_ToolStripMenuItem.Checked = false;
            LineWidth_x3_ToolStripMenuItem.Checked = false;
            LineWidth_x4_ToolStripMenuItem.Checked = false;
            LineWidth_x5_ToolStripMenuItem.Checked = false;
            switch (Width_val)
            {
                case 1:
                    LineWidth_x1_ToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    LineWidth_x2_ToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    LineWidth_x3_ToolStripMenuItem.Checked = true;
                    break;
                case 4:
                    LineWidth_x4_ToolStripMenuItem.Checked = true;
                    break;
                case 5:
                    LineWidth_x5_ToolStripMenuItem.Checked = true;
                    break;
            }
            myPen.Width = Width_val;
        }

        private void LineWidth_x1_ToolStripMenuItem_Click(object sender, EventArgs e)//筆寬1更改
        {
            ChangeLineWidth(1);
        }

        private void LineWidth_x2_ToolStripMenuItem_Click(object sender, EventArgs e)//筆寬2更改
        {
            ChangeLineWidth(2);
        }

        private void LineWidth_x3_ToolStripMenuItem_Click(object sender, EventArgs e)//筆寬3更改
        {
            ChangeLineWidth(3);
        }

        private void LineWidth_x4_ToolStripMenuItem_Click(object sender, EventArgs e)//筆寬4更改
        {
            ChangeLineWidth(4);
        }

        private void LineWidth_x5_ToolStripMenuItem_Click(object sender, EventArgs e)//筆寬5更改
        {
            ChangeLineWidth(5);
        }

        private void Initial_PencilStyle()//初始化線樣式
        {
            直線ToolStripMenuItem.Checked = false;
            虛線ToolStripMenuItem.Checked = false;
            破折線ToolStripMenuItem.Checked = false;
            破折線虛線ToolStripMenuItem.Checked = false;
            破折線虛線虛線ToolStripMenuItem.Checked = false;
        }
        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Initial_PencilStyle();
            直線ToolStripMenuItem.Checked = true;
        }

        private void 虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Initial_PencilStyle();
            虛線ToolStripMenuItem.Checked = true;
        }

        private void 破折線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Initial_PencilStyle();
            破折線ToolStripMenuItem.Checked = true;
        }

        private void 破折線虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            Initial_PencilStyle();
            破折線虛線ToolStripMenuItem.Checked = true;
        }

        private void 破折線虛線虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            Initial_PencilStyle();
            破折線虛線虛線ToolStripMenuItem.Checked = true;
        }

        private void Initial_PaintTool()//初始化繪圖工具
        {
            Pencil_Button.Checked = false;
            SLine_Button.Checked= false;
            Circle_Button.Checked = false;
            Square_Button.Checked = false;
            Paste_picture_Button.Checked = false;
            Copy_picture_Button.Checked= false;
            Cut_picture_Button.Checked= false;
            
        }

        private void Pencil_Button_Click(object sender, EventArgs e)
        {
            if (Pencil_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                Paint_Mode = 1;
                Initial_PaintTool();
            }
            Pencil_Button.Checked = !Pencil_Button.Checked;
        }

        private void SLine_Button_Click(object sender, EventArgs e)
        {
            if (SLine_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                Paint_Mode = 2;
                Initial_PaintTool();
            }
            SLine_Button.Checked = !SLine_Button.Checked;
        }

        private void Circle_Button_Click(object sender, EventArgs e)
        {
            if (Circle_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                Paint_Mode = 3;
                Initial_PaintTool();
            }
            Circle_Button.Checked = !Circle_Button.Checked;
        }

        private void Square_Button_Click(object sender, EventArgs e)
        {
            if (Square_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                Paint_Mode = 4;
                Initial_PaintTool();
            }
            Square_Button.Checked = !Square_Button.Checked;
        }

        private void Cut_picture_Button_Click(object sender, EventArgs e)
        {
            if (Cut_picture_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                Paint_Mode = 5;
                Initial_PaintTool();
            }
            Cut_picture_Button.Checked = !Cut_picture_Button.Checked;
        }

        private void Copy_picture_Button_Click(object sender, EventArgs e)
        {
            if (Copy_picture_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                Paint_Mode = 5;
                Initial_PaintTool();
            }
            Copy_picture_Button.Checked = !Copy_picture_Button.Checked;
        }
        private void Paste_picture_Button_Click(object sender, EventArgs e)
        {
            if (Paste_picture_Button.Checked == true)
            {
                Paint_Mode = 0;
            }
            else
            {
                if (Clipboard.GetImage() == null)
                {
                    MessageBox.Show("剪貼簿沒有影像");
                }
                else
                {
                    Paint_Mode = 6;
                    Initial_PaintTool();
                    Pic_START_Point.X = 0;
                    Pic_START_Point.Y = 0;
                    temp_Page = (TabPage1)Picture_tabControl.SelectedTab;
                    WaitProcess_Picture = CopyNewBitmap(temp_Page.Picture_Box.Image);
                    Graphics canvas_1 = Graphics.FromImage(WaitProcess_Picture);
                    canvas_1.DrawImageUnscaled(Clipboard.GetImage(), 0, 0);
                    temp_Page.Picture_img = WaitProcess_Picture;
                }
            }
            Paste_picture_Button.Checked = !Paste_picture_Button.Checked;
        }

        static Bitmap CopyNewBitmap(Image copy_img)
        {
            
            Bitmap TempPic = copy_img as Bitmap;
            int Copy_High = copy_img.Height;
            int Copy_Width = copy_img.Width;
            pictureOut = new Bitmap(Copy_Width, Copy_High, PixelFormat.Format24bppRgb);
            DataIn = TempPic.LockBits(new Rectangle(0, 0, Copy_Width, Copy_High), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            DataOut = pictureOut.LockBits(new Rectangle(0, 0, Copy_Width, Copy_High), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* In = (byte*)(DataIn.Scan0.ToPointer());
                byte* Out = (byte*)(DataOut.Scan0.ToPointer());
                for(int y = 0; y < DataIn.Height; y++)
                {
                    for(int x = 0; x < DataIn.Width; x++)
                    {
                        Out[0] = In[0];
                        Out[1] = In[1];
                        Out[2] = In[2];
                        In += 3;
                        Out += 3;
                    }
                    Out += DataOut.Stride - DataOut.Width * 3;
                }
            }
            pictureOut.UnlockBits(DataOut);
            TempPic.UnlockBits(DataIn);
            return pictureOut;
        }

        

        static void Page_MouseDown(object sender, MouseEventArgs e)//滑鼠按下事件
        {
            temp_Page = (TabPage1)TempPicture_TabControl.SelectedTab;
            if (temp_Page.Picture_Box.Image != null && Paint_Mode != 0 && e.Button == MouseButtons.Left)
            {
                MouseStart.X = (int)((e.X * (double)temp_Page.Picture_Box.Image.Width) / (double)temp_Page.Picture_Box.Width);
                MouseStart.Y = (int)((e.Y * (double)temp_Page.Picture_Box.Image.Height) / (double)temp_Page.Picture_Box.Height);
                if (TempPaste_Picture_Button.Checked == true)
                {
                    int PasW = Clipboard.GetImage().Width;
                    int PasH = Clipboard.GetImage().Height;
                    if (MouseStart.X < Pic_START_Point.X || MouseStart.X > Pic_START_Point.X + PasW || MouseStart.Y < Pic_START_Point.Y || MouseStart.Y > Pic_START_Point.Y + PasH)
                    {
                        TempPaste_Picture_Button.Checked = false;
                        Paint_Mode = 0;
                        Pic_START_Point.X = 0;
                        Pic_START_Point.Y = 0;
                    }
                    Process_Picture = WaitProcess_Picture;
                }

            }
        }

        static void Page_MouseMove(object sender, MouseEventArgs e)//滑鼠移動事件
        {
            temp_Page = (TabPage1)TempPicture_TabControl.SelectedTab;
            if (temp_Page.Picture_Box.Image != null && Paint_Mode != 0 && e.Button == MouseButtons.Left)
            {
                MouseEnd.X = (int)((e.X *(double) temp_Page.Picture_Box.Image.Width )/ (double)temp_Page.Picture_Box.Width);
                MouseEnd.Y = (int)((e.Y *(double) temp_Page.Picture_Box.Image.Height) / (double)temp_Page.Picture_Box.Height);
                int UpLeftside_X = MouseEnd.X > MouseStart.X ? MouseStart.X : MouseEnd.X;
                int UpLeftside_Y = MouseEnd.Y > MouseStart.Y ? MouseStart.Y : MouseEnd.Y;
                int DownRightside_X = MouseEnd.X > MouseStart.X ? MouseEnd.X : MouseStart.X;
                int DownRightside_Y = MouseEnd.Y > MouseStart.Y ? MouseEnd.Y : MouseStart.Y;
                Process_Picture = CopyNewBitmap(WaitProcess_Picture);
                Graphics canvas_1 = Graphics.FromImage(Process_Picture);//宣告畫布
                
                switch (Paint_Mode)
                {
                    case 1://畫筆
                        Graphics canvas_2 = Graphics.FromImage(WaitProcess_Picture);//宣告畫布
                        canvas_2.DrawLine(myPen, MouseStart, MouseEnd);
                        temp_Page.Picture_Box.Image = WaitProcess_Picture;
                        MouseStart = MouseEnd;
                        canvas_2.Dispose();
                        break;
                    case 2://畫直線
                        canvas_1.DrawLine(myPen, MouseStart, MouseEnd);
                        temp_Page.Picture_Box.Image = Process_Picture;
                        break;
                    case 3://畫橢圓
                        canvas_1.DrawEllipse(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        temp_Page.Picture_Box.Image = Process_Picture;
                        break;
                    case 4://畫方形
                        canvas_1.DrawRectangle(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        temp_Page.Picture_Box.Image = Process_Picture;
                        break;
                    case 5://複製、簡下
                        myPen = new Pen(Color.Blue, 5);
                        myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                        canvas_1.DrawRectangle(myPen, UpLeftside_X, UpLeftside_Y, DownRightside_X - UpLeftside_X, DownRightside_Y - UpLeftside_Y);
                        temp_Page.Picture_Box.Image = Process_Picture;
                        break;
                    case 6:
                        Pic_START_Point.X = MouseEnd.X - MouseStart.X;
                        Pic_START_Point.Y = MouseEnd.Y - MouseStart.Y;
                        canvas_1.DrawImageUnscaled(Clipboard.GetImage(), Pic_START_Point);
                        temp_Page.Picture_Box.Image = Process_Picture;
                        break;
                }
                canvas_1.Dispose();
            }
        }

        static void Page_MouseUp(object sender, MouseEventArgs e)//滑鼠抬起事件
        {
            temp_Page = (TabPage1)TempPicture_TabControl.SelectedTab;
            if (temp_Page.Picture_Box.Image != null && Paint_Mode != 0 && e.Button == MouseButtons.Left)
            {
                temp_Page.Picture_Box.Image = WaitProcess_Picture;
                Graphics canvas_1 = Graphics.FromImage(WaitProcess_Picture);
                MouseEnd.X = (int)(e.X *(double) temp_Page.Picture_img.Width / (double)temp_Page.Width);
                MouseEnd.Y = (int)(e.Y *(double) temp_Page.Picture_img.Height / (double)temp_Page.Height);
                int UpLeftside_X = MouseEnd.X > MouseStart.X ? MouseStart.X : MouseEnd.X;
                int UpLeftside_Y = MouseEnd.Y > MouseStart.Y ? MouseStart.Y : MouseEnd.Y;
                int DownRightside_X = MouseEnd.X > MouseStart.X ? MouseEnd.X : MouseStart.X;
                int DownRightside_Y = MouseEnd.Y > MouseStart.Y ? MouseEnd.Y : MouseStart.Y;
                switch (Paint_Mode)
                {
                    case 1:
                        break;
                    case 2:
                        canvas_1.DrawLine(myPen, MouseStart, MouseEnd);
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
                        if (DownRightside_X >= temp_Page.Picture_Box.Image.Width) DownRightside_X = temp_Page.Picture_Box.Image.Width - 1;
                        if (DownRightside_Y >= temp_Page.Picture_Box.Image.Height) DownRightside_Y = temp_Page.Picture_Box.Image.Height - 1;
                        int Ori_w = WaitProcess_Picture.Width;
                        int Ori_h = WaitProcess_Picture.Height;
                        BitmapData DataIn_1 = WaitProcess_Picture.LockBits(new Rectangle(0, 0, Ori_w, Ori_h), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                        int Copy_w = DownRightside_X - UpLeftside_X + 1;
                        int Copy_h = DownRightside_Y - UpLeftside_Y + 1;
                        Bitmap C_Picture = new Bitmap(Copy_w, Copy_h, PixelFormat.Format24bppRgb);
                        BitmapData NewData = C_Picture.LockBits(new Rectangle(0, 0, Copy_w, Copy_h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                        Process_Picture = new Bitmap(Ori_w, Ori_h, PixelFormat.Format24bppRgb);
                        BitmapData DataOut_1 = Process_Picture.LockBits(new Rectangle(0, 0, Ori_w, Ori_h), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
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
                                        if (TempCut_Picture_Button.Checked == true)//剪下
                                        {
                                            Out[0] = 255;
                                            Out[1] = 255;
                                            Out[2] = 255;
                                        }
                                        else//複製
                                        {
                                            Out[0] = In[0];
                                            Out[1] = In[1];
                                            Out[2] = In[2];
                                        }
                                    }
                                    else//其他區域顏色
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
                        WaitProcess_Picture.UnlockBits(DataIn_1);
                        C_Picture.UnlockBits(NewData);
                        Process_Picture.UnlockBits(DataOut_1);
                        canvas_1.Dispose();
                        Clipboard.SetImage(C_Picture);
                        temp_Page.Picture_Box.Image = Process_Picture;
                        WaitProcess_Picture = Process_Picture;
                        TempCut_Picture_Button.Checked = false;
                        TempCopy_Picture_Button.Checked = false;
                        Paint_Mode = 0;
                        break;
                    case 6:
                        Graphics canvas_2 = Graphics.FromImage(Process_Picture);
                        canvas_2.DrawImageUnscaled(Clipboard.GetImage(), Pic_START_Point);
                        canvas_2.Dispose();
                        temp_Page.Picture_Box.Image = Process_Picture;
                        TempPaste_Picture_Button.Checked = false;
                        Paint_Mode = 0;
                        WaitProcess_Picture = Process_Picture;
                        break;
                }
            }
        }

        //以下是不小心點到的

        private void Picture_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Picture_tabControl_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Picture_tabControl_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void Picture_tabControl_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
