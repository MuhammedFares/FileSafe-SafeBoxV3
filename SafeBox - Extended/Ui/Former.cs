using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Ui
{
    public class Former
    {
        public enum ViewMode
        {
            Small,
            Meduim,
            Large
        }
        public string OPenIntro()
        {
            string RES = "";
            //Save the DialogResult as res
            DialogResult res = IntroB.ShowDialog();
            //Check InputBox result
            if (res == System.Windows.Forms.DialogResult.OK || res == System.Windows.Forms.DialogResult.Yes)
                RES = IntroB.ResultValue; //Get returned value
            return RES;
        }
        public static class IntroB
        {
            private static Intro frm = new Intro();
            public static string ResultValue;
            private static DialogResult DialogRes;



            public static DialogResult ShowDialog()
            {

                frm.FinishBtn.Click += SubmitBtn_Click;
                frm.ShowDialog();
                //Return text value
                ResultValue = frm.PwBox.Text + "%" + frm.root;
                DialogRes = DialogResult.OK;
                return DialogRes;
            }

            private static void SubmitBtn_Click(object sender, EventArgs e)
            {
                if (frm.PwBox.Text != "")
                {
                    frm.DialogResult = DialogResult.OK;
                    ResultValue = frm.PwBox.Text + "%" + frm.root;
                    frm.Close();
                }

            }
        }
    }
}