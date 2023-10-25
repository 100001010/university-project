namespace Windowsform_week12_penguin
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
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.done = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToAshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1 = new System.Windows.Forms.ToolStripMenuItem();
            this.c2 = new System.Windows.Forms.ToolStripMenuItem();
            this.draw = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.cut = new System.Windows.Forms.ToolStripButton();
            this.copy = new System.Windows.Forms.ToolStripButton();
            this.paste = new System.Windows.Forms.ToolStripButton();
            this.color = new System.Windows.Forms.ToolStripButton();
            this.pen = new System.Windows.Forms.ToolStripButton();
            this.slash = new System.Windows.Forms.ToolStripButton();
            this.circle = new System.Windows.Forms.ToolStripButton();
            this.square = new System.Windows.Forms.ToolStripButton();
            this.lineall = new System.Windows.Forms.ToolStripDropDownButton();
            this.big1 = new System.Windows.Forms.ToolStripMenuItem();
            this.big2 = new System.Windows.Forms.ToolStripMenuItem();
            this.big3 = new System.Windows.Forms.ToolStripMenuItem();
            this.big4 = new System.Windows.Forms.ToolStripMenuItem();
            this.big5 = new System.Windows.Forms.ToolStripMenuItem();
            this.dash = new System.Windows.Forms.ToolStripDropDownButton();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashDotDotLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LA1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LA2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LA3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LA4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.piantcolor = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.檔案FToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.draw});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1446, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.setToolStripMenuItem.Text = "set";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.toolStripSeparator,
            this.save,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.done,
            this.close});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open.Size = new System.Drawing.Size(249, 34);
            this.open.Text = "open(&O)";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(246, 6);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(249, 34);
            this.save.Text = "save(&S)";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // done
            // 
            this.done.Name = "done";
            this.done.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.done.Size = new System.Drawing.Size(249, 34);
            this.done.Text = "結束(&A)";
            this.done.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.close.Size = new System.Drawing.Size(249, 34);
            this.close.Text = "close(&X)";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToAshToolStripMenuItem});
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.changeToolStripMenuItem.Text = "change";
            // 
            // changeToAshToolStripMenuItem
            // 
            this.changeToAshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c1,
            this.c2});
            this.changeToAshToolStripMenuItem.Name = "changeToAshToolStripMenuItem";
            this.changeToAshToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.changeToAshToolStripMenuItem.Text = "grayscale";
            // 
            // c1
            // 
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(271, 34);
            this.c1.Text = "average method";
            this.c1.Click += new System.EventHandler(this.asaToolStripMenuItem_Click);
            // 
            // c2
            // 
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(271, 34);
            this.c2.Text = "brightness method";
            this.c2.Click += new System.EventHandler(this.asasToolStripMenuItem_Click);
            // 
            // draw
            // 
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(68, 27);
            this.draw.Text = "draw";
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.cut,
            this.copy,
            this.paste,
            this.color,
            this.pen,
            this.slash,
            this.circle,
            this.square,
            this.lineall,
            this.dash});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1446, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Open file";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Save the new file";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "Close file";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // cut
            // 
            this.cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut.Image = ((System.Drawing.Image)(resources.GetObject("cut.Image")));
            this.cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(34, 28);
            this.cut.Text = "cut";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(34, 28);
            this.copy.Text = "copy";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
            this.paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(34, 28);
            this.paste.Text = "paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // color
            // 
            this.color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.color.Image = ((System.Drawing.Image)(resources.GetObject("color.Image")));
            this.color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(34, 28);
            this.color.Text = "color";
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // pen
            // 
            this.pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pen.Image = ((System.Drawing.Image)(resources.GetObject("pen.Image")));
            this.pen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(34, 28);
            this.pen.Text = "pen";
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // slash
            // 
            this.slash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.slash.Image = ((System.Drawing.Image)(resources.GetObject("slash.Image")));
            this.slash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(34, 28);
            this.slash.Text = "slash";
            this.slash.Click += new System.EventHandler(this.slash_Click);
            // 
            // circle
            // 
            this.circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(34, 28);
            this.circle.Text = "circle";
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // square
            // 
            this.square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.square.Image = ((System.Drawing.Image)(resources.GetObject("square.Image")));
            this.square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(34, 28);
            this.square.Text = "square";
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // lineall
            // 
            this.lineall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineall.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.big1,
            this.big2,
            this.big3,
            this.big4,
            this.big5});
            this.lineall.Image = ((System.Drawing.Image)(resources.GetObject("lineall.Image")));
            this.lineall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineall.Name = "lineall";
            this.lineall.Size = new System.Drawing.Size(42, 28);
            this.lineall.Text = "line";
            // 
            // big1
            // 
            this.big1.Image = ((System.Drawing.Image)(resources.GetObject("big1.Image")));
            this.big1.Name = "big1";
            this.big1.Size = new System.Drawing.Size(128, 34);
            this.big1.Text = "*1";
            this.big1.Click += new System.EventHandler(this.big1_Click);
            // 
            // big2
            // 
            this.big2.Image = ((System.Drawing.Image)(resources.GetObject("big2.Image")));
            this.big2.Name = "big2";
            this.big2.Size = new System.Drawing.Size(128, 34);
            this.big2.Text = "*2";
            this.big2.Click += new System.EventHandler(this.big2_Click);
            // 
            // big3
            // 
            this.big3.Image = ((System.Drawing.Image)(resources.GetObject("big3.Image")));
            this.big3.Name = "big3";
            this.big3.Size = new System.Drawing.Size(128, 34);
            this.big3.Text = "*3";
            this.big3.Click += new System.EventHandler(this.big3_Click);
            // 
            // big4
            // 
            this.big4.Image = ((System.Drawing.Image)(resources.GetObject("big4.Image")));
            this.big4.Name = "big4";
            this.big4.Size = new System.Drawing.Size(128, 34);
            this.big4.Text = "*4";
            this.big4.Click += new System.EventHandler(this.big4_Click);
            // 
            // big5
            // 
            this.big5.Image = ((System.Drawing.Image)(resources.GetObject("big5.Image")));
            this.big5.Name = "big5";
            this.big5.Size = new System.Drawing.Size(128, 34);
            this.big5.Text = "*5";
            this.big5.Click += new System.EventHandler(this.big5_Click);
            // 
            // dash
            // 
            this.dash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dotLineToolStripMenuItem,
            this.dashLineToolStripMenuItem,
            this.dashDotLineToolStripMenuItem,
            this.dashDotDotLineToolStripMenuItem});
            this.dash.Image = ((System.Drawing.Image)(resources.GetObject("dash.Image")));
            this.dash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(42, 28);
            this.dash.Text = "dash";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("solidToolStripMenuItem.Image")));
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.solidToolStripMenuItem.Text = "solid line";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.dashToolStripMenuItem_Click);
            // 
            // dotLineToolStripMenuItem
            // 
            this.dotLineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dotLineToolStripMenuItem.Image")));
            this.dotLineToolStripMenuItem.Name = "dotLineToolStripMenuItem";
            this.dotLineToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.dotLineToolStripMenuItem.Text = "dot line";
            this.dotLineToolStripMenuItem.Click += new System.EventHandler(this.dotLineToolStripMenuItem_Click);
            // 
            // dashLineToolStripMenuItem
            // 
            this.dashLineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashLineToolStripMenuItem.Image")));
            this.dashLineToolStripMenuItem.Name = "dashLineToolStripMenuItem";
            this.dashLineToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.dashLineToolStripMenuItem.Text = "dash line";
            this.dashLineToolStripMenuItem.Click += new System.EventHandler(this.dashLineToolStripMenuItem_Click);
            // 
            // dashDotLineToolStripMenuItem
            // 
            this.dashDotLineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashDotLineToolStripMenuItem.Image")));
            this.dashDotLineToolStripMenuItem.Name = "dashDotLineToolStripMenuItem";
            this.dashDotLineToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.dashDotLineToolStripMenuItem.Text = "dash dot line";
            this.dashDotLineToolStripMenuItem.Click += new System.EventHandler(this.dashDotLineToolStripMenuItem_Click);
            // 
            // dashDotDotLineToolStripMenuItem
            // 
            this.dashDotDotLineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashDotDotLineToolStripMenuItem.Image")));
            this.dashDotDotLineToolStripMenuItem.Name = "dashDotDotLineToolStripMenuItem";
            this.dashDotDotLineToolStripMenuItem.Size = new System.Drawing.Size(254, 34);
            this.dashDotDotLineToolStripMenuItem.Text = "dash dot dot line";
            this.dashDotDotLineToolStripMenuItem.Click += new System.EventHandler(this.dashDotDotLineToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LA1,
            this.LA2,
            this.LA3,
            this.LA4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 717);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1446, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LA1
            // 
            this.LA1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LA1.Name = "LA1";
            this.LA1.Size = new System.Drawing.Size(4, 15);
            this.LA1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // LA2
            // 
            this.LA2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LA2.Name = "LA2";
            this.LA2.Size = new System.Drawing.Size(4, 15);
            // 
            // LA3
            // 
            this.LA3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.LA3.Name = "LA3";
            this.LA3.Size = new System.Drawing.Size(4, 15);
            // 
            // LA4
            // 
            this.LA4.Name = "LA4";
            this.LA4.Size = new System.Drawing.Size(0, 15);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 521);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            this.tabControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseMove);
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseUp);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(787, 93);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(553, 499);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 5;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 739);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "呂弘睿";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem done;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToAshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c1;
        private System.Windows.Forms.ToolStripMenuItem c2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LA1;
        private System.Windows.Forms.ToolStripStatusLabel LA2;
        private System.Windows.Forms.ToolStripStatusLabel LA3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.ToolStripStatusLabel LA4;
        private System.Windows.Forms.ToolStripButton cut;
        private System.Windows.Forms.ToolStripButton copy;
        private System.Windows.Forms.ToolStripButton paste;
        private System.Windows.Forms.ToolStripButton color;
        private System.Windows.Forms.ToolStripButton pen;
        private System.Windows.Forms.ToolStripButton slash;
        private System.Windows.Forms.ToolStripButton circle;
        private System.Windows.Forms.ToolStripButton square;
        private System.Windows.Forms.ToolStripDropDownButton lineall;
        private System.Windows.Forms.ToolStripMenuItem big1;
        private System.Windows.Forms.ToolStripMenuItem big2;
        private System.Windows.Forms.ToolStripMenuItem big3;
        private System.Windows.Forms.ToolStripMenuItem big4;
        private System.Windows.Forms.ToolStripMenuItem big5;
        private System.Windows.Forms.ToolStripDropDownButton dash;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashDotDotLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem draw;
        private System.Windows.Forms.ColorDialog piantcolor;
    }
}

