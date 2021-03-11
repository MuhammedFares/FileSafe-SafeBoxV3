namespace SafeBox3.Ui
{
    partial class MainUi
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
            this.FormE = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.MiniE = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseE = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FloatBtns = new System.Windows.Forms.Panel();
            this.SyncBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.DashBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.LockBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.SettingBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MediaBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.iMGBTN = new Bunifu.Framework.UI.BunifuImageButton();
            this.FloatE = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ContatinerPan = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FloatBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SyncBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LockBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // FormE
            // 
            this.FormE.ElipseRadius = 5;
            this.FormE.TargetControl = this;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Crimson;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.Coral;
            this.CloseBtn.Location = new System.Drawing.Point(766, -49);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(78, 71);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // MiniBtn
            // 
            this.MiniBtn.BackColor = System.Drawing.Color.DarkRed;
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            this.MiniBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.MiniBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.ForeColor = System.Drawing.Color.Coral;
            this.MiniBtn.Location = new System.Drawing.Point(760, -103);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(135, 130);
            this.MiniBtn.TabIndex = 4;
            this.MiniBtn.UseVisualStyleBackColor = false;
            // 
            // MiniE
            // 
            this.MiniE.ElipseRadius = 55;
            this.MiniE.TargetControl = this.MiniBtn;
            // 
            // CloseE
            // 
            this.CloseE.ElipseRadius = 51;
            this.CloseE.TargetControl = this.CloseBtn;
            // 
            // FloatBtns
            // 
            this.FloatBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FloatBtns.Controls.Add(this.SyncBtn);
            this.FloatBtns.Controls.Add(this.DashBtn);
            this.FloatBtns.Controls.Add(this.LockBTN);
            this.FloatBtns.Controls.Add(this.SettingBtn);
            this.FloatBtns.Controls.Add(this.MediaBtn);
            this.FloatBtns.Controls.Add(this.iMGBTN);
            this.FloatBtns.Location = new System.Drawing.Point(251, -68);
            this.FloatBtns.Name = "FloatBtns";
            this.FloatBtns.Size = new System.Drawing.Size(317, 100);
            this.FloatBtns.TabIndex = 6;
            // 
            // SyncBtn
            // 
            this.SyncBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SyncBtn.Image = global::SafeBox3.Properties.Resources.icons8_Cloud_50px1;
            this.SyncBtn.ImageActive = null;
            this.SyncBtn.Location = new System.Drawing.Point(201, 70);
            this.SyncBtn.Name = "SyncBtn";
            this.SyncBtn.Size = new System.Drawing.Size(28, 29);
            this.SyncBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SyncBtn.TabIndex = 9;
            this.SyncBtn.TabStop = false;
            this.SyncBtn.Zoom = 10;
            // 
            // DashBtn
            // 
            this.DashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashBtn.Image = global::SafeBox3.Properties.Resources.Dash;
            this.DashBtn.ImageActive = null;
            this.DashBtn.Location = new System.Drawing.Point(39, 69);
            this.DashBtn.Name = "DashBtn";
            this.DashBtn.Size = new System.Drawing.Size(33, 28);
            this.DashBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashBtn.TabIndex = 8;
            this.DashBtn.TabStop = false;
            this.DashBtn.Zoom = 10;
            // 
            // LockBTN
            // 
            this.LockBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LockBTN.Image = global::SafeBox3.Properties.Resources.Login;
            this.LockBTN.ImageActive = null;
            this.LockBTN.Location = new System.Drawing.Point(239, 69);
            this.LockBTN.Name = "LockBTN";
            this.LockBTN.Size = new System.Drawing.Size(27, 27);
            this.LockBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockBTN.TabIndex = 7;
            this.LockBTN.TabStop = false;
            this.LockBTN.Zoom = 10;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingBtn.Image = global::SafeBox3.Properties.Resources.icons8_settings_50px_2;
            this.SettingBtn.ImageActive = null;
            this.SettingBtn.Location = new System.Drawing.Point(161, 71);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(30, 28);
            this.SettingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingBtn.TabIndex = 6;
            this.SettingBtn.TabStop = false;
            this.SettingBtn.Zoom = 10;
            // 
            // MediaBtn
            // 
            this.MediaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MediaBtn.Image = global::SafeBox3.Properties.Resources.play;
            this.MediaBtn.ImageActive = null;
            this.MediaBtn.Location = new System.Drawing.Point(121, 70);
            this.MediaBtn.Name = "MediaBtn";
            this.MediaBtn.Size = new System.Drawing.Size(35, 31);
            this.MediaBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MediaBtn.TabIndex = 3;
            this.MediaBtn.TabStop = false;
            this.MediaBtn.Zoom = 10;
            // 
            // iMGBTN
            // 
            this.iMGBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iMGBTN.Image = global::SafeBox3.Properties.Resources.icons8_Compact_Camera_50px;
            this.iMGBTN.ImageActive = null;
            this.iMGBTN.Location = new System.Drawing.Point(78, 71);
            this.iMGBTN.Name = "iMGBTN";
            this.iMGBTN.Size = new System.Drawing.Size(37, 28);
            this.iMGBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iMGBTN.TabIndex = 2;
            this.iMGBTN.TabStop = false;
            this.iMGBTN.Zoom = 10;
            // 
            // FloatE
            // 
            this.FloatE.ElipseRadius = 55;
            this.FloatE.TargetControl = this.FloatBtns;
            // 
            // ContatinerPan
            // 
            this.ContatinerPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContatinerPan.Location = new System.Drawing.Point(0, 37);
            this.ContatinerPan.Name = "ContatinerPan";
            this.ContatinerPan.Size = new System.Drawing.Size(800, 413);
            this.ContatinerPan.TabIndex = 8;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 59;
            this.bunifuElipse1.TargetControl = this.ContatinerPan;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 55;
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContatinerPan);
            this.Controls.Add(this.FloatBtns);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.MiniBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainUi";
            this.Text = "MainUi";
            this.Load += new System.EventHandler(this.MainUi_Load);
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

        private Bunifu.Framework.UI.BunifuElipse FormE;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button CloseBtn;
        private Bunifu.Framework.UI.BunifuElipse MiniE;
        private Bunifu.Framework.UI.BunifuElipse CloseE;
        private System.Windows.Forms.Panel FloatBtns;
        private Bunifu.Framework.UI.BunifuImageButton SyncBtn;
        private Bunifu.Framework.UI.BunifuImageButton DashBtn;
        private Bunifu.Framework.UI.BunifuImageButton LockBTN;
        private Bunifu.Framework.UI.BunifuImageButton SettingBtn;
        private Bunifu.Framework.UI.BunifuImageButton MediaBtn;
        private Bunifu.Framework.UI.BunifuImageButton iMGBTN;
        private Bunifu.Framework.UI.BunifuElipse FloatE;
        private System.Windows.Forms.Panel ContatinerPan;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}