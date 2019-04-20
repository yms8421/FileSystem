namespace BilgeAdam.FileInformation
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
            this.lstContents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathOrName = new System.Windows.Forms.TextBox();
            this.trvStructure = new System.Windows.Forms.TreeView();
            this.lsvInfo = new System.Windows.Forms.ListView();
            this.lscName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lscType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lscSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lscLastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstContents
            // 
            this.lstContents.FormattingEnabled = true;
            this.lstContents.Location = new System.Drawing.Point(12, 44);
            this.lstContents.Name = "lstContents";
            this.lstContents.Size = new System.Drawing.Size(225, 394);
            this.lstContents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yardımcı Değerler";
            // 
            // txtPathOrName
            // 
            this.txtPathOrName.Location = new System.Drawing.Point(128, 13);
            this.txtPathOrName.Name = "txtPathOrName";
            this.txtPathOrName.Size = new System.Drawing.Size(863, 20);
            this.txtPathOrName.TabIndex = 2;
            // 
            // trvStructure
            // 
            this.trvStructure.ImageIndex = 0;
            this.trvStructure.ImageList = this.imlIcons;
            this.trvStructure.Location = new System.Drawing.Point(243, 44);
            this.trvStructure.Name = "trvStructure";
            this.trvStructure.SelectedImageIndex = 0;
            this.trvStructure.Size = new System.Drawing.Size(285, 394);
            this.trvStructure.TabIndex = 3;
            this.trvStructure.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvStructure_NodeMouseDoubleClick);
            // 
            // lsvInfo
            // 
            this.lsvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lscName,
            this.lscType,
            this.lscSize,
            this.lscLastModified});
            this.lsvInfo.LargeImageList = this.imlIcons;
            this.lsvInfo.Location = new System.Drawing.Point(534, 44);
            this.lsvInfo.Name = "lsvInfo";
            this.lsvInfo.Size = new System.Drawing.Size(585, 394);
            this.lsvInfo.SmallImageList = this.imlIcons;
            this.lsvInfo.TabIndex = 4;
            this.lsvInfo.UseCompatibleStateImageBehavior = false;
            // 
            // lscName
            // 
            this.lscName.Text = "Ad";
            this.lscName.Width = 180;
            // 
            // lscType
            // 
            this.lscType.Text = "Tür";
            // 
            // lscSize
            // 
            this.lscSize.Text = "Boyut";
            // 
            // lscLastModified
            // 
            this.lscLastModified.Text = "Değiştirme Tarihi";
            this.lscLastModified.Width = 150;
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "folder.png");
            this.imlIcons.Images.SetKeyName(1, "image.png");
            this.imlIcons.Images.SetKeyName(2, "json.png");
            this.imlIcons.Images.SetKeyName(3, "text.png");
            this.imlIcons.Images.SetKeyName(4, "other.png");
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(997, 11);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(122, 23);
            this.btnGetInfo.TabIndex = 5;
            this.btnGetInfo.Text = "Getir";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.lsvInfo);
            this.Controls.Add(this.trvStructure);
            this.Controls.Add(this.txtPathOrName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dosya Bilgisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathOrName;
        private System.Windows.Forms.TreeView trvStructure;
        private System.Windows.Forms.ListView lsvInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.ColumnHeader lscName;
        private System.Windows.Forms.ColumnHeader lscType;
        private System.Windows.Forms.ColumnHeader lscSize;
        private System.Windows.Forms.ColumnHeader lscLastModified;
        private System.Windows.Forms.ImageList imlIcons;
    }
}

