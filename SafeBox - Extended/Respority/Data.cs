using SafeBox3.Security;
using SafeBox3.Struct;
using SafeBox3.Ui;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Respority
{
    public class Data
    {
        public UnitList Photos;
        public Videos Videos;
        public UnitList Others;
        private string TempFolder()
        {
            return Path.Combine(respo, "Temp");
        }
        public struct Response
        {
            public bool Verified;
            public string Message;
        }
        private string RespoPath = "";
        private string password, respo;
        internal bool working;
        public WorkingSet Wst;
        public Data()
        {


            ReadData();
            Debug.WriteLine("Data Readed");

            UnLockDir(respo);
            Debug.WriteLine("Files Unlocked");

            CheckFiles();
            Debug.WriteLine("Files Checked");
            LoadMedia();
            Debug.WriteLine("Files Loaded");
            PrepareWorkingSet();
            Debug.WriteLine("WST Loaded");

            ClearTemp();
            Debug.WriteLine("Temp Cleard");
        }

        public static void LockDir(string Dir)
        {
            DirectoryInfo d = new DirectoryInfo(Dir);
            string l = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
            if (d.Name.Contains(l))
            {
                return;
            }
            else
            {
                try
                {
                    d.MoveTo(d.Parent.FullName + "\\" + d.Name + l);
                }
                catch (Exception) { Debug.Write("FOlder Is Open iN Explorer"); }
            }
        }
        public static void UnLockDir(string Dir)
        {
            try
            {
                if (!Directory.Exists(Dir))
                {
                    Dir += ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
                }
                DirectoryInfo d = new DirectoryInfo(Dir);
                string l = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
                d.MoveTo(d.Parent.FullName + "\\" + d.Name.Replace(l, ""));
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error , Locker Normal Error");
                Debug.WriteLine(e.Message);
            }
        }


        private void PrepareWorkingSet()
        {
            Wst = new WorkingSet
            {
                Folder = this.RespoPath
            };
            FileInfo f = new FileInfo(this.ImagesFile);
            string drive = Path.GetPathRoot(f.FullName);
            Wst.part = new DriveInfo(drive);
            Wst.ImagesSize = Partion.FB(new FileInfo(this.ImagesFile).Length);
            Wst.VideosSize = Partion.FB(Partion.DirSize(new DirectoryInfo(this.VideoFolder)) + new FileInfo(this.VideosTumb).Length);
            Wst.AllSize = Partion.FB(Partion.DirSize(new DirectoryInfo(this.respo)));

            Wst.iMGsCount = this.Photos.Items.Count.ToString();
            Wst.VidsCount = this.Videos.Items.Count.ToString();
            Wst.OthersCount = "0";


            string tot;

            tot =
                (Partion.FB(Wst.part.TotalSize));

            _ =
                (Partion.FB(Wst.part.AvailableFreeSpace));



            Wst.dirSizeString = Partion.FB(Wst.part.TotalSize - Wst.part.AvailableFreeSpace) + " - " + tot;
        }
        public void RefreshWst()
        {
            Wst = new WorkingSet();
            PrepareWorkingSet();
        }
        public class WorkingSet
        {
            public string Folder;
            public DriveInfo part;
            public string ImagesSize, VideosSize, OthersSize, AllSize;
            public string iMGsCount, VidsCount, OthersCount, dirSizeString;

        }
        private void LoadMedia()
        {

            Photos = BinaryCipher.FromFile(ImagesFile);
            Videos = BinaryCipher.VideosFromFile(VideosTumb);


        }
        private void CheckFiles()
        {
            if (!Directory.Exists(respo))
            {
                Directory.CreateDirectory(respo);
            }
            if (!File.Exists(ImagesFile))
            {
                using (File.Create(ImagesFile)) { };

            }
            if (!File.Exists(VideosTumb))
            {
                using (File.Create(VideosTumb)) { };

            }
            if (!Directory.Exists(VideoFolder))
            {
                Directory.CreateDirectory(VideoFolder);

            }

            if (!Directory.Exists(TempFolder()))
            {
                Directory.CreateDirectory(TempFolder());

            }
            if (!Directory.Exists(OthersFolder))
            {
                Directory.CreateDirectory(VideoFolder);
            }
        }

        #region FilesPath
        private string ImagesFile
        {
            get
            {
                return Path.Combine(RespoPath, "Images.SafeBox");
            }
        }
        private string VideoFolder
        {
            get
            {
                return Path.Combine(RespoPath, "Videos");
            }
        }
        private string OthersFolder
        {
            get
            {
                return Path.Combine(RespoPath, "Others");
            }
        }
        private string VideosTumb
        {
            get
            {
                return Path.Combine(RespoPath, "SafeBox-Tumbnails");
            }
        }
        #endregion
        #region Helpers
        private void Write(string pass, string respo, int change = 0)
        {
            FileStream fs = new FileStream(KeyFile(), FileMode.OpenOrCreate);

            fs.Close();
            if (change == 1)
            {
                password = pass; RespoPath = respo;
            }
            respo = Path.Combine(respo, "SafeBox");
            string bas = pass + "#" + respo + "$";
            try
            {
                File.WriteAllText(KeyFile(), StringCipher.GenerateName(bas));
                Debug.WriteLine("### MetaFile Written Successfully ##");
            }
            catch (Exception q)
            { Debug.WriteLine(q.Message + "###error in writing in mf"); }

        }
        private string KeyFile()
        {
            return Path.Combine(Environment
             .GetFolderPath(Environment.SpecialFolder.ApplicationData)
             .ToString(), "MetaFile.SafeBox");
        }
        private void ReadData()
        {
            if (!File.Exists(KeyFile()))
            {
                using (File.Create(KeyFile())) { }
                password = ""; respo = "";
                //Supposed To Run Intro Form Here 
                try { Application.OpenForms["Splash"].Invoke(new MethodInvoker(delegate { Splash.frm.Hide(); })); }
                catch (Exception)
                {

                }
                Debug.WriteLine("### KeyFile Found But Empty , Start Intro ###");
                string all = new Former().OPenIntro();
                Write(all.Split('%')[0], all.Split('%')[1]);
                Environment.Exit(0);
                return;
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream(KeyFile(), FileMode.OpenOrCreate);
                    fs.Close();
                    Debug.WriteLine(KeyFile());

                    var text = File.ReadAllText(KeyFile());
                    text = StringCipher.ReGenerateName(text);
                    Debug.WriteLine(text);

                    if (text != "")
                    {
                        var p = text.Remove(text.IndexOf("#"), text.Length - text.IndexOf("#"));
                        var pp = text.Remove(0, text.IndexOf("#"));
                        var px = pp.Replace("$", "").Replace("#", "");

                        password = p;
                        respo = px;
                        RespoPath = px;

                        //TODO ; REMOVE THIS
#if Debugging
                        if (password != "" && RespoPath != "")
                            Debug.WriteLine
                                ("#### " + password + "  Is Readed [" + respo + "] ###");
                        else
                            Debug.WriteLine
                            ("#### MetaFile Is Readed [empty] ###");
#endif
                    }
                    else { password = ""; RespoPath = ""; }
                }
                catch (Exception)
                {
                    File.Delete(KeyFile());
                    ReadData();
                }
            }
        }
#endregion

        public void ReloadFiles()
        {
            LoadMedia();
        }
        public void ReWriteALL()
        {
            //Delete all
            File.Delete(ImagesFile);
            //Write All
            BinaryCipher.ToFile(ImagesFile, Photos);


        }
        public void Dispose()
        {
            Photos = new UnitList();
            Videos = new Videos();
            Others = new UnitList();
            RespoPath = "";
            password = "";
            respo = "";
        }
        public string GenTemp()
        {
            var name = Path.GetRandomFileName();
            var f = Path.Combine(TempFolder(), name);
            using (File.Create(f)) { };
            return f;

        }
        public string VideosFolder()
        {

            return VideoFolder;
        }
        public void ClearTemp()
        {
            foreach (var item in Directory.GetFiles(TempFolder()))
            {
                try { File.Delete(item); }
                catch (Exception e) { Debug.WriteLine("## Can't Delete , " + e.Message); }
            }
        }

        private async Task Onexit()
        {
            if (working)
            {
                while (working)
                {
                    Thread.Sleep(2);
                }
            }
            try
            {
                await Task.Run(() =>
                {
                    ClearTemp();
                    BinaryCipher.ToFile(ImagesFile, Photos);
                    BinaryCipher.VideosToFile(VideosTumb, Videos);
                    LockDir(respo);


                });
            }
            catch (Exception) { }
        }
        public async Task OnExit()
        {
            await Onexit();
        }
        public Response VerifyPassword(string pw)
        {
            Response r = new Response();
            if (pw == password)
            {
                r.Verified = true;
                return r;
            }
            else
            {
                r.Verified = false;
                r.Message = "Incorect Password";
                return r;
            }
        }
        public static void FreshStart(string pass, string path)
        {
            var KeyFile = Path.Combine(Environment
             .GetFolderPath(Environment.SpecialFolder.ApplicationData)
             .ToString(), "MetaFile.SafeBox");
            FileStream fs = new FileStream(KeyFile, FileMode.OpenOrCreate);
            fs.Close();
            string bas = pass + "#" + path + "$";

            var text = StringCipher.GenerateName(bas);
            File.WriteAllText(KeyFile, text);
            Debug.WriteLine("All Done , Restart Application");
        }




    }
}
