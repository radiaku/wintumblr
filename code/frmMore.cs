using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinTumblr
{
    public partial class frmMore : Form
    {
        tumblr.Account mAcc;
        public frmMore(tumblr.Account pAcc)
        {
            mAcc = pAcc;
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            tipPrivate.SetToolTip(cbPrivate, "Private posts only appear in the Dashboard or with authenticated links, and do not appear on the tumblelog's main page");
            dtpDate.MaxDate = DateTime.Now;
            cbPrivate.Checked = mAcc.IsPrivate;
            if (mAcc.StrDateOfPost.Length > 0)
            {
                dtpDate.Checked = true;
                dtpDate.Value = mAcc.DateOfPost;
            }
            else
            {
                dtpDate.Checked = false;
            }
            txtTags.Text = mAcc.Tags;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            mAcc.IsPrivate = cbPrivate.Checked;
            if (dtpDate.Checked)
            {
                mAcc.DateOfPost = dtpDate.Value;
            }
            else
            {
                mAcc.StrDateOfPost = "";
            }
            mAcc.Tags = txtTags.Text;
        }
    }
}