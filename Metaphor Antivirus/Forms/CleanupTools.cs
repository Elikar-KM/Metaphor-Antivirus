﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections.Generic;
using Metaphor_Antivirus.Registry;
using System.Threading;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;

namespace Metaphor_Antivirus
{
    public partial class CleanupTools : Form
    {

        Dictionary<string, string> appDirectory = new Dictionary<string, string>();
        bool amd64 = Environment.Is64BitOperatingSystem;

        /* Metro related */
        List<string> uninstallSuccessList = new List<string>();
        List<string> uninstallFailedList = new List<string>();

        public CleanupTools()
        {
            InitializeComponent();
        }


        private void CleanupTools_Load(object sender, EventArgs e)
        {

        }

        private void CleanupContext_Click(object sender, EventArgs e)
        {
            Enabled = false;

            // Provided by http://fragme.bLogspot.se/2007/07/windows-tip-18-remove-unnecessary-right.html
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var baseReg = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
                string[] extensions = {
                    "batfile",
                    "cmdfile",
                    "docfile",
                    "fonfile",
                    "htmlfile",
                    "inffile",
                    "inifile",
                    "JSEFile",
                    "JSFile",
                    "MSInfo.Document",
                    "otffile",
                    "pfmfile",
                    "regfile",
                    "rtffile",
                    "ttcfile",
                    "ttffile",
                    "txtfile",
                    "VBEFile",
                    "VBSFile",
                    "Wordpad.Document.1",
                    "WSFFile"
                };

                // Disable print
                foreach (string ext in extensions)
                {
                    try
                    {
                        string finalKey = ext + @"\shell\print";
                        using (var key = baseReg.OpenSubKey(finalKey, true))
                        {
                            key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                            Log("Print disabled for: " + ext);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log(ex.GetType().ToString() + " - couldn't disable print for: " + ext);
                        // Ignore errors
                    }
                }

                // Disable edit
                foreach (string ext in extensions)
                {
                    try
                    {
                        string finalKey = ext + @"\shell\edit";
                        using (var key = baseReg.OpenSubKey(finalKey, true))
                        {
                            key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                            Log("Edit disabled for: " + ext);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log(ex.GetType().ToString() + " - couldn't disable edit for: " + ext);
                        // Ignore errors
                    }
                }

                // Extra things
                try
                {
                    // Manual fix for txt
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\text\shell\edit", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Edit disabled for: TXT files");
                    }

                    // WMP #1 - add to list
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\audio\shell\Enqueue", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Disabled add to play list for: audio files!");
                    }

