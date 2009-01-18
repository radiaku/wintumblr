using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WinTumblr
{
    public partial class notify : Form
    {
        public notify()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void showMsg(Status status)
        {
            txtMsg.Text = status.Msg;
            //txtMsg.Text += "\nStatus Code: " + status.Code.ToString();
            if ((status.Code == 201) || (status.Code == 200))
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }
        }

        public void showAuthenticate(string Msg)
        {
            txtMsg.Text = Msg;
            if (Msg.ToLower() != "ok")
            {
                txtMsg.Text = "Email and/or Password are incorrect";
                SystemSounds.Asterisk.Play();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }

        public void showVimeo(string Msg)
        {
            txtMsg.Text = Msg;
            //if (Msg.ToLower() != "ok")
            //{
            //    txtMsg.Text = "Not logged into Vimeo.";
            //}
            if (Msg.ToLower() == "ok")
            {
                SystemSounds.Beep.Play();
            }
            else
            {
                SystemSounds.Asterisk.Play();
            }
        }

        public void showAudio(string Msg)
        {
            txtMsg.Text = Msg;
            if (Msg.ToLower() != "ok")
            {
                txtMsg.Text = "This account has exceeded the daily audio upload quota";
                SystemSounds.Asterisk.Play();
            }
            else
            {
                SystemSounds.Beep.Play();
            }
        }


    }
}