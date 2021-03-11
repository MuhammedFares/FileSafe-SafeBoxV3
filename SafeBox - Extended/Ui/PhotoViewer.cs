using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SafeBox3.Struct;
using System.IO;
using Bunifu.Framework.UI;
using SafeBox3.Tools;
using System.Threading.Tasks;
using SafeBox3.Ui2;

namespace SafeBox3.Ui
{

    public partial class PhotoViewer : UserControl
    {
        private Size miniSize = new Size(156, 144);
        private Size meduimSize = new Size(260, 419);
        private Size fullSize = new Size(816, 419);
   
        public PhotoViewer()
        {
            InitializeComponent();
            Current = miniSize;
        }
        private Size Current;
        private readonly bool removeafter = true;
        public PicBox Pb(Unit pic)
        {
            try
            {
                PicBox a = new PicBox
                {
                    Size = Current
                };
                var img = view.Frm.data.GenTemp();
                Task.Run(() => { File.WriteAllBytes(img, pic.FileContent); }).Wait();
                a.Controls.AsParallel();
                a.Image = Image.FromFile(img);
                a.pic = pic;
                a.SizeMode = PictureBoxSizeMode.StretchImage;
                a.Size = Current;
                if (removeafter) { File.Delete(pic.FullPath); }
                return a;
            }catch(OutOfMemoryException) { return new PicBox(); }
        }
        public async Task AddPic(Unit pic)
        {
         await   Task.Run(() =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Holder.Controls.AsParallel();
                    Holder.Controls.Add(Pb(pic));

                });
            });
        }


        int chng = 0;
        private void Changemode()
        {
            if (chng > 2)
            {
                chng = 0;
            }            
            if (chng == 0)
            {
                foreach (PicBox a in Holder.Controls)
                {
                    a.Size = miniSize;
                    a.SizeMode = PictureBoxSizeMode.StretchImage;
                    Current = miniSize;
                }
            }
            else if (chng == 1)
            {
                foreach (PicBox a in Holder.Controls)
                {
                    a.Size = meduimSize;
                    a.SizeMode = PictureBoxSizeMode.StretchImage;
                    Current = meduimSize;
                }
            }
            else if (chng == 2)
            {
                foreach (PicBox a in Holder.Controls)
                {
                    a.Size = fullSize;
                    a.SizeMode = PictureBoxSizeMode.Zoom;
                    Current = fullSize;
                }
            }
            chng++;

        }  
        private void Switcher_OnValueChange(object sender, EventArgs e)
        {
            Showselection(((BunifuiOSSwitch)sender).Value);
        }
        private void Showselection(bool value)
        {
            
            foreach (PicBox item in Holder.Controls)
            {
                item.selector.Visible = value;
            }
        }
        private List<PicBox> SelectedPhotos()
        {
            List<PicBox> a = new List<PicBox>();
            foreach (PicBox item in Holder.Controls)
            {
                if (item.selector.Checked)
                {
                    a.Add(item);
                }
            }
            return a;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            List<string> files = new List<string>();
            OpenFileDialog a = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.bmp, *.tiff, *.png) | *.jpg; *.jpeg; *.bmp; *.tiff; *.png",
                Multiselect = true
            };
            if (a.ShowDialog() == DialogResult.OK)
            {
                files = a.FileNames.ToList();
            }

            foreach (var item in files)
            {

                this.Invoke((MethodInvoker)delegate
                {
                    Holder.Controls.Add(Pb(view.Frm.data.Photos.AddUnit(item)));
                });
            }


        }
        private void AddFolderBtn_Click(object sender, EventArgs e)
        {
            var files = new List<string>();
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                files = Directory.GetFiles(f.SelectedPath).ToList();
            }

            foreach (var item in files)
            {
                if (ItemType.GetType(item) == ItemType.Item.image)
                {
                    Holder.Controls.Add(Pb(view.Frm.data.Photos.AddUnit(item)));
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var sel = SelectedPhotos();

            foreach (PicBox item in sel)
            {
                view.Frm.data.Photos.RemoveUnit(item.pic.Name);
                Holder.Controls.Remove(item);
            }
        }
        private async void RefreshBtn_Click(object sender, EventArgs e)
        {
            Holder.Controls.Clear();
            foreach (var item in view.Frm.data.Photos.Items)
            {
              await AddPic(item) ;
            }
        }
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if(SelectedPhotos().Count == 0) { return; }

            FolderBrowserDialog a = new FolderBrowserDialog();
            a.ShowDialog();

            foreach (var item in SelectedPhotos())
            {
                File.WriteAllBytes(Path.Combine(a.SelectedPath, item.pic.Name), item.pic.FileContent);
            }

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Changemode();
        }

        private void PhotoViewer_Load(object sender, EventArgs e)
        {

        }

        private void Switcher_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Holder.Controls.AsParallel();
                foreach (PicBox item in Holder.Controls)
                {
                    item.selector.Checked = true;
                }
            }
        }
    }
}
