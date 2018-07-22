namespace Kapec
{
    partial class FileConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileConnectForm));
            this.MyDirectTree = new System.Windows.Forms.TreeView();
            this.OtherListBox = new System.Windows.Forms.ListBox();
            this.ReciveFromOtherCompButton = new System.Windows.Forms.Button();
            this.SendFromNyCompButton = new System.Windows.Forms.Button();
            this.MyCopy = new System.Windows.Forms.Button();
            this.MyDelete = new System.Windows.Forms.Button();
            this.MyInsert = new System.Windows.Forms.Button();
            this.OtherInsert = new System.Windows.Forms.Button();
            this.OtherDelete = new System.Windows.Forms.Button();
            this.OtherCopy = new System.Windows.Forms.Button();
            this.OtherListBoxClear = new System.Windows.Forms.Button();
            this.MyListBoxClear = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.ComboboxOfMyComp = new System.Windows.Forms.ComboBox();
            this.ComboboxOfOtherComp = new System.Windows.Forms.ComboBox();
            this.MyListBox = new System.Windows.Forms.ListBox();
            this.OtherStartDirectLoad = new System.Windows.Forms.Button();
            this.OtherFullDirectPole = new System.Windows.Forms.TextBox();
            this.GoZagruzitDirect = new System.Windows.Forms.Button();
            this.GoNazadDirect = new System.Windows.Forms.Button();
            this.OtherCompDirectBox = new System.Windows.Forms.ListView();
            this.OtherDitectIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // MyDirectTree
            // 
            this.MyDirectTree.Location = new System.Drawing.Point(12, 41);
            this.MyDirectTree.Name = "MyDirectTree";
            this.MyDirectTree.Size = new System.Drawing.Size(300, 350);
            this.MyDirectTree.TabIndex = 0;
            this.MyDirectTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.MyDirectTree_BeforeExpand);
            this.MyDirectTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyDirectTree_MouseDoubleClick);
            // 
            // OtherListBox
            // 
            this.OtherListBox.FormattingEnabled = true;
            this.OtherListBox.Location = new System.Drawing.Point(399, 12);
            this.OtherListBox.Name = "OtherListBox";
            this.OtherListBox.Size = new System.Drawing.Size(206, 108);
            this.OtherListBox.TabIndex = 2;
            // 
            // ReciveFromOtherCompButton
            // 
            this.ReciveFromOtherCompButton.Location = new System.Drawing.Point(318, 12);
            this.ReciveFromOtherCompButton.Name = "ReciveFromOtherCompButton";
            this.ReciveFromOtherCompButton.Size = new System.Drawing.Size(75, 23);
            this.ReciveFromOtherCompButton.TabIndex = 4;
            this.ReciveFromOtherCompButton.Text = "Забрать";
            this.ReciveFromOtherCompButton.UseVisualStyleBackColor = true;
            // 
            // SendFromNyCompButton
            // 
            this.SendFromNyCompButton.Location = new System.Drawing.Point(530, 283);
            this.SendFromNyCompButton.Name = "SendFromNyCompButton";
            this.SendFromNyCompButton.Size = new System.Drawing.Size(75, 23);
            this.SendFromNyCompButton.TabIndex = 5;
            this.SendFromNyCompButton.Text = "Послать";
            this.SendFromNyCompButton.UseVisualStyleBackColor = true;
            // 
            // MyCopy
            // 
            this.MyCopy.Location = new System.Drawing.Point(12, 397);
            this.MyCopy.Name = "MyCopy";
            this.MyCopy.Size = new System.Drawing.Size(60, 30);
            this.MyCopy.TabIndex = 6;
            this.MyCopy.Text = "Copy";
            this.MyCopy.UseVisualStyleBackColor = true;
            // 
            // MyDelete
            // 
            this.MyDelete.Location = new System.Drawing.Point(144, 397);
            this.MyDelete.Name = "MyDelete";
            this.MyDelete.Size = new System.Drawing.Size(60, 30);
            this.MyDelete.TabIndex = 7;
            this.MyDelete.Text = "Delete";
            this.MyDelete.UseVisualStyleBackColor = true;
            this.MyDelete.Click += new System.EventHandler(this.MyDelete_Click);
            // 
            // MyInsert
            // 
            this.MyInsert.Location = new System.Drawing.Point(78, 397);
            this.MyInsert.Name = "MyInsert";
            this.MyInsert.Size = new System.Drawing.Size(60, 30);
            this.MyInsert.TabIndex = 8;
            this.MyInsert.Text = "Insert";
            this.MyInsert.UseVisualStyleBackColor = true;
            // 
            // OtherInsert
            // 
            this.OtherInsert.Location = new System.Drawing.Point(1006, 387);
            this.OtherInsert.Name = "OtherInsert";
            this.OtherInsert.Size = new System.Drawing.Size(60, 30);
            this.OtherInsert.TabIndex = 11;
            this.OtherInsert.Text = "Insert";
            this.OtherInsert.UseVisualStyleBackColor = true;
            // 
            // OtherDelete
            // 
            this.OtherDelete.Location = new System.Drawing.Point(1072, 387);
            this.OtherDelete.Name = "OtherDelete";
            this.OtherDelete.Size = new System.Drawing.Size(60, 30);
            this.OtherDelete.TabIndex = 10;
            this.OtherDelete.Text = "Delete";
            this.OtherDelete.UseVisualStyleBackColor = true;
            // 
            // OtherCopy
            // 
            this.OtherCopy.Location = new System.Drawing.Point(940, 387);
            this.OtherCopy.Name = "OtherCopy";
            this.OtherCopy.Size = new System.Drawing.Size(60, 30);
            this.OtherCopy.TabIndex = 9;
            this.OtherCopy.Text = "Copy";
            this.OtherCopy.UseVisualStyleBackColor = true;
            // 
            // OtherListBoxClear
            // 
            this.OtherListBoxClear.Location = new System.Drawing.Point(318, 41);
            this.OtherListBoxClear.Name = "OtherListBoxClear";
            this.OtherListBoxClear.Size = new System.Drawing.Size(75, 23);
            this.OtherListBoxClear.TabIndex = 12;
            this.OtherListBoxClear.Text = "Clear";
            this.OtherListBoxClear.UseVisualStyleBackColor = true;
            this.OtherListBoxClear.Click += new System.EventHandler(this.OtherListBoxClear_Click);
            // 
            // MyListBoxClear
            // 
            this.MyListBoxClear.Location = new System.Drawing.Point(530, 312);
            this.MyListBoxClear.Name = "MyListBoxClear";
            this.MyListBoxClear.Size = new System.Drawing.Size(75, 23);
            this.MyListBoxClear.TabIndex = 13;
            this.MyListBoxClear.Text = "Clear";
            this.MyListBoxClear.UseVisualStyleBackColor = true;
            this.MyListBoxClear.Click += new System.EventHandler(this.MyListBoxClear_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(252, 397);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 30);
            this.button9.TabIndex = 14;
            this.button9.Tag = "";
            this.button9.Text = "Reload";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1138, 387);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 30);
            this.button10.TabIndex = 15;
            this.button10.Tag = "";
            this.button10.Text = "Reload";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // ComboboxOfMyComp
            // 
            this.ComboboxOfMyComp.FormattingEnabled = true;
            this.ComboboxOfMyComp.Location = new System.Drawing.Point(12, 12);
            this.ComboboxOfMyComp.Name = "ComboboxOfMyComp";
            this.ComboboxOfMyComp.Size = new System.Drawing.Size(300, 21);
            this.ComboboxOfMyComp.TabIndex = 16;
            this.ComboboxOfMyComp.SelectedIndexChanged += new System.EventHandler(this.ComboboxOfMyComp_SelectedIndexChanged);
            this.ComboboxOfMyComp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboboxOfMyComp_MouseClick);
            // 
            // ComboboxOfOtherComp
            // 
            this.ComboboxOfOtherComp.FormattingEnabled = true;
            this.ComboboxOfOtherComp.Location = new System.Drawing.Point(611, 12);
            this.ComboboxOfOtherComp.Name = "ComboboxOfOtherComp";
            this.ComboboxOfOtherComp.Size = new System.Drawing.Size(116, 21);
            this.ComboboxOfOtherComp.TabIndex = 17;
            this.ComboboxOfOtherComp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboboxOfOtherComp_MouseClick);
            // 
            // MyListBox
            // 
            this.MyListBox.FormattingEnabled = true;
            this.MyListBox.Location = new System.Drawing.Point(318, 283);
            this.MyListBox.Name = "MyListBox";
            this.MyListBox.Size = new System.Drawing.Size(206, 108);
            this.MyListBox.TabIndex = 3;
            // 
            // OtherStartDirectLoad
            // 
            this.OtherStartDirectLoad.Location = new System.Drawing.Point(733, 12);
            this.OtherStartDirectLoad.Name = "OtherStartDirectLoad";
            this.OtherStartDirectLoad.Size = new System.Drawing.Size(75, 23);
            this.OtherStartDirectLoad.TabIndex = 23;
            this.OtherStartDirectLoad.Text = "Load disk";
            this.OtherStartDirectLoad.UseVisualStyleBackColor = true;
            this.OtherStartDirectLoad.Click += new System.EventHandler(this.OtherStartDirectLoad_Click);
            // 
            // OtherFullDirectPole
            // 
            this.OtherFullDirectPole.Location = new System.Drawing.Point(861, 15);
            this.OtherFullDirectPole.Name = "OtherFullDirectPole";
            this.OtherFullDirectPole.Size = new System.Drawing.Size(255, 20);
            this.OtherFullDirectPole.TabIndex = 26;
            // 
            // GoZagruzitDirect
            // 
            this.GoZagruzitDirect.Location = new System.Drawing.Point(1122, 13);
            this.GoZagruzitDirect.Name = "GoZagruzitDirect";
            this.GoZagruzitDirect.Size = new System.Drawing.Size(75, 23);
            this.GoZagruzitDirect.TabIndex = 27;
            this.GoZagruzitDirect.Text = "Load";
            this.GoZagruzitDirect.UseVisualStyleBackColor = true;
            this.GoZagruzitDirect.Click += new System.EventHandler(this.GoZagruzitDirect_Click);
            // 
            // GoNazadDirect
            // 
            this.GoNazadDirect.Location = new System.Drawing.Point(815, 11);
            this.GoNazadDirect.Name = "GoNazadDirect";
            this.GoNazadDirect.Size = new System.Drawing.Size(40, 23);
            this.GoNazadDirect.TabIndex = 28;
            this.GoNazadDirect.Text = "<=";
            this.GoNazadDirect.UseVisualStyleBackColor = true;
            this.GoNazadDirect.Click += new System.EventHandler(this.GoNazadDirect_Click);
            // 
            // OtherCompDirectBox
            // 
            this.OtherCompDirectBox.LargeImageList = this.OtherDitectIcons;
            this.OtherCompDirectBox.Location = new System.Drawing.Point(611, 41);
            this.OtherCompDirectBox.MultiSelect = false;
            this.OtherCompDirectBox.Name = "OtherCompDirectBox";
            this.OtherCompDirectBox.Size = new System.Drawing.Size(586, 340);
            this.OtherCompDirectBox.TabIndex = 29;
            this.OtherCompDirectBox.UseCompatibleStateImageBehavior = false;
            this.OtherCompDirectBox.DoubleClick += new System.EventHandler(this.OtherCompDirectBox_DoubleClick);
            // 
            // OtherDitectIcons
            // 
            this.OtherDitectIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("OtherDitectIcons.ImageStream")));
            this.OtherDitectIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.OtherDitectIcons.Images.SetKeyName(0, "AudioIcon.png");
            this.OtherDitectIcons.Images.SetKeyName(1, "EXEIcon.png");
            this.OtherDitectIcons.Images.SetKeyName(2, "FileIcon.png");
            this.OtherDitectIcons.Images.SetKeyName(3, "PapkaIcon.png");
            this.OtherDitectIcons.Images.SetKeyName(4, "TextIcon.png");
            this.OtherDitectIcons.Images.SetKeyName(5, "VideoIcon.png");
            this.OtherDitectIcons.Images.SetKeyName(6, "ImageIcon.png");
            // 
            // FileConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 427);
            this.Controls.Add(this.OtherCompDirectBox);
            this.Controls.Add(this.GoNazadDirect);
            this.Controls.Add(this.GoZagruzitDirect);
            this.Controls.Add(this.OtherFullDirectPole);
            this.Controls.Add(this.OtherStartDirectLoad);
            this.Controls.Add(this.ComboboxOfOtherComp);
            this.Controls.Add(this.ComboboxOfMyComp);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.MyListBoxClear);
            this.Controls.Add(this.OtherListBoxClear);
            this.Controls.Add(this.OtherInsert);
            this.Controls.Add(this.OtherDelete);
            this.Controls.Add(this.OtherCopy);
            this.Controls.Add(this.MyInsert);
            this.Controls.Add(this.MyDelete);
            this.Controls.Add(this.MyCopy);
            this.Controls.Add(this.SendFromNyCompButton);
            this.Controls.Add(this.ReciveFromOtherCompButton);
            this.Controls.Add(this.MyListBox);
            this.Controls.Add(this.OtherListBox);
            this.Controls.Add(this.MyDirectTree);
            this.Name = "FileConnectForm";
            this.Text = "FileConnectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox OtherListBox;
        private System.Windows.Forms.Button ReciveFromOtherCompButton;
        private System.Windows.Forms.Button SendFromNyCompButton;
        private System.Windows.Forms.Button MyCopy;
        private System.Windows.Forms.Button MyDelete;
        private System.Windows.Forms.Button MyInsert;
        private System.Windows.Forms.Button OtherInsert;
        private System.Windows.Forms.Button OtherDelete;
        private System.Windows.Forms.Button OtherCopy;
        private System.Windows.Forms.Button OtherListBoxClear;
        private System.Windows.Forms.Button MyListBoxClear;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.TreeView MyDirectTree;
        public System.Windows.Forms.ComboBox ComboboxOfMyComp;
        public System.Windows.Forms.ComboBox ComboboxOfOtherComp;
        public System.Windows.Forms.ListBox MyListBox;
        private System.Windows.Forms.Button OtherStartDirectLoad;
        private System.Windows.Forms.TextBox OtherFullDirectPole;
        private System.Windows.Forms.Button GoZagruzitDirect;
        private System.Windows.Forms.Button GoNazadDirect;
        private System.Windows.Forms.ListView OtherCompDirectBox;
        private System.Windows.Forms.ImageList OtherDitectIcons;
    }
}