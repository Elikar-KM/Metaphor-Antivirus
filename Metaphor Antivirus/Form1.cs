using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Metaphor_Antivirus
{

    public partial class Form1 : Form
    {
        static string FilePath = String.Empty;
        // System.Runtime.InteropServices.DllImportAttribute | DllImportAttribute
        private ContextMenu m_menu;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
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
        }

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

            bool info4 = Environment.Is64BitOperatingSystem; // 64 Bit OS
            OsBit.Text = Convert.ToString(info4);

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

        // Return the OS name.
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
            System.Diagnostics.Process.Start("https://github.com/Wtf-Is-This-x1337/Metaphor-Antivirus/releases/");
        }

        private void ToolsBtn_Click(object sender, EventArgs e)
        {
            ToolsPage.Show();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ToolsPage.Hide();
            // ScanPage.Hide();
            // OptionPage.Hide();
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
            try
            {
                Path.GetDirectoryName(FilePath);
                if (FilePath != "")
                {
                    var md5 = ChecksumUtil.GetChecksum(HashingAlgoTypes.MD5, @FilePath);
                    var sha1 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA1, @FilePath);
                    var sha256 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA256, @FilePath);
                    var sha384 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA384, @FilePath);
                    var sha512 = ChecksumUtil.GetChecksum(HashingAlgoTypes.SHA512, @FilePath);

                    MessageBox.Show("MD5: " + md5 + "\nSHA1: " + sha1 + "\nSHA256: " + sha256 + "\nSHA384: " + sha384 + "\nSHA512: " + sha512, "Hash Check", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("File path is incorrect", "Path Error", MessageBoxButtons.OK);
            }
        }
    }

}
