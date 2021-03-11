using SafeBox3.Respority;
using SafeBox3.Tools;
using SafeBox3.Ui;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Struct
{
    [Serializable]

    public class Video 
    {
        public string B64Tumbnail;
        public Bitmap Tumbnail;  
        public string Name;
        public string Source;
        public string CodedFilePath = "";
        public DateTime InsertionDate;
              
    }
}
