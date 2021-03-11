using System;

namespace SafeBox3.Ui
{
    partial class VideoViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoViewer));
            this.Header = new System.Windows.Forms.Panel();
            this.Switcher = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.AddFolderBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Controlss = new System.Windows.Forms.Panel();
            this.VolumeBar = new Winamp.Components.WinampTrackBar();
            this.VolumeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.TrackBar = new Winamp.Components.WinampTrackBar();
            this.PauseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PlayBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Wall = new System.Windows.Forms.FlowLayoutPanel();
            this.player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Header.SuspendLayout();
            this.Controlss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.Header.Controls.Add(this.Switcher);
            this.Header.Controls.Add(this.RefreshBtn);
            this.Header.Controls.Add(this.DeleteBtn);
            this.Header.Controls.Add(this.ExportBtn);
            this.Header.Controls.Add(this.AddFolderBtn);
            this.Header.Controls.Add(this.AddBtn);
            this.Header.Controls.Add(this.button1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(750, 31);
            this.Header.TabIndex = 2;
            // 
            // Switcher
            // 
            this.Switcher.BackColor = System.Drawing.Color.Transparent;
            this.Switcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Switcher.BackgroundImage")));
            this.Switcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Switcher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switcher.Location = new System.Drawing.Point(188, 3);
            this.Switcher.Name = "Switcher";
            this.Switcher.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Switcher.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.Switcher.Size = new System.Drawing.Size(35, 20);
            this.Switcher.TabIndex = 6;
            this.Switcher.Value = false;
            this.Switcher.OnValueChange += new System.EventHandler(this.Switcher_OnValueChange);
            this.Switcher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Switcher_MouseClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImage = global::SafeBox3.Properties.Resources.repeat;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Location = new System.Drawing.Point(12, -3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(27, 31);
            this.RefreshBtn.TabIndex = 5;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackgroundImage = global::SafeBox3.Properties.Resources.delete2;
            this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(97, 1);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(23, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExportBtn
            // 
            this.ExportBtn.BackgroundImage = global::SafeBox3.Properties.Resources.icons8_Export_50px;
            this.ExportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportBtn.FlatAppearance.BorderSize = 0;
            this.ExportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportBtn.Location = new System.Drawing.Point(73, 3);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(22, 20);
            this.ExportBtn.TabIndex = 3;
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // AddFolderBtn
            // 
            this.AddFolderBtn.BackgroundImage = global::SafeBox3.Properties.Resources.addfolder1;
            this.AddFolderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddFolderBtn.FlatAppearance.BorderSize = 0;
            this.AddFolderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AddFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFolderBtn.Location = new System.Drawing.Point(124, 2);
            this.AddFolderBtn.Name = "AddFolderBtn";
            this.AddFolderBtn.Size = new System.Drawing.Size(29, 22);
            this.AddFolderBtn.TabIndex = 2;
            this.AddFolderBtn.UseVisualStyleBackColor = true;
            this.AddFolderBtn.Click += new System.EventHandler(this.AddFolderBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackgroundImage = global::SafeBox3.Properties.Resources.addnew1;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(157, 2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(25, 22);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SafeBox3.Properties.Resources.next1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(42, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Controlss
            // 
            this.Controlss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.Controlss.Controls.Add(this.VolumeBar);
            this.Controlss.Controls.Add(this.VolumeBtn);
            this.Controlss.Controls.Add(this.TrackBar);
            this.Controlss.Controls.Add(this.PauseBtn);
            this.Controlss.Controls.Add(this.PlayBtn);
            this.Controlss.Location = new System.Drawing.Point(3, 471);
            this.Controlss.Name = "Controlss";
            this.Controlss.Size = new System.Drawing.Size(551, 35);
            this.Controlss.TabIndex = 5;
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.EmptyTrackColor = System.Drawing.Color.Crimson;
            this.VolumeBar.KeyChangeOption = Winamp.Components.WinampTrackBar.WinampTrackBarKeyChangeOption.LeftAndRightArrowKeys;
            this.VolumeBar.Location = new System.Drawing.Point(456, 8);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.ScaleFieldColor = System.Drawing.Color.Transparent;
            this.VolumeBar.ScaleFieldMaxHeight = 7;
            this.VolumeBar.ShowSlider = Winamp.Components.WinampTrackBar.WinampTrackBarShowSlider.OnHover;
            this.VolumeBar.Size = new System.Drawing.Size(93, 25);
            this.VolumeBar.SliderButtonSize = new System.Drawing.Size(18, 10);
            this.VolumeBar.TabIndex = 139;
            this.VolumeBar.TickColor = System.Drawing.Color.Red;
            this.VolumeBar.Scroll += new Winamp.Components.WinampTrackBar.ScrollDelegate(this.VolumeBar_Scroll);
            // 
            // VolumeBtn
            // 
            this.VolumeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VolumeBtn.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBtn.Image = global::SafeBox3.Properties.Resources.audio;
            this.VolumeBtn.ImageActive = null;
            this.VolumeBtn.InitialImage = null;
            this.VolumeBtn.Location = new System.Drawing.Point(424, 9);
            this.VolumeBtn.Name = "VolumeBtn";
            this.VolumeBtn.Size = new System.Drawing.Size(24, 26);
            this.VolumeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolumeBtn.TabIndex = 138;
            this.VolumeBtn.TabStop = false;
            this.VolumeBtn.Zoom = 10;
            this.VolumeBtn.Click += new System.EventHandler(this.VolumeBtn_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar.EmptyTrackColor = System.Drawing.Color.Crimson;
            this.TrackBar.KeyChangeOption = Winamp.Components.WinampTrackBar.WinampTrackBarKeyChangeOption.LeftAndRightArrowKeys;
            this.TrackBar.Location = new System.Drawing.Point(66, 5);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.ScaleFieldColor = System.Drawing.Color.Transparent;
            this.TrackBar.ScaleFieldWidth = 10;
            this.TrackBar.ShowSlider = Winamp.Components.WinampTrackBar.WinampTrackBarShowSlider.OnHover;
            this.TrackBar.Size = new System.Drawing.Size(351, 25);
            this.TrackBar.SliderButtonSize = new System.Drawing.Size(18, 10);
            this.TrackBar.TabIndex = 135;
            this.TrackBar.TickColor = System.Drawing.Color.Red;
            this.TrackBar.TickEmphasizedColor = System.Drawing.Color.SeaGreen;
            this.TrackBar.ToolTipIsBalloon = true;
            this.TrackBar.TrackLowerColor = System.Drawing.Color.SeaGreen;
            this.TrackBar.TrackUpperColor = System.Drawing.Color.SeaGreen;
            this.TrackBar.Scroll += new Winamp.Components.WinampTrackBar.ScrollDelegate(this.TrackBar_Scroll);
            this.TrackBar.SeekDone += new Winamp.Components.WinampTrackBar.SeekDoneDelegate(this.TrackBar_SeekDone);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.PauseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseBtn.Image = global::SafeBox3.Properties.Resources.pause;
            this.PauseBtn.ImageActive = null;
            this.PauseBtn.InitialImage = null;
            this.PauseBtn.Location = new System.Drawing.Point(31, 9);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(24, 26);
            this.PauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PauseBtn.TabIndex = 136;
            this.PauseBtn.TabStop = false;
            this.PauseBtn.Zoom = 9;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Image = global::SafeBox3.Properties.Resources.play;
            this.PlayBtn.ImageActive = null;
            this.PlayBtn.InitialImage = null;
            this.PlayBtn.Location = new System.Drawing.Point(1, 9);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(24, 26);
            this.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayBtn.TabIndex = 137;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Zoom = 9;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // Wall
            // 
            this.Wall.AutoScroll = true;
            this.Wall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.Wall.Location = new System.Drawing.Point(559, 30);
            this.Wall.Name = "Wall";
            this.Wall.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.Wall.Size = new System.Drawing.Size(191, 533);
            this.Wall.TabIndex = 141;
            // 
            // player1
            // 
            this.player1.Enabled = true;
            this.player1.Location = new System.Drawing.Point(4, 34);
            this.player1.Name = "player1";
            this.player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player1.OcxState")));
            this.player1.Size = new System.Drawing.Size(550, 436);
            this.player1.TabIndex = 142;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 513);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(883, 23);
            this.progressBar1.TabIndex = 140;
            // 
            // VideoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.Controlss);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Wall);
            this.Name = "VideoViewer";
            this.Size = new System.Drawing.Size(750, 514);
            this.Load += new System.EventHandler(this.VideoViewer_Load);
            this.Header.ResumeLayout(false);
            this.Controlss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switcher;
        public System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button AddFolderBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Controlss;
        public Winamp.Components.WinampTrackBar VolumeBar;
        public Bunifu.Framework.UI.BunifuImageButton VolumeBtn;
        public Winamp.Components.WinampTrackBar TrackBar;
        public Bunifu.Framework.UI.BunifuImageButton PauseBtn;
        public Bunifu.Framework.UI.BunifuImageButton PlayBtn;
        private System.Windows.Forms.FlowLayoutPanel Wall;
        private AxWMPLib.AxWindowsMediaPlayer player1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
