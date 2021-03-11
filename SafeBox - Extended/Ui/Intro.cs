using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeBox3.Ui
{
    public partial class Intro : Form
    {
        public static Intro frm;
        public string root, pw;
        public Intro()
        {

            InitializeComponent();
            frm = this;
           

        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }

        private void PwBox_TextChanged(object sender, EventArgs e)
        {
            if (Tools.PasswordChecker.GetPasswordStrength(PwBox.Text) == Tools.PasswordChecker.PasswordStrength.Blank)
            {
                UpdateBar(0);
            }
            else
            {
                UpdateBar((int)Tools.PasswordChecker.GetPasswordStrength(PwBox.Text));
            }
        }
        private void UpdateBar(int Value)
        {
            bunifuProgressBar1.Value = Value;
            if (Value == 0)
            {
                bunifuProgressBar1.ProgressColor = Color.Red;
            }
            else if (Value == 1 || Value == 2)
            {
                bunifuProgressBar1.ProgressColor = Color.Red;
            }
            else if (Value == 3)
            {
                bunifuProgressBar1.ProgressColor = Color.Orange;
            }
            else if (Value == 4 || Value == 5 )
            {
                bunifuProgressBar1.ProgressColor = Color.SeaGreen;
            }
            else
            {
                bunifuProgressBar1.ProgressColor = bunifuProgressBar1.ProgressColor;
            }
            UpdateBtns(Value);
        }

        private void UpdateBtns(int value)
        {
            if (value > 2 && value < 6)
            {
                NextBtn.Visible = true;
                label2.Visible = true;
            }
            else
            {
                NextBtn.Visible = false;
                label2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (PwBox.Text!="")
            {
                ChoosePanel.Visible = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            foreach (Partion item in partions1.Holder.Controls)
            {
                if (item.checkBox1.Checked)
                {
                    root = item.Root;
                    pw = PwBox.Text;
                    ChoosePanel.Visible = false;
                    Final.Visible = true;

                    break;
                }
            }
        }
    }
}
