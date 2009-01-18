using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinTumblr
{
    public partial class frmAccounts : Form
    {
        private int rowindex = -1; // For remove()
        private tumblr tum;
        static notify notice;

        public frmAccounts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = Program.data.ds;
            dgvAccounts.DataMember = "Accounts";
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            // Add a new record if the Account Name is not in the list
            // Update the existing Account otherwise
            bool updated = false;
            try
            {
                for (int i = 0; i < Program.data.ds.Accounts.Rows.Count; i++)
                {
                    if (cbDefault.Checked) // Remove all default values.
                    {
                        Program.data.ds.Accounts.Rows[i].BeginEdit();
                        Program.data.ds.Accounts.Rows[i]["default"] = false;
                        Program.data.ds.Accounts.Rows[i].EndEdit();
                    }
                    // Not the most efficient design. Was either two loops through the dataset or one with multiple edits.
                    if ((string)Program.data.ds.Accounts.Rows[i]["account"] == txtAccountName.Text)
                    {
                        Program.data.ds.Accounts.Rows[i].BeginEdit();
                        Program.data.ds.Accounts.Rows[i]["email"] = txtEmail.Text;
                        Program.data.ds.Accounts.Rows[i]["password"] = Program.data.xor(txtPassword.Text);
                        Program.data.ds.Accounts.Rows[i]["default"] = cbDefault.Checked;
                        Program.data.ds.Accounts.Rows[i].EndEdit();
                        Program.data.ds.Accounts.Rows[i].AcceptChanges();
                        updated = true;

                        //Program.data.ds.Accounts.AddAccountsRow(txtAccountName.Text, txtEmail.Text, txtPassword.Text, cbDefault.Checked);
                    }
                }
            }
            catch
            {
            }
            if (!updated)
            {

                try
                {
                    Program.data.ds.Accounts.AddAccountsRow(txtAccountName.Text, txtEmail.Text, Program.data.xor(txtPassword.Text), cbDefault.Checked);
                }
                catch
                {
                    MessageBox.Show(this, "There was an error adding this account. Please check all fields and try again.", "Error adding account - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (rowindex >= 0)
            {
                //bool wasdefault = (bool)Program.data.ds.Accounts.Rows[rowindex]["default"];
                Program.data.ds.Accounts.Rows[rowindex].Delete();
                rowindex = -1;
                txtAccountName.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                cbDefault.Checked = false;
                dgvAccounts.ClearSelection();
                Program.data.ds.WriteXml(Program.data.datapath);
            }
        }

        private void dgvAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if ((Program.data.ds.Accounts.Rows.Count > 0) && (Program.data.ds.Accounts.Rows[i].RowState != DataRowState.Detached) && (Program.data.ds.Accounts.Rows[i].RowState != DataRowState.Deleted))
            {
                rowindex = i;
                txtAccountName.Text = (string)Program.data.ds.Accounts.Rows[i]["account"];
                txtEmail.Text = (string)Program.data.ds.Accounts.Rows[i]["email"];
                try
                {
                    txtPassword.Text = Program.data.rox((string)Program.data.ds.Accounts.Rows[i]["password"]);
                }
                catch
                {
                    txtPassword.Text = "";
                }
                cbDefault.Checked = (bool)Program.data.ds.Accounts.Rows[i]["default"];
            }
            else
            {
                rowindex = -1;
                txtAccountName.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                cbDefault.Checked = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnValidate.Enabled = false;
            tumblr.Account account = new tumblr.Account();
            tum = new tumblr();

            account.Email = txtEmail.Text;
            account.Password = txtPassword.Text;
            if ((account.Email.Length > 0) && (account.Password.Length > 0))
            {
                tumblr.aAuthenticate aA = new tumblr.aAuthenticate(tum.Authenticate);

                IAsyncResult result = aA.BeginInvoke(account, new AsyncCallback(CallbackMethod), aA);
            }
            else
            {
                btnValidate.Enabled = true;
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, "Something went wrong setting all of the parameters for posting. Please check the account details and fields.", "Error - WinTumblr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CallbackMethod(IAsyncResult ar)
        {
            // Retrieve the delegate.
            tumblr.aAuthenticate caller = (tumblr.aAuthenticate)ar.AsyncState;
            // Call EndInvoke to retrieve the results.
            Status returnValue = caller.EndInvoke(ar);
            Form.CheckForIllegalCrossThreadCalls = false;
            Posted(returnValue);
        }

        void Posted(Status status)
        {
            btnValidate.Enabled = true;
            this.Cursor = Cursors.Default;
            notice = new notify();
            notice.showMsg(status); //notice.showAuthenticate(status.Msg);
            notice.ShowDialog(this);
        }
    }
}