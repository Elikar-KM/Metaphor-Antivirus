using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.Win32;
using Metaphor_Antivirus.Common;
using System.Net;

namespace Metaphor_Antivirus
{

    // ClamAV Packet + Server for virus detection 

    public partial class Form1 : Form
    {
        string CurrentVersion = "0.2"; // I NEED TO UPDATE THIS
        bool defenderSwitch = false;
        static string FilePath = String.Empty;
        bool amd64 = Environment.Is64BitOperatingSystem;
        private ContextMenu m_menu;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        // System.Runtime.InteropServices.DllImportAttribute | DllImportAttribute
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            m_menuLoad();
            notifyIcon1.Visible = false;
            SystemInfo();
        }

        // LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Application minimized";
            notifyIcon1.BalloonTipTitle = "Metaphor Antivirus";
            donatebitch.Text = "Hey '" + Environment.UserName + "'";
        }

        // Tray icon
        private void m_menuLoad()
        {
            m_menu = new ContextMenu();
            m_menu.MenuItems.Add(0,
                new MenuItem("Show", new System.EventHandler(Show_Click)));
            m_menu.MenuItems.Add(1,
                new MenuItem("Exit", new System.EventHandler(Exit_Click)));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowIcon = false;
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ContextMenu = m_menu;
        }

        protected void Exit_Click(Object sender, System.EventArgs e)
        {
            Close();
        }
        protected void Show_Click(Object sender, System.EventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close Metaphor Antivirus ?", "Metaphor Antivirus", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SystemInfo()
        {
            OperatingSystem os_info = System.Environment.OSVersion;

            String info1 = Environment.MachineName; // Computer name
            ComputerName.Text = info1;

            String info2 = Environment.UserName; // username
            Username.Text = Convert.ToString(info2);

            String info3 = Environment.OSVersion.ToString(); // version
            TextVersion.Text = info3;

            OsBit.Text = Convert.ToString(amd64); // 64 Bit OS

            bool info5 = Environment.Is64BitProcess; // 64 Bit Process
            ProcessBit.Text = Convert.ToString(info5);

            String info6 = Environment.OSVersion.Platform.ToString(); // System Platform
            OsPlatform.Text = info6;

            OS.Text = GetOsName(os_info); // OS Name
        }

        private void usageBtn_Click(object sender, EventArgs e)
        {
            RamAndCpuUsage ramAndCpuUsage = new RamAndCpuUsage();
            ramAndCpuUsage.Show();
        }

        // Return the OS name
        private string GetOsName(OperatingSystem os_info)
        {
            string version =
                os_info.Version.Major.ToString() + "." +
                os_info.Version.Minor.ToString();
            switch (version)
            {
                case "10.0": return "10 / Server 2016";
                case "6.3": return "8.1 / Server 2012 R2";
                case "6.2": return "8 / Server 2012";
                case "6.1": return "7  /Server 2008 R2";
                case "6.0": return "Server 2008 / Vista";
                case "5.2": return "Server 2003 R2 / Server 2003 / XP 64-Bit Edition";
                case "5.1": return "XP";
                case "5.0": return "2000";
            }
            return "Unknown";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wtf-Is-This-x1337/Metaphor-Antivirus");
        }

        private void processesBtn_Click(object sender, EventArgs e)
        {
            LowBudgetTaskManager lowBudgetTaskManager = new LowBudgetTaskManager();
            lowBudgetTaskManager.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // I just download the whole html code to a string called "version", then i check if the string contains the current version.
            WebClient client = new WebClient();
            string version = client.DownloadString("https://raw.githubusercontent.com/Wtf-Is-This-x1337/Metaphor-Antivirus/main/Version.txt");
            if (version.Contains(CurrentVersion))
            {
                MessageBox.Show("You are up to date", "Version Check", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("You need to update to the new version", "Version Check", MessageBoxButtons.OK);
                System.Diagnostics.Process.Start("https://github.com/Wtf-Is-This-x1337/Metaphor-Antivirus");
            }
        }

        private void ToolsBtn_Click(object sender, EventArgs e)
        {
            ScanPage.Visible = false;
            ToolsPage.Visible = true;
            ToolsPage.BringToFront();
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            ScanPage.Visible = false;
            ToolsPage.Visible = true;
            ToolsPage.BringToFront();
            ScanPage.Visible = true;
            ScanPage.BringToFront();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ScanPage.Visible = false;
            ToolsPage.Visible = false;
        }

        // Hash Test
        public static class ChecksumUtil
        {
            public static string GetChecksum(HashingAlgoTypes hashingAlgoType, string filename)
            {
                using (var hasher = System.Security.Cryptography.HashAlgorithm.Create(hashingAlgoType.ToString()))
                {
                    using (var stream = System.IO.File.OpenRead(filename))
                    {
                        var hash = hasher.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "");
                    }
                }
            }

        }
        public enum HashingAlgoTypes
        {
            MD5,
            SHA1,
            SHA256,
            SHA384,
            SHA512
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = false;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                MessageBox.Show("You selected: " + dialog.FileName);
                textBox.Text = ""; // TextBox.Text = Empty String
                textBox.Text = dialog.FileName;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FilePath = textBox.Text;
            if (FilePath != "")
            {
                try
                {
                    Path.GetDirectoryName(FilePath);
                    var md5 = ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, @FilePath);
                    var sha1 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA1, @FilePath);
                    var sha256 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA256, @FilePath);
                    var sha384 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA384, @FilePath);
                    var sha512 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA512, @FilePath);

                    MessageBox.Show("-MD5: " + md5 + "\n-SHA1: " + sha1 + "\n-SHA256: " + sha256 + "\n-SHA384: " + sha384 + "\n-SHA512: " + sha512, "Hash Check", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("File path is incorrect", "Path Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("You forgot to select a path", "Path Error", MessageBoxButtons.OK);
            }
        }

        private void EandDToolsBtn_Click(object sender, EventArgs e)
        {
            // New Form for Encryption and Decryption tools
            EandDForm eandDForm = new EandDForm();
            eandDForm.Show();
        }

        private void WandAV_Click(object sender, EventArgs e)
        {
            WbAndAV wbAndAV = new WbAndAV();
            wbAndAV.Show();
        }

        private void DisableDefenderBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var baseReg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                if (!defenderSwitch)
                {
                    try
                    {
                        // Disable active anti malware
                        using (var key = baseReg.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true))
                        {
                            key.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
                        }
                    }
                    catch (Exception ex)
                    {
                        // later versions of Defender added anti-tamper protection
                        MessageBox.Show("Unable to disable the core Defender active anti malware protection. This is probably caused by its own anti-tamper protection. You'll have to disable Defender using the Defender security app instead.", ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    try
                    {
                        // Delete Defender from startup / tray icons
                        using (var key = baseReg.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
                        {
                            key.DeleteValue("WindowsDefender", false);
                            key.DeleteValue("SecurityHealth", false);
                        }

                        // Unregister Defender shell extension
                        // not really needed anymore as it seems like Defender disables the shell extention by its own now (not sure how) when disabled
                        string defenderPath;

                        if (amd64)
                        {
                            defenderPath = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
                        }
                        else
                        {
                            defenderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                        }

                        defenderPath += @"\Windows Defender\shellext.dll";

                        if (File.Exists(defenderPath))
                        {
                            Helper.RunCommand(@"regsvr32 /u /s """ + defenderPath + "\"");
                        }
                        else
                        {
                        }

                        MessageBox.Show("OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                { // re-enable Defender
                    try
                    {
                        using (var key = baseReg.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true))
                        {
                            key.SetValue("DisableAntiSpyware", 0, RegistryValueKind.DWord);
                        }

                        MessageBox.Show("OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baseReg.Dispose();
            }
            Enabled = true;
        }

        private void LogsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("~SOON~", "LogsBtn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // new panel.visible = true
            // new panels for logs + consoleBox new text box
            // + back menu
        }

        private void CleanupBtn_Click(object sender, EventArgs e)
        {
            CleanupTools cleanupTools = new CleanupTools();
            cleanupTools.Show();
        }

        private void HashChangerBtn_Click(object sender, EventArgs e)
        {
            HashChanger hashchanger = new HashChanger();
            hashchanger.Show();
        }

        private void donatebitch_Click(object sender, EventArgs e)
        {

        }

        private void NetworkBtn_Click(object sender, EventArgs e)
        {
            // https://github.com/ewwink/Network-Bandwidth-Meter
        }

        private void YoutubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC_HV32JteVfGzYMtqkpH7Ng");
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Wtf-Is-This-x1337/Metaphor-Antivirus");
        }

        private void DonationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://duckduckgo.com/");
        }
    }

}
