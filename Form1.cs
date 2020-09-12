using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CraftopiaWorldTransferApp
{
    public partial class Form1 : Form
    {
        JObject srcSavedData;
        JObject dstSavedData;

        public JObject DecompressSavedData(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                {
                    StreamReader reader = new StreamReader(decompressionStream);
                    JObject savedData = JObject.Parse(reader.ReadToEnd());
                    return savedData;
                }
            }
        }

        public void CompressNewSavedData(JObject dstSavedData)
        {
            string currentFileName = textBox2.Text;
            using (FileStream compressedFileStream = File.Create(currentFileName))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(dstSavedData.ToString());
                    MemoryStream dstStream = new MemoryStream(byteArray);
                    dstStream.CopyTo(compressionStream);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BrowseButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse .ocs files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "ocs",
                Filter = "ocs files (*.ocs)|*.ocs",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                textBox1.Text = openFileDialog1.FileName;
                srcSavedData = DecompressSavedData(new FileInfo(openFileDialog1.FileName));
                foreach (var world in srcSavedData["WorldListSave"]["value"])
                {
                    listBox1.Items.Add(world["name"]);
                }
            }
        }

        private void BrowseButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse .ocs files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "ocs",
                Filter = "ocs files (*.ocs)|*.ocs",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox2.Items.Clear();
                textBox2.Text = openFileDialog1.FileName;
                dstSavedData = DecompressSavedData(new FileInfo(openFileDialog1.FileName));
                foreach (var world in dstSavedData["WorldListSave"]["value"])
                {
                    listBox2.Items.Add(world["name"]);
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                JToken sourceWorld = srcSavedData["WorldListSave"]["value"][listBox1.SelectedIndex];
                dstSavedData["WorldListSave"]["value"][0].AddBeforeSelf(sourceWorld);
                CompressNewSavedData(dstSavedData);
                listBox2.Items.Insert(0, listBox1.SelectedItem.ToString());
                MessageBox.Show("World has been successfully transferred to the " +
                    $"designated save file:\n({textBox2.Text}).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Click on a world to transfer from the source box "+
                    "and click 'Transfer' to import it over.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
