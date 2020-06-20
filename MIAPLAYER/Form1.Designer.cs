namespace MIAPLAYER
{
    partial class MiaPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiaPlayer));
            this.LeftGradientBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.NowPlayingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BrowseFilesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlayListButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.StopButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.volumeLevel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.volumeBar = new Bunifu.Framework.UI.BunifuSlider();
            this.fullTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.currentTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VolumeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.NextButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.PauseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.playButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.PrevButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.ProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menubar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.songTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl5 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.rightBarGrad = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mainBox = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LeftGradientBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevButton)).BeginInit();
            this.menubar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.mainBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftGradientBar
            // 
            this.LeftGradientBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftGradientBar.BackgroundImage")));
            this.LeftGradientBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftGradientBar.Controls.Add(this.NowPlayingButton);
            this.LeftGradientBar.Controls.Add(this.BrowseFilesButton);
            this.LeftGradientBar.Controls.Add(this.PlayListButton);
            this.LeftGradientBar.Controls.Add(this.pictureBox1);
            this.LeftGradientBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftGradientBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LeftGradientBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LeftGradientBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LeftGradientBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LeftGradientBar.Location = new System.Drawing.Point(0, 0);
            this.LeftGradientBar.Name = "LeftGradientBar";
            this.LeftGradientBar.Quality = 10;
            this.LeftGradientBar.Size = new System.Drawing.Size(232, 547);
            this.LeftGradientBar.TabIndex = 0;
            // 
            // NowPlayingButton
            // 
            this.NowPlayingButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NowPlayingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NowPlayingButton.BackColor = System.Drawing.Color.Transparent;
            this.NowPlayingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NowPlayingButton.BorderRadius = 0;
            this.NowPlayingButton.ButtonText = "Now Playing";
            this.NowPlayingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NowPlayingButton.DisabledColor = System.Drawing.Color.Gray;
            this.NowPlayingButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingButton.Iconcolor = System.Drawing.Color.Transparent;
            this.NowPlayingButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("NowPlayingButton.Iconimage")));
            this.NowPlayingButton.Iconimage_right = null;
            this.NowPlayingButton.Iconimage_right_Selected = null;
            this.NowPlayingButton.Iconimage_Selected = null;
            this.NowPlayingButton.IconMarginLeft = 0;
            this.NowPlayingButton.IconMarginRight = 0;
            this.NowPlayingButton.IconRightVisible = true;
            this.NowPlayingButton.IconRightZoom = 0D;
            this.NowPlayingButton.IconVisible = true;
            this.NowPlayingButton.IconZoom = 50D;
            this.NowPlayingButton.IsTab = true;
            this.NowPlayingButton.Location = new System.Drawing.Point(2, 409);
            this.NowPlayingButton.Name = "NowPlayingButton";
            this.NowPlayingButton.Normalcolor = System.Drawing.Color.Transparent;
            this.NowPlayingButton.OnHovercolor = System.Drawing.Color.Blue;
            this.NowPlayingButton.OnHoverTextColor = System.Drawing.Color.White;
            this.NowPlayingButton.selected = false;
            this.NowPlayingButton.Size = new System.Drawing.Size(229, 48);
            this.NowPlayingButton.TabIndex = 3;
            this.NowPlayingButton.Text = "Now Playing";
            this.NowPlayingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NowPlayingButton.Textcolor = System.Drawing.Color.White;
            this.NowPlayingButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingButton.Click += new System.EventHandler(this.NowPlayingButton_Click);
            // 
            // BrowseFilesButton
            // 
            this.BrowseFilesButton.Activecolor = System.Drawing.Color.Transparent;
            this.BrowseFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BrowseFilesButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseFilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseFilesButton.BorderRadius = 0;
            this.BrowseFilesButton.ButtonText = "Browse Files";
            this.BrowseFilesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseFilesButton.DisabledColor = System.Drawing.Color.Gray;
            this.BrowseFilesButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFilesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.BrowseFilesButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("BrowseFilesButton.Iconimage")));
            this.BrowseFilesButton.Iconimage_right = null;
            this.BrowseFilesButton.Iconimage_right_Selected = null;
            this.BrowseFilesButton.Iconimage_Selected = null;
            this.BrowseFilesButton.IconMarginLeft = 0;
            this.BrowseFilesButton.IconMarginRight = 0;
            this.BrowseFilesButton.IconRightVisible = true;
            this.BrowseFilesButton.IconRightZoom = 0D;
            this.BrowseFilesButton.IconVisible = true;
            this.BrowseFilesButton.IconZoom = 50D;
            this.BrowseFilesButton.IsTab = true;
            this.BrowseFilesButton.Location = new System.Drawing.Point(2, 463);
            this.BrowseFilesButton.Name = "BrowseFilesButton";
            this.BrowseFilesButton.Normalcolor = System.Drawing.Color.Transparent;
            this.BrowseFilesButton.OnHovercolor = System.Drawing.Color.Blue;
            this.BrowseFilesButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BrowseFilesButton.selected = false;
            this.BrowseFilesButton.Size = new System.Drawing.Size(229, 48);
            this.BrowseFilesButton.TabIndex = 2;
            this.BrowseFilesButton.Text = "Browse Files";
            this.BrowseFilesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrowseFilesButton.Textcolor = System.Drawing.Color.White;
            this.BrowseFilesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFilesButton.Click += new System.EventHandler(this.BrowseFilesButton_Click);
            // 
            // PlayListButton
            // 
            this.PlayListButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PlayListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayListButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayListButton.BorderRadius = 0;
            this.PlayListButton.ButtonText = "PlayList";
            this.PlayListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayListButton.DisabledColor = System.Drawing.Color.Gray;
            this.PlayListButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayListButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PlayListButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PlayListButton.Iconimage")));
            this.PlayListButton.Iconimage_right = null;
            this.PlayListButton.Iconimage_right_Selected = null;
            this.PlayListButton.Iconimage_Selected = null;
            this.PlayListButton.IconMarginLeft = 0;
            this.PlayListButton.IconMarginRight = 0;
            this.PlayListButton.IconRightVisible = true;
            this.PlayListButton.IconRightZoom = 0D;
            this.PlayListButton.IconVisible = true;
            this.PlayListButton.IconZoom = 50D;
            this.PlayListButton.IsTab = true;
            this.PlayListButton.Location = new System.Drawing.Point(3, 355);
            this.PlayListButton.Name = "PlayListButton";
            this.PlayListButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PlayListButton.OnHovercolor = System.Drawing.Color.Blue;
            this.PlayListButton.OnHoverTextColor = System.Drawing.Color.White;
            this.PlayListButton.selected = false;
            this.PlayListButton.Size = new System.Drawing.Size(229, 48);
            this.PlayListButton.TabIndex = 1;
            this.PlayListButton.Text = "PlayList";
            this.PlayListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayListButton.Textcolor = System.Drawing.Color.White;
            this.PlayListButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayListButton.Click += new System.EventHandler(this.PlayListButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.StopButton);
            this.bunifuGradientPanel2.Controls.Add(this.volumeLevel);
            this.bunifuGradientPanel2.Controls.Add(this.volumeBar);
            this.bunifuGradientPanel2.Controls.Add(this.fullTime);
            this.bunifuGradientPanel2.Controls.Add(this.currentTime);
            this.bunifuGradientPanel2.Controls.Add(this.VolumeButton);
            this.bunifuGradientPanel2.Controls.Add(this.NextButton);
            this.bunifuGradientPanel2.Controls.Add(this.PauseButton);
            this.bunifuGradientPanel2.Controls.Add(this.playButton);
            this.bunifuGradientPanel2.Controls.Add(this.PrevButton);
            this.bunifuGradientPanel2.Controls.Add(this.ProgressBar);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(232, 459);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(653, 88);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.ImageActive = null;
            this.StopButton.Location = new System.Drawing.Point(211, 14);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(34, 29);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopButton.TabIndex = 11;
            this.StopButton.TabStop = false;
            this.StopButton.Zoom = 10;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // volumeLevel
            // 
            this.volumeLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeLevel.AutoSize = true;
            this.volumeLevel.BackColor = System.Drawing.Color.Transparent;
            this.volumeLevel.ForeColor = System.Drawing.Color.Transparent;
            this.volumeLevel.Location = new System.Drawing.Point(608, 23);
            this.volumeLevel.Name = "volumeLevel";
            this.volumeLevel.Size = new System.Drawing.Size(21, 13);
            this.volumeLevel.TabIndex = 8;
            this.volumeLevel.Text = "0%";
            this.volumeLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.BackgroudColor = System.Drawing.Color.DarkGray;
            this.volumeBar.BorderRadius = 0;
            this.volumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeBar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.volumeBar.IndicatorColor = System.Drawing.Color.Teal;
            this.volumeBar.Location = new System.Drawing.Point(416, 17);
            this.volumeBar.MaximumValue = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(186, 30);
            this.volumeBar.TabIndex = 9;
            this.volumeBar.Value = 50;
            this.volumeBar.ValueChanged += new System.EventHandler(this.volumeBar_ValueChanged);
            // 
            // fullTime
            // 
            this.fullTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullTime.AutoSize = true;
            this.fullTime.BackColor = System.Drawing.Color.Transparent;
            this.fullTime.ForeColor = System.Drawing.Color.Transparent;
            this.fullTime.Location = new System.Drawing.Point(613, 59);
            this.fullTime.Name = "fullTime";
            this.fullTime.Size = new System.Drawing.Size(34, 13);
            this.fullTime.TabIndex = 8;
            this.fullTime.Text = "00:00";
            this.fullTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTime
            // 
            this.currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentTime.AutoSize = true;
            this.currentTime.BackColor = System.Drawing.Color.Transparent;
            this.currentTime.ForeColor = System.Drawing.Color.Transparent;
            this.currentTime.Location = new System.Drawing.Point(7, 60);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(34, 13);
            this.currentTime.TabIndex = 7;
            this.currentTime.Text = "00:00";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeButton
            // 
            this.VolumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeButton.BackColor = System.Drawing.Color.Transparent;
            this.VolumeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeButton.Image = ((System.Drawing.Image)(resources.GetObject("VolumeButton.Image")));
            this.VolumeButton.ImageActive = null;
            this.VolumeButton.Location = new System.Drawing.Point(376, 14);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(34, 29);
            this.VolumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolumeButton.TabIndex = 6;
            this.VolumeButton.TabStop = false;
            this.VolumeButton.Zoom = 10;
            this.VolumeButton.Click += new System.EventHandler(this.VolumeButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageActive = null;
            this.NextButton.Location = new System.Drawing.Point(252, 15);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(34, 29);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextButton.TabIndex = 5;
            this.NextButton.TabStop = false;
            this.NextButton.Zoom = 10;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.Transparent;
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageActive = null;
            this.PauseButton.Location = new System.Drawing.Point(167, 14);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(34, 29);
            this.PauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseButton.TabIndex = 4;
            this.PauseButton.TabStop = false;
            this.PauseButton.Zoom = 10;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.ImageActive = null;
            this.playButton.Location = new System.Drawing.Point(127, 14);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(34, 29);
            this.playButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playButton.TabIndex = 2;
            this.playButton.TabStop = false;
            this.playButton.Zoom = 10;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.BackColor = System.Drawing.Color.Transparent;
            this.PrevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevButton.Image = ((System.Drawing.Image)(resources.GetObject("PrevButton.Image")));
            this.PrevButton.ImageActive = null;
            this.PrevButton.Location = new System.Drawing.Point(85, 14);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(34, 29);
            this.PrevButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PrevButton.TabIndex = 1;
            this.PrevButton.TabStop = false;
            this.PrevButton.Zoom = 10;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar.BorderRadius = 5;
            this.ProgressBar.Location = new System.Drawing.Point(44, 61);
            this.ProgressBar.MaximumValue = 100;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar.Size = new System.Drawing.Size(566, 10);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Value = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.LeftGradientBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.pictureBox1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.bunifuGradientPanel2;
            this.bunifuDragControl4.Vertical = true;
            // 
            // menubar
            // 
            this.menubar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menubar.BackgroundImage")));
            this.menubar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menubar.Controls.Add(this.bunifuCustomLabel1);
            this.menubar.Controls.Add(this.songTitle);
            this.menubar.Controls.Add(this.closeButton);
            this.menubar.Controls.Add(this.maximizeButton);
            this.menubar.Controls.Add(this.minimizeButton);
            this.menubar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menubar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menubar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menubar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menubar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.menubar.Location = new System.Drawing.Point(232, 0);
            this.menubar.Name = "menubar";
            this.menubar.Quality = 10;
            this.menubar.Size = new System.Drawing.Size(653, 40);
            this.menubar.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(50, 13);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Playing :";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuCustomLabel1.UseMnemonic = false;
            // 
            // songTitle
            // 
            this.songTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitle.AutoSize = true;
            this.songTitle.BackColor = System.Drawing.Color.Transparent;
            this.songTitle.ForeColor = System.Drawing.Color.White;
            this.songTitle.Location = new System.Drawing.Point(63, 16);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(33, 13);
            this.songTitle.TabIndex = 6;
            this.songTitle.Text = "None";
            this.songTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songTitle.UseMnemonic = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageActive = null;
            this.closeButton.Location = new System.Drawing.Point(611, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(2);
            this.closeButton.Size = new System.Drawing.Size(30, 25);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 5;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(576, 7);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Padding = new System.Windows.Forms.Padding(2);
            this.maximizeButton.Size = new System.Drawing.Size(30, 25);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Zoom = 5;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(540, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Padding = new System.Windows.Forms.Padding(2);
            this.minimizeButton.Size = new System.Drawing.Size(30, 25);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 5;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // bunifuDragControl5
            // 
            this.bunifuDragControl5.Fixed = true;
            this.bunifuDragControl5.Horizontal = true;
            this.bunifuDragControl5.TargetControl = this.menubar;
            this.bunifuDragControl5.Vertical = true;
            // 
            // rightBarGrad
            // 
            this.rightBarGrad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightBarGrad.BackgroundImage")));
            this.rightBarGrad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBarGrad.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBarGrad.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rightBarGrad.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rightBarGrad.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rightBarGrad.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rightBarGrad.Location = new System.Drawing.Point(848, 40);
            this.rightBarGrad.Name = "rightBarGrad";
            this.rightBarGrad.Quality = 10;
            this.rightBarGrad.Size = new System.Drawing.Size(37, 419);
            this.rightBarGrad.TabIndex = 3;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.rightBarGrad;
            this.bunifuDragControl2.Vertical = true;
            // 
            // mainBox
            // 
            this.mainBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBox.BackgroundImage")));
            this.mainBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBox.Controls.Add(this.PlayList);
            this.mainBox.Controls.Add(this.axWindowsMediaPlayer1);
            this.mainBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBox.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainBox.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainBox.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainBox.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainBox.Location = new System.Drawing.Point(232, 40);
            this.mainBox.Name = "mainBox";
            this.mainBox.Quality = 10;
            this.mainBox.Size = new System.Drawing.Size(616, 419);
            this.mainBox.TabIndex = 6;
            // 
            // PlayList
            // 
            this.PlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayList.ForeColor = System.Drawing.Color.White;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.ItemHeight = 21;
            this.PlayList.Location = new System.Drawing.Point(0, 0);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(616, 441);
            this.PlayList.TabIndex = 1;
            this.PlayList.SelectedIndexChanged += new System.EventHandler(this.PlayList_SelectedIndexChanged);
            this.PlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayList_MouseDoubleClick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, -2);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(616, 429);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MiaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 547);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.rightBarGrad);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.LeftGradientBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiaPlayer";
            this.RightToLeftLayout = true;
            this.Text = "MIA Player";
            this.Load += new System.EventHandler(this.MiaPlayer_Load);
            this.LeftGradientBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrevButton)).EndInit();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.mainBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel LeftGradientBar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton NowPlayingButton;
        private Bunifu.Framework.UI.BunifuFlatButton BrowseFilesButton;
        private Bunifu.Framework.UI.BunifuFlatButton PlayListButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar;
        private Bunifu.Framework.UI.BunifuGradientPanel menubar;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl5;
        private Bunifu.Framework.UI.BunifuCustomLabel volumeLevel;
        private Bunifu.Framework.UI.BunifuSlider volumeBar;
        private Bunifu.Framework.UI.BunifuCustomLabel fullTime;
        private Bunifu.Framework.UI.BunifuCustomLabel currentTime;
        private Bunifu.Framework.UI.BunifuImageButton VolumeButton;
        private Bunifu.Framework.UI.BunifuImageButton NextButton;
        private Bunifu.Framework.UI.BunifuImageButton PauseButton;
        private Bunifu.Framework.UI.BunifuImageButton playButton;
        private Bunifu.Framework.UI.BunifuImageButton PrevButton;
        private Bunifu.Framework.UI.BunifuCustomLabel songTitle;
        private Bunifu.Framework.UI.BunifuGradientPanel rightBarGrad;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuGradientPanel mainBox;
        private System.Windows.Forms.ListBox PlayList;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton StopButton;
        private System.Windows.Forms.Timer timer1;
    }
}

