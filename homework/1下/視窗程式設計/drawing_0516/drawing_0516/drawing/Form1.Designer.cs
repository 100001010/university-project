namespace work2023
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseFileTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ESCTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.轉灰階TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.平均法TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.亮度法TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.小畫家ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileTSB = new System.Windows.Forms.ToolStripButton();
            this.SaveFileTSB = new System.Windows.Forms.ToolStripButton();
            this.CloseFileTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Cut_picture_Button = new System.Windows.Forms.ToolStripButton();
            this.Copy_picture_Button = new System.Windows.Forms.ToolStripButton();
            this.Paste_picture_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Color_Change_Button = new System.Windows.Forms.ToolStripButton();
            this.Pencil_Button = new System.Windows.Forms.ToolStripButton();
            this.SLine_Button = new System.Windows.Forms.ToolStripButton();
            this.Circle_Button = new System.Windows.Forms.ToolStripButton();
            this.Square_Button = new System.Windows.Forms.ToolStripButton();
            this.LineWidth_DropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.LineWidth_x1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWidth_x2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWidth_x3_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWidth_x4_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWidth_x5_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PencilStyle_DropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.直線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.虛線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.破折線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.破折線虛線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.破折線虛線虛線ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathstatusStrip = new System.Windows.Forms.StatusStrip();
            this.Img_Size_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.NowPic_Path = new System.Windows.Forms.ToolStripStatusLabel();
            this.ChangeSize_Percent = new System.Windows.Forms.ToolStripStatusLabel();
            this.Picture_Format_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Picture_tabControl = new System.Windows.Forms.TabControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.PathstatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.ProcessTSM,
            this.小畫家ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileTSM,
            this.SaveFileTSM,
            this.CloseFileTSM,
            this.toolStripSeparator1,
            this.ESCTSM});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem2.Text = "檔案(&F)";
            // 
            // OpenFileTSM
            // 
            this.OpenFileTSM.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileTSM.Image")));
            this.OpenFileTSM.Name = "OpenFileTSM";
            this.OpenFileTSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileTSM.Size = new System.Drawing.Size(185, 22);
            this.OpenFileTSM.Text = "開啟舊檔(&O)";
            this.OpenFileTSM.Click += new System.EventHandler(this.OpenFileTSM_Click);
            // 
            // SaveFileTSM
            // 
            this.SaveFileTSM.Enabled = false;
            this.SaveFileTSM.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileTSM.Image")));
            this.SaveFileTSM.Name = "SaveFileTSM";
            this.SaveFileTSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveFileTSM.Size = new System.Drawing.Size(185, 22);
            this.SaveFileTSM.Text = "另存新檔(&S)";
            this.SaveFileTSM.Click += new System.EventHandler(this.SaveFileTSM_Click);
            // 
            // CloseFileTSM
            // 
            this.CloseFileTSM.Enabled = false;
            this.CloseFileTSM.Image = ((System.Drawing.Image)(resources.GetObject("CloseFileTSM.Image")));
            this.CloseFileTSM.Name = "CloseFileTSM";
            this.CloseFileTSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CloseFileTSM.Size = new System.Drawing.Size(185, 22);
            this.CloseFileTSM.Text = "關閉檔案(&C)";
            this.CloseFileTSM.Click += new System.EventHandler(this.CloseFileTSM_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // ESCTSM
            // 
            this.ESCTSM.Image = ((System.Drawing.Image)(resources.GetObject("ESCTSM.Image")));
            this.ESCTSM.Name = "ESCTSM";
            this.ESCTSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ESCTSM.Size = new System.Drawing.Size(185, 22);
            this.ESCTSM.Text = "結束(&X)";
            this.ESCTSM.Click += new System.EventHandler(this.ESCTSM_Click);
            // 
            // ProcessTSM
            // 
            this.ProcessTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.轉灰階TSM});
            this.ProcessTSM.Enabled = false;
            this.ProcessTSM.Name = "ProcessTSM";
            this.ProcessTSM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.ProcessTSM.Size = new System.Drawing.Size(58, 20);
            this.ProcessTSM.Text = "處理(&P)";
            // 
            // 轉灰階TSM
            // 
            this.轉灰階TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.平均法TSM,
            this.亮度法TSM});
            this.轉灰階TSM.Name = "轉灰階TSM";
            this.轉灰階TSM.Size = new System.Drawing.Size(110, 22);
            this.轉灰階TSM.Text = "轉灰階";
            // 
            // 平均法TSM
            // 
            this.平均法TSM.Name = "平均法TSM";
            this.平均法TSM.Size = new System.Drawing.Size(110, 22);
            this.平均法TSM.Text = "平均法";
            this.平均法TSM.Click += new System.EventHandler(this.平均法TSM_Click);
            // 
            // 亮度法TSM
            // 
            this.亮度法TSM.Name = "亮度法TSM";
            this.亮度法TSM.Size = new System.Drawing.Size(110, 22);
            this.亮度法TSM.Text = "亮度法";
            this.亮度法TSM.Click += new System.EventHandler(this.亮度法TSM_Click);
            // 
            // 小畫家ToolStripMenuItem
            // 
            this.小畫家ToolStripMenuItem.Name = "小畫家ToolStripMenuItem";
            this.小畫家ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.小畫家ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.小畫家ToolStripMenuItem.Text = "小畫家(&D)";
            this.小畫家ToolStripMenuItem.Click += new System.EventHandler(this.小畫家ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "說明(&A)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileTSB,
            this.SaveFileTSB,
            this.CloseFileTSB,
            this.toolStripSeparator2,
            this.Cut_picture_Button,
            this.Copy_picture_Button,
            this.Paste_picture_Button,
            this.toolStripSeparator3,
            this.Color_Change_Button,
            this.Pencil_Button,
            this.SLine_Button,
            this.Circle_Button,
            this.Square_Button,
            this.LineWidth_DropDownButton1,
            this.PencilStyle_DropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFileTSB
            // 
            this.OpenFileTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileTSB.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileTSB.Image")));
            this.OpenFileTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileTSB.Name = "OpenFileTSB";
            this.OpenFileTSB.Size = new System.Drawing.Size(23, 22);
            this.OpenFileTSB.Text = "開啟影像檔";
            this.OpenFileTSB.Click += new System.EventHandler(this.OpenFileTSB_Click);
            // 
            // SaveFileTSB
            // 
            this.SaveFileTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileTSB.Enabled = false;
            this.SaveFileTSB.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileTSB.Image")));
            this.SaveFileTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileTSB.Name = "SaveFileTSB";
            this.SaveFileTSB.Size = new System.Drawing.Size(23, 22);
            this.SaveFileTSB.ToolTipText = "儲存影像檔";
            this.SaveFileTSB.Click += new System.EventHandler(this.SaveFileTSB_Click);
            // 
            // CloseFileTSB
            // 
            this.CloseFileTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseFileTSB.Enabled = false;
            this.CloseFileTSB.Image = ((System.Drawing.Image)(resources.GetObject("CloseFileTSB.Image")));
            this.CloseFileTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseFileTSB.Name = "CloseFileTSB";
            this.CloseFileTSB.Size = new System.Drawing.Size(23, 22);
            this.CloseFileTSB.ToolTipText = "關閉影像檔";
            this.CloseFileTSB.Click += new System.EventHandler(this.CloseFileTSB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Cut_picture_Button
            // 
            this.Cut_picture_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cut_picture_Button.Image = ((System.Drawing.Image)(resources.GetObject("Cut_picture_Button.Image")));
            this.Cut_picture_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cut_picture_Button.Name = "Cut_picture_Button";
            this.Cut_picture_Button.Size = new System.Drawing.Size(23, 22);
            this.Cut_picture_Button.Text = "剪下";
            this.Cut_picture_Button.Click += new System.EventHandler(this.Cut_picture_Button_Click);
            // 
            // Copy_picture_Button
            // 
            this.Copy_picture_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copy_picture_Button.Image = ((System.Drawing.Image)(resources.GetObject("Copy_picture_Button.Image")));
            this.Copy_picture_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copy_picture_Button.Name = "Copy_picture_Button";
            this.Copy_picture_Button.Size = new System.Drawing.Size(23, 22);
            this.Copy_picture_Button.Text = "複製";
            this.Copy_picture_Button.Click += new System.EventHandler(this.Copy_picture_Button_Click);
            // 
            // Paste_picture_Button
            // 
            this.Paste_picture_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste_picture_Button.Image = ((System.Drawing.Image)(resources.GetObject("Paste_picture_Button.Image")));
            this.Paste_picture_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste_picture_Button.Name = "Paste_picture_Button";
            this.Paste_picture_Button.Size = new System.Drawing.Size(23, 22);
            this.Paste_picture_Button.Text = "貼上";
            this.Paste_picture_Button.Click += new System.EventHandler(this.Paste_picture_Button_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Color_Change_Button
            // 
            this.Color_Change_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Color_Change_Button.Image = ((System.Drawing.Image)(resources.GetObject("Color_Change_Button.Image")));
            this.Color_Change_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Color_Change_Button.Name = "Color_Change_Button";
            this.Color_Change_Button.Size = new System.Drawing.Size(23, 22);
            this.Color_Change_Button.Text = "調色盤";
            this.Color_Change_Button.Click += new System.EventHandler(this.Color_Change_Button_Click);
            // 
            // Pencil_Button
            // 
            this.Pencil_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil_Button.Image = ((System.Drawing.Image)(resources.GetObject("Pencil_Button.Image")));
            this.Pencil_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil_Button.Name = "Pencil_Button";
            this.Pencil_Button.Size = new System.Drawing.Size(23, 22);
            this.Pencil_Button.Text = "畫筆";
            this.Pencil_Button.Click += new System.EventHandler(this.Pencil_Button_Click);
            // 
            // SLine_Button
            // 
            this.SLine_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SLine_Button.Image = ((System.Drawing.Image)(resources.GetObject("SLine_Button.Image")));
            this.SLine_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SLine_Button.Name = "SLine_Button";
            this.SLine_Button.Size = new System.Drawing.Size(23, 22);
            this.SLine_Button.Text = "直線";
            this.SLine_Button.Click += new System.EventHandler(this.SLine_Button_Click);
            // 
            // Circle_Button
            // 
            this.Circle_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle_Button.Image = ((System.Drawing.Image)(resources.GetObject("Circle_Button.Image")));
            this.Circle_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle_Button.Name = "Circle_Button";
            this.Circle_Button.Size = new System.Drawing.Size(23, 22);
            this.Circle_Button.Text = "圓圈";
            this.Circle_Button.Click += new System.EventHandler(this.Circle_Button_Click);
            // 
            // Square_Button
            // 
            this.Square_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Square_Button.Image = ((System.Drawing.Image)(resources.GetObject("Square_Button.Image")));
            this.Square_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Square_Button.Name = "Square_Button";
            this.Square_Button.Size = new System.Drawing.Size(23, 22);
            this.Square_Button.Text = "方形";
            this.Square_Button.Click += new System.EventHandler(this.Square_Button_Click);
            // 
            // LineWidth_DropDownButton1
            // 
            this.LineWidth_DropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineWidth_DropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineWidth_x1_ToolStripMenuItem,
            this.LineWidth_x2_ToolStripMenuItem,
            this.LineWidth_x3_ToolStripMenuItem,
            this.LineWidth_x4_ToolStripMenuItem,
            this.LineWidth_x5_ToolStripMenuItem});
            this.LineWidth_DropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth_DropDownButton1.Image")));
            this.LineWidth_DropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineWidth_DropDownButton1.Name = "LineWidth_DropDownButton1";
            this.LineWidth_DropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.LineWidth_DropDownButton1.Text = "筆寬";
            // 
            // LineWidth_x1_ToolStripMenuItem
            // 
            this.LineWidth_x1_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth_x1_ToolStripMenuItem.Image")));
            this.LineWidth_x1_ToolStripMenuItem.Name = "LineWidth_x1_ToolStripMenuItem";
            this.LineWidth_x1_ToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.LineWidth_x1_ToolStripMenuItem.Text = "×1";
            this.LineWidth_x1_ToolStripMenuItem.Click += new System.EventHandler(this.LineWidth_x1_ToolStripMenuItem_Click);
            // 
            // LineWidth_x2_ToolStripMenuItem
            // 
            this.LineWidth_x2_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth_x2_ToolStripMenuItem.Image")));
            this.LineWidth_x2_ToolStripMenuItem.Name = "LineWidth_x2_ToolStripMenuItem";
            this.LineWidth_x2_ToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.LineWidth_x2_ToolStripMenuItem.Text = "×2";
            this.LineWidth_x2_ToolStripMenuItem.Click += new System.EventHandler(this.LineWidth_x2_ToolStripMenuItem_Click);
            // 
            // LineWidth_x3_ToolStripMenuItem
            // 
            this.LineWidth_x3_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth_x3_ToolStripMenuItem.Image")));
            this.LineWidth_x3_ToolStripMenuItem.Name = "LineWidth_x3_ToolStripMenuItem";
            this.LineWidth_x3_ToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.LineWidth_x3_ToolStripMenuItem.Text = "×3";
            this.LineWidth_x3_ToolStripMenuItem.Click += new System.EventHandler(this.LineWidth_x3_ToolStripMenuItem_Click);
            // 
            // LineWidth_x4_ToolStripMenuItem
            // 
            this.LineWidth_x4_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth_x4_ToolStripMenuItem.Image")));
            this.LineWidth_x4_ToolStripMenuItem.Name = "LineWidth_x4_ToolStripMenuItem";
            this.LineWidth_x4_ToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.LineWidth_x4_ToolStripMenuItem.Text = "×4";
            this.LineWidth_x4_ToolStripMenuItem.Click += new System.EventHandler(this.LineWidth_x4_ToolStripMenuItem_Click);
            // 
            // LineWidth_x5_ToolStripMenuItem
            // 
            this.LineWidth_x5_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LineWidth_x5_ToolStripMenuItem.Image")));
            this.LineWidth_x5_ToolStripMenuItem.Name = "LineWidth_x5_ToolStripMenuItem";
            this.LineWidth_x5_ToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.LineWidth_x5_ToolStripMenuItem.Text = "×5";
            this.LineWidth_x5_ToolStripMenuItem.Click += new System.EventHandler(this.LineWidth_x5_ToolStripMenuItem_Click);
            // 
            // PencilStyle_DropDownButton2
            // 
            this.PencilStyle_DropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PencilStyle_DropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.直線ToolStripMenuItem,
            this.虛線ToolStripMenuItem,
            this.破折線ToolStripMenuItem,
            this.破折線虛線ToolStripMenuItem,
            this.破折線虛線虛線ToolStripMenuItem});
            this.PencilStyle_DropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("PencilStyle_DropDownButton2.Image")));
            this.PencilStyle_DropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PencilStyle_DropDownButton2.Name = "PencilStyle_DropDownButton2";
            this.PencilStyle_DropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.PencilStyle_DropDownButton2.Text = "畫筆樣式";
            // 
            // 直線ToolStripMenuItem
            // 
            this.直線ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("直線ToolStripMenuItem.Image")));
            this.直線ToolStripMenuItem.Name = "直線ToolStripMenuItem";
            this.直線ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.直線ToolStripMenuItem.Text = "直線";
            this.直線ToolStripMenuItem.Click += new System.EventHandler(this.直線ToolStripMenuItem_Click);
            // 
            // 虛線ToolStripMenuItem
            // 
            this.虛線ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("虛線ToolStripMenuItem.Image")));
            this.虛線ToolStripMenuItem.Name = "虛線ToolStripMenuItem";
            this.虛線ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.虛線ToolStripMenuItem.Text = "虛線";
            this.虛線ToolStripMenuItem.Click += new System.EventHandler(this.虛線ToolStripMenuItem_Click);
            // 
            // 破折線ToolStripMenuItem
            // 
            this.破折線ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("破折線ToolStripMenuItem.Image")));
            this.破折線ToolStripMenuItem.Name = "破折線ToolStripMenuItem";
            this.破折線ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.破折線ToolStripMenuItem.Text = "破折線";
            this.破折線ToolStripMenuItem.Click += new System.EventHandler(this.破折線ToolStripMenuItem_Click);
            // 
            // 破折線虛線ToolStripMenuItem
            // 
            this.破折線虛線ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("破折線虛線ToolStripMenuItem.Image")));
            this.破折線虛線ToolStripMenuItem.Name = "破折線虛線ToolStripMenuItem";
            this.破折線虛線ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.破折線虛線ToolStripMenuItem.Text = "破折線-虛線";
            this.破折線虛線ToolStripMenuItem.Click += new System.EventHandler(this.破折線虛線ToolStripMenuItem_Click);
            // 
            // 破折線虛線虛線ToolStripMenuItem
            // 
            this.破折線虛線虛線ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("破折線虛線虛線ToolStripMenuItem.Image")));
            this.破折線虛線虛線ToolStripMenuItem.Name = "破折線虛線虛線ToolStripMenuItem";
            this.破折線虛線虛線ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.破折線虛線虛線ToolStripMenuItem.Text = "破折線-虛線-虛線";
            this.破折線虛線虛線ToolStripMenuItem.Click += new System.EventHandler(this.破折線虛線虛線ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathstatusStrip
            // 
            this.PathstatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Img_Size_Status,
            this.NowPic_Path,
            this.ChangeSize_Percent,
            this.Picture_Format_Status});
            this.PathstatusStrip.Location = new System.Drawing.Point(0, 428);
            this.PathstatusStrip.Name = "PathstatusStrip";
            this.PathstatusStrip.Size = new System.Drawing.Size(591, 22);
            this.PathstatusStrip.TabIndex = 3;
            this.PathstatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.PathstatusStrip_ItemClicked);
            // 
            // Img_Size_Status
            // 
            this.Img_Size_Status.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Img_Size_Status.Name = "Img_Size_Status";
            this.Img_Size_Status.Size = new System.Drawing.Size(4, 17);
            // 
            // NowPic_Path
            // 
            this.NowPic_Path.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.NowPic_Path.Name = "NowPic_Path";
            this.NowPic_Path.Size = new System.Drawing.Size(4, 17);
            // 
            // ChangeSize_Percent
            // 
            this.ChangeSize_Percent.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ChangeSize_Percent.Name = "ChangeSize_Percent";
            this.ChangeSize_Percent.Size = new System.Drawing.Size(4, 17);
            // 
            // Picture_Format_Status
            // 
            this.Picture_Format_Status.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Picture_Format_Status.Name = "Picture_Format_Status";
            this.Picture_Format_Status.Size = new System.Drawing.Size(4, 17);
            // 
            // Picture_tabControl
            // 
            this.Picture_tabControl.Location = new System.Drawing.Point(0, 52);
            this.Picture_tabControl.Name = "Picture_tabControl";
            this.Picture_tabControl.SelectedIndex = 0;
            this.Picture_tabControl.Size = new System.Drawing.Size(591, 371);
            this.Picture_tabControl.TabIndex = 4;
            this.Picture_tabControl.Visible = false;
            this.Picture_tabControl.SelectedIndexChanged += new System.EventHandler(this.Picture_tabControl_SelectedIndexChanged);
            this.Picture_tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_tabControl_MouseDown);
            this.Picture_tabControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_tabControl_MouseMove);
            this.Picture_tabControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture_tabControl_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.Picture_tabControl);
            this.Controls.Add(this.PathstatusStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "11360686陳芷芸";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PathstatusStrip.ResumeLayout(false);
            this.PathstatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem OpenFileTSM;
        private System.Windows.Forms.ToolStripMenuItem SaveFileTSM;
        private System.Windows.Forms.ToolStripMenuItem CloseFileTSM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ESCTSM;
        private System.Windows.Forms.ToolStripButton OpenFileTSB;
        private System.Windows.Forms.ToolStripButton SaveFileTSB;
        private System.Windows.Forms.ToolStripButton CloseFileTSB;
        private System.Windows.Forms.StatusStrip PathstatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Picture_Format_Status;
        private System.Windows.Forms.ToolStripMenuItem ProcessTSM;
        private System.Windows.Forms.ToolStripMenuItem 轉灰階TSM;
        private System.Windows.Forms.ToolStripMenuItem 平均法TSM;
        private System.Windows.Forms.ToolStripMenuItem 亮度法TSM;
        private System.Windows.Forms.ToolStripStatusLabel Img_Size_Status;
        private System.Windows.Forms.ToolStripStatusLabel NowPic_Path;
        private System.Windows.Forms.ToolStripStatusLabel ChangeSize_Percent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Cut_picture_Button;
        private System.Windows.Forms.ToolStripButton Copy_picture_Button;
        private System.Windows.Forms.ToolStripButton Paste_picture_Button;
        private System.Windows.Forms.ToolStripButton Color_Change_Button;
        private System.Windows.Forms.ToolStripButton Pencil_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton LineWidth_DropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton PencilStyle_DropDownButton2;
        private System.Windows.Forms.ToolStripButton SLine_Button;
        private System.Windows.Forms.ToolStripButton Circle_Button;
        private System.Windows.Forms.ToolStripButton Square_Button;
        private System.Windows.Forms.ToolStripMenuItem LineWidth_x1_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineWidth_x2_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineWidth_x3_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineWidth_x4_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineWidth_x5_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小畫家ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 直線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 虛線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 破折線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 破折線虛線ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 破折線虛線虛線ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl Picture_tabControl;
    }
}

