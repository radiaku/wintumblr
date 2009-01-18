using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WinTumblr
{
    public partial class frmChat : Form
    {
        private bool bCleared = false;
        private tumblr tum;
        private tumblr.Chat chat = new tumblr.Chat();
        private string orig = "";
        static notify notice;
        //static bool bRemLnCr = true;
        static bool bInsBR = true;

        public frmChat()
        {
            InitializeComponent();
        }

        private void txtDialogue_Enter(object sender, EventArgs e)
        {
            if (!bCleared)
            {
                bCleared = true;
                txtDialogue.Text = "";
                txtDialogue.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.ShowDialog(this);
            LoadAccounts();
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            tipMore.SetToolTip(lnkMore, "\nPost mode is Public\n\nDate of Post is Now\n\nTags: \n\n");
            orig = txtDialogue.Text;
        }

        private void LoadAccounts()
        {
            string acc = "";
            cbAcc.DataSource = Program.data.ds.Accounts;
            foreach (DataRow dr in Program.data.ds.Accounts)
            {
                if ((bool)dr["default"])
                {
                    acc = (string)dr["account"];
                    cbAcc.Text = acc;
                    break;
                }
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //this.Enabled = false;
            foreach (Control et in this.Controls)
            {
                et.Enabled = false;
            }
            tum = new tumblr();
            //tum.TumblrEvent += new tumblr.TumblrEventHandler(TumblrPost);
            //string s;
            DataRowView drv = (DataRowView)cbAcc.SelectedValue;

            string acc = (string)drv[0];
            string email = (string)drv[1];
            string password = "";
            try
            {
                password = Program.data.rox((string)drv[2]);
            }
            catch
            {
                password = "";
            }
            string title = "";
            string conv = "";

            title = txtTitle.Text;
            conv = txtDialogue.Text;
            chat.Email = email;
            chat.Password = password;
            chat.Title = title;
            chat.TheChat = conv;
            if ((conv.Length > 0) && (email.Length > 0) && (password.Length > 0) && (txtDialogue.ForeColor != Color.LightGray))
            {
                tumblr.apostChat ap = new tumblr.apostChat(tum.postChat);

                IAsyncResult result = ap.BeginInvoke(chat, new AsyncCallback(CallbackMethod), ap);
                //s = Convert.ToString(tum.postChat(chat));
            }
            else
            {
                //this.Enabled = true;
                foreach (Control et in this.Controls)
                {
                    et.Enabled = true;
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "Something went wrong setting all of the parameters for posting. Please check the account details and fields.", "Error - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CallbackMethod(IAsyncResult ar)
        {
            // Retrieve the delegate.
            tumblr.apostChat caller = (tumblr.apostChat)ar.AsyncState;
            // Call EndInvoke to retrieve the results.
            Status returnValue = caller.EndInvoke(ar);
            Form.CheckForIllegalCrossThreadCalls = false;
            Posted(returnValue);
        }

        void Posted(Status status)
        {
            //this.Enabled = true;
            foreach (Control et in this.Controls)
            {
                et.Enabled = true;
            }
            this.Cursor = Cursors.Default;
            if ((status.Code != 201) || (!cbClose.Checked))
            {
                notice = new notify();
                notice.showMsg(status);
                notice.ShowDialog(this);
            }
            if ((status.Code == 201) && (cbClose.Checked))
            {
                this.Close();
            }
            //MessageBox.Show(this, Msg, "tumblr Communications - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void TumblrPost(object sender, TumblrEventArgs te)
        {
            this.Enabled = true;
            this.Cursor = Cursors.Default;
            MessageBox.Show(this, te.message, " tumblr Communications - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTitle.Text = "";
            bCleared = false;
            txtDialogue.ForeColor = Color.LightGray;
            txtDialogue.Text = orig;
            txtTitle.Focus();
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Program.data.ds.Settings.Rows.Count > 0)
                {
                    Program.data.ds.Settings.Rows[0].BeginEdit();
                    Program.data.ds.Settings.Rows[0]["closeChat"] = cbClose.Checked;
                    Program.data.ds.Settings.Rows[0].EndEdit();
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
                else
                {
                    DataRow newrow = Program.data.ds.Settings.NewRow();
                    newrow["closeChat"] = cbClose.Checked;
                    Program.data.ds.Settings.Rows.Add(newrow);
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
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

        private void GetSettings()
        {
            if (Program.data.ds.Settings.Rows.Count > 0)
            {
                if (Program.data.ds.Settings.Rows[0]["closeChat"].ToString() != "") cbClose.Checked = (bool)Program.data.ds.Settings.Rows[0]["closeChat"];
                //if (Program.data.ds.Settings.Rows[0]["remlncr"].ToString() != "") bRemLnCr = (bool)Program.data.ds.Settings.Rows[0]["remlncr"];
                if (Program.data.ds.Settings.Rows[0]["addbr"].ToString() != "") { bInsBR = (bool)Program.data.ds.Settings.Rows[0]["addbr"]; } else { bInsBR = true; }
            }
        }

        private void frmChat_Activated(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void lnkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog(this);
            GetSettings();
        }

        private void lnkMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMore frm = new frmMore(chat);
            frm.ShowDialog(this);
            string sTip = "\nPost mode is ";
            if (chat.IsPrivate)
            {
                sTip += "Private\n\nDate of Post is Unaffected\n\nTags: ";
            }
            else
            {
                sTip += "Public\n\nDate of Post is ";
                if (chat.StrDateOfPost.Length > 0)
                {
                    sTip += chat.StrDateOfPost + "\n\nTags: ";
                }
                else
                {
                    sTip += "Now\n\nTags: ";
                }
            }
            sTip += chat.Tags + "\n\n";
            tipMore.SetToolTip(lnkMore, sTip);
        }
    }
}