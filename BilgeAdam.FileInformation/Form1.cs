using BilgeAdam.FileInformation.Enums;
using BilgeAdam.FileInformation.Extensions;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace BilgeAdam.FileInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lsvInfo.View = View.Details;
#if DEBUG
            txtPathOrName.Text = @"C:\Code";
#endif
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (!Path.IsPathRooted(txtPathOrName.Text))
            {
                MessageBox.Show("Girilen değer bir dosya ya da klasör yolu değil");
                return;
            }
            if (!Directory.Exists(txtPathOrName.Text))
            {
                MessageBox.Show("Belirtilen yol bulunamadı");
                return;
            }

            SetListBox();
            SetListView();
            SetTreeView();
        }

        private void SetTreeView()
        {
            trvStructure.Nodes.Clear();
            var folders = Directory.GetDirectories(txtPathOrName.Text);
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                var node = new TreeNode(info.Name, (int)ImageCode.Folder, (int)ImageCode.Folder);
                CreateNode(node, folder);
                trvStructure.Nodes.Add(node);
            }

            var files = Directory.GetFiles(txtPathOrName.Text);
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                var node = new TreeNode(info.Name, info.FullName.GetImageKey(), info.FullName.GetImageKey());
                node.Tag = file;
                trvStructure.Nodes.Add(node);
            }
        }

        private void CreateNode(TreeNode parent, string path)
        {
            var folders = Directory.GetDirectories(path);
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                var node = new TreeNode(info.Name, (int)ImageCode.Folder, (int)ImageCode.Folder);
                CreateNode(node, folder);
                parent.Nodes.Add(node);
            }

            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                var node = new TreeNode(info.Name, info.FullName.GetImageKey(), info.FullName.GetImageKey());
                node.Tag = file;
                parent.Nodes.Add(node);
            }
        }

        private void SetListBox()
        {
            lstContents.Items.Clear();
            var folders = Directory.GetDirectories(txtPathOrName.Text);
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                lstContents.Items.Add($"(K) {info.Name}");
            }

            var files = Directory.GetFiles(txtPathOrName.Text);
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                lstContents.Items.Add($"(D) {info.Name} - {info.Length.GetSize()}");
            }
        }

        private void SetListView()
        {
            lsvInfo.Items.Clear();
            //lsvInfo.View = View.List;
            var folders = Directory.GetDirectories(txtPathOrName.Text);
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                var item = new ListViewItem(info.Name)
                {
                    ImageIndex = (int)ImageCode.Folder
                };
                item.SubItems.Add("Klasör");
                item.SubItems.Add("");
                item.SubItems.Add(info.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss"));
                lsvInfo.Items.Add(item);
            }

            var files = Directory.GetFiles(txtPathOrName.Text);
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                var item = new ListViewItem(info.Name);
                item.ImageIndex = info.FullName.GetImageKey();
                item.SubItems.Add("Dosya");
                item.SubItems.Add(info.Length.GetSize());
                item.SubItems.Add(info.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss"));
                lsvInfo.Items.Add(item);
            }
        }

        private void ExampleForTernaryIf()
        {
            var message = "";
            var value = 0;
            if (value > 0)
            {
                message = "Pozitif";
            }
            else if (value < 0)
            {
                message = "Negatif";
            }
            else
            {
                message = "Sıfır";
            }

            message = value > 0 ? "Pozitif" : value < 0 ? "Negatif" : "Sıfır";
        }

        private void trvStructure_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Process.Start(e.Node.Tag.ToString());
            }
        }
    }
}
