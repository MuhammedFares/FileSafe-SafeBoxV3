using SafeBox3.Respority;
using SafeBox3.Tools;
using SafeBox3.Ui;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SafeBox3.Struct
{
    [Serializable]
    public class Videos
    {
        public List<Video> Items = new List<Video>();
        public async Task<Video>  AddVideo(string file)
        {
            Video u = new Video
            {
                Source = file,
                Name = Path.GetFileName(file)
                
            };
            u.Tumbnail = TumbnailExtractor.GetVideoThumbnail(u.Source);
            u.B64Tumbnail = TumbnailExtractor.ImageToBase64(u.Tumbnail);

            FileHandler fh = new FileHandler(file, Path.Combine(MainForm.Frm.data.VideosFolder(), u.Name),true);
            await fh.CopyAsync();
            Thread a = new Thread(new ThreadStart(fh.Copy));a.Start();
            u.CodedFilePath = (fh.DestFilePath);
            u.InsertionDate = new FileInfo(u.CodedFilePath).CreationTime;
            Items.Add(u);
            return u;
           
        }
        public void RemoveVideo(string VideoName)
        {
            try
            {
                var u = Items.Where(c => c.Name == VideoName).FirstOrDefault();
                Items.Remove(u);
                File.Delete(u.CodedFilePath);
                ///Suppose To Update BinaryFile
            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("NOT REMOVED"); }
        }
        public void Clear()
        {
            Items.Clear();
        }
    }

}
