namespace SafeBox3.Ui
{
    partial class Partions
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
            this.Holder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Holder
            // 
            this.Holder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Holder.Location = new System.Drawing.Point(0, 0);
            this.Holder.Margin = new System.Windows.Forms.Padding(10);
            this.Holder.Name = "Holder";
            this.Holder.Size = new System.Drawing.Size(637, 320);
            this.Holder.TabIndex = 0;
            this.Holder.Paint += new System.Windows.Forms.PaintEventHandler(this.Holder_Paint);
            // 
            // Partions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.Holder);
            this.Name = "Partions";
            this.Size = new System.Drawing.Size(637, 320);
            this.Load += new System.EventHandler(this.Partions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel Holder;
    }
}
