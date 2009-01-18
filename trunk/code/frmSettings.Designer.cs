namespace WinTumblr
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.cbchar = new System.Windows.Forms.CheckBox();
            this.cbBR = new System.Windows.Forms.CheckBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.cbProxy = new System.Windows.Forms.CheckBox();
            this.pnlProxy = new System.Windows.Forms.Panel();
            this.txtProxyDomain = new System.Windows.Forms.TextBox();
            this.lblProxyDomain = new System.Windows.Forms.Label();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.txtProxyUrl = new System.Windows.Forms.TextBox();
            this.lblProxyUrl = new System.Windows.Forms.Label();
            this.cbReveal = new System.Windows.Forms.CheckBox();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.lblProxy3 = new System.Windows.Forms.Label();
            this.txtProxyUser = new System.Windows.Forms.TextBox();
            this.lblProxy2 = new System.Windows.Forms.Label();
            this.bsSettings = new System.Windows.Forms.BindingSource(this.components);
            this.winTumblrData = new WinTumblr.WinTumblrData();
            this.pnlProxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winTumblrData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(122, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(203, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check the box next to the item you wish to enable.";
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Location = new System.Drawing.Point(16, 35);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(151, 17);
            this.cbMin.TabIndex = 0;
            this.cbMin.Text = "Minimize to the system tray";
            this.cbMin.UseVisualStyleBackColor = true;
            this.cbMin.Visible = false;
            // 
            // cbClose
            // 
            this.cbClose.AutoSize = true;
            this.cbClose.Location = new System.Drawing.Point(16, 35);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(249, 17);
            this.cbClose.TabIndex = 1;
            this.cbClose.Text = "Close all post windows upon successful posting";
            this.cbClose.UseVisualStyleBackColor = true;
            // 
            // cbchar
            // 
            this.cbchar.AutoSize = true;
            this.cbchar.Location = new System.Drawing.Point(16, 60);
            this.cbchar.Name = "cbchar";
            this.cbchar.Size = new System.Drawing.Size(256, 17);
            this.cbchar.TabIndex = 2;
            this.cbchar.Text = "Remove linefeeds and carriage return characters";
            this.cbchar.UseVisualStyleBackColor = true;
            this.cbchar.Visible = false;
            // 
            // cbBR
            // 
            this.cbBR.AutoSize = true;
            this.cbBR.Location = new System.Drawing.Point(16, 60);
            this.cbBR.Name = "cbBR";
            this.cbBR.Size = new System.Drawing.Size(126, 17);
            this.cbBR.TabIndex = 3;
            this.cbBR.Text = "Auto insert <br /> tag";
            this.cbBR.UseVisualStyleBackColor = true;
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxy.Location = new System.Drawing.Point(13, 84);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(88, 13);
            this.lblProxy.TabIndex = 8;
            this.lblProxy.Text = "Proxy Settings";
            // 
            // cbProxy
            // 
            this.cbProxy.AutoSize = true;
            this.cbProxy.Location = new System.Drawing.Point(16, 101);
            this.cbProxy.Name = "cbProxy";
            this.cbProxy.Size = new System.Drawing.Size(74, 17);
            this.cbProxy.TabIndex = 4;
            this.cbProxy.Text = "Use Proxy";
            this.cbProxy.UseVisualStyleBackColor = true;
            this.cbProxy.CheckedChanged += new System.EventHandler(this.cbProxy_CheckedChanged);
            // 
            // pnlProxy
            // 
            this.pnlProxy.Controls.Add(this.txtProxyDomain);
            this.pnlProxy.Controls.Add(this.lblProxyDomain);
            this.pnlProxy.Controls.Add(this.txtProxyPort);
            this.pnlProxy.Controls.Add(this.lblProxyPort);
            this.pnlProxy.Controls.Add(this.txtProxyUrl);
            this.pnlProxy.Controls.Add(this.lblProxyUrl);
            this.pnlProxy.Controls.Add(this.cbReveal);
            this.pnlProxy.Controls.Add(this.txtProxyPassword);
            this.pnlProxy.Controls.Add(this.lblProxy3);
            this.pnlProxy.Controls.Add(this.txtProxyUser);
            this.pnlProxy.Controls.Add(this.lblProxy2);
            this.pnlProxy.Location = new System.Drawing.Point(0, 124);
            this.pnlProxy.Name = "pnlProxy";
            this.pnlProxy.Size = new System.Drawing.Size(288, 119);
            this.pnlProxy.TabIndex = 5;
            // 
            // txtProxyDomain
            // 
            this.txtProxyDomain.Location = new System.Drawing.Point(191, 16);
            this.txtProxyDomain.Name = "txtProxyDomain";
            this.txtProxyDomain.Size = new System.Drawing.Size(87, 20);
            this.txtProxyDomain.TabIndex = 7;
            // 
            // lblProxyDomain
            // 
            this.lblProxyDomain.AutoSize = true;
            this.lblProxyDomain.Location = new System.Drawing.Point(188, 0);
            this.lblProxyDomain.Name = "lblProxyDomain";
            this.lblProxyDomain.Size = new System.Drawing.Size(43, 13);
            this.lblProxyDomain.TabIndex = 29;
            this.lblProxyDomain.Text = "Domain";
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Location = new System.Drawing.Point(218, 94);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Size = new System.Drawing.Size(60, 20);
            this.txtProxyPort.TabIndex = 11;
            this.txtProxyPort.Text = "80";
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.AutoSize = true;
            this.lblProxyPort.Location = new System.Drawing.Point(215, 78);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(26, 13);
            this.lblProxyPort.TabIndex = 27;
            this.lblProxyPort.Text = "Port";
            // 
            // txtProxyUrl
            // 
            this.txtProxyUrl.Location = new System.Drawing.Point(16, 94);
            this.txtProxyUrl.Name = "txtProxyUrl";
            this.txtProxyUrl.Size = new System.Drawing.Size(196, 20);
            this.txtProxyUrl.TabIndex = 10;
            this.txtProxyUrl.Text = "http://";
            // 
            // lblProxyUrl
            // 
            this.lblProxyUrl.AutoSize = true;
            this.lblProxyUrl.Location = new System.Drawing.Point(13, 78);
            this.lblProxyUrl.Name = "lblProxyUrl";
            this.lblProxyUrl.Size = new System.Drawing.Size(58, 13);
            this.lblProxyUrl.TabIndex = 25;
            this.lblProxyUrl.Text = "Proxy URL";
            // 
            // cbReveal
            // 
            this.cbReveal.AutoSize = true;
            this.cbReveal.Location = new System.Drawing.Point(218, 57);
            this.cbReveal.Name = "cbReveal";
            this.cbReveal.Size = new System.Drawing.Size(60, 17);
            this.cbReveal.TabIndex = 9;
            this.cbReveal.Text = "Reveal";
            this.cbReveal.UseVisualStyleBackColor = true;
            this.cbReveal.CheckedChanged += new System.EventHandler(this.cbReveal_CheckedChanged);
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Location = new System.Drawing.Point(16, 55);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.Size = new System.Drawing.Size(196, 20);
            this.txtProxyPassword.TabIndex = 8;
            this.txtProxyPassword.UseSystemPasswordChar = true;
            // 
            // lblProxy3
            // 
            this.lblProxy3.AutoSize = true;
            this.lblProxy3.Location = new System.Drawing.Point(13, 39);
            this.lblProxy3.Name = "lblProxy3";
            this.lblProxy3.Size = new System.Drawing.Size(53, 13);
            this.lblProxy3.TabIndex = 22;
            this.lblProxy3.Text = "Password";
            // 
            // txtProxyUser
            // 
            this.txtProxyUser.Location = new System.Drawing.Point(16, 16);
            this.txtProxyUser.Name = "txtProxyUser";
            this.txtProxyUser.Size = new System.Drawing.Size(169, 20);
            this.txtProxyUser.TabIndex = 6;
            // 
            // lblProxy2
            // 
            this.lblProxy2.AutoSize = true;
            this.lblProxy2.Location = new System.Drawing.Point(13, 0);
            this.lblProxy2.Name = "lblProxy2";
            this.lblProxy2.Size = new System.Drawing.Size(55, 13);
            this.lblProxy2.TabIndex = 20;
            this.lblProxy2.Text = "Username";
            // 
            // bsSettings
            // 
            this.bsSettings.DataMember = "Settings";
            this.bsSettings.DataSource = this.winTumblrData;
            // 
            // winTumblrData
            // 
            this.winTumblrData.DataSetName = "WinTumblrData";
            this.winTumblrData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 288);
            this.Controls.Add(this.pnlProxy);
            this.Controls.Add(this.cbProxy);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.cbBR);
            this.Controls.Add(this.cbchar);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinTumblr Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlProxy.ResumeLayout(false);
            this.pnlProxy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winTumblrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.CheckBox cbClose;
        private System.Windows.Forms.CheckBox cbchar;
        private System.Windows.Forms.CheckBox cbBR;
        private System.Windows.Forms.BindingSource bsSettings;
        private WinTumblrData winTumblrData;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.CheckBox cbProxy;
        private System.Windows.Forms.Panel pnlProxy;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.TextBox txtProxyUrl;
        private System.Windows.Forms.Label lblProxyUrl;
        private System.Windows.Forms.CheckBox cbReveal;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label lblProxy3;
        private System.Windows.Forms.TextBox txtProxyUser;
        private System.Windows.Forms.Label lblProxy2;
        private System.Windows.Forms.TextBox txtProxyDomain;
        private System.Windows.Forms.Label lblProxyDomain;
    }
}