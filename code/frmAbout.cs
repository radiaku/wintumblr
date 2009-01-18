using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinTumblr
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWinTumblr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(btnWinTumblr.Text);
                info.UseShellExecute = true;
                info.Verb = "open";
                System.Diagnostics.Process.Start(info);
            }
            catch
            {
                MessageBox.Show(this, "WinTumblr could not start the web browser", "Error - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNdn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(btnNdn.Tag.ToString());
                info.UseShellExecute = true;
                info.Verb = "open";
                System.Diagnostics.Process.Start(info);
            }
            catch
            {
                MessageBox.Show(this, "WinTumblr could not start the web browser", "Error - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel lnk = (LinkLabel)sender;
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(lnk.Tag.ToString());
                info.UseShellExecute = true;
                info.Verb = "open";
                System.Diagnostics.Process.Start(info);
            }
            catch
            {
                MessageBox.Show(this, "WinTumblr could not start the web browser", "Error - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}