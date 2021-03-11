using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SafeBox3.Ui
{
    public partial class Partions : UserControl
    {
        public bool Done = false;
        public string root;
        public Partions()
        {
            InitializeComponent();
        }

        private void Holder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Partions_Load(object sender, EventArgs e)
        {
            Fetch();
        }

        private void Fetch()
        {
           var drives =  DriveInfo.GetDrives();
            foreach (DriveInfo item in drives)
            {
                if(item.IsReady && item.DriveType != DriveType.CDRom)
                {
                    Partion a = new Partion();
                    a.SetData(item);
                    Holder.Controls.Add(a);
                }
            }
        }
    }
}
