using BilgeAdam.FileSystem.Extensions;
using System;
using System.IO;
using System.Windows.Forms;

namespace BilgeAdam.FileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(txtPathOrName.Text);
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPathOrName.Text))
            {
                if (IOHelper.HasChildren(txtPathOrName.Text))
                {
                    var result = MessageBox.Show("Klasör içerisinde veri mevcut.\nYine de silmek istiyor musunuz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(txtPathOrName.Text, true);
                    }
                }
                else
                {
                    Directory.Delete(txtPathOrName.Text);
                }
            }
            else
            {
                MessageBox.Show("Klasör Bulunamadı");
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            var text = "Onlar fil değil tavşan";
            File.WriteAllText(txtPathOrName.Text, text);
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPathOrName.Text))
            {
                var result = MessageBox.Show($"{txtPathOrName.Text} dosyasını silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    File.Delete(txtPathOrName.Text);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPathOrName.Text))
            {
                var content = File.ReadAllText(txtPathOrName.Text);
                MessageBox.Show(content);
            }
        }

        private void btnFileSample_Click(object sender, EventArgs e)
        {
            var content = File.ReadAllLines(txtPathOrName.Text);
            var bytes = File.ReadAllBytes(txtPathOrName.Text);
            var str = string.Join(",", bytes);
        }

        private void btnAppendFile_Click(object sender, EventArgs e)
        {
            File.AppendAllText(txtPathOrName.Text, "\r\nhadi bir ara verelim");
        }

        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            File.Encrypt(txtPathOrName.Text);
            //File.Decrypt(txtPathOrName.Text);
        }
    }
}
