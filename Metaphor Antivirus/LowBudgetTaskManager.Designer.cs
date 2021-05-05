
namespace Metaphor_Antivirus
{
    partial class LowBudgetTaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowBudgetTaskManager));
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.RunBtn = new ns1.BunifuFlatButton();
            this.RefreshBtn = new ns1.BunifuFlatButton();
            this.EndBtn = new ns1.BunifuFlatButton();
            this.StartBtn = new ns1.BunifuFlatButton();
            this.PropBtn = new ns1.BunifuFlatButton();
            this.SearchBtn = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // lstProcesses
            // 
            this.lstProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lstProcesses.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lstProcesses.ForeColor = System.Drawing.Color.White;
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.ItemHeight = 20;
            this.lstProcesses.Location = new System.Drawing.Point(9, 13);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(228, 424);
            this.lstProcesses.TabIndex = 0;
            // 
            // RunBtn
            // 
            this.RunBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RunBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RunBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RunBtn.BorderRadius = 0;
            this.RunBtn.ButtonText = "Run a command";
            this.RunBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunBtn.DisabledColor = System.Drawing.Color.Gray;
            this.RunBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.RunBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RunBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("RunBtn.Iconimage")));
            this.RunBtn.Iconimage_right = null;
            this.RunBtn.Iconimage_right_Selected = null;
            this.RunBtn.Iconimage_Selected = null;
            this.RunBtn.IconMarginLeft = 0;
            this.RunBtn.IconMarginRight = 0;
            this.RunBtn.IconRightVisible = true;
            this.RunBtn.IconRightZoom = 0D;
            this.RunBtn.IconVisible = true;
            this.RunBtn.IconZoom = 90D;
            this.RunBtn.IsTab = false;
            this.RunBtn.Location = new System.Drawing.Point(255, 27);
            this.RunBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RunBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RunBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RunBtn.selected = false;
            this.RunBtn.Size = new System.Drawing.Size(225, 48);
            this.RunBtn.TabIndex = 6;
            this.RunBtn.Text = "Run a command";
            this.RunBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RunBtn.Textcolor = System.Drawing.Color.White;
            this.RunBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
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
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.RefreshBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.RefreshBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Iconimage")));
            this.RefreshBtn.Iconimage_right = null;
            this.RefreshBtn.Iconimage_right_Selected = null;
            this.RefreshBtn.Iconimage_Selected = null;
            this.RefreshBtn.IconMarginLeft = 0;
            this.RefreshBtn.IconMarginRight = 0;
            this.RefreshBtn.IconRightVisible = true;
            this.RefreshBtn.IconRightZoom = 0D;
            this.RefreshBtn.IconVisible = true;
            this.RefreshBtn.IconZoom = 90D;
            this.RefreshBtn.IsTab = false;
            this.RefreshBtn.Location = new System.Drawing.Point(255, 97);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RefreshBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RefreshBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RefreshBtn.selected = false;
            this.RefreshBtn.Size = new System.Drawing.Size(225, 48);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshBtn.Textcolor = System.Drawing.Color.White;
            this.RefreshBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EndBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EndBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EndBtn.BorderRadius = 0;
            this.EndBtn.ButtonText = "End Task";
            this.EndBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EndBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.EndBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EndBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("EndBtn.Iconimage")));
            this.EndBtn.Iconimage_right = null;
            this.EndBtn.Iconimage_right_Selected = null;
            this.EndBtn.Iconimage_Selected = null;
            this.EndBtn.IconMarginLeft = 0;
            this.EndBtn.IconMarginRight = 0;
            this.EndBtn.IconRightVisible = true;
            this.EndBtn.IconRightZoom = 0D;
            this.EndBtn.IconVisible = true;
            this.EndBtn.IconZoom = 90D;
            this.EndBtn.IsTab = false;
            this.EndBtn.Location = new System.Drawing.Point(255, 167);
            this.EndBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EndBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EndBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EndBtn.selected = false;
            this.EndBtn.Size = new System.Drawing.Size(225, 48);
            this.EndBtn.TabIndex = 8;
            this.EndBtn.Text = "End Task";
            this.EndBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndBtn.Textcolor = System.Drawing.Color.White;
            this.EndBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.BorderRadius = 0;
            this.StartBtn.ButtonText = "Do smth idk";
            this.StartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn.DisabledColor = System.Drawing.Color.Gray;
            this.StartBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.StartBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.StartBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("StartBtn.Iconimage")));
            this.StartBtn.Iconimage_right = null;
            this.StartBtn.Iconimage_right_Selected = null;
            this.StartBtn.Iconimage_Selected = null;
            this.StartBtn.IconMarginLeft = 0;
            this.StartBtn.IconMarginRight = 0;
            this.StartBtn.IconRightVisible = true;
            this.StartBtn.IconRightZoom = 0D;
            this.StartBtn.IconVisible = true;
            this.StartBtn.IconZoom = 90D;
            this.StartBtn.IsTab = false;
            this.StartBtn.Location = new System.Drawing.Point(255, 307);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.StartBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.StartBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.StartBtn.selected = false;
            this.StartBtn.Size = new System.Drawing.Size(225, 48);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.Text = "Do smth idk";
            this.StartBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBtn.Textcolor = System.Drawing.Color.White;
            this.StartBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PropBtn
            // 
            this.PropBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PropBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PropBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PropBtn.BorderRadius = 0;
            this.PropBtn.ButtonText = "Properties";
            this.PropBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PropBtn.DisabledColor = System.Drawing.Color.Gray;
            this.PropBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.PropBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.PropBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("PropBtn.Iconimage")));
            this.PropBtn.Iconimage_right = null;
            this.PropBtn.Iconimage_right_Selected = null;
            this.PropBtn.Iconimage_Selected = null;
            this.PropBtn.IconMarginLeft = 0;
            this.PropBtn.IconMarginRight = 0;
            this.PropBtn.IconRightVisible = true;
            this.PropBtn.IconRightZoom = 0D;
            this.PropBtn.IconVisible = true;
            this.PropBtn.IconZoom = 90D;
            this.PropBtn.IsTab = false;
            this.PropBtn.Location = new System.Drawing.Point(255, 237);
            this.PropBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PropBtn.Name = "PropBtn";
            this.PropBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PropBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PropBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PropBtn.selected = false;
            this.PropBtn.Size = new System.Drawing.Size(225, 48);
            this.PropBtn.TabIndex = 10;
            this.PropBtn.Text = "Properties";
            this.PropBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PropBtn.Textcolor = System.Drawing.Color.White;
            this.PropBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropBtn.Click += new System.EventHandler(this.PropBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchBtn.BorderRadius = 0;
            this.SearchBtn.ButtonText = "Search online";
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.SearchBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SearchBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Iconimage")));
            this.SearchBtn.Iconimage_right = null;
            this.SearchBtn.Iconimage_right_Selected = null;
            this.SearchBtn.Iconimage_Selected = null;
            this.SearchBtn.IconMarginLeft = 0;
            this.SearchBtn.IconMarginRight = 0;
            this.SearchBtn.IconRightVisible = true;
            this.SearchBtn.IconRightZoom = 0D;
            this.SearchBtn.IconVisible = true;
            this.SearchBtn.IconZoom = 90D;
            this.SearchBtn.IsTab = false;
            this.SearchBtn.Location = new System.Drawing.Point(255, 377);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SearchBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SearchBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SearchBtn.selected = false;
            this.SearchBtn.Size = new System.Drawing.Size(225, 48);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Search online";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.Textcolor = System.Drawing.Color.White;
            this.SearchBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LowBudgetTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PropBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.lstProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LowBudgetTaskManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "All Procesess";
            this.Load += new System.EventHandler(this.LowBudgetTaskManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcesses;
        private ns1.BunifuFlatButton RunBtn;
        private ns1.BunifuFlatButton RefreshBtn;
        private ns1.BunifuFlatButton EndBtn;
        private ns1.BunifuFlatButton StartBtn;
        private ns1.BunifuFlatButton PropBtn;
        private ns1.BunifuFlatButton SearchBtn;
    }
}