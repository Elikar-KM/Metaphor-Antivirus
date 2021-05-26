
namespace Metaphor_Antivirus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Page2 = new System.Windows.Forms.Panel();
            this.OptionsBtn = new ns1.BunifuFlatButton();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.ScanBtn = new ns1.BunifuFlatButton();
            this.ToolsBtn = new ns1.BunifuFlatButton();
            this.DashboardBtn = new ns1.BunifuFlatButton();
            this.IconImage = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ComputerNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.VersionLbl = new System.Windows.Forms.Label();
            this.OSLbl = new System.Windows.Forms.Label();
            this.ComputerName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.TextVersion = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.BitOsLbl = new System.Windows.Forms.Label();
            this.OsBit = new System.Windows.Forms.Label();
            this.BitProcessLbl = new System.Windows.Forms.Label();
            this.ProcessBit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OsPlatform = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ToolsPage = new ns1.BunifuGradientPanel();
            this.ScanPage = new ns1.BunifuGradientPanel();
            this.Givemeyourmoney = new ns1.BunifuGradientPanel();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.DonationLink = new System.Windows.Forms.LinkLabel();
            this.YoutubeLink = new System.Windows.Forms.LinkLabel();
            this.Info = new System.Windows.Forms.Label();
            this.donatebitch = new System.Windows.Forms.Label();
            this.StateTile = new ns1.BunifuTileButton();
            this.StateLbl = new System.Windows.Forms.Label();
            this.NetworkBtn = new ns1.BunifuTileButton();
            this.RegistryBtn = new ns1.BunifuTileButton();
            this.ReportsBtn = new ns1.BunifuTileButton();
            this.ScannerBtn = new ns1.BunifuTileButton();
            this.label10 = new System.Windows.Forms.Label();
            this.HashChangerBtn = new ns1.BunifuFlatButton();
            this.LogsBtn = new ns1.BunifuFlatButton();
            this.label9 = new System.Windows.Forms.Label();
            this.DisableDefenderBtn = new ns1.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CleanupBtn = new ns1.BunifuFlatButton();
            this.InfoWbandAv = new System.Windows.Forms.Label();
            this.WandAV = new ns1.BunifuFlatButton();
            this.InfoEandDTools = new System.Windows.Forms.Label();
            this.EandDToolsBtn = new ns1.BunifuFlatButton();
            this.bunifuFlatButton2 = new ns1.BunifuFlatButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.processesBtn = new ns1.BunifuFlatButton();
            this.usageBtn = new ns1.BunifuFlatButton();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.ToolsPage.SuspendLayout();
            this.ScanPage.SuspendLayout();
            this.Givemeyourmoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Metaphor Antivirus";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LeftPanel.Controls.Add(this.Page2);
            this.LeftPanel.Controls.Add(this.OptionsBtn);
            this.LeftPanel.Controls.Add(this.UpdateBtn);
            this.LeftPanel.Controls.Add(this.Version);
            this.LeftPanel.Controls.Add(this.ScanBtn);
            this.LeftPanel.Controls.Add(this.ToolsBtn);
            this.LeftPanel.Controls.Add(this.DashboardBtn);
            this.LeftPanel.Controls.Add(this.IconImage);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 43);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(207, 493);
            this.LeftPanel.TabIndex = 3;
            // 
            // Page2
            // 
            this.Page2.Location = new System.Drawing.Point(207, 0);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(696, 493);
            this.Page2.TabIndex = 0;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OptionsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OptionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsBtn.BorderRadius = 0;
            this.OptionsBtn.ButtonText = "Options";
            this.OptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.OptionsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OptionsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("OptionsBtn.Iconimage")));
            this.OptionsBtn.Iconimage_right = null;
            this.OptionsBtn.Iconimage_right_Selected = null;
            this.OptionsBtn.Iconimage_Selected = null;
            this.OptionsBtn.IconMarginLeft = 0;
            this.OptionsBtn.IconMarginRight = 0;
            this.OptionsBtn.IconRightVisible = true;
            this.OptionsBtn.IconRightZoom = 0D;
            this.OptionsBtn.IconVisible = true;
            this.OptionsBtn.IconZoom = 90D;
            this.OptionsBtn.IsTab = true;
            this.OptionsBtn.Location = new System.Drawing.Point(0, 341);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OptionsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OptionsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OptionsBtn.selected = false;
            this.OptionsBtn.Size = new System.Drawing.Size(209, 48);
            this.OptionsBtn.TabIndex = 8;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsBtn.Textcolor = System.Drawing.Color.White;
            this.OptionsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.Location = new System.Drawing.Point(46, 451);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(76, 32);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = " Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Version.ForeColor = System.Drawing.SystemColors.Control;
            this.Version.Location = new System.Drawing.Point(55, 430);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(64, 18);
            this.Version.TabIndex = 6;
            this.Version.Text = "4/5/2021";
            // 
            // ScanBtn
            // 
            this.ScanBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScanBtn.BorderRadius = 0;
            this.ScanBtn.ButtonText = "Scan";
            this.ScanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScanBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ScanBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ScanBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ScanBtn.Iconimage")));
            this.ScanBtn.Iconimage_right = null;
            this.ScanBtn.Iconimage_right_Selected = null;
            this.ScanBtn.Iconimage_Selected = null;
            this.ScanBtn.IconMarginLeft = 0;
            this.ScanBtn.IconMarginRight = 0;
            this.ScanBtn.IconRightVisible = true;
            this.ScanBtn.IconRightZoom = 0D;
            this.ScanBtn.IconVisible = true;
            this.ScanBtn.IconZoom = 90D;
            this.ScanBtn.IsTab = true;
            this.ScanBtn.Location = new System.Drawing.Point(0, 284);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScanBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScanBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ScanBtn.selected = false;
            this.ScanBtn.Size = new System.Drawing.Size(209, 48);
            this.ScanBtn.TabIndex = 5;
            this.ScanBtn.Text = "Scan";
            this.ScanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScanBtn.Textcolor = System.Drawing.Color.White;
            this.ScanBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // ToolsBtn
            // 
            this.ToolsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ToolsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ToolsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsBtn.BorderRadius = 0;
            this.ToolsBtn.ButtonText = "Tools";
            this.ToolsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ToolsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ToolsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ToolsBtn.Iconimage")));
            this.ToolsBtn.Iconimage_right = null;
            this.ToolsBtn.Iconimage_right_Selected = null;
            this.ToolsBtn.Iconimage_Selected = null;
            this.ToolsBtn.IconMarginLeft = 0;
            this.ToolsBtn.IconMarginRight = 0;
            this.ToolsBtn.IconRightVisible = true;
            this.ToolsBtn.IconRightZoom = 0D;
            this.ToolsBtn.IconVisible = true;
            this.ToolsBtn.IconZoom = 90D;
            this.ToolsBtn.IsTab = true;
            this.ToolsBtn.Location = new System.Drawing.Point(0, 227);
            this.ToolsBtn.Name = "ToolsBtn";
            this.ToolsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ToolsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ToolsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ToolsBtn.selected = false;
            this.ToolsBtn.Size = new System.Drawing.Size(209, 48);
            this.ToolsBtn.TabIndex = 4;
            this.ToolsBtn.Text = "Tools";
            this.ToolsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolsBtn.Textcolor = System.Drawing.Color.White;
            this.ToolsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsBtn.Click += new System.EventHandler(this.ToolsBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardBtn.BorderRadius = 0;
            this.DashboardBtn.ButtonText = "Dashboard";
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.Iconimage")));
            this.DashboardBtn.Iconimage_right = null;
            this.DashboardBtn.Iconimage_right_Selected = null;
            this.DashboardBtn.Iconimage_Selected = null;
            this.DashboardBtn.IconMarginLeft = 0;
            this.DashboardBtn.IconMarginRight = 0;
            this.DashboardBtn.IconRightVisible = true;
            this.DashboardBtn.IconRightZoom = 0D;
            this.DashboardBtn.IconVisible = true;
            this.DashboardBtn.IconZoom = 90D;
            this.DashboardBtn.IsTab = true;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 170);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DashboardBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DashboardBtn.selected = true;
            this.DashboardBtn.Size = new System.Drawing.Size(209, 48);
            this.DashboardBtn.TabIndex = 3;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Textcolor = System.Drawing.Color.White;
            this.DashboardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // IconImage
            // 
            this.IconImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconImage.BackgroundImage")));
            this.IconImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconImage.Location = new System.Drawing.Point(16, 9);
            this.IconImage.Name = "IconImage";
            this.IconImage.Size = new System.Drawing.Size(174, 151);
            this.IconImage.TabIndex = 2;
            this.IconImage.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.MinBtn);
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(903, 43);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metaphor Antivirus - Github";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.MinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MinBtn.Location = new System.Drawing.Point(811, 3);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(38, 38);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Location = new System.Drawing.Point(860, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(38, 38);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ComputerNameLbl
            // 
            this.ComputerNameLbl.AutoSize = true;
            this.ComputerNameLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.ComputerNameLbl.ForeColor = System.Drawing.Color.White;
            this.ComputerNameLbl.Location = new System.Drawing.Point(225, 95);
            this.ComputerNameLbl.Name = "ComputerNameLbl";
            this.ComputerNameLbl.Size = new System.Drawing.Size(179, 21);
            this.ComputerNameLbl.TabIndex = 7;
            this.ComputerNameLbl.Text = "- Computer name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "System Information";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(225, 125);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(119, 21);
            this.usernameLbl.TabIndex = 9;
            this.usernameLbl.Text = "- Username: ";
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.VersionLbl.ForeColor = System.Drawing.Color.White;
            this.VersionLbl.Location = new System.Drawing.Point(225, 155);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(96, 21);
            this.VersionLbl.TabIndex = 10;
            this.VersionLbl.Text = "- Version: ";
            // 
            // OSLbl
            // 
            this.OSLbl.AutoSize = true;
            this.OSLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OSLbl.ForeColor = System.Drawing.Color.White;
            this.OSLbl.Location = new System.Drawing.Point(225, 185);
            this.OSLbl.Name = "OSLbl";
            this.OSLbl.Size = new System.Drawing.Size(189, 21);
            this.OSLbl.TabIndex = 11;
            this.OSLbl.Text = "- Operating System: ";
            // 
            // ComputerName
            // 
            this.ComputerName.AutoSize = true;
            this.ComputerName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.ComputerName.ForeColor = System.Drawing.Color.White;
            this.ComputerName.Location = new System.Drawing.Point(410, 95);
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Size = new System.Drawing.Size(160, 21);
            this.ComputerName.TabIndex = 12;
            this.ComputerName.Text = "Computer Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(350, 125);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(98, 21);
            this.Username.TabIndex = 13;
            this.Username.Text = "Username";
            // 
            // TextVersion
            // 
            this.TextVersion.AutoSize = true;
            this.TextVersion.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.TextVersion.ForeColor = System.Drawing.Color.White;
            this.TextVersion.Location = new System.Drawing.Point(327, 155);
            this.TextVersion.Name = "TextVersion";
            this.TextVersion.Size = new System.Drawing.Size(75, 21);
            this.TextVersion.TabIndex = 14;
            this.TextVersion.Text = "Version";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OS.ForeColor = System.Drawing.Color.White;
            this.OS.Location = new System.Drawing.Point(420, 185);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(35, 21);
            this.OS.TabIndex = 15;
            this.OS.Text = "OS";
            // 
            // BitOsLbl
            // 
            this.BitOsLbl.AutoSize = true;
            this.BitOsLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.BitOsLbl.ForeColor = System.Drawing.Color.White;
            this.BitOsLbl.Location = new System.Drawing.Point(225, 215);
            this.BitOsLbl.Name = "BitOsLbl";
            this.BitOsLbl.Size = new System.Drawing.Size(101, 21);
            this.BitOsLbl.TabIndex = 16;
            this.BitOsLbl.Text = "- 64 Bit OS:";
            // 
            // OsBit
            // 
            this.OsBit.AutoSize = true;
            this.OsBit.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OsBit.ForeColor = System.Drawing.Color.White;
            this.OsBit.Location = new System.Drawing.Point(332, 215);
            this.OsBit.Name = "OsBit";
            this.OsBit.Size = new System.Drawing.Size(46, 21);
            this.OsBit.TabIndex = 17;
            this.OsBit.Text = "True";
            // 
            // BitProcessLbl
            // 
            this.BitProcessLbl.AutoSize = true;
            this.BitProcessLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.BitProcessLbl.ForeColor = System.Drawing.Color.White;
            this.BitProcessLbl.Location = new System.Drawing.Point(226, 245);
            this.BitProcessLbl.Name = "BitProcessLbl";
            this.BitProcessLbl.Size = new System.Drawing.Size(142, 21);
            this.BitProcessLbl.TabIndex = 18;
            this.BitProcessLbl.Text = "- 64 Bit Process:";
            // 
            // ProcessBit
            // 
            this.ProcessBit.AutoSize = true;
            this.ProcessBit.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.ProcessBit.ForeColor = System.Drawing.Color.White;
            this.ProcessBit.Location = new System.Drawing.Point(374, 245);
            this.ProcessBit.Name = "ProcessBit";
            this.ProcessBit.Size = new System.Drawing.Size(46, 21);
            this.ProcessBit.TabIndex = 19;
            this.ProcessBit.Text = "True";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(226, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "- OS Platform:";
            // 
            // OsPlatform
            // 
            this.OsPlatform.AutoSize = true;
            this.OsPlatform.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OsPlatform.ForeColor = System.Drawing.Color.White;
            this.OsPlatform.Location = new System.Drawing.Point(361, 275);
            this.OsPlatform.Name = "OsPlatform";
            this.OsPlatform.Size = new System.Drawing.Size(113, 21);
            this.OsPlatform.TabIndex = 21;
            this.OsPlatform.Text = "OS Platform";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(227, 81);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(219, 10);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(227, 341);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(199, 10);
            this.bunifuSeparator2.TabIndex = 24;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(224, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "About Metaphor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(223, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(454, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Metaphor is an open-source antivirus written in C#.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkLabel1.Location = new System.Drawing.Point(683, 354);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(190, 21);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[ Github Repository ]";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(223, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(663, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "The goal of this project is to make a free antivirus driven by the community";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(218, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(663, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = " that can be easily changed to work in closed environments. ( Like InfANT )";
            // 
            // ToolsPage
            // 
            this.ToolsPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolsPage.BackgroundImage")));
            this.ToolsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsPage.Controls.Add(this.ScanPage);
            this.ToolsPage.Controls.Add(this.label10);
            this.ToolsPage.Controls.Add(this.HashChangerBtn);
            this.ToolsPage.Controls.Add(this.LogsBtn);
            this.ToolsPage.Controls.Add(this.label9);
            this.ToolsPage.Controls.Add(this.DisableDefenderBtn);
            this.ToolsPage.Controls.Add(this.label8);
            this.ToolsPage.Controls.Add(this.CleanupBtn);
            this.ToolsPage.Controls.Add(this.InfoWbandAv);
            this.ToolsPage.Controls.Add(this.WandAV);
            this.ToolsPage.Controls.Add(this.InfoEandDTools);
            this.ToolsPage.Controls.Add(this.EandDToolsBtn);
            this.ToolsPage.Controls.Add(this.bunifuFlatButton2);
            this.ToolsPage.Controls.Add(this.textBox);
            this.ToolsPage.Controls.Add(this.bunifuFlatButton1);
            this.ToolsPage.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ToolsPage.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ToolsPage.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ToolsPage.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ToolsPage.Location = new System.Drawing.Point(207, 43);
            this.ToolsPage.Name = "ToolsPage";
            this.ToolsPage.Quality = 10;
            this.ToolsPage.Size = new System.Drawing.Size(696, 493);
            this.ToolsPage.TabIndex = 29;
            this.ToolsPage.Visible = false;
            // 
            // ScanPage
            // 
            this.ScanPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScanPage.BackgroundImage")));
            this.ScanPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScanPage.Controls.Add(this.Givemeyourmoney);
            this.ScanPage.Controls.Add(this.StateTile);
            this.ScanPage.Controls.Add(this.StateLbl);
            this.ScanPage.Controls.Add(this.NetworkBtn);
            this.ScanPage.Controls.Add(this.RegistryBtn);
            this.ScanPage.Controls.Add(this.ReportsBtn);
            this.ScanPage.Controls.Add(this.ScannerBtn);
            this.ScanPage.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ScanPage.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ScanPage.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ScanPage.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ScanPage.Location = new System.Drawing.Point(0, 0);
            this.ScanPage.Name = "ScanPage";
            this.ScanPage.Quality = 10;
            this.ScanPage.Size = new System.Drawing.Size(696, 493);
            this.ScanPage.TabIndex = 30;
            // 
            // Givemeyourmoney
            // 
            this.Givemeyourmoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Givemeyourmoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Givemeyourmoney.BackgroundImage")));
            this.Givemeyourmoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Givemeyourmoney.Controls.Add(this.GithubLink);
            this.Givemeyourmoney.Controls.Add(this.DonationLink);
            this.Givemeyourmoney.Controls.Add(this.YoutubeLink);
            this.Givemeyourmoney.Controls.Add(this.Info);
            this.Givemeyourmoney.Controls.Add(this.donatebitch);
            this.Givemeyourmoney.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Givemeyourmoney.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Givemeyourmoney.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Givemeyourmoney.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Givemeyourmoney.Location = new System.Drawing.Point(394, 52);
            this.Givemeyourmoney.Name = "Givemeyourmoney";
            this.Givemeyourmoney.Quality = 10;
            this.Givemeyourmoney.Size = new System.Drawing.Size(281, 254);
            this.Givemeyourmoney.TabIndex = 6;
            // 
            // GithubLink
            // 
            this.GithubLink.ActiveLinkColor = System.Drawing.Color.White;
            this.GithubLink.AutoSize = true;
            this.GithubLink.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.GithubLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.GithubLink.Location = new System.Drawing.Point(10, 215);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(115, 23);
            this.GithubLink.TabIndex = 4;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github Link";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // DonationLink
            // 
            this.DonationLink.ActiveLinkColor = System.Drawing.Color.White;
            this.DonationLink.AutoSize = true;
            this.DonationLink.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.DonationLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DonationLink.Location = new System.Drawing.Point(10, 175);
            this.DonationLink.Name = "DonationLink";
            this.DonationLink.Size = new System.Drawing.Size(147, 23);
            this.DonationLink.TabIndex = 3;
            this.DonationLink.TabStop = true;
            this.DonationLink.Text = "Donations Link";
            this.DonationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DonationLink_LinkClicked);
            // 
            // YoutubeLink
            // 
            this.YoutubeLink.ActiveLinkColor = System.Drawing.Color.White;
            this.YoutubeLink.AutoSize = true;
            this.YoutubeLink.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.YoutubeLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.YoutubeLink.Location = new System.Drawing.Point(10, 135);
            this.YoutubeLink.Name = "YoutubeLink";
            this.YoutubeLink.Size = new System.Drawing.Size(134, 23);
            this.YoutubeLink.TabIndex = 2;
            this.YoutubeLink.TabStop = true;
            this.YoutubeLink.Text = "Youtube Link";
            this.YoutubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YoutubeLink_LinkClicked);
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Info.Location = new System.Drawing.Point(10, 53);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(264, 80);
            this.Info.TabIndex = 1;
            this.Info.Text = "If you like this software, don\'t forget to subscribe / donate:";
            // 
            // donatebitch
            // 
            this.donatebitch.AutoSize = true;
            this.donatebitch.BackColor = System.Drawing.Color.Transparent;
            this.donatebitch.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.donatebitch.ForeColor = System.Drawing.Color.White;
            this.donatebitch.Location = new System.Drawing.Point(10, 9);
            this.donatebitch.Name = "donatebitch";
            this.donatebitch.Size = new System.Drawing.Size(49, 24);
            this.donatebitch.TabIndex = 0;
            this.donatebitch.Text = "Hey";
            this.donatebitch.Click += new System.EventHandler(this.donatebitch_Click);
            // 
            // StateTile
            // 
            this.StateTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.StateTile.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.StateTile.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.StateTile.Cursor = System.Windows.Forms.Cursors.Default;
            this.StateTile.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StateTile.ForeColor = System.Drawing.Color.White;
            this.StateTile.Image = global::Metaphor_Antivirus.Properties.Resources.ProtectedIcon;
            this.StateTile.ImagePosition = 20;
            this.StateTile.ImageZoom = 50;
            this.StateTile.LabelPosition = 41;
            this.StateTile.LabelText = "Protected";
            this.StateTile.Location = new System.Drawing.Point(17, 52);
            this.StateTile.Margin = new System.Windows.Forms.Padding(6);
            this.StateTile.Name = "StateTile";
            this.StateTile.Size = new System.Drawing.Size(348, 254);
            this.StateTile.TabIndex = 5;
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StateLbl.Location = new System.Drawing.Point(21, 18);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(67, 24);
            this.StateLbl.TabIndex = 4;
            this.StateLbl.Text = "State:";
            // 
            // NetworkBtn
            // 
            this.NetworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NetworkBtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NetworkBtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.NetworkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NetworkBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.NetworkBtn.ForeColor = System.Drawing.Color.White;
            this.NetworkBtn.Image = global::Metaphor_Antivirus.Properties.Resources.network;
            this.NetworkBtn.ImagePosition = 20;
            this.NetworkBtn.ImageZoom = 55;
            this.NetworkBtn.LabelPosition = 41;
            this.NetworkBtn.LabelText = "Network";
            this.NetworkBtn.Location = new System.Drawing.Point(530, 322);
            this.NetworkBtn.Margin = new System.Windows.Forms.Padding(6);
            this.NetworkBtn.Name = "NetworkBtn";
            this.NetworkBtn.Size = new System.Drawing.Size(145, 159);
            this.NetworkBtn.TabIndex = 3;
            this.NetworkBtn.Click += new System.EventHandler(this.NetworkBtn_Click);
            // 
            // RegistryBtn
            // 
            this.RegistryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RegistryBtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RegistryBtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RegistryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistryBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.RegistryBtn.ForeColor = System.Drawing.Color.White;
            this.RegistryBtn.Image = global::Metaphor_Antivirus.Properties.Resources.Registry;
            this.RegistryBtn.ImagePosition = 20;
            this.RegistryBtn.ImageZoom = 55;
            this.RegistryBtn.LabelPosition = 41;
            this.RegistryBtn.LabelText = "Registry";
            this.RegistryBtn.Location = new System.Drawing.Point(360, 322);
            this.RegistryBtn.Margin = new System.Windows.Forms.Padding(6);
            this.RegistryBtn.Name = "RegistryBtn";
            this.RegistryBtn.Size = new System.Drawing.Size(145, 159);
            this.RegistryBtn.TabIndex = 2;
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ReportsBtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ReportsBtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ReportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportsBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ReportsBtn.ForeColor = System.Drawing.Color.White;
            this.ReportsBtn.Image = global::Metaphor_Antivirus.Properties.Resources.reports;
            this.ReportsBtn.ImagePosition = 20;
            this.ReportsBtn.ImageZoom = 55;
            this.ReportsBtn.LabelPosition = 41;
            this.ReportsBtn.LabelText = "Reports";
            this.ReportsBtn.Location = new System.Drawing.Point(190, 322);
            this.ReportsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(145, 159);
            this.ReportsBtn.TabIndex = 1;
            // 
            // ScannerBtn
            // 
            this.ScannerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScannerBtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScannerBtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ScannerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScannerBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ScannerBtn.ForeColor = System.Drawing.Color.White;
            this.ScannerBtn.Image = global::Metaphor_Antivirus.Properties.Resources.scan;
            this.ScannerBtn.ImagePosition = 20;
            this.ScannerBtn.ImageZoom = 55;
            this.ScannerBtn.LabelPosition = 41;
            this.ScannerBtn.LabelText = "Scanner";
            this.ScannerBtn.Location = new System.Drawing.Point(20, 322);
            this.ScannerBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ScannerBtn.Name = "ScannerBtn";
            this.ScannerBtn.Size = new System.Drawing.Size(145, 159);
            this.ScannerBtn.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(302, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 37);
            this.label10.TabIndex = 19;
            this.label10.Text = " Change MD5 Hash of any file. It work by appending \"null\" characters to the end o" +
    "f file. Credits to Erwin Solihin ( ewwink )";
            // 
            // HashChangerBtn
            // 
            this.HashChangerBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.HashChangerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.HashChangerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HashChangerBtn.BorderRadius = 0;
            this.HashChangerBtn.ButtonText = "MD5 hash changer";
            this.HashChangerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HashChangerBtn.DisabledColor = System.Drawing.Color.Gray;
            this.HashChangerBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.HashChangerBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("HashChangerBtn.Iconimage")));
            this.HashChangerBtn.Iconimage_right = null;
            this.HashChangerBtn.Iconimage_right_Selected = null;
            this.HashChangerBtn.Iconimage_Selected = null;
            this.HashChangerBtn.IconMarginLeft = 0;
            this.HashChangerBtn.IconMarginRight = 0;
            this.HashChangerBtn.IconRightVisible = false;
            this.HashChangerBtn.IconRightZoom = 0D;
            this.HashChangerBtn.IconVisible = false;
            this.HashChangerBtn.IconZoom = 90D;
            this.HashChangerBtn.IsTab = false;
            this.HashChangerBtn.Location = new System.Drawing.Point(19, 345);
            this.HashChangerBtn.Name = "HashChangerBtn";
            this.HashChangerBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.HashChangerBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.HashChangerBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.HashChangerBtn.selected = false;
            this.HashChangerBtn.Size = new System.Drawing.Size(270, 48);
            this.HashChangerBtn.TabIndex = 18;
            this.HashChangerBtn.Text = "MD5 hash changer";
            this.HashChangerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HashChangerBtn.Textcolor = System.Drawing.Color.White;
            this.HashChangerBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashChangerBtn.Click += new System.EventHandler(this.HashChangerBtn_Click);
            // 
            // LogsBtn
            // 
            this.LogsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogsBtn.BorderRadius = 0;
            this.LogsBtn.ButtonText = "Show Logs";
            this.LogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.LogsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.LogsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("LogsBtn.Iconimage")));
            this.LogsBtn.Iconimage_right = null;
            this.LogsBtn.Iconimage_right_Selected = null;
            this.LogsBtn.Iconimage_Selected = null;
            this.LogsBtn.IconMarginLeft = 0;
            this.LogsBtn.IconMarginRight = 0;
            this.LogsBtn.IconRightVisible = false;
            this.LogsBtn.IconRightZoom = 0D;
            this.LogsBtn.IconVisible = false;
            this.LogsBtn.IconZoom = 90D;
            this.LogsBtn.IsTab = false;
            this.LogsBtn.Location = new System.Drawing.Point(487, 265);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LogsBtn.selected = false;
            this.LogsBtn.Size = new System.Drawing.Size(179, 48);
            this.LogsBtn.TabIndex = 17;
            this.LogsBtn.Text = "Show Logs";
            this.LogsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogsBtn.Textcolor = System.Drawing.Color.White;
            this.LogsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(302, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 34);
            this.label9.TabIndex = 16;
            this.label9.Text = "Disable windows defender on your computer.";
            // 
            // DisableDefenderBtn
            // 
            this.DisableDefenderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DisableDefenderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DisableDefenderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DisableDefenderBtn.BorderRadius = 0;
            this.DisableDefenderBtn.ButtonText = "Disable windows defender";
            this.DisableDefenderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisableDefenderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DisableDefenderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DisableDefenderBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DisableDefenderBtn.Iconimage")));
            this.DisableDefenderBtn.Iconimage_right = null;
            this.DisableDefenderBtn.Iconimage_right_Selected = null;
            this.DisableDefenderBtn.Iconimage_Selected = null;
            this.DisableDefenderBtn.IconMarginLeft = 0;
            this.DisableDefenderBtn.IconMarginRight = 0;
            this.DisableDefenderBtn.IconRightVisible = false;
            this.DisableDefenderBtn.IconRightZoom = 0D;
            this.DisableDefenderBtn.IconVisible = false;
            this.DisableDefenderBtn.IconZoom = 90D;
            this.DisableDefenderBtn.IsTab = false;
            this.DisableDefenderBtn.Location = new System.Drawing.Point(19, 265);
            this.DisableDefenderBtn.Name = "DisableDefenderBtn";
            this.DisableDefenderBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DisableDefenderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DisableDefenderBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DisableDefenderBtn.selected = false;
            this.DisableDefenderBtn.Size = new System.Drawing.Size(270, 48);
            this.DisableDefenderBtn.TabIndex = 15;
            this.DisableDefenderBtn.Text = "Disable windows defender";
            this.DisableDefenderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisableDefenderBtn.Textcolor = System.Drawing.Color.White;
            this.DisableDefenderBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableDefenderBtn.Click += new System.EventHandler(this.DisableDefenderBtn_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(302, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 48);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cleanup your Windows enviroment! [Uninstall OneDrive, cleanup context menus, unin" +
    "stall modern apps, windows 7 explorer + windows native apps uninstall ]";
            // 
            // CleanupBtn
            // 
            this.CleanupBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanupBtn.BorderRadius = 0;
            this.CleanupBtn.ButtonText = "Windows Cleanup Tools";
            this.CleanupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanupBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CleanupBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CleanupBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("CleanupBtn.Iconimage")));
            this.CleanupBtn.Iconimage_right = null;
            this.CleanupBtn.Iconimage_right_Selected = null;
            this.CleanupBtn.Iconimage_Selected = null;
            this.CleanupBtn.IconMarginLeft = 0;
            this.CleanupBtn.IconMarginRight = 0;
            this.CleanupBtn.IconRightVisible = false;
            this.CleanupBtn.IconRightZoom = 0D;
            this.CleanupBtn.IconVisible = false;
            this.CleanupBtn.IconZoom = 90D;
            this.CleanupBtn.IsTab = false;
            this.CleanupBtn.Location = new System.Drawing.Point(19, 185);
            this.CleanupBtn.Name = "CleanupBtn";
            this.CleanupBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CleanupBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CleanupBtn.selected = false;
            this.CleanupBtn.Size = new System.Drawing.Size(270, 48);
            this.CleanupBtn.TabIndex = 13;
            this.CleanupBtn.Text = "Windows Cleanup Tools";
            this.CleanupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CleanupBtn.Textcolor = System.Drawing.Color.White;
            this.CleanupBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanupBtn.Click += new System.EventHandler(this.CleanupBtn_Click);
            // 
            // InfoWbandAv
            // 
            this.InfoWbandAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.InfoWbandAv.Location = new System.Drawing.Point(302, 106);
            this.InfoWbandAv.Name = "InfoWbandAv";
            this.InfoWbandAv.Size = new System.Drawing.Size(374, 48);
            this.InfoWbandAv.TabIndex = 12;
            this.InfoWbandAv.Text = "Analyze suspicious files and URLs to detect types of malware, check if your perso" +
    "nal data has been compromised by data breaches, etc.";
            // 
            // WandAV
            // 
            this.WandAV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.WandAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.WandAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WandAV.BorderRadius = 0;
            this.WandAV.ButtonText = "Best security websites and antiviruses";
            this.WandAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WandAV.DisabledColor = System.Drawing.Color.Gray;
            this.WandAV.Iconcolor = System.Drawing.Color.Transparent;
            this.WandAV.Iconimage = ((System.Drawing.Image)(resources.GetObject("WandAV.Iconimage")));
            this.WandAV.Iconimage_right = null;
            this.WandAV.Iconimage_right_Selected = null;
            this.WandAV.Iconimage_Selected = null;
            this.WandAV.IconMarginLeft = 0;
            this.WandAV.IconMarginRight = 0;
            this.WandAV.IconRightVisible = false;
            this.WandAV.IconRightZoom = 0D;
            this.WandAV.IconVisible = false;
            this.WandAV.IconZoom = 90D;
            this.WandAV.IsTab = false;
            this.WandAV.Location = new System.Drawing.Point(19, 105);
            this.WandAV.Name = "WandAV";
            this.WandAV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.WandAV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.WandAV.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.WandAV.selected = false;
            this.WandAV.Size = new System.Drawing.Size(270, 48);
            this.WandAV.TabIndex = 11;
            this.WandAV.Text = "Best security websites and antiviruses";
            this.WandAV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WandAV.Textcolor = System.Drawing.Color.White;
            this.WandAV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WandAV.Click += new System.EventHandler(this.WandAV_Click);
            // 
            // InfoEandDTools
            // 
            this.InfoEandDTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.InfoEandDTools.Location = new System.Drawing.Point(302, 25);
            this.InfoEandDTools.Name = "InfoEandDTools";
            this.InfoEandDTools.Size = new System.Drawing.Size(374, 48);
            this.InfoEandDTools.TabIndex = 10;
            this.InfoEandDTools.Text = "Protect your text by Encrypting and Decrypting any given text with a key that no " +
    "one knows. Supports cipher, md5, base64, sha, aes, hex, binary conversion, unico" +
    "de and files encryption.";
            // 
            // EandDToolsBtn
            // 
            this.EandDToolsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EandDToolsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EandDToolsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EandDToolsBtn.BorderRadius = 0;
            this.EandDToolsBtn.ButtonText = "Encryption and Decryption tools";
            this.EandDToolsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EandDToolsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EandDToolsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EandDToolsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("EandDToolsBtn.Iconimage")));
            this.EandDToolsBtn.Iconimage_right = null;
            this.EandDToolsBtn.Iconimage_right_Selected = null;
            this.EandDToolsBtn.Iconimage_Selected = null;
            this.EandDToolsBtn.IconMarginLeft = 0;
            this.EandDToolsBtn.IconMarginRight = 0;
            this.EandDToolsBtn.IconRightVisible = false;
            this.EandDToolsBtn.IconRightZoom = 0D;
            this.EandDToolsBtn.IconVisible = false;
            this.EandDToolsBtn.IconZoom = 90D;
            this.EandDToolsBtn.IsTab = false;
            this.EandDToolsBtn.Location = new System.Drawing.Point(19, 25);
            this.EandDToolsBtn.Name = "EandDToolsBtn";
            this.EandDToolsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EandDToolsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EandDToolsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EandDToolsBtn.selected = false;
            this.EandDToolsBtn.Size = new System.Drawing.Size(270, 48);
            this.EandDToolsBtn.TabIndex = 9;
            this.EandDToolsBtn.Text = "Encryption and Decryption tools";
            this.EandDToolsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EandDToolsBtn.Textcolor = System.Drawing.Color.White;
            this.EandDToolsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EandDToolsBtn.Click += new System.EventHandler(this.EandDToolsBtn_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::Metaphor_Antivirus.Properties.Resources.folder;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 5;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 100D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(72, 437);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(61, 52);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(138, 448);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(313, 30);
            this.textBox.TabIndex = 7;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     Check hash";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(457, 445);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(108, 38);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "     Check hash";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // processesBtn
            // 
            this.processesBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.processesBtn.BorderRadius = 0;
            this.processesBtn.ButtonText = "Process Manager";
            this.processesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.processesBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.processesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.processesBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("processesBtn.Iconimage")));
            this.processesBtn.Iconimage_right = null;
            this.processesBtn.Iconimage_right_Selected = null;
            this.processesBtn.Iconimage_Selected = null;
            this.processesBtn.IconMarginLeft = 0;
            this.processesBtn.IconMarginRight = 0;
            this.processesBtn.IconRightVisible = true;
            this.processesBtn.IconRightZoom = 0D;
            this.processesBtn.IconVisible = true;
            this.processesBtn.IconZoom = 90D;
            this.processesBtn.IsTab = false;
            this.processesBtn.Location = new System.Drawing.Point(572, 476);
            this.processesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processesBtn.Name = "processesBtn";
            this.processesBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.processesBtn.selected = false;
            this.processesBtn.Size = new System.Drawing.Size(314, 48);
            this.processesBtn.TabIndex = 6;
            this.processesBtn.Text = "Process Manager";
            this.processesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processesBtn.Textcolor = System.Drawing.Color.White;
            this.processesBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesBtn.Click += new System.EventHandler(this.processesBtn_Click);
            // 
            // usageBtn
            // 
            this.usageBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usageBtn.BorderRadius = 0;
            this.usageBtn.ButtonText = " CPU && RAM usage";
            this.usageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.usageBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.usageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.usageBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("usageBtn.Iconimage")));
            this.usageBtn.Iconimage_right = null;
            this.usageBtn.Iconimage_right_Selected = null;
            this.usageBtn.Iconimage_Selected = null;
            this.usageBtn.IconMarginLeft = 0;
            this.usageBtn.IconMarginRight = 0;
            this.usageBtn.IconRightVisible = true;
            this.usageBtn.IconRightZoom = 0D;
            this.usageBtn.IconVisible = true;
            this.usageBtn.IconZoom = 90D;
            this.usageBtn.IsTab = false;
            this.usageBtn.Location = new System.Drawing.Point(229, 476);
            this.usageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usageBtn.Name = "usageBtn";
            this.usageBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.usageBtn.selected = false;
            this.usageBtn.Size = new System.Drawing.Size(314, 48);
            this.usageBtn.TabIndex = 5;
            this.usageBtn.Text = " CPU && RAM usage";
            this.usageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usageBtn.Textcolor = System.Drawing.Color.White;
            this.usageBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usageBtn.Click += new System.EventHandler(this.usageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.ToolsPage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.OsPlatform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessBit);
            this.Controls.Add(this.BitProcessLbl);
            this.Controls.Add(this.OsBit);
            this.Controls.Add(this.BitOsLbl);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.TextVersion);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.OSLbl);
            this.Controls.Add(this.VersionLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComputerNameLbl);
            this.Controls.Add(this.processesBtn);
            this.Controls.Add(this.usageBtn);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ComputerName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metaphor Antivirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ToolsPage.ResumeLayout(false);
            this.ToolsPage.PerformLayout();
            this.ScanPage.ResumeLayout(false);
            this.ScanPage.PerformLayout();
            this.Givemeyourmoney.ResumeLayout(false);
            this.Givemeyourmoney.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.PictureBox IconImage;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton DashboardBtn;
        private ns1.BunifuFlatButton ToolsBtn;
        private ns1.BunifuFlatButton ScanBtn;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button UpdateBtn;
        private ns1.BunifuFlatButton OptionsBtn;
        private ns1.BunifuFlatButton usageBtn;
        private ns1.BunifuFlatButton processesBtn;
        private System.Windows.Forms.Label ComputerNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label VersionLbl;
        private System.Windows.Forms.Label OSLbl;
        private System.Windows.Forms.Label ComputerName;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label TextVersion;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label BitOsLbl;
        private System.Windows.Forms.Label OsBit;
        private System.Windows.Forms.Label BitProcessLbl;
        private System.Windows.Forms.Label ProcessBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OsPlatform;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Page2;
        private ns1.BunifuGradientPanel ToolsPage;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox textBox;
        private ns1.BunifuFlatButton bunifuFlatButton2;
        private ns1.BunifuFlatButton EandDToolsBtn;
        private System.Windows.Forms.Label InfoEandDTools;
        private ns1.BunifuFlatButton WandAV;
        private System.Windows.Forms.Label InfoWbandAv;
        private ns1.BunifuFlatButton CleanupBtn;
        private System.Windows.Forms.Label label8;
        private ns1.BunifuFlatButton DisableDefenderBtn;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuFlatButton LogsBtn;
        private ns1.BunifuFlatButton HashChangerBtn;
        private System.Windows.Forms.Label label10;
        private ns1.BunifuGradientPanel ScanPage;
        private ns1.BunifuTileButton ScannerBtn;
        private ns1.BunifuTileButton ReportsBtn;
        private ns1.BunifuTileButton RegistryBtn;
        private ns1.BunifuTileButton NetworkBtn;
        private System.Windows.Forms.Label StateLbl;
        private ns1.BunifuTileButton StateTile;
        private ns1.BunifuGradientPanel Givemeyourmoney;
        private System.Windows.Forms.Label donatebitch;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.LinkLabel YoutubeLink;
        private System.Windows.Forms.LinkLabel DonationLink;
        private System.Windows.Forms.LinkLabel GithubLink;
    }
}

