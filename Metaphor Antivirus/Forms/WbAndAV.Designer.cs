
namespace Metaphor_Antivirus
{
    partial class WbAndAV
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
            this.AntivirusesLbl = new ns1.BunifuCustomLabel();
            this.WebsitesLbl = new ns1.BunifuCustomLabel();
            this.WebsitesImage = new ns1.BunifuImageButton();
            this.AntivirusesImage = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.WebsitesImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntivirusesImage)).BeginInit();
            this.SuspendLayout();
            // 
            // AntivirusesLbl
            // 
            this.AntivirusesLbl.AutoSize = true;
            this.AntivirusesLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.AntivirusesLbl.Location = new System.Drawing.Point(156, 14);
            this.AntivirusesLbl.Name = "AntivirusesLbl";
            this.AntivirusesLbl.Size = new System.Drawing.Size(113, 23);
            this.AntivirusesLbl.TabIndex = 4;
            this.AntivirusesLbl.Text = "Antiviruses";
            // 
            // WebsitesLbl
            // 
            this.WebsitesLbl.AutoSize = true;
            this.WebsitesLbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.WebsitesLbl.Location = new System.Drawing.Point(593, 14);
            this.WebsitesLbl.Name = "WebsitesLbl";
            this.WebsitesLbl.Size = new System.Drawing.Size(96, 23);
            this.WebsitesLbl.TabIndex = 5;
            this.WebsitesLbl.Text = "Websites";
            // 
            // WebsitesImage
            // 
            this.WebsitesImage.BackColor = System.Drawing.Color.MediumTurquoise;
            this.WebsitesImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebsitesImage.Image = global::Metaphor_Antivirus.Properties.Resources.websites;
            this.WebsitesImage.ImageActive = null;
            this.WebsitesImage.Location = new System.Drawing.Point(450, 47);
            this.WebsitesImage.Name = "WebsitesImage";
            this.WebsitesImage.Size = new System.Drawing.Size(369, 260);
            this.WebsitesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WebsitesImage.TabIndex = 3;
            this.WebsitesImage.TabStop = false;
            this.WebsitesImage.Zoom = 4;
            this.WebsitesImage.Click += new System.EventHandler(this.WebsitesImage_Click);
            // 
            // AntivirusesImage
            // 
            this.AntivirusesImage.BackColor = System.Drawing.Color.White;
            this.AntivirusesImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AntivirusesImage.Image = global::Metaphor_Antivirus.Properties.Resources.antivirusImage;
            this.AntivirusesImage.ImageActive = null;
            this.AntivirusesImage.Location = new System.Drawing.Point(35, 47);
            this.AntivirusesImage.Name = "AntivirusesImage";
            this.AntivirusesImage.Size = new System.Drawing.Size(369, 260);
            this.AntivirusesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AntivirusesImage.TabIndex = 2;
            this.AntivirusesImage.TabStop = false;
            this.AntivirusesImage.Zoom = 4;
            // 
            // WbAndAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(852, 324);
            this.Controls.Add(this.WebsitesLbl);
            this.Controls.Add(this.AntivirusesLbl);
            this.Controls.Add(this.WebsitesImage);
            this.Controls.Add(this.AntivirusesImage);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WbAndAV";
            this.ShowIcon = false;
            this.Text = "Websites and Antiviruses";
            this.Load += new System.EventHandler(this.WbAndAV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WebsitesImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AntivirusesImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuImageButton AntivirusesImage;
        private ns1.BunifuImageButton WebsitesImage;
        private ns1.BunifuCustomLabel AntivirusesLbl;
        private ns1.BunifuCustomLabel WebsitesLbl;
    }
}