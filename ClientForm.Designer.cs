namespace Kapec
{
    partial class ClientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipText = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoPole = new System.Windows.Forms.ListBox();
            this.RTB2 = new System.Windows.Forms.RichTextBox();
            this.SendFile = new System.Windows.Forms.Button();
            this.RashNamePole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.portText = new System.Windows.Forms.MaskedTextBox();
            this.portText2 = new System.Windows.Forms.MaskedTextBox();
            this.AAAaKAk6OMBIT = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ip";
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(49, 6);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(300, 20);
            this.ipText.TabIndex = 12;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(355, 17);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 11;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(272, 579);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 10;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 581);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 9;
            // 
            // infoPole
            // 
            this.infoPole.FormattingEnabled = true;
            this.infoPole.HorizontalScrollbar = true;
            this.infoPole.Location = new System.Drawing.Point(12, 166);
            this.infoPole.Name = "infoPole";
            this.infoPole.Size = new System.Drawing.Size(335, 407);
            this.infoPole.TabIndex = 8;
            // 
            // RTB2
            // 
            this.RTB2.Location = new System.Drawing.Point(353, 457);
            this.RTB2.Name = "RTB2";
            this.RTB2.Size = new System.Drawing.Size(497, 144);
            this.RTB2.TabIndex = 17;
            this.RTB2.Text = "";
            // 
            // SendFile
            // 
            this.SendFile.Location = new System.Drawing.Point(775, 17);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(75, 23);
            this.SendFile.TabIndex = 18;
            this.SendFile.Text = "Send a file";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // RashNamePole
            // 
            this.RashNamePole.Location = new System.Drawing.Point(651, 46);
            this.RashNamePole.Name = "RashNamePole";
            this.RashNamePole.Size = new System.Drawing.Size(199, 20);
            this.RashNamePole.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "portText2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(355, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 285);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(49, 36);
            this.portText.Mask = "00000";
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(300, 20);
            this.portText.TabIndex = 23;
            // 
            // portText2
            // 
            this.portText2.Location = new System.Drawing.Point(70, 62);
            this.portText2.Mask = "00000";
            this.portText2.Name = "portText2";
            this.portText2.Size = new System.Drawing.Size(277, 20);
            this.portText2.TabIndex = 24;
            // 
            // AAAaKAk6OMBIT
            // 
            this.AAAaKAk6OMBIT.Location = new System.Drawing.Point(70, 88);
            this.AAAaKAk6OMBIT.Mask = "00000";
            this.AAAaKAk6OMBIT.Name = "AAAaKAk6OMBIT";
            this.AAAaKAk6OMBIT.Size = new System.Drawing.Size(277, 20);
            this.AAAaKAk6OMBIT.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "portText3";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 613);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AAAaKAk6OMBIT);
            this.Controls.Add(this.portText2);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RashNamePole);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.RTB2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.infoPole);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox infoPole;
        private System.Windows.Forms.RichTextBox RTB2;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.TextBox RashNamePole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox portText;
        private System.Windows.Forms.MaskedTextBox portText2;
        private System.Windows.Forms.MaskedTextBox AAAaKAk6OMBIT;
        private System.Windows.Forms.Label label4;
    }
}