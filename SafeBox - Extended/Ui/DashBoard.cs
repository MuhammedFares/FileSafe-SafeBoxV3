using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SafeBox3.Sync;
using System.Threading;
using SafeBox3.Tools;
using SafeBox3.Ui2;

namespace SafeBox3.Ui
{
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
            this.Load += DashBoard_Load;

        }



        private void DashBoard_Load(object sender, EventArgs e)
        {
            //Network.Monitor m = new Network.Monitor();
            //m.exc = true;
            // new BgWorker.JobManager().ExecuteAllJobs();
            
        }

      
        private void FolderLbl_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", FolderLbl.Text);
            }
            catch (Exception) { };
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            view.Frm.data.RefreshWst();
            view.Frm.AssignDashBoard();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DropEngine.Run();
        }
    }
}
