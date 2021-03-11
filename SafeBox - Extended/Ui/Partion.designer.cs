namespace SafeBox3.Ui
{
    partial class Partion
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
            this.DImage = new System.Windows.Forms.PictureBox();
            this.DName = new System.Windows.Forms.Label();
            this.Dletter = new System.Windows.Forms.Label();
            this.DCap = new Bunifu.Framework.UI.BunifuProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DImage)).BeginInit();
            this.SuspendLayout();
            // 
            // DImage
            // 
            this.DImage.BackgroundImage = global::SafeBox3.Properties.Resources.part;
            this.DImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DImage.Location = new System.Drawing.Point(3, 2);
            this.DImage.Name = "DImage";
            this.DImage.Size = new System.Drawing.Size(65, 50);
            this.DImage.TabIndex = 0;
            this.DImage.TabStop = false;
            // 
            // DName
            // 
            this.DName.AutoSize = true;
            this.DName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DName.ForeColor = System.Drawing.Color.White;
            this.DName.Location = new System.Drawing.Point(112, 8);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(46, 18);
            this.DName.TabIndex = 1;
            this.DName.Text = "Moka";
            // 
            // Dletter
            // 
            this.Dletter.AutoSize = true;
            this.Dletter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dletter.ForeColor = System.Drawing.Color.White;
            this.Dletter.Location = new System.Drawing.Point(76, 7);
            this.Dletter.Name = "Dletter";
            this.Dletter.Size = new System.Drawing.Size(37, 18);
            this.Dletter.TabIndex = 2;
            this.Dletter.Text = "(C:) ";
            // 
            // DCap
            // 
            this.DCap.BackColor = System.Drawing.Color.Silver;
            this.DCap.BorderRadius = 5;
            this.DCap.Location = new System.Drawing.Point(75, 35);
            this.DCap.MaximumValue = 100;
            this.DCap.Name = "DCap";
            this.DCap.ProgressColor = System.Drawing.Color.Teal;
            this.DCap.Size = new System.Drawing.Size(198, 16);
            this.DCap.TabIndex = 3;
            this.DCap.Value = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Partion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DCap);
            this.Controls.Add(this.Dletter);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.DImage);
            this.Name = "Partion";
            this.Size = new System.Drawing.Size(288, 55);
            this.Load += new System.EventHandler(this.Partion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox DImage;
        public System.Windows.Forms.Label DName;
        public System.Windows.Forms.Label Dletter;
        public Bunifu.Framework.UI.BunifuProgressBar DCap;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}
