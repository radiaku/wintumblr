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
    public partial class frmLink : Form
    {
        private tumblr tum;
        private tumblr.Link link = new tumblr.Link();
        static notify notice;
        //static bool bRemLnCr = true;
        static bool bInsBR = true;

        public frmLink()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.ShowDialog(this);
            LoadAccounts();
        }

        private void frmLink_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            tipMore.SetToolTip(lnkMore, "\nDate of Post is Now\n\nPost mode is Public\n\nTags: \n\n");
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

            string acc = (string)drv["account"];
            string email = (string)drv["email"];
            string group = (drv["group"] != DBNull.Value ? (string)drv["group"] : "");
            string password = "";
            try
            {
                password = Program.data.rox((string)drv["password"]);
            }
            catch
            {
                password = "";
            }
            string Nam = "";
            string Url = "";
            string Desc = "";

            Nam = txtName.Text;
            Url = txtURL.Text;
            Desc = txtDescription.Text.Replace("\r\n", " ");
            link.Email = email;
            link.Password = password;
            link.Group = group;
            link.Name = Nam;
            link.Url = Url;
            link.Description = Desc;
            if ((Url.Length > 0) && (email.Length > 0) && (password.Length > 0))
            {
                tumblr.apostLink ap = new tumblr.apostLink(tum.postLink);

                IAsyncResult result = ap.BeginInvoke(link, new AsyncCallback(CallbackMethod), ap);
                //s = Convert.ToString(tum.postLink(link));
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
            tumblr.apostLink caller = (tumblr.apostLink)ar.AsyncState;
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
            txtURL.Text = txtName.Text = txtDescription.Text = "";
            txtName.Focus();
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (!e.Control)
            {
                if (e.KeyCode == Keys.Return)
                {
                    if (bInsBR)
                    {
                        int sel = t.SelectionStart;
                        t.Text = t.Text.Insert(sel - 2, "<br />");
                        t.SelectionStart = sel + 6;
                        t.ScrollToCaret();
                    }
                }
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            int ist = txtDescription.SelectionStart;
            txtDescription.Text = txtDescription.Text.Insert(ist, "<img src=\"http://url\" />");
            txtDescription.ScrollToCaret();
            txtDescription.SelectionStart = ist + 17;
            txtDescription.SelectionLength = 3;
            txtDescription.Focus();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            int ist = txtDescription.SelectionStart;
            string tx = txtDescription.SelectedText;
            txtDescription.Text = txtDescription.Text.Insert(ist, "<a href=\"http://url\">");
            txtDescription.Text = txtDescription.Text.Insert(ist + 21 + tx.Length, "</a>");
            txtDescription.ScrollToCaret();
            txtDescription.SelectionStart = ist + 16;
            txtDescription.SelectionLength = 3;
            txtDescription.Focus();
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Program.data.ds.Settings.Rows.Count > 0)
                {
                    Program.data.ds.Settings.Rows[0].BeginEdit();
                    Program.data.ds.Settings.Rows[0]["closeLink"] = cbClose.Checked;
                    Program.data.ds.Settings.Rows[0].EndEdit();
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
                else
                {
                    DataRow newrow = Program.data.ds.Settings.NewRow();
                    newrow["closeLink"] = cbClose.Checked;
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
                if (Program.data.ds.Settings.Rows[0]["closeLink"].ToString() != "") cbClose.Checked = (bool)Program.data.ds.Settings.Rows[0]["closeLink"];
                //if (Program.data.ds.Settings.Rows[0]["remlncr"].ToString() != "") bRemLnCr = (bool)Program.data.ds.Settings.Rows[0]["remlncr"];
                if (Program.data.ds.Settings.Rows[0]["addbr"].ToString() != "") { bInsBR = (bool)Program.data.ds.Settings.Rows[0]["addbr"]; } else { bInsBR = true; }
            }
        }

        private void frmLink_Activated(object sender, EventArgs e)
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
            frmMore frm = new frmMore(link);
            frm.ShowDialog(this);
            string sTip = "\nPost mode is ";
            if (link.IsPrivate)
            {
                sTip += "Private\n\nDate of Post is Unaffected\n\nTags: ";
            }
            else
            {
                sTip += "Public\n\nDate of Post is ";
                if (link.StrDateOfPost.Length > 0)
                {
                    sTip += link.StrDateOfPost + "\n\nTags: ";
                }
                else
                {
                    sTip += "Now\n\nTags: ";
                }
            }
            sTip += link.Tags + "\n\n";
            tipMore.SetToolTip(lnkMore, sTip);
        }
    }
}