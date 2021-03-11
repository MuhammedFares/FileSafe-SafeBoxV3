namespace SafeBox3.Ui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FloatBtns = new System.Windows.Forms.Panel();
            this.SyncBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DashBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.LockBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.SettingBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MediaBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.iMGBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Notifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.photoViewer1 = new SafeBox3.Ui.PhotoViewer();
            this.dashBoard1 = new SafeBox3.Ui.DashBoard();
            this.videoViewer2 = new SafeBox3.Ui.VideoViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FloatBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PwBox);
            this.panel1.Controls.Add(this.FinishBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(69, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 194);
            this.panel1.TabIndex = 0;
            // 
            // PwBox
            // 
            this.PwBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwBox.ForeColor = System.Drawing.Color.SpringGreen;
            this.PwBox.Location = new System.Drawing.Point(361, 358);
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
            this.FinishBtn.Location = new System.Drawing.Point(361, 394);
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
            this.pictureBox1.Location = new System.Drawing.Point(282, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FloatBtns
            // 
            this.FloatBtns.BackColor = System.Drawing.Color.Black;
            this.FloatBtns.Controls.Add(this.SyncBtn);
            this.FloatBtns.Controls.Add(this.DashBtn);
            this.FloatBtns.Controls.Add(this.LockBTN);
            this.FloatBtns.Controls.Add(this.SettingBtn);
            this.FloatBtns.Controls.Add(this.MediaBtn);
            this.FloatBtns.Controls.Add(this.iMGBTN);
            this.FloatBtns.Controls.Add(this.button1);
            this.FloatBtns.Location = new System.Drawing.Point(278, -69);
            this.FloatBtns.Name = "FloatBtns";
            this.FloatBtns.Size = new System.Drawing.Size(317, 100);
            this.FloatBtns.TabIndex = 1;
            this.FloatBtns.Paint += new System.Windows.Forms.PaintEventHandler(this.FloatBtns_Paint);
            this.FloatBtns.MouseLeave += new System.EventHandler(this.FloatBtns_MouseLeave);
            // 
            // SyncBtn
            // 
            this.SyncBtn.BackColor = System.Drawing.Color.Black;
            this.SyncBtn.Image = global::SafeBox3.Properties.Resources.icons8_Cloud_50px1;
            this.SyncBtn.ImageActive = null;
            this.SyncBtn.Location = new System.Drawing.Point(168, 73);
            this.SyncBtn.Name = "SyncBtn";
            this.SyncBtn.Size = new System.Drawing.Size(28, 29);
            this.SyncBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SyncBtn.TabIndex = 9;
            this.SyncBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.SyncBtn, "Syncronization Status");
            this.SyncBtn.Zoom = 10;
            // 
            // DashBtn
            // 
            this.DashBtn.BackColor = System.Drawing.Color.Black;
            this.DashBtn.Image = global::SafeBox3.Properties.Resources.Dash;
            this.DashBtn.ImageActive = null;
            this.DashBtn.Location = new System.Drawing.Point(47, 70);
            this.DashBtn.Name = "DashBtn";
            this.DashBtn.Size = new System.Drawing.Size(33, 28);
            this.DashBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashBtn.TabIndex = 8;
            this.DashBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.DashBtn, "Images Tab");
            this.DashBtn.Zoom = 10;
            this.DashBtn.Click += new System.EventHandler(this.DashBtn_Click);
            // 
            // LockBTN
            // 
            this.LockBTN.BackColor = System.Drawing.Color.Black;
            this.LockBTN.Image = global::SafeBox3.Properties.Resources.Login;
            this.LockBTN.ImageActive = null;
            this.LockBTN.Location = new System.Drawing.Point(238, 71);
            this.LockBTN.Name = "LockBTN";
            this.LockBTN.Size = new System.Drawing.Size(27, 27);
            this.LockBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockBTN.TabIndex = 7;
            this.LockBTN.TabStop = false;
            this.toolTip1.SetToolTip(this.LockBTN, "Lock application");
            this.LockBTN.Zoom = 10;
            this.LockBTN.Click += new System.EventHandler(this.LockBTN_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.Black;
            this.SettingBtn.Image = global::SafeBox3.Properties.Resources.icons8_settings_50px_2;
            this.SettingBtn.ImageActive = null;
            this.SettingBtn.Location = new System.Drawing.Point(202, 74);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(30, 28);
            this.SettingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingBtn.TabIndex = 6;
            this.SettingBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.SettingBtn, "Documents and Other Files Tab");
            this.SettingBtn.Zoom = 10;
            // 
            // MediaBtn
            // 
            this.MediaBtn.BackColor = System.Drawing.Color.Black;
            this.MediaBtn.Image = global::SafeBox3.Properties.Resources.play;
            this.MediaBtn.ImageActive = null;
            this.MediaBtn.Location = new System.Drawing.Point(127, 71);
            this.MediaBtn.Name = "MediaBtn";
            this.MediaBtn.Size = new System.Drawing.Size(35, 31);
            this.MediaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MediaBtn.TabIndex = 3;
            this.MediaBtn.TabStop = false;
            this.toolTip1.SetToolTip(this.MediaBtn, "Videos Tab");
            this.MediaBtn.Zoom = 10;
            this.MediaBtn.Click += new System.EventHandler(this.VIDBTN_Click);
            // 
            // iMGBTN
            // 
            this.iMGBTN.BackColor = System.Drawing.Color.Black;
            this.iMGBTN.Image = global::SafeBox3.Properties.Resources.icons8_Compact_Camera_50px;
            this.iMGBTN.ImageActive = null;
            this.iMGBTN.Location = new System.Drawing.Point(86, 73);
            this.iMGBTN.Name = "iMGBTN";
            this.iMGBTN.Size = new System.Drawing.Size(37, 28);
            this.iMGBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iMGBTN.TabIndex = 2;
            this.iMGBTN.TabStop = false;
            this.toolTip1.SetToolTip(this.iMGBTN, "Images Tab");
            this.iMGBTN.Zoom = 10;
            this.iMGBTN.Click += new System.EventHandler(this.IMGBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 90;
            this.bunifuElipse2.TargetControl = this.FloatBtns;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Crimson;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Coral;
            this.CloseBtn.Location = new System.Drawing.Point(855, -49);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(78, 71);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 90;
            this.bunifuElipse3.TargetControl = this.CloseBtn;
            // 
            // Notifier
            // 
            this.Notifier.Icon = ((System.Drawing.Icon)(resources.GetObject("Notifier.Icon")));
            this.Notifier.Text = "SafeBox by Moka";
            this.Notifier.Visible = true;
            this.Notifier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notifier_MouseClick);
            // 
            // photoViewer1
            // 
            this.photoViewer1.Location = new System.Drawing.Point(12, 12);
            this.photoViewer1.Name = "photoViewer1";
            this.photoViewer1.Size = new System.Drawing.Size(15, 25);
            this.photoViewer1.TabIndex = 3;
            // 
            // dashBoard1
            // 
            this.dashBoard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dashBoard1.Location = new System.Drawing.Point(42, 20);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(10, 10);
            this.dashBoard1.TabIndex = 5;
            this.dashBoard1.Visible = false;
            // 
            // videoViewer2
            // 
            this.videoViewer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.videoViewer2.Location = new System.Drawing.Point(69, 7);
            this.videoViewer2.Name = "videoViewer2";
            this.videoViewer2.Size = new System.Drawing.Size(11, 26);
            this.videoViewer2.TabIndex = 6;
            this.videoViewer2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(883, 577);
            this.Controls.Add(this.FloatBtns);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.photoViewer1);
            this.Controls.Add(this.dashBoard1);
            this.Controls.Add(this.videoViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FloatBtns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SyncBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button FinishBtn;
        public System.Windows.Forms.TextBox PwBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel FloatBtns;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuImageButton iMGBTN;
        private Bunifu.Framework.UI.BunifuImageButton MediaBtn;
        private System.Windows.Forms.Button CloseBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton SettingBtn;
        private Bunifu.Framework.UI.BunifuImageButton LockBTN;
        private Bunifu.Framework.UI.BunifuImageButton DashBtn;
        private PhotoViewer photoViewer1;
        private System.Windows.Forms.NotifyIcon Notifier;
        public DashBoard dashBoard1;
        private Bunifu.Framework.UI.BunifuImageButton SyncBtn;
        public VideoViewer videoViewer2;
    }
}