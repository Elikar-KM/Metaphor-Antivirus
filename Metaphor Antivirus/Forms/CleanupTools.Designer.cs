
namespace Metaphor_Antivirus
{
    partial class CleanupTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanupTools));
            this.Credits = new System.Windows.Forms.Label();
            this.tabApps = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.appBox = new System.Windows.Forms.CheckedListBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.AppsBtn = new ns1.BunifuFlatButton();
            this.OneDrive = new ns1.BunifuFlatButton();
            this.RevertBtn = new ns1.BunifuFlatButton();
            this.CleanupContext = new ns1.BunifuFlatButton();
            this.UninstallBtn = new ns1.BunifuFlatButton();
            this.RefreshBtn = new ns1.BunifuFlatButton();
            this.tabApps.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Credits
            // 
            this.Credits.AutoSize = true;
            this.Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Credits.ForeColor = System.Drawing.Color.White;
            this.Credits.Location = new System.Drawing.Point(8, 254);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(230, 18);
            this.Credits.TabIndex = 1;
            this.Credits.Text = "Credits to ElPumpo - Win10Clean";
            // 
            // tabApps
            // 
            this.tabApps.Controls.Add(this.tabHome);
            this.tabApps.Controls.Add(this.tabPage2);
            this.tabApps.Controls.Add(this.tabLogs);
            this.tabApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApps.Location = new System.Drawing.Point(0, 0);
            this.tabApps.Name = "tabApps";
            this.tabApps.SelectedIndex = 0;
            this.tabApps.Size = new System.Drawing.Size(558, 309);
            this.tabApps.TabIndex = 16;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tabHome.Controls.Add(this.Credits);
            this.tabHome.Controls.Add(this.AppsBtn);
            this.tabHome.Controls.Add(this.OneDrive);
            this.tabHome.Controls.Add(this.RevertBtn);
            this.tabHome.Controls.Add(this.CleanupContext);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(550, 283);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tabPage2.Controls.Add(this.appBox);
            this.tabPage2.Controls.Add(this.UninstallBtn);
            this.tabPage2.Controls.Add(this.RefreshBtn);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 283);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Windows 10 native apps";
            // 
            // appBox
            // 
            this.appBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.appBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.appBox.CheckOnClick = true;
            this.appBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.appBox.ForeColor = System.Drawing.Color.White;
            this.appBox.FormattingEnabled = true;
            this.appBox.Location = new System.Drawing.Point(3, 3);
            this.appBox.Margin = new System.Windows.Forms.Padding(2);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(373, 277);
            this.appBox.Sorted = true;
            this.appBox.TabIndex = 18;
            this.appBox.UseCompatibleTextRendering = true;
            this.appBox.SelectedIndexChanged += new System.EventHandler(this.appBox_SelectedIndexChanged);
            // 
            // tabLogs
            // 
            this.tabLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tabLogs.Controls.Add(this.consoleBox);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(550, 283);
            this.tabLogs.TabIndex = 2;
            this.tabLogs.Text = "Logs";
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.consoleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleBox.ForeColor = System.Drawing.Color.White;
            this.consoleBox.Location = new System.Drawing.Point(3, 3);
            this.consoleBox.Margin = new System.Windows.Forms.Padding(2);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ReadOnly = true;
            this.consoleBox.Size = new System.Drawing.Size(544, 277);
            this.consoleBox.TabIndex = 1;
            this.consoleBox.Text = "";
            // 
            // AppsBtn
            // 
            this.AppsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AppsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AppsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AppsBtn.BorderRadius = 0;
            this.AppsBtn.ButtonText = "Don\'t reinstall modern apps";
            this.AppsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.AppsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.AppsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("AppsBtn.Iconimage")));
            this.AppsBtn.Iconimage_right = null;
            this.AppsBtn.Iconimage_right_Selected = null;
            this.AppsBtn.Iconimage_Selected = null;
            this.AppsBtn.IconMarginLeft = 0;
            this.AppsBtn.IconMarginRight = 0;
            this.AppsBtn.IconRightVisible = false;
            this.AppsBtn.IconRightZoom = 0D;
            this.AppsBtn.IconVisible = false;
            this.AppsBtn.IconZoom = 90D;
            this.AppsBtn.IsTab = false;
            this.AppsBtn.Location = new System.Drawing.Point(283, 97);
            this.AppsBtn.Name = "AppsBtn";
            this.AppsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AppsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AppsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.AppsBtn.selected = false;
            this.AppsBtn.Size = new System.Drawing.Size(239, 48);
            this.AppsBtn.TabIndex = 15;
            this.AppsBtn.Text = "Don\'t reinstall modern apps";
            this.AppsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppsBtn.Textcolor = System.Drawing.Color.White;
            this.AppsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.AppsBtn.Click += new System.EventHandler(this.AppsBtn_Click);
            // 
            // OneDrive
            // 
            this.OneDrive.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OneDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OneDrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OneDrive.BorderRadius = 0;
            this.OneDrive.ButtonText = "Uninstall OneDrive";
            this.OneDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OneDrive.DisabledColor = System.Drawing.Color.Gray;
            this.OneDrive.Iconcolor = System.Drawing.Color.Transparent;
            this.OneDrive.Iconimage = ((System.Drawing.Image)(resources.GetObject("OneDrive.Iconimage")));
            this.OneDrive.Iconimage_right = null;
            this.OneDrive.Iconimage_right_Selected = null;
            this.OneDrive.Iconimage_Selected = null;
            this.OneDrive.IconMarginLeft = 0;
            this.OneDrive.IconMarginRight = 0;
            this.OneDrive.IconRightVisible = false;
            this.OneDrive.IconRightZoom = 0D;
            this.OneDrive.IconVisible = false;
            this.OneDrive.IconZoom = 90D;
            this.OneDrive.IsTab = false;
            this.OneDrive.Location = new System.Drawing.Point(283, 27);
            this.OneDrive.Name = "OneDrive";
            this.OneDrive.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OneDrive.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OneDrive.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OneDrive.selected = false;
            this.OneDrive.Size = new System.Drawing.Size(239, 48);
            this.OneDrive.TabIndex = 13;
            this.OneDrive.Text = "Uninstall OneDrive";
            this.OneDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OneDrive.Textcolor = System.Drawing.Color.White;
            this.OneDrive.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.OneDrive.Click += new System.EventHandler(this.OneDrive_Click);
            // 
            // RevertBtn
            // 
            this.RevertBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RevertBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RevertBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RevertBtn.BorderRadius = 0;
            this.RevertBtn.ButtonText = "Revert explorer to win7 style";
            this.RevertBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevertBtn.DisabledColor = System.Drawing.Color.Gray;
            this.RevertBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RevertBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("RevertBtn.Iconimage")));
            this.RevertBtn.Iconimage_right = null;
            this.RevertBtn.Iconimage_right_Selected = null;
            this.RevertBtn.Iconimage_Selected = null;
            this.RevertBtn.IconMarginLeft = 0;
            this.RevertBtn.IconMarginRight = 0;
            this.RevertBtn.IconRightVisible = false;
            this.RevertBtn.IconRightZoom = 0D;
            this.RevertBtn.IconVisible = false;
            this.RevertBtn.IconZoom = 90D;
            this.RevertBtn.IsTab = false;
            this.RevertBtn.Location = new System.Drawing.Point(16, 97);
            this.RevertBtn.Name = "RevertBtn";
            this.RevertBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RevertBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RevertBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RevertBtn.selected = false;
            this.RevertBtn.Size = new System.Drawing.Size(239, 48);
            this.RevertBtn.TabIndex = 14;
            this.RevertBtn.Text = "Revert explorer to win7 style";
            this.RevertBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RevertBtn.Textcolor = System.Drawing.Color.White;
            this.RevertBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.RevertBtn.Click += new System.EventHandler(this.RevertBtn_Click);
            // 
            // CleanupContext
            // 
            this.CleanupContext.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanupContext.BorderRadius = 0;
            this.CleanupContext.ButtonText = "Cleanup context menus";
            this.CleanupContext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanupContext.DisabledColor = System.Drawing.Color.Gray;
            this.CleanupContext.Iconcolor = System.Drawing.Color.Transparent;
            this.CleanupContext.Iconimage = ((System.Drawing.Image)(resources.GetObject("CleanupContext.Iconimage")));
            this.CleanupContext.Iconimage_right = null;
            this.CleanupContext.Iconimage_right_Selected = null;
            this.CleanupContext.Iconimage_Selected = null;
            this.CleanupContext.IconMarginLeft = 0;
            this.CleanupContext.IconMarginRight = 0;
            this.CleanupContext.IconRightVisible = false;
            this.CleanupContext.IconRightZoom = 0D;
            this.CleanupContext.IconVisible = false;
            this.CleanupContext.IconZoom = 90D;
            this.CleanupContext.IsTab = false;
            this.CleanupContext.Location = new System.Drawing.Point(16, 27);
            this.CleanupContext.Name = "CleanupContext";
            this.CleanupContext.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupContext.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupContext.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CleanupContext.selected = false;
            this.CleanupContext.Size = new System.Drawing.Size(239, 48);
            this.CleanupContext.TabIndex = 12;
            this.CleanupContext.Text = "Cleanup context menus";
            this.CleanupContext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CleanupContext.Textcolor = System.Drawing.Color.White;
            this.CleanupContext.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.CleanupContext.Click += new System.EventHandler(this.CleanupContext_Click);
            // 
            // UninstallBtn
            // 
            this.UninstallBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.UninstallBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.UninstallBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UninstallBtn.BorderRadius = 0;
            this.UninstallBtn.ButtonText = "Uninstall";
            this.UninstallBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UninstallBtn.DisabledColor = System.Drawing.Color.Gray;
            this.UninstallBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.UninstallBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("UninstallBtn.Iconimage")));
            this.UninstallBtn.Iconimage_right = null;
            this.UninstallBtn.Iconimage_right_Selected = null;
            this.UninstallBtn.Iconimage_Selected = null;
            this.UninstallBtn.IconMarginLeft = 0;
            this.UninstallBtn.IconMarginRight = 0;
            this.UninstallBtn.IconRightVisible = false;
            this.UninstallBtn.IconRightZoom = 0D;
            this.UninstallBtn.IconVisible = false;
            this.UninstallBtn.IconZoom = 90D;
            this.UninstallBtn.IsTab = false;
            this.UninstallBtn.Location = new System.Drawing.Point(421, 141);
            this.UninstallBtn.Name = "UninstallBtn";
            this.UninstallBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.UninstallBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.UninstallBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.UninstallBtn.selected = false;
            this.UninstallBtn.Size = new System.Drawing.Size(111, 38);
            this.UninstallBtn.TabIndex = 17;
            this.UninstallBtn.Text = "Uninstall";
            this.UninstallBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UninstallBtn.Textcolor = System.Drawing.Color.White;
            this.UninstallBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.UninstallBtn.Click += new System.EventHandler(this.UninstallBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.BorderRadius = 0;
            this.RefreshBtn.ButtonText = "Refresh";
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.DisabledColor = System.Drawing.Color.Gray;
            this.RefreshBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RefreshBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Iconimage")));
            this.RefreshBtn.Iconimage_right = null;
            this.RefreshBtn.Iconimage_right_Selected = null;
            this.RefreshBtn.Iconimage_Selected = null;
            this.RefreshBtn.IconMarginLeft = 0;
            this.RefreshBtn.IconMarginRight = 0;
            this.RefreshBtn.IconRightVisible = false;
            this.RefreshBtn.IconRightZoom = 0D;
            this.RefreshBtn.IconVisible = false;
            this.RefreshBtn.IconZoom = 90D;
            this.RefreshBtn.IsTab = false;
            this.RefreshBtn.Location = new System.Drawing.Point(421, 71);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RefreshBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RefreshBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RefreshBtn.selected = false;
            this.RefreshBtn.Size = new System.Drawing.Size(111, 38);
            this.RefreshBtn.TabIndex = 16;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshBtn.Textcolor = System.Drawing.Color.White;
            this.RefreshBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CleanupTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(558, 309);
            this.Controls.Add(this.tabApps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CleanupTools";
            this.ShowIcon = false;
            this.Text = "Windows Cleanup Tools";
            this.Load += new System.EventHandler(this.CleanupTools_Load);
            this.tabApps.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Credits;
        private ns1.BunifuFlatButton CleanupContext;
        private ns1.BunifuFlatButton OneDrive;
        private ns1.BunifuFlatButton RevertBtn;
        private ns1.BunifuFlatButton AppsBtn;
        private System.Windows.Forms.TabControl tabApps;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabLogs;
        private ns1.BunifuFlatButton UninstallBtn;
        private ns1.BunifuFlatButton RefreshBtn;
        private System.Windows.Forms.CheckedListBox appBox;
        private System.Windows.Forms.RichTextBox consoleBox;
    }
}