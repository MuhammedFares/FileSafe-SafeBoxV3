using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SafeBox3.Security;
using System.IO;
using Bunifu.Framework.UI;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SafeBox3.Ui2;

namespace SafeBox3.Ui
{
    public partial class VideoViewer : UserControl
    {
        readonly Timer a;
        public VideoViewer()
        {             

            InitializeComponent();

            a = new Timer
            {
                Interval = 100,
                Enabled = true
            };
            a.Tick += A_Tick;
            a.Stop();
            player1.PlayStateChange
                += Player1_PlayStateChange;
            player1.Ctlcontrols.stop();
        }

        private void Player1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                a.Start();
                TrackBar.Maximum = (int)player1.currentMedia.duration;

            }
            else if(player1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                a.Stop();
            }
            else if(player1.playState == WMPLib.WMPPlayState.wmppsStopped) { a.Stop(); }
            else if (player1.playState == WMPLib.WMPPlayState.wmppsUndefined) { a.Stop(); }

        }

        public async void FromStream(MemoryStream Src)
        {
            if (Src.Length == 0) { return; }
            var f = view.Frm.data.GenTemp();
            var x = Path.GetExtension(f);
            var y = f.Replace(x, ".mp4");
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Value = 1;

            await Task.Run(() => { File.WriteAllBytes(y, Src.ToArray()); });

            player1.URL = y;
            player1.Ctlcontrols.play();
            progressBar1.Style = ProgressBarStyle.Blocks;
            progressBar1.Value = 0;

            a.Start();

        }
        private void A_Tick(object sender, EventArgs e)
        {
            
                TrackBar.Value = (int)player1.Ctlcontrols.currentPosition;
           
        }
        private void VideoViewer_Load(object sender, EventArgs e)
        {
              this.VolumeBar.Value = this.player1.settings.volume;

        }


        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            if (player1 == null)
            {
                return;
            }
            player1.Ctlcontrols.currentPosition = TrackBar.Value;
        }
        private void TrackBar_SeekDone(object sender, Winamp.Components.WinampTrackBarSeekEventArgs e)
        {
            if (player1 == null)
            {
                return;
            }
            player1.Ctlcontrols.currentPosition = TrackBar.Value;

        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (player1 == null)
            {
                return;
            }
            player1.Ctlcontrols.play();
            a.Start();

        }
        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (player1 == null)
            {
                return;
            }
            player1.Ctlcontrols.pause();
            a.Stop();
        }
        private void VolumeBtn_Click(object sender, EventArgs e)
        {
           
              player1.settings.mute = !player1.settings.mute;

            if (player1.settings.mute)
                VolumeBtn.BackgroundImage = Properties.Resources.audio;
            else
                VolumeBtn.BackgroundImage = Properties.Resources.mute;


        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            player1.settings.volume = VolumeBar.Value;
            if (player1.settings.volume == 0)
            {
                VolumeBtn.Image = Properties.Resources.mute;
            }
            else if (player1.settings.volume != 0)
            {
                VolumeBtn.Image = Properties.Resources.audio;
            }
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog
            {
                Multiselect = true,

                Filter = "Audio & Video Files|*.mp4;*.flv;*.mkv;*.mp3"
            };

            if (a.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Maximum = a.FileNames.Length;
                foreach (var item in a.FileNames)
                {
                    progressBar1.Invoke((MethodInvoker)delegate
                    {
                        progressBar1.Value++;

                    });
                    var vi = await view.Frm.data.Videos.AddVideo(item);

                    Tumb t = new Tumb
                    {
                        
                        vid = vi
                       
                    };
                    t.pictureBox1.Image = vi.Tumbnail;
                    t.lblname.Text = vi.Name;
                    Wall.Controls.Add(t);
                }
            }
            progressBar1.Value = 0;
        }

       private List<Tumb> Selection()
        {

            List<Tumb> a = new List<Tumb>();
            foreach (Tumb item in Wall.Controls)
            {
                if (item.IsSelected.Checked)
                {
                    a.Add(item);
                }
            }
            return a;
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Wall.Controls.Clear();
            foreach (var vi in view.Frm.data.Videos.Items)
            {
                Tumb t = new Tumb
                {
                    vid = vi
                };
                t.pictureBox1.Image = vi.Tumbnail;
                t.lblname.Text = vi.Name;
                Wall.Controls.Add(t);
            }
        }

        private async void AddFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fo = new FolderBrowserDialog();
            if (fo.ShowDialog() == DialogResult.OK)
            {
                var files = Directory.GetFiles(fo.SelectedPath);
                foreach (var item in files)
                {
                    if (Path.GetExtension(item) == ".mp4" ||
                        Path.GetExtension(item) == ".flv" ||
                        Path.GetExtension(item) == ".mkv")
                    {
                        var vi = await view.Frm.data.Videos.AddVideo(item);
                        progressBar1.Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Value++;

                        });
                        Tumb t = new Tumb
                        {
                            vid = vi
                        };
                        t.pictureBox1.Image = vi.Tumbnail;
                        t.lblname.Text = vi.Name;
                        Wall.Controls.Add(t);
                    }

                }
            }
            progressBar1.Value = 0;
        }

        private void Switcher_OnValueChange(object sender, EventArgs e)
        {
            Showselection(((BunifuiOSSwitch)sender).Value);
        }
        private void Showselection(bool value)
        {
            foreach (Ui.Tumb item in Wall.Controls)
            {
                item.IsSelected.Visible = value;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var sel = Selection();
            progressBar1.Maximum = Selection().Count;
            foreach (Tumb item in sel)
            {
                progressBar1.Invoke((MethodInvoker)delegate
                {
                    progressBar1.Value++;

                });
                view.Frm.data.Videos.RemoveVideo(item.vid.Name);
                Wall.Controls.Remove(item);
            }
        }

        private async void ExportBtn_Click(object sender, EventArgs e)
        {
            if (Selection().Count == 0) { return; }

            FolderBrowserDialog a = new FolderBrowserDialog();
            a.ShowDialog();
            progressBar1.Maximum = Selection().Count;
            foreach (var item in Selection())
            {
                try
                {
                    progressBar1.Invoke((MethodInvoker)delegate
                    {
                        progressBar1.Value++;

                    });
                    var dist = Path.Combine(a.SelectedPath, Path.GetFileName(item.vid.Source));
                    var bytes = await FileCipher.StreamFromEncdFile(item.vid.CodedFilePath);
                    File.WriteAllBytes(dist, bytes.ToArray());
                }catch(Exception q) { Debug.WriteLine(q.Message); }
            }
            progressBar1.Value = 0;
        }

        private void Switcher_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Wall.Controls.AsParallel();
                foreach (Tumb item in Wall.Controls)
                {
                    item.IsSelected.Checked = true;
                }
            }
        }
    }
}
