namespace AliceAndBob
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
            this.alicesMessageLabel = new System.Windows.Forms.Label();
            this.alicesMessageTextBox = new System.Windows.Forms.TextBox();
            this.aliceGroupBox = new System.Windows.Forms.GroupBox();
            this.newGeneratorButton = new System.Windows.Forms.Button();
            this.generatorLabel = new System.Windows.Forms.Label();
            this.generatorComboBox = new System.Windows.Forms.ComboBox();
            this.primeModLabel = new System.Windows.Forms.Label();
            this.primeModComboBox = new System.Windows.Forms.ComboBox();
            this.aliceRecvLabel = new System.Windows.Forms.Label();
            this.aliceRecvListBox = new System.Windows.Forms.ListBox();
            this.aliceSendButton = new System.Windows.Forms.Button();
            this.alicesPKTextBox = new System.Windows.Forms.TextBox();
            this.alicesPKLabel = new System.Windows.Forms.Label();
            this.bobGroupBox = new System.Windows.Forms.GroupBox();
            this.bobRecvLabel = new System.Windows.Forms.Label();
            this.bobRecvListBox = new System.Windows.Forms.ListBox();
            this.bobSendButton = new System.Windows.Forms.Button();
            this.bobsPKTextBox = new System.Windows.Forms.TextBox();
            this.bobsPKLabel = new System.Windows.Forms.Label();
            this.bobsMessageTextBox = new System.Windows.Forms.TextBox();
            this.bobsMessageLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.eveGroupBox = new System.Windows.Forms.GroupBox();
            this.eveListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.aboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aliceGroupBox.SuspendLayout();
            this.bobGroupBox.SuspendLayout();
            this.eveGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // alicesMessageLabel
            // 
            this.alicesMessageLabel.AutoSize = true;
            this.alicesMessageLabel.Location = new System.Drawing.Point(6, 23);
            this.alicesMessageLabel.Name = "alicesMessageLabel";
            this.alicesMessageLabel.Size = new System.Drawing.Size(86, 13);
            this.alicesMessageLabel.TabIndex = 0;
            this.alicesMessageLabel.Text = "Alice\'s Message:";
            // 
            // alicesMessageTextBox
            // 
            this.alicesMessageTextBox.Location = new System.Drawing.Point(117, 20);
            this.alicesMessageTextBox.Name = "alicesMessageTextBox";
            this.alicesMessageTextBox.Size = new System.Drawing.Size(176, 20);
            this.alicesMessageTextBox.TabIndex = 1;
            this.alicesMessageTextBox.TextChanged += new System.EventHandler(this.alicesMessageTextBox_TextChanged);
            // 
            // aliceGroupBox
            // 
            this.aliceGroupBox.Controls.Add(this.newGeneratorButton);
            this.aliceGroupBox.Controls.Add(this.generatorLabel);
            this.aliceGroupBox.Controls.Add(this.generatorComboBox);
            this.aliceGroupBox.Controls.Add(this.primeModLabel);
            this.aliceGroupBox.Controls.Add(this.primeModComboBox);
            this.aliceGroupBox.Controls.Add(this.aliceRecvLabel);
            this.aliceGroupBox.Controls.Add(this.aliceRecvListBox);
            this.aliceGroupBox.Controls.Add(this.aliceSendButton);
            this.aliceGroupBox.Controls.Add(this.alicesPKTextBox);
            this.aliceGroupBox.Controls.Add(this.alicesPKLabel);
            this.aliceGroupBox.Controls.Add(this.alicesMessageLabel);
            this.aliceGroupBox.Controls.Add(this.alicesMessageTextBox);
            this.aliceGroupBox.Location = new System.Drawing.Point(16, 12);
            this.aliceGroupBox.Name = "aliceGroupBox";
            this.aliceGroupBox.Size = new System.Drawing.Size(300, 320);
            this.aliceGroupBox.TabIndex = 2;
            this.aliceGroupBox.TabStop = false;
            this.aliceGroupBox.Text = "Alice";
            // 
            // newGeneratorButton
            // 
            this.newGeneratorButton.Enabled = false;
            this.newGeneratorButton.Location = new System.Drawing.Point(250, 104);
            this.newGeneratorButton.Name = "newGeneratorButton";
            this.newGeneratorButton.Size = new System.Drawing.Size(42, 23);
            this.newGeneratorButton.TabIndex = 13;
            this.newGeneratorButton.Text = "New";
            this.newGeneratorButton.UseVisualStyleBackColor = true;
            this.newGeneratorButton.Click += new System.EventHandler(this.newGeneratorButton_Click);
            // 
            // generatorLabel
            // 
            this.generatorLabel.AutoSize = true;
            this.generatorLabel.Location = new System.Drawing.Point(8, 109);
            this.generatorLabel.Name = "generatorLabel";
            this.generatorLabel.Size = new System.Drawing.Size(72, 13);
            this.generatorLabel.TabIndex = 12;
            this.generatorLabel.Text = "Generator (g):";
            // 
            // generatorComboBox
            // 
            this.generatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generatorComboBox.FormattingEnabled = true;
            this.generatorComboBox.Location = new System.Drawing.Point(117, 105);
            this.generatorComboBox.Name = "generatorComboBox";
            this.generatorComboBox.Size = new System.Drawing.Size(127, 21);
            this.generatorComboBox.TabIndex = 11;
            // 
            // primeModLabel
            // 
            this.primeModLabel.AutoSize = true;
            this.primeModLabel.Location = new System.Drawing.Point(7, 81);
            this.primeModLabel.Name = "primeModLabel";
            this.primeModLabel.Size = new System.Drawing.Size(94, 13);
            this.primeModLabel.TabIndex = 10;
            this.primeModLabel.Text = "Prime Modulus (p):";
            // 
            // primeModComboBox
            // 
            this.primeModComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primeModComboBox.FormattingEnabled = true;
            this.primeModComboBox.Location = new System.Drawing.Point(117, 77);
            this.primeModComboBox.Name = "primeModComboBox";
            this.primeModComboBox.Size = new System.Drawing.Size(176, 21);
            this.primeModComboBox.TabIndex = 9;
            this.primeModComboBox.SelectedIndexChanged += new System.EventHandler(this.primeModComboBox_SelectedIndexChanged);
            // 
            // aliceRecvLabel
            // 
            this.aliceRecvLabel.AutoSize = true;
            this.aliceRecvLabel.Location = new System.Drawing.Point(9, 163);
            this.aliceRecvLabel.Name = "aliceRecvLabel";
            this.aliceRecvLabel.Size = new System.Drawing.Size(81, 13);
            this.aliceRecvLabel.TabIndex = 8;
            this.aliceRecvLabel.Text = "Alice Receives:";
            // 
            // aliceRecvListBox
            // 
            this.aliceRecvListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aliceRecvListBox.FormattingEnabled = true;
            this.aliceRecvListBox.HorizontalScrollbar = true;
            this.aliceRecvListBox.Location = new System.Drawing.Point(7, 179);
            this.aliceRecvListBox.Name = "aliceRecvListBox";
            this.aliceRecvListBox.Size = new System.Drawing.Size(286, 134);
            this.aliceRecvListBox.TabIndex = 7;
            // 
            // aliceSendButton
            // 
            this.aliceSendButton.Enabled = false;
            this.aliceSendButton.Location = new System.Drawing.Point(117, 134);
            this.aliceSendButton.Name = "aliceSendButton";
            this.aliceSendButton.Size = new System.Drawing.Size(75, 23);
            this.aliceSendButton.TabIndex = 6;
            this.aliceSendButton.Text = "Send";
            this.aliceSendButton.UseVisualStyleBackColor = true;
            this.aliceSendButton.Click += new System.EventHandler(this.aliceSendButton_Click);
            // 
            // alicesPKTextBox
            // 
            this.alicesPKTextBox.Location = new System.Drawing.Point(117, 49);
            this.alicesPKTextBox.Name = "alicesPKTextBox";
            this.alicesPKTextBox.Size = new System.Drawing.Size(176, 20);
            this.alicesPKTextBox.TabIndex = 3;
            this.alicesPKTextBox.TextChanged += new System.EventHandler(this.alicesPKTextBox_TextChanged);
            this.alicesPKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alicesPKTextBox_KeyPress);
            // 
            // alicesPKLabel
            // 
            this.alicesPKLabel.AutoSize = true;
            this.alicesPKLabel.Location = new System.Drawing.Point(6, 53);
            this.alicesPKLabel.Name = "alicesPKLabel";
            this.alicesPKLabel.Size = new System.Drawing.Size(112, 13);
            this.alicesPKLabel.TabIndex = 2;
            this.alicesPKLabel.Text = "Alice\'s Private Key (a):";
            // 
            // bobGroupBox
            // 
            this.bobGroupBox.Controls.Add(this.bobRecvLabel);
            this.bobGroupBox.Controls.Add(this.bobRecvListBox);
            this.bobGroupBox.Controls.Add(this.bobSendButton);
            this.bobGroupBox.Controls.Add(this.bobsPKTextBox);
            this.bobGroupBox.Controls.Add(this.bobsPKLabel);
            this.bobGroupBox.Controls.Add(this.bobsMessageTextBox);
            this.bobGroupBox.Controls.Add(this.bobsMessageLabel);
            this.bobGroupBox.Location = new System.Drawing.Point(321, 12);
            this.bobGroupBox.Name = "bobGroupBox";
            this.bobGroupBox.Size = new System.Drawing.Size(300, 320);
            this.bobGroupBox.TabIndex = 3;
            this.bobGroupBox.TabStop = false;
            this.bobGroupBox.Text = "Bob";
            // 
            // bobRecvLabel
            // 
            this.bobRecvLabel.AutoSize = true;
            this.bobRecvLabel.Location = new System.Drawing.Point(9, 163);
            this.bobRecvLabel.Name = "bobRecvLabel";
            this.bobRecvLabel.Size = new System.Drawing.Size(77, 13);
            this.bobRecvLabel.TabIndex = 8;
            this.bobRecvLabel.Text = "Bob Receives:";
            // 
            // bobRecvListBox
            // 
            this.bobRecvListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.bobRecvListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bobRecvListBox.FormattingEnabled = true;
            this.bobRecvListBox.HorizontalScrollbar = true;
            this.bobRecvListBox.Location = new System.Drawing.Point(8, 179);
            this.bobRecvListBox.Name = "bobRecvListBox";
            this.bobRecvListBox.Size = new System.Drawing.Size(286, 134);
            this.bobRecvListBox.TabIndex = 7;
            // 
            // bobSendButton
            // 
            this.bobSendButton.Enabled = false;
            this.bobSendButton.Location = new System.Drawing.Point(115, 134);
            this.bobSendButton.Name = "bobSendButton";
            this.bobSendButton.Size = new System.Drawing.Size(75, 23);
            this.bobSendButton.TabIndex = 6;
            this.bobSendButton.Text = "Send";
            this.bobSendButton.UseVisualStyleBackColor = true;
            this.bobSendButton.Click += new System.EventHandler(this.bobSendButton_Click);
            // 
            // bobsPKTextBox
            // 
            this.bobsPKTextBox.Location = new System.Drawing.Point(117, 49);
            this.bobsPKTextBox.Name = "bobsPKTextBox";
            this.bobsPKTextBox.Size = new System.Drawing.Size(176, 20);
            this.bobsPKTextBox.TabIndex = 3;
            this.bobsPKTextBox.TextChanged += new System.EventHandler(this.bobsPKTextBox_TextChanged);
            this.bobsPKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bobsPKTextBox_KeyPress);
            // 
            // bobsPKLabel
            // 
            this.bobsPKLabel.AutoSize = true;
            this.bobsPKLabel.Location = new System.Drawing.Point(6, 52);
            this.bobsPKLabel.Name = "bobsPKLabel";
            this.bobsPKLabel.Size = new System.Drawing.Size(108, 13);
            this.bobsPKLabel.TabIndex = 2;
            this.bobsPKLabel.Text = "Bob\'s Private Key (b):";
            // 
            // bobsMessageTextBox
            // 
            this.bobsMessageTextBox.Location = new System.Drawing.Point(117, 20);
            this.bobsMessageTextBox.Name = "bobsMessageTextBox";
            this.bobsMessageTextBox.Size = new System.Drawing.Size(176, 20);
            this.bobsMessageTextBox.TabIndex = 1;
            this.bobsMessageTextBox.TextChanged += new System.EventHandler(this.bobsMessageTextBox_TextChanged);
            // 
            // bobsMessageLabel
            // 
            this.bobsMessageLabel.AutoSize = true;
            this.bobsMessageLabel.Location = new System.Drawing.Point(6, 22);
            this.bobsMessageLabel.Name = "bobsMessageLabel";
            this.bobsMessageLabel.Size = new System.Drawing.Size(82, 13);
            this.bobsMessageLabel.TabIndex = 0;
            this.bobsMessageLabel.Text = "Bob\'s Message:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(636, 566);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 316;
            this.lineShape4.X2 = 316;
            this.lineShape4.Y1 = 361;
            this.lineShape4.Y2 = 418;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 494;
            this.lineShape3.X2 = 494;
            this.lineShape3.Y1 = 333;
            this.lineShape3.Y2 = 360;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 132;
            this.lineShape2.X2 = 132;
            this.lineShape2.Y1 = 333;
            this.lineShape2.Y2 = 360;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 133;
            this.lineShape1.X2 = 494;
            this.lineShape1.Y1 = 360;
            this.lineShape1.Y2 = 360;
            // 
            // eveGroupBox
            // 
            this.eveGroupBox.Controls.Add(this.eveListBox);
            this.eveGroupBox.Location = new System.Drawing.Point(12, 410);
            this.eveGroupBox.Name = "eveGroupBox";
            this.eveGroupBox.Size = new System.Drawing.Size(609, 144);
            this.eveGroupBox.TabIndex = 5;
            this.eveGroupBox.TabStop = false;
            this.eveGroupBox.Text = "Eve the Eavesdropper";
            // 
            // eveListBox
            // 
            this.eveListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.eveListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.eveListBox.FormattingEnabled = true;
            this.eveListBox.Location = new System.Drawing.Point(7, 18);
            this.eveListBox.Name = "eveListBox";
            this.eveListBox.Size = new System.Drawing.Size(591, 121);
            this.eveListBox.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(546, 338);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // aboutLinkLabel
            // 
            this.aboutLinkLabel.AutoSize = true;
            this.aboutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLinkLabel.Location = new System.Drawing.Point(16, 360);
            this.aboutLinkLabel.Name = "aboutLinkLabel";
            this.aboutLinkLabel.Size = new System.Drawing.Size(90, 18);
            this.aboutLinkLabel.TabIndex = 7;
            this.aboutLinkLabel.TabStop = true;
            this.aboutLinkLabel.Text = "Help/About";
            this.aboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 566);
            this.Controls.Add(this.aboutLinkLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.eveGroupBox);
            this.Controls.Add(this.bobGroupBox);
            this.Controls.Add(this.aliceGroupBox);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(648, 600);
            this.MinimumSize = new System.Drawing.Size(648, 600);
            this.Name = "Form1";
            this.Text = "to be filled out @ runtime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.aliceGroupBox.ResumeLayout(false);
            this.aliceGroupBox.PerformLayout();
            this.bobGroupBox.ResumeLayout(false);
            this.bobGroupBox.PerformLayout();
            this.eveGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alicesMessageLabel;
        private System.Windows.Forms.TextBox alicesMessageTextBox;
        private System.Windows.Forms.GroupBox aliceGroupBox;
        private System.Windows.Forms.GroupBox bobGroupBox;
        private System.Windows.Forms.TextBox alicesPKTextBox;
        private System.Windows.Forms.Label alicesPKLabel;
        private System.Windows.Forms.TextBox bobsMessageTextBox;
        private System.Windows.Forms.Label bobsMessageLabel;
        private System.Windows.Forms.TextBox bobsPKTextBox;
        private System.Windows.Forms.Label bobsPKLabel;
        private System.Windows.Forms.ListBox aliceRecvListBox;
        private System.Windows.Forms.Button aliceSendButton;
        private System.Windows.Forms.ListBox bobRecvListBox;
        private System.Windows.Forms.Button bobSendButton;
        private System.Windows.Forms.Label aliceRecvLabel;
        private System.Windows.Forms.Label bobRecvLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox eveGroupBox;
        private System.Windows.Forms.ListBox eveListBox;
        private System.Windows.Forms.Label primeModLabel;
        private System.Windows.Forms.ComboBox primeModComboBox;
        private System.Windows.Forms.Label generatorLabel;
        private System.Windows.Forms.ComboBox generatorComboBox;
        private System.Windows.Forms.Button newGeneratorButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.LinkLabel aboutLinkLabel;

    }
}

