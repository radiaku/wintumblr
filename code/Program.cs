using System;
using System.IO;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace WinTumblr
{
    // The WinTumblr System Tray menu and functionality
    // Why bother creating a window form when you don't need one yet...
    public class wtTray
    {
        private System.Windows.Forms.ContextMenuStrip mnuTray2;
        private System.Windows.Forms.ToolStripMenuItem mnutShow;
        private System.Windows.Forms.ToolStripMenuItem mnutAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnutSettings;
        private System.Windows.Forms.ToolStripMenuItem mnutWinStart;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnutText;
        private System.Windows.Forms.ToolStripMenuItem mnutPhoto;
        private System.Windows.Forms.ToolStripMenuItem mnutQuote;
        private System.Windows.Forms.ToolStripMenuItem mnutLink;
        private System.Windows.Forms.ToolStripMenuItem mnutChat;
        private System.Windows.Forms.ToolStripMenuItem mnutVideo;
        private System.Windows.Forms.ToolStripMenuItem mnutAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnutExit;

        public NotifyIcon niMain;
        public wtTray()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnuTray2 = new System.Windows.Forms.ContextMenuStrip();
            mnutShow = new System.Windows.Forms.ToolStripMenuItem();
            mnutAccounts = new System.Windows.Forms.ToolStripMenuItem();
            mnutSettings = new System.Windows.Forms.ToolStripMenuItem();
            mnutWinStart = new System.Windows.Forms.ToolStripMenuItem();
            mnutText = new System.Windows.Forms.ToolStripMenuItem();
            mnutPhoto = new System.Windows.Forms.ToolStripMenuItem();
            mnutQuote = new System.Windows.Forms.ToolStripMenuItem();
            mnutLink = new System.Windows.Forms.ToolStripMenuItem();
            mnutChat = new System.Windows.Forms.ToolStripMenuItem();
            mnutVideo = new System.Windows.Forms.ToolStripMenuItem();
            mnutAbout = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            mnutExit = new System.Windows.Forms.ToolStripMenuItem();
            // 
            // mnuTray2
            // 
            mnuTray2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnutShow,
            mnutAccounts,
            mnutSettings,
            mnutWinStart,
            toolStripMenuItem4,
            mnutText,
            mnutPhoto,
            mnutQuote,
            mnutLink,
            mnutChat,
            mnutVideo,
            toolStripMenuItem3,
            mnutAbout,
            mnutExit});
            mnuTray2.Name = "mnuTray2";
            mnuTray2.ShowCheckMargin = true;
            mnuTray2.ShowImageMargin = false;
            mnuTray2.Size = new System.Drawing.Size(192, 252);
            // 
            // mnutShow
            // 
            mnutShow.Name = "mnutShow";
            mnutShow.Size = new System.Drawing.Size(191, 22);
            mnutShow.Text = "Show &WinTumblr";            
            mnutShow.Click += new System.EventHandler(mnutShow_Click);
            // 
            // mnutAccounts
            // 
            mnutAccounts.Name = "mnutAccounts";
            mnutAccounts.Size = new System.Drawing.Size(191, 22);
            mnutAccounts.Text = "&Manage Accounts";
            mnutAccounts.Click += new System.EventHandler(mnutAccounts_Click);
            // 
            // mnutSettings
            // 
            mnutSettings.Name = "mnutSettings";
            mnutSettings.Size = new System.Drawing.Size(191, 22);
            mnutSettings.Text = "S&ettings";
            mnutSettings.Click += new System.EventHandler(mnutSettings_Click);
            // 
            // mnutWinStart
            // 
            mnutWinStart.Name = "mnutWinStart";
            mnutWinStart.Size = new System.Drawing.Size(191, 22);
            mnutWinStart.Text = "Run on Windows &Start";
            mnutWinStart.CheckOnClick = true;
            // Check registry for correct setting
            bool bWinStart = false;
            string s = "";
            try
            {
                Microsoft.Win32.RegistryKey key;
                string path = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                s = (string)key.GetValue("WinTumblr", "");
                key.Close();
                if (s.Length > 0)
                {
                    bWinStart = true;
                }
            }
            catch
            {
                bWinStart = false;
            }
            Program.winstart = bWinStart;
            mnutWinStart.Checked = bWinStart;

            mnutWinStart.CheckedChanged += new System.EventHandler(mnutWinStart_CheckedChanged);
            // 
            // mnutText
            // 
            mnutText.Name = "mnutText";
            mnutText.Size = new System.Drawing.Size(191, 22);
            mnutText.Text = "New &Text Post";
            mnutText.Click += new System.EventHandler(mnutText_Click);
            // 
            // mnutPhoto
            // 
            mnutPhoto.Name = "mnutPhoto";
            mnutPhoto.Size = new System.Drawing.Size(191, 22);
            mnutPhoto.Text = "New &Photo Post";
            mnutPhoto.Click += new System.EventHandler(mnutPhoto_Click);
            // 
            // mnutQuote
            // 
            mnutQuote.Name = "mnutQuote";
            mnutQuote.Size = new System.Drawing.Size(191, 22);
            mnutQuote.Text = "New &Quote Post";
            mnutQuote.Click += new System.EventHandler(mnutQuote_Click);
            // 
            // mnutLink
            // 
            mnutLink.Name = "mnutLink";
            mnutLink.Size = new System.Drawing.Size(191, 22);
            mnutLink.Text = "New &Link Post";
            mnutLink.Click += new System.EventHandler(mnutLink_Click);
            // 
            // mnutChat
            // 
            mnutChat.Name = "mnutChat";
            mnutChat.Size = new System.Drawing.Size(191, 22);
            mnutChat.Text = "New &Chat Post";
            mnutChat.Click += new System.EventHandler(mnutChat_Click);
            // 
            // mnutVideo
            // 
            mnutVideo.Name = "mnutVideo";
            mnutVideo.Size = new System.Drawing.Size(191, 22);
            mnutVideo.Text = "New &Video Post";
            mnutVideo.Click += new System.EventHandler(mnutVideo_Click);
            // 
            // mnutAbout
            // 
            mnutAbout.Name = "mnutAbout";
            mnutAbout.Size = new System.Drawing.Size(191, 22);
            mnutAbout.Text = "&About WinTumblr";
            mnutAbout.Click += new System.EventHandler(mnutAbout_Click);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(188, 6);
            // 
            // mnutExit
            // 
            mnutExit.Name = "mnutExit";
            mnutExit.Size = new System.Drawing.Size(191, 22);
            mnutExit.Text = "E&xit";
            mnutExit.Click += new System.EventHandler(mnutExit_Click);



            niMain = new NotifyIcon();
            niMain.BalloonTipText = "WinTumblr is still running. To exit right-click this icon.";
            niMain.ContextMenuStrip = mnuTray2;
            niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            niMain.Text = "WinTumblr";
            niMain.Visible = true;
            niMain.DoubleClick += new System.EventHandler(this.niMain_DoubleClick);
        }

        public bool mnuStartGet()
        {
            return mnutWinStart.Checked;
        }

        public void mnuStartChange()
        {
            mnutWinStart.Checked = !mnutWinStart.Checked;
        }

        public void mnuStartChange(bool bState)
        {
            mnutWinStart.Checked = bState;
            mnutWinStart.Checked = bState;
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            if (mnutShow.Enabled)
            {
                Program.main.Show();
                Program.main.BringToFront();
                Program.main.WindowState = FormWindowState.Normal;
            }
        }

        private void mnutExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnutShow_Click(object sender, EventArgs e)
        {
            Program.main.Show();
        }

        private void mnutAccounts_Click(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutText_Click(object sender, EventArgs e)
        {
            frmText frm = new frmText();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutPhoto_Click(object sender, EventArgs e)
        {
            frmPhoto frm = new frmPhoto();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutQuote_Click(object sender, EventArgs e)
        {
            frmQuote frm = new frmQuote();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutLink_Click(object sender, EventArgs e)
        {
            frmLink frm = new frmLink();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutChat_Click(object sender, EventArgs e)
        {
            frmChat frm = new frmChat();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutVideo_Click(object sender, EventArgs e)
        {
            frmVideo frm = new frmVideo();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            SwitchMenuItems(false);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowInTaskbar = true;
            frm.ShowDialog();
            SwitchMenuItems(true);
        }

        private void mnutWinStart_CheckedChanged(object sender, EventArgs e)
        {
            if (mnutWinStart.Checked)
            {
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    string path = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                    key.SetValue("WinTumblr", "\"" + Application.ExecutablePath + "\" winstart");
                    key.Close();
                }
                catch
                {
                    MessageBox.Show("Unable to write WinTumblr startup entry into the registry", "WinTumblr Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Microsoft.Win32.RegistryKey key;
                    string path = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path, true);
                    key.DeleteValue("WinTumblr");
                    key.Close();
                }
                catch
                {
                    MessageBox.Show("Unable to remove WinTumblr startup entry from the registry", "WinTumblr Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Used to disable the menu items while busy in any of the forms
        // If they aren't disabled then you can open up the same form again or any of the other forms at the same time
        // Decided to rather keep things synchronous to avoid lost windows and any programming faults due to asynchronous behaviour
        public void SwitchMenuItems(bool b)
        {
            mnutShow.Enabled = b;
            mnutAccounts.Enabled = b;
            mnutSettings.Enabled = b;
            //mnutWinStart.Enabled = b;
            mnutText.Enabled = b;
            mnutPhoto.Enabled = b;
            mnutQuote.Enabled = b;
            mnutLink.Enabled = b;
            mnutChat.Enabled = b;
            mnutVideo.Enabled = b;
            mnutAbout.Enabled = b;
        }
    }

    // Wintumblr data storage
    public class wtData
    {
        /* Need to store the following data:
         * Accounts
         * Settings
        */

        public WinTumblrData ds;
        public string datapath = "";
        public bool bCText = false;
        public bool bCChat = false;
        public bool bCLink = false;
        public bool bCPhoto = false;
        public bool bCQuote = false;
        public bool bCVideo = false;
        public bool bAddBR = false;


        public wtData()
        {
            ds = new WinTumblrData();
            InitPaths();
            InitData();
            InitProxy();
        }

        // This method may fail if you do not have write permission to the particular folder
        // It tries to create a folder in the user's application data folder
        // If that fails then it tries to create a folder within the application's working folder
        // If that fails then it will all be temporary (while the application runs)
        private void InitPaths()
        {
            bool other = false;
            datapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Application.ProductName;
            try
            {
                lock (typeof(Application))
                {
                    if (!Directory.Exists(datapath))
                    {
                        Directory.CreateDirectory(datapath);
                    }
                }
            }
            catch
            {
                // Try to save and read data locally
                other = true;
                datapath = Application.StartupPath + "\\data";
            }
            if (other)
            {
                try
                {
                    lock (typeof(Application))
                    {
                        if (!Directory.Exists(datapath))
                        {
                            Directory.CreateDirectory(datapath);
                        }
                    }
                }
                catch
                {
                    // Run it all in memory then
                    datapath = "";
                }
            }            
        }

        private void InitData()
        {
            // Read the dataset XML file
            if (datapath != "")
            {
                try
                {
                    datapath += "\\data.xml";
                    lock (typeof(Application))
                    {
                        if (File.Exists(datapath))
                        {
                            ds.ReadXml(datapath);
                        }
                    }
                }
                catch
                {
                    datapath = "";
                }
            }

        }

        private void InitProxy()
        {
            if ((ds.Settings.Rows.Count > 0) && (ds.Settings.Rows[0]["useProxy"].ToString() != ""))
            {
                tumblr.Proxy.UseProxy = (bool)ds.Settings.Rows[0]["useProxy"];
                tumblr.Proxy.UserName = ds.Settings.Rows[0]["proxyUsername"].ToString();
                tumblr.Proxy.Password = ds.Settings.Rows[0]["proxyPassword"].ToString();
                tumblr.Proxy.ServerURL = ds.Settings.Rows[0]["proxyUrl"].ToString();
                tumblr.Proxy.ServerPort = ds.Settings.Rows[0]["proxyPort"].ToString();
                tumblr.Proxy.Domain = ds.Settings.Rows[0]["proxyDomain"].ToString();
            }
        }
        
        // A very very very simple obfuscation method for the account password
        // There are a few things wrong with this:
        // 1. The password is right here for anyone to see!
        // 2. Well, it isn't actually using XOR, it is Triple DES
        //
        // Why is point 1 a problem?
        // My intention was not to make your tumblr account details secure, only to prevent casual 
        // browsing of the data file and the accidental discovery of your account details. Storing 
        // a long password in the code solves a lot of other problems.
        //
        // You're welcome to change this method to something a lot more secure. Perhaps prompt for 
        // the account password upon submitting a post? Or change the way account password are 
        // stored to something far more secure.
        public string xor(string pass)
        {
            string pk = "nASjfDSdk()DSsai&^*o;fjHJK@@no2;SDKLPqj930[ jffifj  i cdnio3T 1Rfj$*#(HDjklhdU(P*#YR*HJlJKLH#EC*(HU NS:L@*(CNPOUE@*PONJ:JENIDX:OJ@*)(DXU@*()#NJHEHC UILGVIOY@&EX(PhuIDLHUDCU(P@#UC)@NUJHuHDC#@YL&(P#*(Q{(NCUE(QJDKno:UBCE*)(UPN(C@C JDIO:WNI)@u9@){UCE)(@UEC)(@CNU IE@JH8i0@*&(C)EU()EUV EU90[U(CNUICJDiNCU(N{C(E JI:J90@*U@(E@U C(E@JIX{@EU()[";
            return EncryptMessage(pass, pk);
        }

        public string rox(string pass)
        {
            string pk = "nASjfDSdk()DSsai&^*o;fjHJK@@no2;SDKLPqj930[ jffifj  i cdnio3T 1Rfj$*#(HDjklhdU(P*#YR*HJlJKLH#EC*(HU NS:L@*(CNPOUE@*PONJ:JENIDX:OJ@*)(DXU@*()#NJHEHC UILGVIOY@&EX(PhuIDLHUDCU(P@#UC)@NUJHuHDC#@YL&(P#*(Q{(NCUE(QJDKno:UBCE*)(UPN(C@C JDIO:WNI)@u9@){UCE)(@UEC)(@CNU IE@JH8i0@*&(C)EU()EUV EU90[U(CNUICJDiNCU(N{C(E JI:J90@*U@(E@U C(E@JIX{@EU()[";
            return DecryptMessage(pass, pk);
        }

        public string EncryptMessage(string plainMessage, string password)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.IV = new byte[8];
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[0]);
            des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
            MemoryStream ms = new MemoryStream(plainMessage.Length * 2);
            CryptoStream encStream = new CryptoStream(ms, des.CreateEncryptor(),
            CryptoStreamMode.Write);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainMessage);
            encStream.Write(plainBytes, 0, plainBytes.Length);
            encStream.FlushFinalBlock();
            byte[] encryptedBytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(encryptedBytes, 0, (int)ms.Length);
            encStream.Close();
            return Convert.ToBase64String(encryptedBytes);
        }
        public string DecryptMessage(string encryptedBase64, string password)
        {
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.IV = new byte[8];
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[0]);
            des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
            byte[] encryptedBytes = Convert.FromBase64String(encryptedBase64);
            MemoryStream ms = new MemoryStream(encryptedBase64.Length);
            CryptoStream decStream = new CryptoStream(ms, des.CreateDecryptor(),
            CryptoStreamMode.Write);
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            decStream.FlushFinalBlock();
            byte[] plainBytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(plainBytes, 0, (int)ms.Length);
            decStream.Close();
            return Encoding.UTF8.GetString(plainBytes);
        }
    }

    // The magic behind windowless startups... or not. It depends on what you know.
    // That means starting your application without actually creating and showing 
    // a Windows Form.
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool winstart = false;
        public static wtTray tray;
        public static wtData data;
        public static frmMain main;
        public static bool totray = false; // Prevent popup info on subsequent closings

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tray = new wtTray();
            data = new wtData();
            main = new frmMain();
            if (args.Length > 0)
            {
                foreach (string s in args)
                {
                    if (s == "winstart")
                    {
                        totray = true;
                        Application.Run();
                        break;
                    }
                }
            }
            // When you set the application to start on Windows Start then the command line is appended with "winstart"
            // This command prevents WinTumblr from showing the main form
            // else we will want to display it for the user
            if (!totray)
            {
                Application.Run(main);
            }
            // Dispose of all things when the message loops stop
            tray.niMain.Dispose();
        }
    }
}