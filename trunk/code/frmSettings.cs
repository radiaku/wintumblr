using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinTumblr
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            bool bText = false;
            bool bChat = false;
            bool bLink = false;
            bool bPhoto = false;
            bool bQuote = false;
            bool bVideo = false;
            bool bUseProxy = false;
            string sProxyUsername = "";
            string sProxyPassword = "";
            string sProxyUrl = "http://";
            string sProxyPort = "";
            string sProxyDomain = "";
            cbBR.Checked = true;
            try
            {
                // Get all of the settings from the first row in "settings"
                if (Program.data.ds.Settings.Rows.Count > 0)
                {

                    //cbMin.Checked = (bool)Program.data.ds.Settings.Rows[0]["Minimize"];
                    //if (Program.data.ds.Settings.Rows[0]["remlncr"].ToString() != "") cbchar.Checked = (bool)Program.data.ds.Settings.Rows[0]["remlncr"];
                    if (Program.data.ds.Settings.Rows[0]["addbr"].ToString() != "") cbBR.Checked = (bool)Program.data.ds.Settings.Rows[0]["addbr"];
                    if (Program.data.ds.Settings.Rows[0]["closeText"].ToString() != "") bText = (bool)Program.data.ds.Settings.Rows[0]["closeText"];
                    if (Program.data.ds.Settings.Rows[0]["closeChat"].ToString() != "") bChat = (bool)Program.data.ds.Settings.Rows[0]["closeChat"];
                    if (Program.data.ds.Settings.Rows[0]["closeLink"].ToString() != "") bLink = (bool)Program.data.ds.Settings.Rows[0]["closeLink"];
                    if (Program.data.ds.Settings.Rows[0]["closePhoto"].ToString() != "") bPhoto = (bool)Program.data.ds.Settings.Rows[0]["closePhoto"];
                    if (Program.data.ds.Settings.Rows[0]["closeQuote"].ToString() != "") bQuote = (bool)Program.data.ds.Settings.Rows[0]["closeQuote"];
                    if (Program.data.ds.Settings.Rows[0]["closeVideo"].ToString() != "") bVideo = (bool)Program.data.ds.Settings.Rows[0]["closeVideo"];
                    cbClose.Checked = bText & bChat & bLink & bPhoto & bQuote & bVideo;
                    if (!cbClose.Checked)
                    {
                        if (bText || bChat || bLink || bPhoto || bQuote || bVideo)
                        {
                            cbClose.CheckState = CheckState.Indeterminate;
                        }
                    }
                    if (Program.data.ds.Settings.Rows[0]["useProxy"].ToString() != "") bUseProxy = (bool)Program.data.ds.Settings.Rows[0]["useProxy"];
                    cbProxy.Checked = bUseProxy;
                    sProxyUsername = Program.data.ds.Settings.Rows[0]["proxyUsername"].ToString();
                    sProxyPassword = Program.data.ds.Settings.Rows[0]["proxyPassword"].ToString();
                    sProxyUrl = Program.data.ds.Settings.Rows[0]["proxyUrl"].ToString();
                    sProxyPort = Program.data.ds.Settings.Rows[0]["proxyPort"].ToString();
                    sProxyDomain = Program.data.ds.Settings.Rows[0]["proxyDomain"].ToString();
                    txtProxyUser.Text = sProxyUsername;
                    txtProxyPassword.Text = sProxyPassword;
                    txtProxyUrl.Text = sProxyUrl;
                    txtProxyPort.Text = sProxyPort;
                    txtProxyDomain.Text = sProxyDomain;
                }
                pnlProxy.Enabled = bUseProxy;
            }
            catch
            {
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbReveal_CheckedChanged(object sender, EventArgs e)
        {
            txtProxyPassword.UseSystemPasswordChar = !(cbReveal.Checked);
        }

        private void cbProxy_CheckedChanged(object sender, EventArgs e)
        {
            pnlProxy.Enabled = cbProxy.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtProxyUrl.Text.StartsWith("http", true, null))
                {
                    txtProxyUrl.Text = "http://" + txtProxyUrl.Text;
                }
                if (Program.data.ds.Settings.Rows.Count > 0)
                {
                    // Get all of the settings from the first row in "settings"
                    Program.data.ds.Settings.Rows[0].BeginEdit();
                    //Program.data.ds.Settings.Rows[0]["Minimize"] = cbMin.Checked;
                    //Program.data.ds.Settings.Rows[0]["remlncr"] = cbchar.Checked;
                    Program.data.ds.Settings.Rows[0]["addbr"] = cbBR.Checked;

                    if (cbClose.Checked && cbClose.CheckState == CheckState.Checked)
                    {
                        Program.data.ds.Settings.Rows[0]["closeText"] = true;
                        Program.data.ds.Settings.Rows[0]["closeChat"] = true;
                        Program.data.ds.Settings.Rows[0]["closeLink"] = true;
                        Program.data.ds.Settings.Rows[0]["closePhoto"] = true;
                        Program.data.ds.Settings.Rows[0]["closeQuote"] = true;
                        Program.data.ds.Settings.Rows[0]["closeVideo"] = true;
                    }
                    else if (!cbClose.Checked && cbClose.CheckState == CheckState.Unchecked)
                    {
                        Program.data.ds.Settings.Rows[0]["closeText"] = false;
                        Program.data.ds.Settings.Rows[0]["closeChat"] = false;
                        Program.data.ds.Settings.Rows[0]["closeLink"] = false;
                        Program.data.ds.Settings.Rows[0]["closePhoto"] = false;
                        Program.data.ds.Settings.Rows[0]["closeQuote"] = false;
                        Program.data.ds.Settings.Rows[0]["closeVideo"] = false;
                    }


                    Program.data.ds.Settings.Rows[0]["useProxy"] = cbProxy.Checked;
                    Program.data.ds.Settings.Rows[0]["proxyUsername"] = txtProxyUser.Text;
                    Program.data.ds.Settings.Rows[0]["proxyPassword"] = txtProxyPassword.Text;
                    Program.data.ds.Settings.Rows[0]["proxyUrl"] = txtProxyUrl.Text;
                    Program.data.ds.Settings.Rows[0]["proxyPort"] = txtProxyPort.Text;
                    Program.data.ds.Settings.Rows[0]["proxyDomain"] = txtProxyDomain.Text;
                    Program.data.ds.Settings.Rows[0].EndEdit();
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
                else
                {
                    DataRow newrow = Program.data.ds.Settings.NewRow();
                    //newrow["Minimize"] = cbMin.Checked;
                    //newrow["remlncr"] = cbchar.Checked;
                    newrow["addbr"] = cbBR.Checked;
                    newrow["closeText"] = true;
                    newrow["closeChat"] = true;
                    newrow["closeLink"] = true;
                    newrow["closePhoto"] = true;
                    newrow["closeQuote"] = true;
                    newrow["closeVideo"] = true;
                    newrow["useProxy"] = cbProxy.Checked;
                    newrow["proxyUsername"] = txtProxyUser.Text;
                    newrow["proxyPassword"] = txtProxyPassword.Text;
                    newrow["proxyUrl"] = txtProxyUrl.Text;
                    newrow["proxyPort"] = txtProxyPort.Text;
                    newrow["proxyDomain"] = txtProxyDomain.Text;
                    Program.data.ds.Settings.Rows.Add(newrow);
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
                tumblr.Proxy.UseProxy = (bool)Program.data.ds.Settings.Rows[0]["useProxy"];
                tumblr.Proxy.UserName = Program.data.ds.Settings.Rows[0]["proxyUsername"].ToString();
                tumblr.Proxy.Password = Program.data.ds.Settings.Rows[0]["proxyPassword"].ToString();
                tumblr.Proxy.ServerURL = Program.data.ds.Settings.Rows[0]["proxyUrl"].ToString();
                tumblr.Proxy.ServerPort = Program.data.ds.Settings.Rows[0]["proxyPort"].ToString();
                tumblr.Proxy.Domain = Program.data.ds.Settings.Rows[0]["proxyDomain"].ToString();

                try
                {
                    if (Program.data.datapath != "")
                    {
                        Program.data.ds.WriteXml(Program.data.datapath);
                    }
                }
                catch
                {
                    // Do nothing if it failed. Could do something but why?
                }
            }
            catch
            {
            }

        }
    }
}