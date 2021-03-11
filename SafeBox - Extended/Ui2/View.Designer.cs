namespace SafeBox3.Ui2
{
    partial class view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Mark = new System.Windows.Forms.Panel();
            this.LockBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.SettingBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.SyncBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DashBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.iMGBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.MediaBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.LOGO = new Bunifu.Framework.UI.BunifuImageButton();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.videoViewer1 = new SafeBox3.Ui.VideoViewer();
            this.photoViewer1 = new SafeBox3.Ui.PhotoViewer();
            this.dashBoard1 = new SafeBox3.Ui.DashBoard();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyncBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Black;
            this.SidePanel.Controls.Add(this.CloseBtn);
            this.SidePanel.Controls.Add(this.videoViewer1);
            this.SidePanel.Controls.Add(this.photoViewer1);
            this.SidePanel.Controls.Add(this.dashBoard1);
            this.SidePanel.Controls.Add(this.Mark);
            this.SidePanel.Controls.Add(this.LockBTN);
            this.SidePanel.Controls.Add(this.SettingBtn);
            this.SidePanel.Controls.Add(this.SyncBtn);
            this.SidePanel.Controls.Add(this.DashBtn);
            this.SidePanel.Controls.Add(this.iMGBTN);
            this.SidePanel.Controls.Add(this.MediaBtn);
            this.SidePanel.Controls.Add(this.LOGO);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(59, 514);
            this.SidePanel.TabIndex = 0;
            // 
            // Mark
            // 
            this.Mark.BackColor = System.Drawing.Color.Maroon;
            this.Mark.Location = new System.Drawing.Point(9, 0);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(2, 31);
            this.Mark.TabIndex = 0;
            // 
            // LockBTN
            // 
            this.LockBTN.BackColor = System.Drawing.Color.Transparent;
            this.LockBTN.Image = global::SafeBox3.Properties.Resources.Login;
            this.LockBTN.ImageActive = null;
            this.LockBTN.Location = new System.Drawing.Point(16, 458);
            this.LockBTN.Name = "LockBTN";
            this.LockBTN.Size = new System.Drawing.Size(25, 22);
            this.LockBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockBTN.TabIndex = 13;
            this.LockBTN.TabStop = false;
            this.LockBTN.Zoom = 10;
            this.LockBTN.Click += new System.EventHandler(this.LockBTN_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.Image = global::SafeBox3.Properties.Resources.icons8_Contacts_64px;
            this.SettingBtn.ImageActive = null;
            this.SettingBtn.Location = new System.Drawing.Point(13, 204);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(39, 31);
            this.SettingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingBtn.TabIndex = 12;
            this.SettingBtn.TabStop = false;
            this.SettingBtn.Zoom = 10;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // SyncBtn
            // 
            this.SyncBtn.BackColor = System.Drawing.Color.Transparent;
            this.SyncBtn.Image = global::SafeBox3.Properties.Resources.icons8_Cloud_50px1;
            this.SyncBtn.ImageActive = null;
            this.SyncBtn.Location = new System.Drawing.Point(13, 166);
            this.SyncBtn.Name = "SyncBtn";
            this.SyncBtn.Size = new System.Drawing.Size(39, 31);
            this.SyncBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SyncBtn.TabIndex = 15;
            this.SyncBtn.TabStop = false;
            this.SyncBtn.Zoom = 10;
            this.SyncBtn.Click += new System.EventHandler(this.SyncBtn_Click);
            // 
            // DashBtn
            // 
            this.DashBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashBtn.Image = global::SafeBox3.Properties.Resources.Dash;
            this.DashBtn.ImageActive = null;
            this.DashBtn.Location = new System.Drawing.Point(13, 54);
            this.DashBtn.Name = "DashBtn";
            this.DashBtn.Size = new System.Drawing.Size(39, 31);
            this.DashBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashBtn.TabIndex = 14;
            this.DashBtn.TabStop = false;
            this.DashBtn.Zoom = 10;
            this.DashBtn.Click += new System.EventHandler(this.DashBtn_Click);
            // 
            // iMGBTN
            // 
            this.iMGBTN.BackColor = System.Drawing.Color.Transparent;
            this.iMGBTN.Image = global::SafeBox3.Properties.Resources.icons8_Compact_Camera_50px;
            this.iMGBTN.ImageActive = null;
            this.iMGBTN.Location = new System.Drawing.Point(13, 92);
            this.iMGBTN.Name = "iMGBTN";
            this.iMGBTN.Size = new System.Drawing.Size(39, 31);
            this.iMGBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iMGBTN.TabIndex = 10;
            this.iMGBTN.TabStop = false;
            this.iMGBTN.Zoom = 10;
            this.iMGBTN.Click += new System.EventHandler(this.IMGBTN_Click);
            // 
            // MediaBtn
            // 
            this.MediaBtn.BackColor = System.Drawing.Color.Transparent;
            this.MediaBtn.Image = global::SafeBox3.Properties.Resources.play;
            this.MediaBtn.ImageActive = null;
            this.MediaBtn.Location = new System.Drawing.Point(13, 129);
            this.MediaBtn.Name = "MediaBtn";
            this.MediaBtn.Size = new System.Drawing.Size(39, 31);
            this.MediaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MediaBtn.TabIndex = 11;
            this.MediaBtn.TabStop = false;
            this.MediaBtn.Zoom = 10;
            this.MediaBtn.Click += new System.EventHandler(this.MediaBtn_Click);
            // 
            // LOGO
            // 
            this.LOGO.BackColor = System.Drawing.Color.Transparent;
            this.LOGO.Image = global::SafeBox3.Properties.Resources.icons8_safe;
            this.LOGO.ImageActive = null;
            this.LOGO.Location = new System.Drawing.Point(12, -1);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(41, 31);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 9;
            this.LOGO.TabStop = false;
            this.LOGO.Zoom = 10;
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "SafeBox ";
            this.notify.Visible = true;
            this.notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseClick);
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PwBox);
            this.panel1.Controls.Add(this.FinishBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(813, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 514);
            this.panel1.TabIndex = 1;
            // 
            // PwBox
            // 
            this.PwBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwBox.ForeColor = System.Drawing.Color.SpringGreen;
            this.PwBox.Location = new System.Drawing.Point(253, 308);
            this.PwBox.Multiline = true;
            this.PwBox.Name = "PwBox";
            this.PwBox.Size = new System.Drawing.Size(175, 30);
            this.PwBox.TabIndex = 8;
            this.PwBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PwBox.WordWrap = false;
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.FinishBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.FinishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishBtn.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.FinishBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.FinishBtn.Location = new System.Drawing.Point(253, 344);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(175, 39);
            this.FinishBtn.TabIndex = 7;
            this.FinishBtn.Text = "Login";
            this.FinishBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FinishBtn.UseVisualStyleBackColor = false;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SafeBox3.Properties.Resources.icons8_Protect_100px;
            this.pictureBox1.Location = new System.Drawing.Point(201, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 46;
            this.bunifuElipse2.TargetControl = this.FinishBtn;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // videoViewer1
            // 
            this.videoViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.videoViewer1.Location = new System.Drawing.Point(31, 313);
            this.videoViewer1.Name = "videoViewer1";
            this.videoViewer1.Size = new System.Drawing.Size(10, 16);
            this.videoViewer1.TabIndex = 2;
            this.videoViewer1.Visible = false;
            // 
            // photoViewer1
            // 
            this.photoViewer1.Location = new System.Drawing.Point(31, 291);
            this.photoViewer1.Name = "photoViewer1";
            this.photoViewer1.Size = new System.Drawing.Size(10, 16);
            this.photoViewer1.TabIndex = 2;
            this.photoViewer1.Visible = false;
            // 
            // dashBoard1
            // 
            this.dashBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dashBoard1.Location = new System.Drawing.Point(31, 269);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(10, 16);
            this.dashBoard1.TabIndex = 16;
            this.dashBoard1.Visible = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Image = global::SafeBox3.Properties.Resources.close;
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(16, 486);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(25, 22);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 14;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "view";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LockBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyncBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuImageButton LockBTN;
        private Bunifu.Framework.UI.BunifuImageButton SyncBtn;
        private Bunifu.Framework.UI.BunifuImageButton SettingBtn;
        private Bunifu.Framework.UI.BunifuImageButton DashBtn;
        private Bunifu.Framework.UI.BunifuImageButton iMGBTN;
        private Bunifu.Framework.UI.BunifuImageButton MediaBtn;
        private Bunifu.Framework.UI.BunifuImageButton LOGO;
        private System.Windows.Forms.Panel Mark;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox PwBox;
        public System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Ui.VideoViewer videoViewer1;
        private Ui.PhotoViewer photoViewer1;
        private Ui.DashBoard dashBoard1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
    }
}