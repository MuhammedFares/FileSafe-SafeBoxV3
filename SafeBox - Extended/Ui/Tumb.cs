using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafeBox3.Struct;
using SafeBox3.Ui;
using SafeBox3.Security;

namespace SafeBox3.Ui
{
    public partial class Tumb : UserControl
    {
        public Video vid;
        public Tumb()
        {
            InitializeComponent();
          
        }

        private void lblname_Click(object sender, EventArgs e)
        {
           
        }

        private void lblname_TextChanged(object sender, EventArgs e)
        {
            if (lblname.Text.Length > 22)
            {
                var text = lblname.Text.Remove(20, lblname.Text.Length - 20 - 1);
                lblname.Text = text + "..";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IsSelected.Checked = !IsSelected.Checked;
        }

        private  async void PlayBtn_Click(object sender, EventArgs e)
        {
            MainForm.Frm.videoViewer2.FromStream(await FileCipher.StreamFromEncdFile((this).vid.CodedFilePath));

        }

        private void IsSelected_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
