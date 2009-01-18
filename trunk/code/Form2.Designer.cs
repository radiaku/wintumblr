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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWin = new System.Windows.Forms.CheckBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.cbchar = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(122, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(203, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // cbWin
            // 
            this.cbWin.AutoSize = true;
            this.cbWin.Location = new System.Drawing.Point(16, 42);
            this.cbWin.Name = "cbWin";
            this.cbWin.Size = new System.Drawing.Size(143, 17);
            this.cbWin.TabIndex = 3;
            this.cbWin.Text = "Run on Windows startup";
            this.cbWin.UseVisualStyleBackColor = true;
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Location = new System.Drawing.Point(16, 67);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(151, 17);
            this.cbMin.TabIndex = 4;
            this.cbMin.Text = "Minimize to the system tray";
            this.cbMin.UseVisualStyleBackColor = true;
            // 
            // cbClose
            // 
            this.cbClose.AutoSize = true;
            this.cbClose.Location = new System.Drawing.Point(16, 92);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(249, 17);
            this.cbClose.TabIndex = 5;
            this.cbClose.Text = "Close all post windows upon successful posting";
            this.cbClose.UseVisualStyleBackColor = true;
            // 
            // cbchar
            // 
            this.cbchar.AutoSize = true;
            this.cbchar.Location = new System.Drawing.Point(16, 117);
            this.cbchar.Name = "cbchar";
            this.cbchar.Size = new System.Drawing.Size(256, 17);
            this.cbchar.TabIndex = 6;
            this.cbchar.Text = "Remove linefeeds and carriage return characters";
            this.cbchar.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(16, 142);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(126, 17);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Auto insert <br /> tag";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 217);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.cbchar);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.cbWin);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbWin;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.CheckBox cbClose;
        private System.Windows.Forms.CheckBox cbchar;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}