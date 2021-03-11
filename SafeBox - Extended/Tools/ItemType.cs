using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Tools
{
  public  class ItemType
    {
        private static string[] imgformats = { ".jpg", ".png", ".bmb", ".tiff" };
        private static string[] audioformats = { ".mp3", ".rm", ".wav", ".m4a" };
        private static string[] videoformats = { ".mp4", ".mkv", ".flv" };
        private static string[] otherformats = { ".txt", ".text", ".pdf", ".doc", ".docx" };

        public enum Item
        {
            Audio,
            Video,
            image,
            others,
            Undefined
        }

        public static Item GetType(string i)
        {
            var x = Path.GetExtension(i).ToLower();
            if (imgformats.Contains(x))
            {
                return Item.image;
            }
            else if (audioformats.Contains(x))
            {
                return Item.Audio;
            }
            else if (videoformats.Contains(x))
            {
                return Item.Video;
            }
            else if(otherformats.Contains(x))
            {
                return Item.others;
            }
            else
            {
                return Item.Undefined;
            }
        }
    }
}

