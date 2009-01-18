using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace WinTumblr
{
    public partial class frmMain : Form
    {
        //private enum RenderMode { None, EntireWindow, TopWindow, Region };
        //RenderMode m_RenderMode;
        bool bBlue = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WinTumblr.tumblr tum = new tumblr();
            //tum.TumblrEvent += new tumblr.TumblrEventHandler(TumblrPost);
            //string s;
            //textBox1.Text = "";
            //s = Convert.ToString(tum.postRegular("wintumblr@feedfeast.com", "wintumblr1", "Event Raising", "My object raises an event with the message property containing the returned message from the web server."));
            //tum.test(ref textBox1, "wintumblr@feedfeast.com", "", "test01 - Regular post", "WinTumblr post test #1<br />The smartest tumblr client for windows &endash; at least it will be when it is done.");
        }

        void TumblrPost(object sender, TumblrEventArgs te) 
        {
            //textBox1.Text += te.message;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (Program.winstart)
            //{
            //    Hide();
            //}
            // Check registry for correct setting
            //bool bWinStart = false;
            //string s = "";
            //try
            //{
            //    Microsoft.Win32.RegistryKey key;
            //    string path = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
            //    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
            //    s = (string)key.GetValue("WinTumblr", "");
            //    key.Close();
            //    if (s.Length > 0)
            //    {
            //        bWinStart = true;
            //    }
            //}
            //catch
            //{
            //    bWinStart = false;
            //}
            //runOnWindowsStartToolStripMenuItem.Checked = bWinStart;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = !bBlue;
            pictureBox2.Visible = bBlue;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            //System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ttClickMe.SetToolTip(this.pictureBox2, "Click Me");
            //ttClickMe.Show("Click Me", pictureBox2.Handle);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            runOnWindowsStartToolStripMenuItem.Checked = Program.tray.mnuStartGet();
            mnuMain.Show(pictureBox2, ((int)Math.Abs(mnuMain.Width/2))*-1+(pictureBox2.Width/2), pictureBox2.Height-8); //pictureBox2.Left, pictureBox2.Top + pictureBox2.Height);
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            bBlue = true;
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            bBlue = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        //private void niMain_DoubleClick(object sender, EventArgs e)
        //{
        //    Show();
        //    BringToFront();
        //    WindowState = FormWindowState.Normal;
        //}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.ApplicationExitCall) || (e.CloseReason == CloseReason.WindowsShutDown))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                Hide();
                if (!Program.totray)
                {
                    Program.totray = true;
                    Program.tray.niMain.ShowBalloonTip(4000, "", "WinTumblr is still running. To exit right-click this icon.", ToolTipIcon.None);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmText frm = new frmText();
            Program.tray.SwitchMenuItems(false);
            frm.ShowDialog(this);
            Program.tray.SwitchMenuItems(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmPhoto frm = new frmPhoto();
            Program.tray.SwitchMenuItems(false);
            frm.ShowDialog(this);
            Program.tray.SwitchMenuItems(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmQuote frm = new frmQuote();
            Program.tray.SwitchMenuItems(false);
            frm.ShowDialog(this);
            Program.tray.SwitchMenuItems(true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLink frm = new frmLink();
            Program.tray.SwitchMenuItems(false);
            frm.ShowDialog(this);
            Program.tray.SwitchMenuItems(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChat frm = new frmChat();
            Program.tray.SwitchMenuItems(false);
            frm.ShowDialog(this);
            Program.tray.SwitchMenuItems(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVideo frm = new frmVideo();
            Program.tray.SwitchMenuItems(false);
            frm.ShowDialog(this);
            Program.tray.SwitchMenuItems(true);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            frm.ShowDialog(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog(this);
        }

        private void postHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmHistory frm = new frmHistory();
            //frm.ShowDialog(this);
        }

        private void runOnWindowsStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call the tray menu one
            Program.tray.mnuStartChange();
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog(this);
        }

     }
}