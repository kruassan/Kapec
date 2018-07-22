namespace Kapec
{
    partial class ServerForm
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
            this.infoPole = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SendButton01 = new System.Windows.Forms.Button();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckCursorGo = new System.Windows.Forms.CheckBox();
            this.StreamPortText = new System.Windows.Forms.MaskedTextBox();
            this.portText = new System.Windows.Forms.MaskedTextBox();
            this.ipText = new System.Windows.Forms.TextBox();
            this.CheckCursorClick = new System.Windows.Forms.CheckBox();
            this.FilesConnectButton = new System.Windows.Forms.Button();
            this.SendAfile = new System.Windows.Forms.Button();
            this.RashNamePole = new System.Windows.Forms.TextBox();
            this.FandTVPortText = new System.Windows.Forms.MaskedTextBox();
            this.qeqwefadsafqwer = new System.Windows.Forms.Label();
            this.StreamChB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoPole
            // 
            this.infoPole.FormattingEnabled = true;
            this.infoPole.Location = new System.Drawing.Point(12, 131);
            this.infoPole.Name = "infoPole";
            this.infoPole.Size = new System.Drawing.Size(194, 290);
            this.infoPole.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(131, 427);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(353, 17);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "port";
            // 
            // PB1
            // 
            this.PB1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PB1.Location = new System.Drawing.Point(633, 6);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(800, 450);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB1.TabIndex = 9;
            this.PB1.TabStop = false;
            this.PB1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB1_MouseClick);
            this.PB1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB1_MouseMove_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1162, 462);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1162, 500);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1300, 500);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(133, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1300, 462);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(133, 20);
            this.textBox5.TabIndex = 12;
            // 
            // SendButton01
            // 
            this.SendButton01.Location = new System.Drawing.Point(1069, 462);
            this.SendButton01.Name = "SendButton01";
            this.SendButton01.Size = new System.Drawing.Size(75, 23);
            this.SendButton01.TabIndex = 14;
            this.SendButton01.Text = "Send";
            this.SendButton01.UseVisualStyleBackColor = true;
            this.SendButton01.Click += new System.EventHandler(this.SendButton01_Click);
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(237, 131);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(390, 448);
            this.RTB1.TabIndex = 15;
            this.RTB1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stram port";
            // 
            // CheckCursorGo
            // 
            this.CheckCursorGo.AutoSize = true;
            this.CheckCursorGo.Location = new System.Drawing.Point(735, 465);
            this.CheckCursorGo.Name = "CheckCursorGo";
            this.CheckCursorGo.Size = new System.Drawing.Size(91, 17);
            this.CheckCursorGo.TabIndex = 19;
            this.CheckCursorGo.Text = "ZombieCursor";
            this.CheckCursorGo.UseVisualStyleBackColor = true;
            // 
            // StreamPortText
            // 
            this.StreamPortText.Location = new System.Drawing.Point(73, 61);
            this.StreamPortText.Mask = "00000";
            this.StreamPortText.Name = "StreamPortText";
            this.StreamPortText.Size = new System.Drawing.Size(274, 20);
            this.StreamPortText.TabIndex = 21;
            // 
            // portText
            // 
            this.portText.Location = new System.Drawing.Point(47, 36);
            this.portText.Mask = "00000";
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(300, 20);
            this.portText.TabIndex = 22;
            // 
            // ipText
            // 
            this.ipText.Location = new System.Drawing.Point(47, 6);
            this.ipText.Name = "ipText";
            this.ipText.Size = new System.Drawing.Size(300, 20);
            this.ipText.TabIndex = 4;
            // 
            // CheckCursorClick
            // 
            this.CheckCursorClick.AutoSize = true;
            this.CheckCursorClick.Location = new System.Drawing.Point(633, 466);
            this.CheckCursorClick.Name = "CheckCursorClick";
            this.CheckCursorClick.Size = new System.Drawing.Size(79, 17);
            this.CheckCursorClick.TabIndex = 23;
            this.CheckCursorClick.Text = "CursorClick";
            this.CheckCursorClick.UseVisualStyleBackColor = true;
            // 
            // FilesConnectButton
            // 
            this.FilesConnectButton.Location = new System.Drawing.Point(434, 17);
            this.FilesConnectButton.Name = "FilesConnectButton";
            this.FilesConnectButton.Size = new System.Drawing.Size(193, 23);
            this.FilesConnectButton.TabIndex = 24;
            this.FilesConnectButton.Text = "FilesFilesFiles";
            this.FilesConnectButton.UseVisualStyleBackColor = true;
            this.FilesConnectButton.Click += new System.EventHandler(this.FilesConnectButton_Click);
            // 
            // SendAfile
            // 
            this.SendAfile.Location = new System.Drawing.Point(1069, 500);
            this.SendAfile.Name = "SendAfile";
            this.SendAfile.Size = new System.Drawing.Size(75, 23);
            this.SendAfile.TabIndex = 25;
            this.SendAfile.Text = "Send a file";
            this.SendAfile.UseVisualStyleBackColor = true;
            this.SendAfile.Click += new System.EventHandler(this.SendAfile_Click);
            // 
            // RashNamePole
            // 
            this.RashNamePole.Location = new System.Drawing.Point(1069, 529);
            this.RashNamePole.Name = "RashNamePole";
            this.RashNamePole.Size = new System.Drawing.Size(225, 20);
            this.RashNamePole.TabIndex = 26;
            // 
            // FandTVPortText
            // 
            this.FandTVPortText.Location = new System.Drawing.Point(73, 87);
            this.FandTVPortText.Mask = "00000";
            this.FandTVPortText.Name = "FandTVPortText";
            this.FandTVPortText.Size = new System.Drawing.Size(274, 20);
            this.FandTVPortText.TabIndex = 27;
            // 
            // qeqwefadsafqwer
            // 
            this.qeqwefadsafqwer.AutoSize = true;
            this.qeqwefadsafqwer.Location = new System.Drawing.Point(12, 90);
            this.qeqwefadsafqwer.Name = "qeqwefadsafqwer";
            this.qeqwefadsafqwer.Size = new System.Drawing.Size(54, 13);
            this.qeqwefadsafqwer.TabIndex = 28;
            this.qeqwefadsafqwer.Text = "FaTV port";
            // 
            // StreamChB
            // 
            this.StreamChB.AutoSize = true;
            this.StreamChB.Location = new System.Drawing.Point(841, 464);
            this.StreamChB.Name = "StreamChB";
            this.StreamChB.Size = new System.Drawing.Size(80, 17);
            this.StreamChB.TabIndex = 29;
            this.StreamChB.Text = "checkBox1";
            this.StreamChB.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 591);
            this.Controls.Add(this.StreamChB);
            this.Controls.Add(this.qeqwefadsafqwer);
            this.Controls.Add(this.FandTVPortText);
            this.Controls.Add(this.RashNamePole);
            this.Controls.Add(this.SendAfile);
            this.Controls.Add(this.FilesConnectButton);
            this.Controls.Add(this.CheckCursorClick);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.StreamPortText);
            this.Controls.Add(this.CheckCursorGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTB1);
            this.Controls.Add(this.SendButton01);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipText);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.infoPole);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox infoPole;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button SendButton01;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckCursorGo;
        private System.Windows.Forms.MaskedTextBox StreamPortText;
        private System.Windows.Forms.MaskedTextBox portText;
        private System.Windows.Forms.TextBox ipText;
        private System.Windows.Forms.CheckBox CheckCursorClick;
        private System.Windows.Forms.Button FilesConnectButton;
        private System.Windows.Forms.Button SendAfile;
        private System.Windows.Forms.TextBox RashNamePole;
        private System.Windows.Forms.MaskedTextBox FandTVPortText;
        private System.Windows.Forms.Label qeqwefadsafqwer;
        private System.Windows.Forms.CheckBox StreamChB;
    }
}