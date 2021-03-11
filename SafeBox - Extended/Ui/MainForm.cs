using SafeBox3.Respority;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Ui
{
    public partial class MainForm : Form
    {
        public static MainForm Frm;
        public Data data;
        public MainForm()
        {
            InitializeComponent();
            Frm = this;
            PwBox.PasswordChar = '*';
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Loading();
            data = new Data();
            Loading();
        }
     
        //872,422
        private void Loading()
        {
            data = new Data();

            videoViewer2.RefreshBtn.PerformClick();
            photoViewer1.RefreshBtn.PerformClick();

            AssignDashBoard();


            panel1.Dock = DockStyle.Fill;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BringToFront();
            FinishBtn.BringToFront();
            PwBox.BringToFront();
            FloatBtns.SendToBack();
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
            }
            else
            {
                PwBox.ForeColor = Color.Red;
                if (i== 3)
                {
                    FinishBtn.Enabled = false;
                }
            }
           
        }

        private async void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.photoViewer1.Dispose();
            await data.OnExit();

            this.Close();
        }
        ///add to clipboard FunC
        private void FloatBtns_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        }

        ///Float Btns : 278, -69
        private void IMGBTN_Click(object sender, EventArgs e)
        {
            HideAll();
            photoViewer1.Show();
            photoViewer1.Location = new Point(-1, 7);
            photoViewer1.Size = new Size(886, 599);
            photoViewer1.SendToBack();
        }
        private void LockBTN_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            panel1.Show();
            PwBox.Show();
            FinishBtn.Show();
            pictureBox1.Show();
        }
        private void FloatBtns_MouseLeave(object sender, EventArgs e)
        {
            
        }
      private void  HideAll()
        {
            photoViewer1.Hide();
            videoViewer2.Hide();
            dashBoard1.Hide();
        }
        private void VIDBTN_Click(object sender, EventArgs e)
        {
            HideAll();
            videoViewer2.Location = new Point(-1, 7);
            videoViewer2.Size = new Size(886, 599);
            videoViewer2.SendToBack();
            videoViewer2.Show();

        }

        private void Notifier_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = !Visible;
        }

        private void DashBtn_Click(object sender, EventArgs e)
        {
            //870, 452

            HideAll();
            dashBoard1.Location = new Point(-1, 7);
            dashBoard1.Size = new Size(886, 599);
            dashBoard1.SendToBack();
            dashBoard1.Show();

        }

       
    }
}

