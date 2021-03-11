using SafeBox3.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SafeBox3.Tools.BgWorker;

namespace SafeBox3.Sync
{
   public class Network
    {
        public static bool IsConnected()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public static string Speed()
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            //DateTime Variable To Store Download Start Time.
            DateTime dt1 = DateTime.Now;

            //Number Of Bytes Downloaded Are Stored In ‘data’
            byte[] data = wc.DownloadData("http://google.com");

            //DateTime Variable To Store Download End Time.
            DateTime dt2 = DateTime.Now;

            //To Calculate Speed in Kb Divide Value Of data by 1024 And Then by End Time Subtract Start Time To Know Download Per Second.
            return Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2).ToString()+" Kb/s";

        }


        public class Monitor : Job
        {
            public bool exc = false;
            public override void DoJob()
            {
                //try
                //{
                //    MainForm.Frm.dashBoard1.NetStat.Invoke((MethodInvoker)delegate
                //    { MainForm.Frm.dashBoard1.NetStat.Text = Network.IsConnected() ? "Connected " : "Connection Lost "; });
                //    MainForm.Frm.dashBoard1.NetSpd.Invoke((MethodInvoker)delegate { MainForm.Frm.dashBoard1.NetSpd.Text = Network.Speed(); });
                //}
                //catch (Exception)
                //{
                //    if (!MainForm.Frm.data.working)
                //    {
                //        Environment.Exit(0);
                //    }
                //    else
                //    {

                //    }
                //}
            }

            public override string GetName()
            {
                return "UiUpdator";
            }

            public override int GetRepetitionIntervalTime()
            {
                return 2000;
            }
            public override bool isExcuteable()
            {
                return exc;

            }
            public override bool IsRepeatable()
            {
                return true;
            }
        }

    }
}
 