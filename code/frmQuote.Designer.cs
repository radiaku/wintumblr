namespace WinTumblr
{
    partial class frmQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuote));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnAcc = new System.Windows.Forms.Button();
            this.cbAcc = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winTumblrData = new WinTumblr.WinTumblrData();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.lnkReset = new System.Windows.Forms.LinkLabel();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.lnkSettings = new System.Windows.Forms.LinkLabel();
            this.lnkMore = new System.Windows.Forms.LinkLabel();
            this.tipMore = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winTumblrData)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Source (Optional; HTML Allowed)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quote";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tumblr Account:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(257, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.Location = new System.Drawing.Point(176, 266);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(15, 169);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(317, 91);
            this.txtSource.TabIndex = 1;
            this.txtSource.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // btnAcc
            // 
            this.btnAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcc.Location = new System.Drawing.Point(252, 11);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(75, 23);
            this.btnAcc.TabIndex = 5;
            this.btnAcc.Text = "Add/Edit";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // cbAcc
            // 
            this.cbAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAcc.DataSource = this.accountsBindingSource;
            this.cbAcc.DisplayMember = "account";
            this.cbAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcc.FormattingEnabled = true;
            this.cbAcc.Location = new System.Drawing.Point(100, 12);
            this.cbAcc.Name = "cbAcc";
            this.cbAcc.Size = new System.Drawing.Size(146, 21);
            this.cbAcc.TabIndex = 4;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.winTumblrData;
            // 
            // winTumblrData
            // 
            this.winTumblrData.DataSetName = "WinTumblrData";
            this.winTumblrData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtQuote
            // 
            this.txtQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuote.Location = new System.Drawing.Point(15, 59);
            this.txtQuote.Multiline = true;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuote.Size = new System.Drawing.Size(317, 91);
            this.txtQuote.TabIndex = 0;
            // 
            // lnkReset
            // 
            this.lnkReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkReset.AutoSize = true;
            this.lnkReset.Location = new System.Drawing.Point(12, 263);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(35, 13);
            this.lnkReset.TabIndex = 8;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset";
            this.lnkReset.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
            // 
            // btnImg
            // 
            this.btnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImg.Image = global::WinTumblr.Properties.Resources.image;
            this.btnImg.Location = new System.Drawing.Point(269, 150);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(30, 19);
            this.btnImg.TabIndex = 6;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnLink
            // 
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLink.Image = global::WinTumblr.Properties.Resources.link;
            this.btnLink.Location = new System.Drawing.Point(302, 150);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(30, 19);
            this.btnLink.TabIndex = 7;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbClose.AutoSize = true;
            this.cbClose.Location = new System.Drawing.Point(15, 279);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(113, 17);
            this.cbClose.TabIndex = 20;
            this.cbClose.Text = "Close after posting";
            this.cbClose.UseVisualStyleBackColor = true;
            this.cbClose.CheckedChanged += new System.EventHandler(this.cbClose_CheckedChanged);
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkSettings.AutoSize = true;
            this.lnkSettings.Location = new System.Drawing.Point(44, 263);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Size = new System.Drawing.Size(45, 13);
            this.lnkSettings.TabIndex = 22;
            this.lnkSettings.TabStop = true;
            this.lnkSettings.Text = "Settings";
            this.lnkSettings.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSettings_LinkClicked);
            // 
            // lnkMore
            // 
            this.lnkMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkMore.AutoSize = true;
            this.lnkMore.Location = new System.Drawing.Point(86, 263);
            this.lnkMore.Name = "lnkMore";
            this.lnkMore.Size = new System.Drawing.Size(52, 13);
            this.lnkMore.TabIndex = 24;
            this.lnkMore.TabStop = true;
            this.lnkMore.Text = "Options...";
            this.lnkMore.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMore_LinkClicked);
            // 
            // tipMore
            // 
            this.tipMore.AutomaticDelay = 50;
            this.tipMore.AutoPopDelay = 20000;
            this.tipMore.InitialDelay = 50;
            this.tipMore.IsBalloon = true;
            this.tipMore.ReshowDelay = 10;
            this.tipMore.ShowAlways = true;
            this.tipMore.ToolTipTitle = "Extra Settings";
            // 
            // frmQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(348, 301);
            this.Controls.Add(this.lnkMore);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.lnkReset);
            this.Controls.Add(this.txtQuote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.cbAcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(364, 337);
            this.Name = "frmQuote";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Quote - WinTumblr";
            this.Activated += new System.EventHandler(this.frmQuote_Activated);
            this.Load += new System.EventHandler(this.frmQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winTumblrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.ComboBox cbAcc;
        private System.Windows.Forms.TextBox txtQuote;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private WinTumblrData winTumblrData;
        private System.Windows.Forms.LinkLabel lnkReset;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.CheckBox cbClose;
        private System.Windows.Forms.LinkLabel lnkSettings;
        private System.Windows.Forms.LinkLabel lnkMore;
        private System.Windows.Forms.ToolTip tipMore;

    }
}