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
   public class Unit
    {
        public string Name;
        public string FullPath;
        public Byte[] FileContent;
        public DateTime InsertionDate;
    }
}
