namespace AliceAndBob
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.helpPictureBox = new System.Windows.Forms.PictureBox();
            this.helpTitleLabel = new System.Windows.Forms.Label();
            this.helpTitleLabel2 = new System.Windows.Forms.Label();
            this.helpTitleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.helpTextLabel1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.helpTextLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // helpPictureBox
            // 
            this.helpPictureBox.Image = global::AliceAndBob.Properties.Resources.key_icon1;
            this.helpPictureBox.Location = new System.Drawing.Point(486, 11);
            this.helpPictureBox.Name = "helpPictureBox";
            this.helpPictureBox.Size = new System.Drawing.Size(136, 138);
            this.helpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helpPictureBox.TabIndex = 0;
            this.helpPictureBox.TabStop = false;
            // 
            // helpTitleLabel
            // 
            this.helpTitleLabel.AutoSize = true;
            this.helpTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTitleLabel.Location = new System.Drawing.Point(41, 14);
            this.helpTitleLabel.Name = "helpTitleLabel";
            this.helpTitleLabel.Size = new System.Drawing.Size(180, 31);
            this.helpTitleLabel.TabIndex = 1;
            this.helpTitleLabel.Text = "AliceAndBob";
            // 
            // helpTitleLabel2
            // 
            this.helpTitleLabel2.AutoSize = true;
            this.helpTitleLabel2.Location = new System.Drawing.Point(77, 49);
            this.helpTitleLabel2.Name = "helpTitleLabel2";
            this.helpTitleLabel2.Size = new System.Drawing.Size(191, 13);
            this.helpTitleLabel2.TabIndex = 2;
            this.helpTitleLabel2.Text = "Written by Ryan Ries, September 2012";
            // 
            // helpTitleLinkLabel
            // 
            this.helpTitleLinkLabel.AutoSize = true;
            this.helpTitleLinkLabel.Location = new System.Drawing.Point(80, 66);
            this.helpTitleLinkLabel.Name = "helpTitleLinkLabel";
            this.helpTitleLinkLabel.Size = new System.Drawing.Size(176, 13);
            this.helpTitleLinkLabel.TabIndex = 3;
            this.helpTitleLinkLabel.TabStop = true;
            this.helpTitleLinkLabel.Text = "http://www.myotherpcisacloud.com";
            this.helpTitleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpTitleLinkLabel_LinkClicked);
            // 
            // helpTextLabel1
            // 
            this.helpTextLabel1.Location = new System.Drawing.Point(12, 109);
            this.helpTextLabel1.Name = "helpTextLabel1";
            this.helpTextLabel1.Size = new System.Drawing.Size(460, 59);
            this.helpTextLabel1.TabIndex = 4;
            this.helpTextLabel1.Text = resources.GetString("helpTextLabel1.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 169);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(314, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Public Key Cryptography: Diffie-Hellman Key Exchange (Youtube)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(15, 187);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(200, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Diffie–Hellman key exchange (Wikipedia)";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(15, 205);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(320, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Does the generator size matter in Diffie-Hellman? (Stackexchange)";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // helpTextLabel2
            // 
            this.helpTextLabel2.Location = new System.Drawing.Point(15, 229);
            this.helpTextLabel2.Name = "helpTextLabel2";
            this.helpTextLabel2.Size = new System.Drawing.Size(607, 218);
            this.helpTextLabel2.TabIndex = 8;
            this.helpTextLabel2.Text = resources.GetString("helpTextLabel2.Text");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 456);
            this.Controls.Add(this.helpTextLabel2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.helpTextLabel1);
            this.Controls.Add(this.helpTitleLinkLabel);
            this.Controls.Add(this.helpTitleLabel2);
            this.Controls.Add(this.helpTitleLabel);
            this.Controls.Add(this.helpPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About/Help";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.helpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox helpPictureBox;
        private System.Windows.Forms.Label helpTitleLabel;
        private System.Windows.Forms.Label helpTitleLabel2;
        private System.Windows.Forms.LinkLabel helpTitleLinkLabel;
        private System.Windows.Forms.Label helpTextLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label helpTextLabel2;
    }
}