using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.FileInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPathOrName.Text = @"C:\Code";
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (!Path.IsPathRooted(txtPathOrName.Text))
            {
                MessageBox.Show("Girilen değer bir dosya ya da klasör yolu değil");
                return;
            }

            SetListBox();
            SetListView();
        }

        private void SetListBox()
        {
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
                var size = info.Length / 1024 > 0 ? (info.Length / 1024) + " KB" : info.Length + " B";
                lstContents.Items.Add($"(D) {info.Name} - {size}");
            }
        }

        private void SetListView()
        {
            //TODO: lsvInfo.View = View.Details;  bu olacak
            lsvInfo.View = View.List;
            var folders = Directory.GetDirectories(txtPathOrName.Text);
            foreach (var folder in folders)
            {
                var info = new DirectoryInfo(folder);
                lsvInfo.Items.Add(new ListViewItem(info.Name));
            }

            var files = Directory.GetFiles(txtPathOrName.Text);
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                lsvInfo.Items.Add(new ListViewItem(info.Name));
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
            else if(value < 0)
            {
                message = "Negatif";
            }
            else
            {
                message = "Sıfır";
            }

            message = value > 0 ? "Pozitif" : value < 0 ? "Negatif" : "Sıfır";
        }
    }
}
