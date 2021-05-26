
namespace Metaphor_Antivirus
{
    partial class EandDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EandDForm));
            this.DecryptTextBox = new System.Windows.Forms.TextBox();
            this.EncryptTextBox = new System.Windows.Forms.TextBox();
            this.DecryptBtn = new ns1.BunifuFlatButton();
            this.EncryptBtn = new ns1.BunifuFlatButton();
            this.Info1 = new System.Windows.Forms.Label();
            this.Info2 = new System.Windows.Forms.Label();
            this.Method = new ns1.BunifuDropdown();
            this.Info3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DecryptTextBox
            // 
            this.DecryptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DecryptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DecryptTextBox.ForeColor = System.Drawing.Color.White;
            this.DecryptTextBox.Location = new System.Drawing.Point(12, 28);
            this.DecryptTextBox.Multiline = true;
            this.DecryptTextBox.Name = "DecryptTextBox";
            this.DecryptTextBox.Size = new System.Drawing.Size(467, 149);
            this.DecryptTextBox.TabIndex = 0;
            // 
            // EncryptTextBox
            // 
            this.EncryptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EncryptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EncryptTextBox.ForeColor = System.Drawing.Color.White;
            this.EncryptTextBox.Location = new System.Drawing.Point(12, 208);
            this.EncryptTextBox.Multiline = true;
            this.EncryptTextBox.Name = "EncryptTextBox";
            this.EncryptTextBox.Size = new System.Drawing.Size(467, 149);
            this.EncryptTextBox.TabIndex = 1;
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DecryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DecryptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecryptBtn.BorderRadius = 0;
            this.DecryptBtn.ButtonText = "Decrypt Text";
            this.DecryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecryptBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DecryptBtn.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.DecryptBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DecryptBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DecryptBtn.Iconimage")));
            this.DecryptBtn.Iconimage_right = null;
            this.DecryptBtn.Iconimage_right_Selected = null;
            this.DecryptBtn.Iconimage_Selected = null;
            this.DecryptBtn.IconMarginLeft = 0;
            this.DecryptBtn.IconMarginRight = 0;
            this.DecryptBtn.IconRightVisible = false;
            this.DecryptBtn.IconRightZoom = 0D;
            this.DecryptBtn.IconVisible = false;
            this.DecryptBtn.IconZoom = 90D;
            this.DecryptBtn.IsTab = false;
            this.DecryptBtn.Location = new System.Drawing.Point(541, 110);
            this.DecryptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DecryptBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DecryptBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DecryptBtn.selected = false;
            this.DecryptBtn.Size = new System.Drawing.Size(153, 38);
            this.DecryptBtn.TabIndex = 7;
            this.DecryptBtn.Text = "Decrypt Text";
            this.DecryptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecryptBtn.Textcolor = System.Drawing.Color.White;
            this.DecryptBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EncryptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EncryptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EncryptBtn.BorderRadius = 0;
            this.EncryptBtn.ButtonText = "Encrypt Text";
            this.EncryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptBtn.DisabledColor = System.Drawing.Color.Gray;
            this.EncryptBtn.Font = new System.Drawing.Font("Arial Narrow", 24F);
            this.EncryptBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.EncryptBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("EncryptBtn.Iconimage")));
            this.EncryptBtn.Iconimage_right = null;
            this.EncryptBtn.Iconimage_right_Selected = null;
            this.EncryptBtn.Iconimage_Selected = null;
            this.EncryptBtn.IconMarginLeft = 0;
            this.EncryptBtn.IconMarginRight = 0;
            this.EncryptBtn.IconRightVisible = false;
            this.EncryptBtn.IconRightZoom = 0D;
            this.EncryptBtn.IconVisible = false;
            this.EncryptBtn.IconZoom = 90D;
            this.EncryptBtn.IsTab = false;
            this.EncryptBtn.Location = new System.Drawing.Point(541, 57);
            this.EncryptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EncryptBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.EncryptBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EncryptBtn.selected = false;
            this.EncryptBtn.Size = new System.Drawing.Size(153, 38);
            this.EncryptBtn.TabIndex = 8;
            this.EncryptBtn.Text = "Encrypt Text";
            this.EncryptBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EncryptBtn.Textcolor = System.Drawing.Color.White;
            this.EncryptBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // Info1
            // 
            this.Info1.AutoSize = true;
            this.Info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Info1.ForeColor = System.Drawing.Color.White;
            this.Info1.Location = new System.Drawing.Point(12, 8);
            this.Info1.Name = "Info1";
            this.Info1.Size = new System.Drawing.Size(100, 16);
            this.Info1.TabIndex = 9;
            this.Info1.Text = "Decrypted Text";
            // 
            // Info2
            // 
            this.Info2.AutoSize = true;
            this.Info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Info2.ForeColor = System.Drawing.Color.White;
            this.Info2.Location = new System.Drawing.Point(12, 188);
            this.Info2.Name = "Info2";
            this.Info2.Size = new System.Drawing.Size(98, 16);
            this.Info2.TabIndex = 10;
            this.Info2.Text = "Encrypted Text";
            // 
            // Method
            // 
            this.Method.BackColor = System.Drawing.Color.Transparent;
            this.Method.BorderRadius = 3;
            this.Method.ForeColor = System.Drawing.Color.White;
            this.Method.Items = new string[] {
        "MD5",
        "AES",
        "BASE64"};
            this.Method.Location = new System.Drawing.Point(509, 208);
            this.Method.Name = "Method";
            this.Method.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Method.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Method.selectedIndex = 0;
            this.Method.Size = new System.Drawing.Size(220, 35);
            this.Method.TabIndex = 11;
            // 
            // Info3
            // 
            this.Info3.AutoSize = true;
            this.Info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Info3.ForeColor = System.Drawing.Color.White;
            this.Info3.Location = new System.Drawing.Point(519, 188);
            this.Info3.Name = "Info3";
            this.Info3.Size = new System.Drawing.Size(199, 16);
            this.Info3.TabIndex = 12;
            this.Info3.Text = "Encryption && Decryption method";
            // 
            // EandDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(766, 369);
            this.Controls.Add(this.Info3);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.Info2);
            this.Controls.Add(this.Info1);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptTextBox);
            this.Controls.Add(this.DecryptTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EandDForm";
            this.ShowIcon = false;
            this.Text = "Encryption And Decryption tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DecryptTextBox;
        private System.Windows.Forms.TextBox EncryptTextBox;
        private ns1.BunifuFlatButton DecryptBtn;
        private ns1.BunifuFlatButton EncryptBtn;
        private System.Windows.Forms.Label Info1;
        private System.Windows.Forms.Label Info2;
        private ns1.BunifuDropdown Method;
        private System.Windows.Forms.Label Info3;
    }
}