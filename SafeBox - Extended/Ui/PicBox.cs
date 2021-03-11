using SafeBox3.Struct;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Ui
{
  public  class PicBox :PictureBox
    {

        public Unit pic { get; set; }
        public bool IsSelected { get; set; }
        public CheckBox selector;
        
        public PicBox()
        {
            selector = new CheckBox();
            selector.Text = "";
            selector.Parent = this;
            selector.Location = this.Location;
            selector.BackColor = Color.Transparent;
            selector.Checked = false;
            selector.Visible = false;
            MouseClick += PicBox_MouseClick;
        }

        private void PicBox_MouseClick(object sender, MouseEventArgs e)
        {
            selector.Checked = !selector.Checked;
        }
    }
}
