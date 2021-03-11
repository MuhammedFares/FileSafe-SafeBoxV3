namespace SafeBox3.Ui
{
    partial class Intro
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ChoosePanel = new System.Windows.Forms.Panel();
            this.Next2 = new System.Windows.Forms.Button();
            this.partions1 = new SafeBox3.Ui.Partions();
            this.label3 = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ChoosePanel.SuspendLayout();
            this.Final.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(169, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome , Let\'s Create a Password";
            // 
            // PwBox
            // 
            this.PwBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.PwBox.Location = new System.Drawing.Point(257, 137);
            this.PwBox.Multiline = true;
            this.PwBox.Name = "PwBox";
            this.PwBox.Size = new System.Drawing.Size(288, 35);
            this.PwBox.TabIndex = 1;
            this.PwBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PwBox.WordWrap = false;
            this.PwBox.TextChanged += new System.EventHandler(this.PwBox_TextChanged);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 2;
            this.bunifuProgressBar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(257, 178);
            this.bunifuProgressBar1.MaximumValue = 5;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(288, 10);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(276, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "it\'s Okay , Continue";
            this.label2.Visible = false;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.NextBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.Location = new System.Drawing.Point(358, 323);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(93, 44);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "NEXT ";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Visible = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ChoosePanel
            // 
            this.ChoosePanel.Controls.Add(this.Next2);
            this.ChoosePanel.Controls.Add(this.partions1);
            this.ChoosePanel.Controls.Add(this.label3);
            this.ChoosePanel.Location = new System.Drawing.Point(82, 35);
            this.ChoosePanel.Name = "ChoosePanel";
            this.ChoosePanel.Size = new System.Drawing.Size(648, 376);
            this.ChoosePanel.TabIndex = 9;
            this.ChoosePanel.Visible = false;
            // 
            // Next2
            // 
            this.Next2.BackColor = System.Drawing.Color.SeaGreen;
            this.Next2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.Next2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next2.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.Next2.ForeColor = System.Drawing.Color.White;
            this.Next2.Location = new System.Drawing.Point(285, 305);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(93, 44);
            this.Next2.TabIndex = 5;
            this.Next2.Text = "NEXT ";
            this.Next2.UseVisualStyleBackColor = false;
            this.Next2.Visible = false;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // partions1
            // 
            this.partions1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.partions1.Location = new System.Drawing.Point(11, 48);
            this.partions1.Name = "partions1";
            this.partions1.Size = new System.Drawing.Size(623, 275);
            this.partions1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 17F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose a Partion";
            // 
            // Final
            // 
            this.Final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Final.Controls.Add(this.button2);
            this.Final.Controls.Add(this.FinishBtn);
            this.Final.Controls.Add(this.label4);
            this.Final.Controls.Add(this.label5);
            this.Final.Location = new System.Drawing.Point(50, 34);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(712, 397);
            this.Final.TabIndex = 10;
            this.Final.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SafeBox3.Properties.Resources.icons8_Cancel_50px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(769, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.FinishBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.FinishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishBtn.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.FinishBtn.ForeColor = System.Drawing.Color.White;
            this.FinishBtn.Location = new System.Drawing.Point(268, 246);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(177, 54);
            this.FinishBtn.TabIndex = 6;
            this.FinishBtn.Text = "Start";
            this.FinishBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 17F);
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(219, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "All Finished";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 17F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(363, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = ", Let\'s Go !";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SafeBox3.Properties.Resources.icons8_Cancel_50px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(780, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SafeBox3.Properties.Resources.icons8_safe;
            this.pictureBox2.Location = new System.Drawing.Point(4, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Noor Light", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(32, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "SafteyBlock";
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.pictureBox2;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(805, 447);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ChoosePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwBox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intro";
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.ChoosePanel.ResumeLayout(false);
            this.ChoosePanel.PerformLayout();
            this.Final.ResumeLayout(false);
            this.Final.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox PwBox;
        public System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Panel ChoosePanel;
        private Partions partions1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Panel Final;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}