using SafeBox3.Respority;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Ui2
{
    public partial class view : Form
    {
        public static view Frm;
        public Data data;

        public view()
        {
            InitializeComponent();
            SetView(panel1);
            PwBox.PasswordChar = '*';
            Frm = this;
            LockAll();
        }

        #region SIDEBTNS
        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBtn_Click(object sender, EventArgs e)
        {
            MoveMark(DashBtn.Location.Y);
            SetView(dashBoard1);

        }

        private void IMGBTN_Click(object sender, EventArgs e)
        {
            MoveMark(iMGBTN.Location.Y);
            SetView(photoViewer1);

        }

        private void MediaBtn_Click(object sender, EventArgs e)
        {
            MoveMark(MediaBtn.Location.Y);
            SetView(videoViewer1);

        }

        private void SyncBtn_Click(object sender, EventArgs e)
        {
            MoveMark(SyncBtn.Location.Y);

        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            MoveMark(SettingBtn.Location.Y);
        }

        void MoveMark(int x)
        {
            Mark.Location = new Point(Mark.Location.X,x);
        }
        #endregion

        void SetView(Panel usr)
        {
            panel1.Hide();
            photoViewer1.Hide();
            videoViewer1.Hide();
            dashBoard1.Hide();

            this.SidePanel.Controls.Remove(usr);
            this.Controls.Add(usr);

            usr.Visible = true;
            usr.Location = new Point(60, 1);
            usr.Size = new Size((this.Size.Width - SidePanel.Size.Width), this.Size.Height);
            usr.BringToFront();
        }      
        void SetView(UserControl usr)
        {
            panel1.Hide();
            photoViewer1.Hide();
            videoViewer1.Hide();
            dashBoard1.Hide();

            this.SidePanel.Controls.Remove(usr);
            this.Controls.Add(usr);

            usr.Visible = true;
            usr.Location = new Point(60, 1);
            usr.Size = new Size((this.Size.Width - SidePanel.Size.Width),this.Size.Height);
            usr.BringToFront();

        }

        private void LockBTN_Click(object sender, EventArgs e)
        {
            LockAll();
            this.Visible = false;

            SetView(panel1);
            PwBox.Show();
            FinishBtn.Show();
            pictureBox1.Show();
        }

        private void Notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !Visible;

            if (Visible)
                notify.Text = "SafeBox is Unlocked";
            else
                notify.Text = "SafeBox is Locked";
        }

        private void Notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //TODO : EXIT
                CloseBtn_Click(CloseBtn, null);
            }
        }

        int i = 0;
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            i++;
            if (data.VerifyPassword(PwBox.Text).Verified)
            {
                panel1.Hide();
                PwBox.Hide();
                FinishBtn.Hide();
                pictureBox1.Hide();
                PwBox.Clear();

                UnlockAll();

                SetView(dashBoard1);
                MoveMark(DashBtn.Location.Y);

               
            }
            else
            {
                PwBox.ForeColor = Color.Red;
                if (i == 3)
                {
                    FinishBtn.Enabled = false;
                
                }
            }

        }

        private void LockAll()
        {
            DashBtn.Enabled = false;
            iMGBTN.Enabled = false;
            MediaBtn.Enabled = false;
            SyncBtn.Enabled = false;
            SettingBtn.Enabled = false;
        }
        private void UnlockAll()
        {
            DashBtn.Enabled = true;
            iMGBTN.Enabled = true;
            MediaBtn.Enabled = true;
            SyncBtn.Enabled = true;
            SettingBtn.Enabled = true;
        }

        private void View_Load(object sender, EventArgs e)
        {
            data = new Data();
            videoViewer1.RefreshBtn.PerformClick();
            photoViewer1.RefreshBtn.PerformClick();
            AssignDashBoard();
        }
        public void AssignDashBoard()
        {
            dashBoard1.partion1.SetData(data.Wst.part);
            dashBoard1.FolderLbl.Text = data.Wst.Folder;

            //Counts
            dashBoard1.IMGSLBL.Text = data.Wst.iMGsCount;
            dashBoard1.VIDSLBL.Text = data.Wst.VidsCount;
            dashBoard1.DocLBL.Text = "0";

            //Sizes
            dashBoard1.imgsizelbl.Text = data.Wst.ImagesSize;
            dashBoard1.vidsizelbl.Text = data.Wst.VideosSize;

            //Folder
            dashBoard1.FolderSizeStr.Text = data.Wst.AllSize;
            dashBoard1.DiskSizeSTr.Text = data.Wst.dirSizeString;

            dashBoard1.partion1.checkBox1.Hide();
        }
        private async void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.photoViewer1.Dispose();
            await data.OnExit();

            this.Close();
        }
    }
}
