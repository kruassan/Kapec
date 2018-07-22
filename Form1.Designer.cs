namespace Kapec
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.CreateServerButton = new System.Windows.Forms.Button();
			this.ConnectToSetverButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CreateServerButton
			// 
			this.CreateServerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateServerButton.Location = new System.Drawing.Point(12, 15);
			this.CreateServerButton.Name = "CreateServerButton";
			this.CreateServerButton.Size = new System.Drawing.Size(150, 38);
			this.CreateServerButton.TabIndex = 0;
			this.CreateServerButton.Text = "Create server";
			this.CreateServerButton.UseVisualStyleBackColor = true;
			this.CreateServerButton.Click += new System.EventHandler(this.button1_Click);
			this.CreateServerButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			// 
			// ConnectToSetverButton
			// 
			this.ConnectToSetverButton.Location = new System.Drawing.Point(12, 65);
			this.ConnectToSetverButton.Name = "ConnectToSetverButton";
			this.ConnectToSetverButton.Size = new System.Drawing.Size(150, 37);
			this.ConnectToSetverButton.TabIndex = 1;
			this.ConnectToSetverButton.Text = "Connect to server";
			this.ConnectToSetverButton.UseVisualStyleBackColor = true;
			this.ConnectToSetverButton.Click += new System.EventHandler(this.ConnectToSetverButton_Click);
			this.ConnectToSetverButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(189, 114);
			this.Controls.Add(this.ConnectToSetverButton);
			this.Controls.Add(this.CreateServerButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateServerButton;
        private System.Windows.Forms.Button ConnectToSetverButton;
    }
}

