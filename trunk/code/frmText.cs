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
    public partial class frmText : Form
    {
        private tumblr tum;
        private tumblr.Text text = new tumblr.Text();
        static notify notice;
        //static bool bRemLnCr = true;
        private bool bInsBR = true;

        public frmText()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmText_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            tipMore.SetToolTip(lnkMore, "\nDate of Post is Now\n\nPost mode is Public\n\nTags: \n\n");
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.ShowDialog(this);
            LoadAccounts();
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
            //text = new tumblr.Text();
            tum = new tumblr();
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
            string body = "";

            title = txtTitle.Text;
            body = txtBody.Text.Replace("\r\n", " ");
            text.Email = email;
            text.Password = password;
            text.Title = title;
            text.Body = body;
            if (((body.Length > 0) || (title.Length > 0)) && (email.Length > 0) && (password.Length > 0))
            {
                //notice = new notify();
                //notice.Left = Left + (int)(((Width - notice.Width) / 2));
                //notice.Top = Top + (int)(((Height - notice.Height) / 2));
                //notice.Show(this);
                tumblr.apostText ap = new tumblr.apostText(tum.postText);

                IAsyncResult result = ap.BeginInvoke(text, new AsyncCallback(CallbackMethod), ap);
                //s = Convert.ToString(tum.postText(text)); //email, password, title, body));
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
            tumblr.apostText caller = (tumblr.apostText)ar.AsyncState;
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
            //notice.Close();
            //notice.Dispose();
            //this.Enabled = true;
            //this.Cursor = Cursors.Default;
            //MessageBox.Show(this, te.message, " tumblr Communications - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTitle.Text = txtBody.Text = "";
            txtTitle.Focus();
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
            int ist = txtBody.SelectionStart;
            txtBody.Text = txtBody.Text.Insert(ist, "<img src=\"http://url\" />");
            txtBody.ScrollToCaret();
            txtBody.SelectionStart = ist + 17;
            txtBody.SelectionLength = 3;
            txtBody.Focus();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            int ist = txtBody.SelectionStart;
            string tx = txtBody.SelectedText;
            txtBody.Text = txtBody.Text.Insert(ist, "<a href=\"http://url\">");
            txtBody.Text = txtBody.Text.Insert(ist + 21 + tx.Length, "</a>");
            txtBody.ScrollToCaret();
            txtBody.SelectionStart = ist + 16;
            txtBody.SelectionLength = 3;
            txtBody.Focus();
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Program.data.ds.Settings.Rows.Count > 0)
                {
                    Program.data.ds.Settings.Rows[0].BeginEdit();
                    Program.data.ds.Settings.Rows[0]["closeText"] = cbClose.Checked;
                    Program.data.ds.Settings.Rows[0].EndEdit();
                    Program.data.ds.Settings.Rows[0].AcceptChanges();
                }
                else
                {
                    DataRow newrow = Program.data.ds.Settings.NewRow();
                    newrow["closeText"] = cbClose.Checked;
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
                if (Program.data.ds.Settings.Rows[0]["closeText"].ToString() != "") cbClose.Checked = (bool)Program.data.ds.Settings.Rows[0]["closeText"];
                //if (Program.data.ds.Settings.Rows[0]["remlncr"].ToString() != "") bRemLnCr = (bool)Program.data.ds.Settings.Rows[0]["remlncr"];
                if (Program.data.ds.Settings.Rows[0]["addbr"].ToString() != "") { bInsBR = (bool)Program.data.ds.Settings.Rows[0]["addbr"]; } else { bInsBR = true; }
            }
        }

        private void frmText_Activated(object sender, EventArgs e)
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
            frmMore frm = new frmMore(text);
            frm.ShowDialog(this);
            string sTip = "\nPost mode is ";
            if (text.IsPrivate)
            {
                sTip += "Private\n\nDate of Post is Unaffected\n\nTags: ";
            }
            else
            {
                sTip += "Public\n\nDate of Post is ";
                if (text.StrDateOfPost.Length > 0)
                {
                    sTip += text.StrDateOfPost + "\n\nTags: ";
                }
                else
                {
                    sTip += "Now\n\nTags: ";
                }
            }
            sTip += text.Tags + "\n\n";
            tipMore.SetToolTip(lnkMore, sTip);
        }
    }
}