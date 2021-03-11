using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Tools
{
    class TumbnailExtractor
    {
        public static Bitmap GetVideoThumbnail(string video)
        {
            try
            {
                var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
                Stream output = new MemoryStream();
                ffMpeg.GetVideoThumbnail(video, output);

                return LoadImageFromStream(output);
            } catch (Exception)
            { return Properties.Resources.icons8_safe; }
        }
        public static Bitmap TumbnailFromB64(string b64Tumbnail)
        {
            byte[] imageBytes = Convert.FromBase64String(b64Tumbnail);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = System.Drawing.Image.FromStream(ms, true);
            return (Bitmap)image;
        }
        public static string ImageToBase64(Image img)
        {
          
                using (MemoryStream m = new MemoryStream())
                {
                    img.Save(m, img.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string  base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            
        }
        public static Bitmap LoadImageFromStream(Stream stream)
        {
            try
            {
                var ms = stream;
                return (Bitmap)Image.FromStream(ms);
            }
            catch(Exception) { return (Bitmap)Properties.Resources.icons8_safe; }
            }
    }
}
