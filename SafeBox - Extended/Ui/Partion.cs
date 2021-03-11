using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Ui
{
    public partial class Partion : UserControl
    {
        public string Root { get; set; }
        public Partion()
        {
            InitializeComponent();
            this.Margin = new Padding(10, 10, 10, 10);
        }

        public void SetData(DriveInfo dinfo)
        {
            this.DName.Text = dinfo.VolumeLabel;
            this.Dletter.Text = string.Format("({0})", dinfo.Name).Replace("'\\'", "");
            if (dinfo.RootDirectory.Root.ToString() != Path.GetPathRoot(Environment.SystemDirectory))
            {
                this.DImage.BackgroundImage = Properties.Resources.part;
            }
            else
            {
                this.DImage.BackgroundImage = Properties.Resources.WinPart;
            }
            SetBar(dinfo);
            Root = dinfo.RootDirectory.ToString();
            
        }

        private void SetBar(DriveInfo dinfo)
        {
            int used, tot;

            tot = Convert.ToInt16
                (FormatBytes(dinfo.TotalSize));

            used = Convert.ToInt16
                (FormatBytes(dinfo.AvailableFreeSpace));

            DCap.MaximumValue = tot;
            DCap.Value = tot -used;

        }

        private static int FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return (int)dblSByte;
        }
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
            // Add file sizes.
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo fi in fis)
            {
                size += fi.Length;
            }
            // Add subdirectory sizes.
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirSize(di);
            }
            return size;
        }
        public static string FB(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return string.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (this.checkBox1.Checked)
                {

                    Intro.frm.Next2.Visible = true;
                    foreach (Partion item in this.Parent.Controls)
                    {
                        if (item == this)
                        {

                        }
                        else
                        {
                            item.checkBox1.Checked = false;
                            Intro.frm.Next2.Visible = true;
                        }
                    }
                }
                else
                {
                    Intro.frm.Next2.Visible = false;
                }
            }

    
	catch (global::System.Exception)
	{

	}
        }

        private void Partion_Load(object sender, EventArgs e)
        {

        }
    }
}