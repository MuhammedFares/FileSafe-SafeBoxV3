using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeBox3.Struct
{  [Serializable]
   public class UnitList
    {
        public List<Unit> Items = new List<Unit>();
        public  Unit AddUnit(string file)
        {
            Unit u = new Unit();
            u.FullPath = file;
            u.Name = Path.GetFileName(file);
            u.FileContent = File.ReadAllBytes(file);
            u.InsertionDate = DateTime.Now;
            Items.Add(u);
            return u;
        }
        public void RemoveUnit(string UnitName)
        {
            try
            {
                var u = Items.Where(c => c.Name == UnitName).FirstOrDefault();
                Items.Remove(u);
                ///Suppose To Update BinaryFile
            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("NOT REMOVED");}
        }
        public void Clear()
        {
            Items.Clear();
        }
        
    }
}
