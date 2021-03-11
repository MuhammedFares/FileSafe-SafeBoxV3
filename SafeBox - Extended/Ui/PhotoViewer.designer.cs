namespace SafeBox3.Ui
{
    partial class PhotoViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoViewer));
            this.Holder = new System.Windows.Forms.FlowLayoutPanel();
            this.Header = new System.Windows.Forms.Panel();
            this.Switcher = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.AddFolderBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Holder
            // 
            this.Holder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Holder.AutoScroll = true;
            this.Holder.Location = new System.Drawing.Point(0, 29);
            this.Holder.Margin = new System.Windows.Forms.Padding(4);
            this.Holder.Name = "Holder";
            this.Holder.Size = new System.Drawing.Size(874, 450);
            this.Holder.TabIndex = 0;
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
            this.Header.Size = new System.Drawing.Size(874, 29);
            this.Header.TabIndex = 1;
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
            this.toolTip1.SetToolTip(this.Switcher, "Turn Selection Mode On/Off\r\nClick With RightClick To Select All Photos\r\n");
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
            this.toolTip1.SetToolTip(this.RefreshBtn, "ReFresh");
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
            this.toolTip1.SetToolTip(this.DeleteBtn, "Delete Selected Items");
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
            this.toolTip1.SetToolTip(this.ExportBtn, "Export Items Out Side Safe");
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
            this.toolTip1.SetToolTip(this.AddFolderBtn, "Add Folder Content");
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
            this.toolTip1.SetToolTip(this.AddBtn, "Add Single / Multiple Items ");
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
            this.toolTip1.SetToolTip(this.button1, "Change Preview Mode");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.Holder;
            this.bunifuDragControl2.Vertical = true;
            // 
            // PhotoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Holder);
            this.Name = "PhotoViewer";
            this.Size = new System.Drawing.Size(874, 422);
            this.Load += new System.EventHandler(this.PhotoViewer_Load);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Holder;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button AddFolderBtn;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switcher;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        public System.Windows.Forms.Button RefreshBtn;
    }
}
