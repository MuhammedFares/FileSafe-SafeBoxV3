namespace SafeBox3.Ui
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FolderLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IMGSLBL = new System.Windows.Forms.Label();
            this.VIDSLBL = new System.Windows.Forms.Label();
            this.DocLBL = new System.Windows.Forms.Label();
            this.docsizelbl = new System.Windows.Forms.Label();
            this.vidsizelbl = new System.Windows.Forms.Label();
            this.imgsizelbl = new System.Windows.Forms.Label();
            this.DiskSizeSTr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FolderSizeStr = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.partion1 = new SafeBox3.Ui.Partion();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SafeBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Storage Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Box Place :";
            // 
            // FolderLbl
            // 
            this.FolderLbl.AutoSize = true;
            this.FolderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FolderLbl.ForeColor = System.Drawing.Color.White;
            this.FolderLbl.Location = new System.Drawing.Point(88, 198);
            this.FolderLbl.Name = "FolderLbl";
            this.FolderLbl.Size = new System.Drawing.Size(70, 20);
            this.FolderLbl.TabIndex = 6;
            this.FolderLbl.Text = "SafeBox";
            this.FolderLbl.Click += new System.EventHandler(this.FolderLbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(274, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Media ";
            // 
            // IMGSLBL
            // 
            this.IMGSLBL.AutoSize = true;
            this.IMGSLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IMGSLBL.ForeColor = System.Drawing.Color.SpringGreen;
            this.IMGSLBL.Location = new System.Drawing.Point(343, 79);
            this.IMGSLBL.Name = "IMGSLBL";
            this.IMGSLBL.Size = new System.Drawing.Size(18, 20);
            this.IMGSLBL.TabIndex = 9;
            this.IMGSLBL.Text = "0";
            // 
            // VIDSLBL
            // 
            this.VIDSLBL.AutoSize = true;
            this.VIDSLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.VIDSLBL.ForeColor = System.Drawing.Color.SpringGreen;
            this.VIDSLBL.Location = new System.Drawing.Point(343, 133);
            this.VIDSLBL.Name = "VIDSLBL";
            this.VIDSLBL.Size = new System.Drawing.Size(18, 20);
            this.VIDSLBL.TabIndex = 10;
            this.VIDSLBL.Text = "0";
            // 
            // DocLBL
            // 
            this.DocLBL.AutoSize = true;
            this.DocLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DocLBL.ForeColor = System.Drawing.Color.SpringGreen;
            this.DocLBL.Location = new System.Drawing.Point(343, 184);
            this.DocLBL.Name = "DocLBL";
            this.DocLBL.Size = new System.Drawing.Size(18, 20);
            this.DocLBL.TabIndex = 10;
            this.DocLBL.Text = "0";
            // 
            // docsizelbl
            // 
            this.docsizelbl.AutoSize = true;
            this.docsizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.docsizelbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.docsizelbl.Location = new System.Drawing.Point(343, 210);
            this.docsizelbl.Name = "docsizelbl";
            this.docsizelbl.Size = new System.Drawing.Size(18, 20);
            this.docsizelbl.TabIndex = 14;
            this.docsizelbl.Text = "0";
            // 
            // vidsizelbl
            // 
            this.vidsizelbl.AutoSize = true;
            this.vidsizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.vidsizelbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.vidsizelbl.Location = new System.Drawing.Point(343, 158);
            this.vidsizelbl.Name = "vidsizelbl";
            this.vidsizelbl.Size = new System.Drawing.Size(18, 20);
            this.vidsizelbl.TabIndex = 13;
            this.vidsizelbl.Text = "0";
            // 
            // imgsizelbl
            // 
            this.imgsizelbl.AutoSize = true;
            this.imgsizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.imgsizelbl.ForeColor = System.Drawing.Color.SpringGreen;
            this.imgsizelbl.Location = new System.Drawing.Point(343, 104);
            this.imgsizelbl.Name = "imgsizelbl";
            this.imgsizelbl.Size = new System.Drawing.Size(18, 20);
            this.imgsizelbl.TabIndex = 12;
            this.imgsizelbl.Text = "0";
            // 
            // DiskSizeSTr
            // 
            this.DiskSizeSTr.AutoSize = true;
            this.DiskSizeSTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DiskSizeSTr.ForeColor = System.Drawing.Color.White;
            this.DiskSizeSTr.Location = new System.Drawing.Point(14, 135);
            this.DiskSizeSTr.Name = "DiskSizeSTr";
            this.DiskSizeSTr.Size = new System.Drawing.Size(86, 20);
            this.DiskSizeSTr.TabIndex = 16;
            this.DiskSizeSTr.Text = "DiskSpace";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.SpringGreen;
            this.label9.Location = new System.Drawing.Point(3, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Box Size :";
            // 
            // FolderSizeStr
            // 
            this.FolderSizeStr.AutoSize = true;
            this.FolderSizeStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FolderSizeStr.ForeColor = System.Drawing.Color.White;
            this.FolderSizeStr.Location = new System.Drawing.Point(88, 175);
            this.FolderSizeStr.Name = "FolderSizeStr";
            this.FolderSizeStr.Size = new System.Drawing.Size(70, 20);
            this.FolderSizeStr.TabIndex = 18;
            this.FolderSizeStr.Text = "SafeBox";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SafeBox3.Properties.Resources.Notes;
            this.pictureBox4.Location = new System.Drawing.Point(278, 184);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SafeBox3.Properties.Resources.next;
            this.pictureBox3.Location = new System.Drawing.Point(275, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SafeBox3.Properties.Resources.icons8_Compact_Camera_50px;
            this.pictureBox2.Location = new System.Drawing.Point(278, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImage = global::SafeBox3.Properties.Resources.repeat;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Location = new System.Drawing.Point(88, -3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(27, 31);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // partion1
            // 
            this.partion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.partion1.Location = new System.Drawing.Point(-69, 79);
            this.partion1.Margin = new System.Windows.Forms.Padding(10);
            this.partion1.Name = "partion1";
            this.partion1.Root = null;
            this.partion1.Size = new System.Drawing.Size(377, 55);
            this.partion1.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.FolderSizeStr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DiskSizeSTr);
            this.Controls.Add(this.docsizelbl);
            this.Controls.Add(this.vidsizelbl);
            this.Controls.Add(this.imgsizelbl);
            this.Controls.Add(this.DocLBL);
            this.Controls.Add(this.VIDSLBL);
            this.Controls.Add(this.IMGSLBL);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FolderLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partion1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(7, 40);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(750, 514);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public Partion partion1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label FolderLbl;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Label IMGSLBL;
        public System.Windows.Forms.Label VIDSLBL;
        public System.Windows.Forms.Label DocLBL;
        public System.Windows.Forms.Label docsizelbl;
        public System.Windows.Forms.Label vidsizelbl;
        public System.Windows.Forms.Label imgsizelbl;
        public System.Windows.Forms.Label DiskSizeSTr;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label FolderSizeStr;
        public System.Windows.Forms.Button RefreshBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
