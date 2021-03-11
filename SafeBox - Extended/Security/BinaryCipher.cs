using SafeBox3.Struct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Security
{
   public class BinaryCipher
    {
        public static UnitList FromFile(string f)
        {
            using (FileStream a = new FileStream(f, FileMode.Open))
            {
                if (a.Length == 0)
                {
                    return new UnitList();
                }
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var readBack = (UnitList)binaryFormatter.Deserialize(a);
                return readBack;
            }
        }
        public static Videos VideosFromFile(string f)
        {
            using (FileStream a = new FileStream(f, FileMode.Open))
            {
                if (a.Length == 0)
                {
                    return new Videos();
                }
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var readBack = (Videos)binaryFormatter.Deserialize(a);
                return readBack;
            }
        }
        public static void ToFile(string Saveto , UnitList content)
        {
            File.Delete(Saveto);
            using (FileStream fs = new FileStream(Saveto, FileMode.OpenOrCreate))
            {
                BinaryWriter br = new BinaryWriter(fs);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(fs, content);
            }
        }
        public static void VideosToFile(string Saveto, Videos content)
        {
            using (FileStream fs = new FileStream(Saveto, FileMode.OpenOrCreate))
            {
                BinaryWriter br = new BinaryWriter(fs);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(fs, content);
            }
        }

    }
}