                    // WMP #2 - play
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\audio\shell\Play", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Disabled play song for: audio files!");
                    }

                    // WMP #3 - add to list (audio folder)
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\Directory.Audio\shell\Enqueue", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Disabled add to play list for: audio directories!");
                    }

                    // WMP #4 - play (audio folder)
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\Directory.Audio\shell\Play", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Disabled play song for: audio directories!");
                    }

                    // WMP #5 - add to list (image folder?!)
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\Directory.Image\shell\Enqueue", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Disabled add to play list for: image directories!");
                    }

                    // WMP #6 - play (image folder?!)
                    using (var key = baseReg.OpenSubKey(@"SystemFileAssociations\Directory.Image\shell\Play", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty, RegistryValueKind.String);
                        Log("Disabled play song for: image directories!");
                    }

                    // Include in library context
                    using (var key = baseReg.OpenSubKey(@"Folder\shellex\ContextMenuHandlers\Library Location", true))
                    {
                        key.SetValue(string.Empty, "-{3dad6c5d-2167-4cae-9914-f99e41c12cfa}");
                        Log("Disabled include in library menu!");
                    }

                    // Troubleshoot compability EXE
                    using (var key = baseReg.OpenSubKey(@"exefile\shellex\ContextMenuHandlers\Compatibility", true))
                    {
                        key.SetValue(string.Empty, "-{1d27f844-3a1f-4410-85ac-14651078412d}");
                        Log("Disabled troubleshooting compability (EXE)!");
                    }

                    // Troubleshoot compability MSI
                    using (var key = baseReg.OpenSubKey(@"Msi.Package\shellex\ContextMenuHandlers\Compatibility", true))
                    {
                        key.SetValue(string.Empty, "-{1d27f844-3a1f-4410-85ac-14651078412d}");
                        Log("Disabled troubleshooting compability (MSI)!");
                    }

                    // Disable printing .url files
                    var registryUtil = new RegistryUtilities();
                    registryUtil.TakeOwnership(@"InternetShortcut\shell\print", RegistryHive.ClassesRoot);
                    using (var key = baseReg.OpenSubKey(@"InternetShortcut\shell\print", true))
                    {
                        key.SetValue("LegacyDisable", string.Empty);
                        Log("Disabled print for: InternetShortcut!");
                    }

                    // Restore previous version (file)
                    baseReg.DeleteSubKey(@"AllFilesystemObjects\shellex\ContextMenuHandlers\{596AB062-B4D2-4215-9F74-E9109B0A8153}", false);
                    Log("Removed restoring previous version menu! (files)");

                    // Restore previous version (directory)
                    baseReg.DeleteSubKey(@"Directory\shellex\ContextMenuHandlers\{596AB062-B4D2-4215-9F74-E9109B0A8153}", false);
                    Log("Removed restoring previous version menu! (directories)");

                    // Manual fix for .java
                    baseReg.DeleteSubKeyTree(".java", false);
                    Log("Edit disabled for: JAVA files");

                    // https://superuser.com/a/808730
                    // Pin to Start on recycle bin
                    bool skip = false;
                    using (var key = baseReg.OpenSubKey(@"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty"))
                    {
                        if (key == null) skip = true;
                    }

                    // Do we really need to do this?
                    if (!skip)
                    {
                        // Take ownership of the keys
                        registryUtil.TakeOwnership(@"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}", RegistryHive.ClassesRoot);
                        registryUtil.TakeOwnership(@"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell", RegistryHive.ClassesRoot);
                        registryUtil.TakeOwnership(@"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty", RegistryHive.ClassesRoot);
                        registryUtil.TakeOwnership(@"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty\command", RegistryHive.ClassesRoot);

                        registryUtil.RenameSubKey(baseReg, @"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\empty", @"CLSID\{645FF040-5081-101B-9F08-00AA002F954E}\shell\pintostartscreen");
                        Log("Disabled Pin to Start for: Recycle Bin!");
                    }

                    // Disable modern share
                    using (var key = baseReg.OpenSubKey(@"*\shellex\ContextMenuHandlers\ModernSharing", true))
                    {
                        key.SetValue(string.Empty, "-{1d27f844-3a1f-4410-85ac-14651078412d}");
                        Log("Disabled modern share!");
                    }

                    // Disable share menu
                    baseReg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                    string regKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Shell Extensions\Blocked";
                    baseReg.CreateSubKey(regKey); // doesn't exist as default, normal behaviour
                    using (var key = baseReg.OpenSubKey(regKey, true))
                    {
                        key.SetValue("{f81e9010-6ea4-11ce-a7ff-00aa003ca9f6}", string.Empty);
                        Log("Disabled (old) share!");
                    }
                }
                catch (Exception ex)
                {
                    Log(ex.ToString());
                    // Ignore errors
                }

                baseReg.Dispose();

                MessageBox.Show("OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Enabled = true;
        }

        private void OneDrive_Click(object sender, EventArgs e)
        {
            /*
            Enabled = false;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string processName = "OneDrive";
                int byteArray = BitConverter.ToInt32(BitConverter.GetBytes(0xb090010d), 0);
                string onePath;

                try
                {
                    Process.GetProcessesByName(processName)[0].Kill();
                }
                catch (Exception)
                { // Throws IndexOutOfRangeException
                    Log("Could not kill process: " + processName);
                    // ignore errors
                }

                if (amd64)
                {
                    onePath = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "\\OneDriveSetup.exe";
                }
                else
                {
                    onePath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\OneDriveSetup.exe";
                }

                try
                {
                    Process.Start(onePath, "/uninstall");
                    Log("Uninstalled OneDrive using the setup!");
                }
                catch (Exception ex)
                {
                    Log(ex.ToString());
                }

                // All the folders to be deleted
                string[] onePaths = {
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\OneDrive",
                    Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "OneDriveTemp",
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\OneDrive",
                    Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Microsoft OneDrive"
                };

                foreach (string dir in onePaths)
                {
                    if (Directory.Exists(dir))
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                            Log("Folder deleted: " + dir);
                        }
                        catch (Exception)
                        {
                            Log("Could not delete folder: " + dir);
                            // ignore errors
                        }
                    }
                }

                // Remove OneDrive from Explorer
                string oneKey = @"CLSID\{018D5C66-4533-4307-9B53-224DE2ED1FE6}";
                Registry.ClassesRoot.CreateSubKey(oneKey);

                var baseReg = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
                try
                {
                    // Remove from the Explorer file diaLog
                    using (var key = Registry.ClassesRoot.OpenSubKey(oneKey, true))
                    {
                        key.SetValue("System.IsPinnedToNameSpaceTree", 0, RegistryValueKind.DWord);
                        Log("OneDrive removed from Explorer (FileDiaLog)!");
                    }

                    // amd64 system fix
                    if (amd64)
                    {
                        using (var key = baseReg.OpenSubKey(oneKey, true))
                        {
                            if (key != null)
                            { // removed in latest Windows installs
                                key.SetValue("System.IsPinnedToNameSpaceTree", 0, RegistryValueKind.DWord);
                                Log("OneDrive removed from Explorer (FileDiaLog, amd64)!");
                            }
                        }
                    }

                    // Remove from the alternative file diaLog (legacy)
                    using (var key = Registry.ClassesRoot.OpenSubKey(oneKey + "\\ShellFolder", true))
                    {
                        if (key != null)
                        { // removed in latest Windows installs
                            key.SetValue("Attributes", byteArray, RegistryValueKind.DWord);
                            Log("OneDrive removed from Explorer (Legacy FileDiaLog)!");
                        }
                    }

                    // amd64 system fix
                    if (amd64)
                    {
                        using (var key = baseReg.OpenSubKey(oneKey + "\\ShellFolder", true))
                        {
                            if (key != null)
                            { // removed in latest Windows installs
                                key.SetValue("Attributes", byteArray, RegistryValueKind.DWord);
                                Log("OneDrive removed from Explorer (Legacy FileDiaLog, amd64)!");
                            }
                        }
                    }

                    baseReg = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                    // Remove the startup
                    using (var key = baseReg.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                    {
                        key.DeleteValue("OneDriveSetup", false);
                        Log("Removed startup object!");
                    }
                }
                catch (Exception ex)
                {
                    Log(ex.ToString());
                    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baseReg.Dispose();

                // Delete scheduled leftovers
                Helper.RunCommand(@"SCHTASKS /Delete /TN ""OneDrive Standalone Update Task"" /F");
                Helper.RunCommand(@"SCHTASKS /Delete /TN ""OneDrive Standalone Update Task v2"" /F");
                Log("OneDrive scheduled tasks deleted!");

                MessageBox.Show("OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Enabled = true;
            */
        }



        void check()
        {
            // various checks
            try
            {
                /*
                // check defender state
                using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", false))
                {
                    if ((int)key.GetValue("DisableAntiSpyware", 0) == 1)
                    {
                        defenderSwitch = true;
                        btnDefender.Text = "Enable Windows Defender";
                    }
                }
                */

                /*
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", false))
                {
                    if ((int)key.GetValue("SilentInstalledAppsEnabled", 1) == 0)
                    {
                        btnApps.Enabled = false; // "don't reinstall modern apps"
                    }
                    if ((int)key.GetValue("SubscribedContent-338388Enabled", 1) == 0)
                    {
                        btnStartAds.Enabled = false; // ads on start menu
                    }
                }
                */

            }
            catch { }
        }

        private void RevertBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string libKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions\";
                string finalKey;
                var baseReg = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64); // we don't want Wow6432Node

                string[] guidArray = {
                    "{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}", // Desktop
                    "{7d83ee9b-2244-4e70-b1f5-5393042af1e4}", // Downloads
                    "{f42ee2d3-909f-4907-8871-4c22fc0bf756}", // Documents
                    "{0ddd015d-b06c-45d5-8c4c-f59713854639}", // Pictures
                    "{a0c69a99-21c8-4671-8703-7934162fcf1d}", // Music
                    "{35286a68-3c57-41a1-bbb1-0eae73d76c95}", // Videos
                    "{31C0DD25-9439-4F12-BF41-7FF4EDA38722}"  // 3D builder
                };


                // Disable bing search
                using (var key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer", true))
                {
                    key.SetValue("DisableSearchBoxSuggestions", 1, RegistryValueKind.DWord);
                    Log("Disabled bing search in explorer search");
                }

                // Get rid of libary folders in My PC
                foreach (var guid in guidArray)
                {
                    try
                    {
                        finalKey = libKey + guid + @"\PropertyBag";
                        using (var key = baseReg.CreateSubKey(finalKey, true))
                        {
                            key.SetValue("ThisPCPolicy", "Hide");
                            Log(string.Format("Value of {0} modified", guid));
                        }

                        // amd64 fix
                        if (amd64)
                        {
                            using (var key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(finalKey))
                            {
                                key.SetValue("ThisPCPolicy", "Hide");
                                Log(string.Format("Value of {0} modified (amd64)", guid));
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log(ex.ToString());
                        MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baseReg = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                //byte[] bytes = { 002, 000, 000, 000, 013, 214, 247, 023, 109, 251, 211, 001, 000, 000, 000, 000, 067, 066, 001, 000, 203, 050, 010, 002, 005, 134, 145, 204, 147, 005, 036, 170, 163, 001, 068, 195, 132, 001, 102, 159, 247, 157, 177, 135, 203, 209, 172, 212, 001, 000, 005, 188, 201, 168, 164, 001, 036, 140, 172, 003, 068, 137, 133, 001, 102, 160, 129, 186, 203, 189, 215, 168, 164, 130, 001, 000, 194, 060, 001, 194, 070, 001, 197, 090, 001, 000 };

                try
                {
                    // Pin libary folders
                    string pinLib = @"Software\Classes\CLSID\{031E4825-7B94-4dc3-B131-E946B44C8DD5}";
                    baseReg.CreateSubKey(pinLib); // doesn't exist as default, normal behaviour
                    using (var key = baseReg.OpenSubKey(pinLib, true))
                    {
                        key.SetValue("System.IsPinnedToNameSpaceTree", 1, RegistryValueKind.DWord);
                        Log("Pinned the libary folders in Explorer!");
                    }

                    // Stop quick access from filling up with folders and files
                    using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true))
                    {
                        key.SetValue("ShowFrequent", 0, RegistryValueKind.DWord); // folders
                        key.SetValue("ShowRecent", 0, RegistryValueKind.DWord);   // files
                        Log("Disabled quick access filling up!");
                    }

                    // Make explorer open 'My PC' by default
                    using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true))
                    {
                        key.SetValue("LaunchTo", 1, RegistryValueKind.DWord);
                        Log("Open explorer to: This PC!");
                    }

                    // Add explorer to start menu
                    /**
                    pinLib = @"Software\Microsoft\Windows\CurrentVersion\CloudStore\Store\Cache\DefaultAccount\$de${9b6fe347-cb90-4fab-9629-3423e95b842d}$$windows.data.unifiedtile.startglobalproperties\Current";
                    baseReg.CreateSubKey(pinLib); // doesn't exist as default, normal behaviour
                    using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(pinLib, true)) {
                        key.SetValue("Data", bytes, RegistryValueKind.Binary);
                        Log("File Explorer from Start Menu enabled!");
                    }
                    **/

                    // Hide OneDrive popup in Explorer
                    using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true))
                    {
                        key.SetValue("ShowSyncProviderNotifications", 0, RegistryValueKind.DWord);
                        Log("Hide OneDrive popup in Explorer!");
                    }

                    // Hide My People in taskbar
                    pinLib = @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\People";
                    Microsoft.Win32.Registry.CurrentUser.CreateSubKey(pinLib); // doesn't exist as default, normal behaviour
                    using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(pinLib, true))
                    {
                        key.SetValue("PeopleBand", 0, RegistryValueKind.DWord);
                        Log("Hide My People from taskbar");
                    }
                }
                catch (Exception ex)
                {
                    Log(ex.ToString());
                    MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baseReg.Dispose();
                RestartExplorer();
                MessageBox.Show("OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Enabled = true;
        }

        private void RestartExplorer()
        {
            Process[] explorerProcess = Process.GetProcessesByName("explorer");
            foreach (var process in explorerProcess)
            {
                process.Kill();
            }
        }

        private void AppsBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager", true))
                    {
                        key.SetValue("SilentInstalledAppsEnabled", 0, RegistryValueKind.DWord);
                    }

                    Log("Silent Modern App install disabled");
                    MessageBox.Show("OK!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppsBtn.Enabled = false;
                }
                catch (Exception ex)
                {
                    Log(ex.ToString());
                    MessageBox.Show(ex.ToString(), ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            RefreshAppList(false);
            Enabled = true;
        }

        private void UninstallBtn_Click(object sender, EventArgs e)
        {
            Enabled = false;
            string selectedApps = string.Empty;
            string successList = string.Empty;
            string failedList = string.Empty;

            uninstallSuccessList.Clear();
            uninstallFailedList.Clear();

            // Displays all the apps to be uninstalled
            if (appBox.CheckedItems.Count > 0)
            {
                foreach (string app in appBox.CheckedItems)
                {
                    selectedApps += app + Environment.NewLine;
                }

                if (MessageBox.Show("Are you sure you want to uninstall the following app(s)?" + Environment.NewLine + selectedApps, "Confirm uninstall", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    foreach (string packageName in appBox.CheckedItems)
                    {
                        UninstallApp(packageName);
                    }

                    RefreshAppList(true); // refresh list when we're done

                    foreach (var str in uninstallSuccessList)
                    {
                        successList += str + Environment.NewLine;
                    }

                    foreach (var str in uninstallFailedList)
                    {
                        failedList += str + Environment.NewLine;
                    }

                    // Construct message
                    string message = string.Format("App uninstall finished! Of the {0} total app(s), {1} has been uninstalled.",
                        uninstallSuccessList.Count + uninstallFailedList.Count, uninstallSuccessList.Count) + Environment.NewLine + Environment.NewLine;

                    if (uninstallSuccessList.Count != 0)
                    {
                        message += "Successfully uninstalled:" + Environment.NewLine + successList;
                    }

                    if (uninstallFailedList.Count != 0)
                    {
                        message += "Failed uninstall:" + Environment.NewLine + failedList;
                    }

                    MessageBox.Show(message, "Win10Clean", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You haven't selected anything!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Enabled = true;
        }

        private void RetrieveApps(bool reset = false)
        {
            if (reset)
            {
                appBox.Items.Clear();
                appDirectory.Clear();
            }

            /*
            var packageManager = new PackageManager();
            var packages = packageManager.FindPackagesForUserWithPackageTypes(string.Empty, PackageTypes.Main);

            foreach (var package in packages)
            {
                if (!appDirectory.ContainsKey(package.Id.Name))
                {
                    appDirectory.Add(package.Id.Name, package.Id.FullName);
                    appBox.Items.Add(package.Id.Name);
                }
            }
            */
        }

        private void RefreshAppList(bool minusOne)
        {
            RetrieveApps(true);

            if (minusOne)
            {
                try
                {
                    appBox.SelectedIndex = -1;
                }
                catch { }
            }
        }

        private void UninstallApp(string packageName)
        {
            var packageFullName = appDirectory[packageName];
            //var packageManager = new PackageManager();
            var opCompletedEvent = new ManualResetEvent(false);
            //var deploymentOperation = packageManager.RemovePackageAsync(packageFullName);

            //deploymentOperation.Completed = (depProgress, status) => { opCompletedEvent.Set(); };
            opCompletedEvent.WaitOne();

            //if (deploymentOperation.Status == AsyncStatus.Completed)
            //{
            //    uninstallSuccessList.Add(packageFullName);
            //    Log($"App successfully uninstalled '{packageFullName}'");
            //}
            //else
            //{
            //    uninstallFailedList.Add(packageFullName);
            //    Log($"Error uninstalling app '{packageFullName}', {deploymentOperation.ErrorCode}");
            //}

            appDirectory.Remove(packageName);
        }

        private void appBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabHome_Click(object sender, EventArgs e)
        {

        }

        public void Log(string msg)
        {
            if (!string.IsNullOrEmpty(msg))
            {
                try
                {
                    consoleBox.Text += msg + Environment.NewLine;
                }
                catch (Exception)
                {
                    try
                    {
                        consoleBox.Text += msg + Environment.NewLine;
                    }
                    catch { }
                }

            }
        }
    }
}
