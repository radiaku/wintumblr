namespace WinTumblr
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnText = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttClickMe = new System.Windows.Forms.ToolTip(this.components);
            this.mnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.runOnWindowsStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.White;
            this.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Image = ((System.Drawing.Image)(resources.GetObject("btnText.Image")));
            this.btnText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnText.Location = new System.Drawing.Point(12, 57);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(77, 50);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "Text";
            this.btnText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttClickMe.SetToolTip(this.btnText, "Create a regular post");
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.White;
            this.btnVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.Image = ((System.Drawing.Image)(resources.GetObject("btnVideo.Image")));
            this.btnVideo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVideo.Location = new System.Drawing.Point(96, 169);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(77, 50);
            this.btnVideo.TabIndex = 5;
            this.btnVideo.Text = "Video";
            this.btnVideo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttClickMe.SetToolTip(this.btnVideo, "Embed a video or other type of object");
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.White;
            this.btnChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChat.Location = new System.Drawing.Point(12, 169);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(77, 50);
            this.btnChat.TabIndex = 4;
            this.btnChat.Text = "Chat";
            this.btnChat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttClickMe.SetToolTip(this.btnChat, "Post a conversation");
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.White;
            this.btnLink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Image = ((System.Drawing.Image)(resources.GetObject("btnLink.Image")));
            this.btnLink.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLink.Location = new System.Drawing.Point(96, 113);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(77, 50);
            this.btnLink.TabIndex = 3;
            this.btnLink.Text = "Link";
            this.btnLink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttClickMe.SetToolTip(this.btnLink, "Create a link");
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.BackColor = System.Drawing.Color.White;
            this.btnQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuote.Image = ((System.Drawing.Image)(resources.GetObject("btnQuote.Image")));
            this.btnQuote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuote.Location = new System.Drawing.Point(12, 113);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(77, 50);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "Quote";
            this.btnQuote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttClickMe.SetToolTip(this.btnQuote, "Post a quote");
            this.btnQuote.UseVisualStyleBackColor = false;
            this.btnQuote.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackColor = System.Drawing.Color.White;
            this.btnPhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnPhoto.Image")));
            this.btnPhoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhoto.Location = new System.Drawing.Point(96, 57);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(77, 50);
            this.btnPhoto.TabIndex = 1;
            this.btnPhoto.Text = "Photo";
            this.btnPhoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttClickMe.SetToolTip(this.btnPhoto, "Upload or link to a photo");
            this.btnPhoto.UseVisualStyleBackColor = false;
            this.btnPhoto.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.mnuSettings,
            this.runOnWindowsStartToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mnuMain.Name = "contextMenuStrip1";
            this.mnuMain.ShowCheckMargin = true;
            this.mnuMain.ShowImageMargin = false;
            this.mnuMain.Size = new System.Drawing.Size(193, 142);
            this.mnuMain.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            this.mnuMain.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "&Hide";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem2.Text = "&Manage Accounts";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(192, 22);
            this.mnuSettings.Text = "&Settings";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // runOnWindowsStartToolStripMenuItem
            // 
            this.runOnWindowsStartToolStripMenuItem.CheckOnClick = true;
            this.runOnWindowsStartToolStripMenuItem.Name = "runOnWindowsStartToolStripMenuItem";
            this.runOnWindowsStartToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.runOnWindowsStartToolStripMenuItem.Text = "Run on Windows Start";
            this.runOnWindowsStartToolStripMenuItem.Click += new System.EventHandler(this.runOnWindowsStartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(185, 227);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.btnLink);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(191, 259);
            this.MinimumSize = new System.Drawing.Size(191, 259);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinTumblr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip ttClickMe;
        private System.Windows.Forms.ContextMenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runOnWindowsStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
    }
}

