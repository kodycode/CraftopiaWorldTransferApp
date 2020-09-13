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
        string srcSaveDataContent;
        JObject srcSavedData;
        JObject dstSavedData;
        bool isJSON = false;

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
            string currentFileName = dstSaveDataTxt.Text;
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
                Title = "Browse .ocs/.json files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "ocs",
                Filter = "(*.json, *.ocs)|*.json;*.ocs",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                srcList.Items.Clear();
                srcSaveDataTxt.Text = openFileDialog1.FileName;
                if (openFileDialog1.FileName.EndsWith(".json"))
                {
                    srcSaveDataContent = File.ReadAllText(srcSaveDataTxt.Text);
                    isJSON = true;
                    ExportBtn.Enabled = false;
                    srcList.Items.Add(new FileInfo(openFileDialog1.FileName).Name.Replace(".json", ""));
                    srcList.SetSelected(0, true);
                }
                else
                {
                    isJSON = false;
                    ExportBtn.Enabled = true;
                    srcSavedData = DecompressSavedData(new FileInfo(openFileDialog1.FileName));
                    foreach (var world in srcSavedData["WorldListSave"]["value"])
                    {
                        srcList.Items.Add(world["name"]);
                    }
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
                dstList.Items.Clear();
                dstSaveDataTxt.Text = openFileDialog1.FileName;
                dstSavedData = DecompressSavedData(new FileInfo(openFileDialog1.FileName));
                foreach (var world in dstSavedData["WorldListSave"]["value"])
                {
                    dstList.Items.Add(world["name"]);
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void transferWorldBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(dstSaveDataTxt.Text))
            {
                if (srcList.SelectedIndex != -1)
                {
                    JToken sourceWorld;
                    if (isJSON)
                    {
                        sourceWorld = JToken.Parse(srcSaveDataContent);
                    }
                    else
                    {
                        sourceWorld = srcSavedData["WorldListSave"]["value"][srcList.SelectedIndex];
                    }
                    dstSavedData["WorldListSave"]["value"][0].AddBeforeSelf(sourceWorld);
                    CompressNewSavedData(dstSavedData);
                    dstList.Items.Insert(0, srcList.SelectedItem.ToString());
                    MessageBox.Show("World has been successfully transferred to the " +
                        $"designated save file:\n({dstSaveDataTxt.Text}).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Click on a world to transfer from the source box " +
                        "and click 'Transfer World' to import it over.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Destination file path does not exist. Please enter a valid file path. ",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (!isJSON)
            {
                if (srcList.SelectedIndex != -1)
                {
                    JToken sourceWorld = srcSavedData["WorldListSave"]["value"][srcList.SelectedIndex];
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/world");
                    File.WriteAllText($"{Directory.GetCurrentDirectory()}/world/{srcList.SelectedItem.ToString() + ".json"}", sourceWorld.ToString());
                    MessageBox.Show("World has been successfully exported to:\n" +
                        $"({Directory.GetCurrentDirectory()}+/world/{srcList.SelectedItem.ToString() + ".json"}).", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Click on a world to export from the source box " +
                        "and click 'Export World' to export the world as a separate file.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The World you want to export is already a JSON file",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
