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
    public partial class frmQuote : Form
    {
        private tumblr tum;
        private tumblr.Quote quote = new tumblr.Quote();
        static notify notice;
        //static bool bRemLnCr = true;
        static bool bInsBR = true;

        public frmQuote()
        {
            InitializeComponent();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.ShowDialog(this);
            LoadAccounts();
        }

        private void frmQuote_Load(object sender, EventArgs e)
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
            string group = (string)drv["group"];
            string password = "";
            try
            {
                password = Program.data.rox((string)drv["password"]);
            }
            catch
            {
                password = "";
            }
            string TheQuote = "";
            string Source = "";

            TheQuote = txtQuote.Text;
            Source = txtSource.Text.Replace("\r\n", " ");
            quote.Email = email;
            quote.Password = password;
            quote.Group = group;
            quote.TheQuote = TheQuote;
            quote.Source = Source;
            if ((TheQuote.Length > 0) && (email.Length > 0) && (password.Length > 0))
            {
                tumblr.apostQuote ap = new tumblr.apostQuote(tum.postQuote);

                IAsyncResult result = ap.BeginInvoke(quote, new AsyncCallback(CallbackMethod), ap);
                //s = Convert.ToString(tum.postQuote(quote));
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
            tumblr.apostQuote caller = (tumblr.apostQuote)ar.AsyncState;
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
            txtQuote.Text = txtSource.Text = "";
            txtQuote.Focus();
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
            int ist = txtSource.SelectionStart;
            txtSource.Text = txtSource.Text.Insert(ist, "<img src=\"http://url\" />");
            txtSource.ScrollToCaret();
            txtSource.SelectionStart = ist + 17;
            txtSource.SelectionLength = 3;
            txtSource.Focus();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            int ist = txtSource.SelectionStart;
            string tx = txtSource.SelectedText;
            txtSource.Text = txtSource.Text.Insert(ist, "<a href=\"http://url\">");
            txtSource.Text = txtSource.Text.Insert(ist + 21 + tx.Length, "</a>");
            txtSource.ScrollToCaret();
            txtSource.SelectionStart = ist + 16;
            txtSource.SelectionLength = 3;
            txtSource.Focus();
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Program.data.ds.Settings.Rows.Count > 0)
                {
                    Program.data.ds.Settings.Rows[0].BeginEdit();
                    Program.data.ds.Settings.Rows[0]["closeQuote"] = cbClose.Checked;
                    Program.data.ds.Settings.Rows[0].EndEdit();
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
                else
                {
                    DataRow newrow = Program.data.ds.Settings.NewRow();
                    newrow["closeQuote"] = cbClose.Checked;
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
                if (Program.data.ds.Settings.Rows[0]["closeQuote"].ToString() != "") cbClose.Checked = (bool)Program.data.ds.Settings.Rows[0]["closeQuote"];
                //if (Program.data.ds.Settings.Rows[0]["remlncr"].ToString() != "") bRemLnCr = (bool)Program.data.ds.Settings.Rows[0]["remlncr"];
                if (Program.data.ds.Settings.Rows[0]["addbr"].ToString() != "") { bInsBR = (bool)Program.data.ds.Settings.Rows[0]["addbr"]; } else { bInsBR = true; }
            }
        }

        private void frmQuote_Activated(object sender, EventArgs e)
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
            frmMore frm = new frmMore(quote);
            frm.ShowDialog(this);
            string sTip = "\nPost mode is ";
            if (quote.IsPrivate)
            {
                sTip += "Private\n\nDate of Post is Unaffected\n\nTags: ";
            }
            else
            {
                sTip += "Public\n\nDate of Post is ";
                if (quote.StrDateOfPost.Length > 0)
                {
                    sTip += quote.StrDateOfPost + "\n\nTags: ";
                }
                else
                {
                    sTip += "Now\n\nTags: ";
                }
            }
            sTip += quote.Tags + "\n\n";
            tipMore.SetToolTip(lnkMore, sTip);
        }
    }
}