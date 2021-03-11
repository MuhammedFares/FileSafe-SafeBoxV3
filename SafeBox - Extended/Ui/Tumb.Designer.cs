namespace SafeBox3.Ui
{
    partial class Tumb
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
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.IsSelected = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblname.Location = new System.Drawing.Point(6, 132);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(46, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Moka";
            this.lblname.TextChanged += new System.EventHandler(this.lblname_TextChanged);
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Image = global::SafeBox3.Properties.Resources.play;
            this.PlayBtn.ImageActive = null;
            this.PlayBtn.InitialImage = null;
            this.PlayBtn.Location = new System.Drawing.Point(3, 3);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(24, 26);
            this.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayBtn.TabIndex = 138;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Zoom = 9;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // IsSelected
            // 
            this.IsSelected.AutoSize = true;
            this.IsSelected.Location = new System.Drawing.Point(6, 42);
            this.IsSelected.Name = "IsSelected";
            this.IsSelected.Size = new System.Drawing.Size(15, 14);
            this.IsSelected.TabIndex = 139;
            this.IsSelected.UseVisualStyleBackColor = true;
            this.IsSelected.Visible = false;
            this.IsSelected.CheckedChanged += new System.EventHandler(this.IsSelected_CheckedChanged);
            // 
            // Tumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.IsSelected);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Tumb";
            this.Size = new System.Drawing.Size(288, 152);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblname;
        public Bunifu.Framework.UI.BunifuImageButton PlayBtn;
        public System.Windows.Forms.CheckBox IsSelected;
    }
}
