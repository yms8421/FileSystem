namespace BilgeAdam.FileSystem
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
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnFileSample = new System.Windows.Forms.Button();
            this.btnAppendFile = new System.Windows.Forms.Button();
            this.btnEncryptDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathOrName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(110, 46);
            this.btnNewFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(161, 30);
            this.btnNewFolder.TabIndex = 0;
            this.btnNewFolder.Text = "Yeni Klasör";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(110, 84);
            this.btnDeleteFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(161, 30);
            this.btnDeleteFolder.TabIndex = 0;
            this.btnDeleteFolder.Text = "Klasör Sil";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(110, 122);
            this.btnNewFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(161, 30);
            this.btnNewFile.TabIndex = 0;
            this.btnNewFile.Text = "Dosya Oluştur";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(110, 160);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(161, 30);
            this.btnDeleteFile.TabIndex = 0;
            this.btnDeleteFile.Text = "Dosya Sil";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(278, 46);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(161, 30);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Dosya Aç";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnFileSample
            // 
            this.btnFileSample.Location = new System.Drawing.Point(278, 84);
            this.btnFileSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFileSample.Name = "btnFileSample";
            this.btnFileSample.Size = new System.Drawing.Size(161, 30);
            this.btnFileSample.TabIndex = 0;
            this.btnFileSample.Text = "Dosya İşlemleri";
            this.btnFileSample.UseVisualStyleBackColor = true;
            this.btnFileSample.Click += new System.EventHandler(this.btnFileSample_Click);
            // 
            // btnAppendFile
            // 
            this.btnAppendFile.Location = new System.Drawing.Point(278, 122);
            this.btnAppendFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppendFile.Name = "btnAppendFile";
            this.btnAppendFile.Size = new System.Drawing.Size(161, 30);
            this.btnAppendFile.TabIndex = 0;
            this.btnAppendFile.Text = "Sonuna Ekle";
            this.btnAppendFile.UseVisualStyleBackColor = true;
            this.btnAppendFile.Click += new System.EventHandler(this.btnAppendFile_Click);
            // 
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(278, 160);
            this.btnEncryptDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(161, 30);
            this.btnEncryptDecrypt.TabIndex = 0;
            this.btnEncryptDecrypt.Text = "Şifrele";
            this.btnEncryptDecrypt.UseVisualStyleBackColor = true;
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.btnEncryptDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yardımcı Bilgi";
            // 
            // txtPathOrName
            // 
            this.txtPathOrName.Location = new System.Drawing.Point(110, 13);
            this.txtPathOrName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPathOrName.Name = "txtPathOrName";
            this.txtPathOrName.Size = new System.Drawing.Size(507, 25);
            this.txtPathOrName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 201);
            this.Controls.Add(this.txtPathOrName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.btnFileSample);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnAppendFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.btnNewFolder);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dosya ve Klasör İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnFileSample;
        private System.Windows.Forms.Button btnAppendFile;
        private System.Windows.Forms.Button btnEncryptDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathOrName;
    }
}

