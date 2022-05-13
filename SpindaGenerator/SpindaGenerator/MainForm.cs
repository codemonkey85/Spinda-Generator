using Spinda;
using System;
using System.IO;
using System.Windows.Forms;

namespace SpindaGenerator
{
    public partial class MainForm : Form
    {
        private SelectedGeneration selectedGeneration = SelectedGeneration.Generation4;
        private byte[] customData;
        private const uint PidCeilling = uint.MaxValue;

        private enum SelectedGeneration
        {
            Generation4,
            Generation5,
            Generation6
        }

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e)
        {
            MinimumSize = Size;
            labelLoadedSpinda.Text = string.Empty;
        }

        private void buttonPickFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() != DialogResult.Cancel
                && !string.IsNullOrEmpty(folderBrowser.SelectedPath))
                {
                    textOutputPath.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textOutputPath.Text)
                || string.IsNullOrWhiteSpace(textOutputPath.Text))
            {
                throw new Exception("The output path must be a valid path!");
            }

            if (!Directory.Exists(textOutputPath.Text))
            {
                Directory.CreateDirectory(textOutputPath.Text);
            }

            BaseSpinda spinda;
            var generation = 4;
            var fileSizeInBytes = 136;

            switch (selectedGeneration)
            {
                case SelectedGeneration.Generation5:
                    spinda = new SpindaPk5(customData ?? SpindaFiles.SpindaPk5);
                    generation = 5;
                    break;

                case SelectedGeneration.Generation6:
                    spinda = new SpindaPk6(customData ?? SpindaFiles.SpindaPk6);
                    generation = 6;
                    fileSizeInBytes = 232;
                    break;

                default:
                    spinda = new SpindaPk4(customData ?? SpindaFiles.SpindaPk4);
                    break;
            }

            decimal totalSizeInBytes = fileSizeInBytes * uint.MaxValue;
            var totalSizeInKBytes = totalSizeInBytes / 1000m;
            var totalSizeInMBytes = totalSizeInKBytes / 1000m;
            var totalSizeInGBytes = totalSizeInMBytes / 1000m;

            if (totalSizeInMBytes >= 100 && MessageBox.Show(
                $"Warning: this operation will consume approximately {totalSizeInGBytes:##.00} GB of the selected drive. Are you sure you want to proceed?",
                "Generate Spinda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            for (var pid = uint.MinValue; pid < PidCeilling; pid++)
            {
                spinda.SetPid(pid);
                if (string.IsNullOrEmpty(spinda.GetPidHex()))
                {
                    continue;
                }

                using (var fileStream = new FileStream(Path.Combine(textOutputPath.Text,
                    string.Format("Spinda_{0}.pk{1}", spinda.GetPidHex(), generation)), FileMode.Create, FileAccess.Write))
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(spinda.GetData());
                }
            }
        }

        private void radioGen4_CheckedChanged(object sender, EventArgs e) => selectedGeneration = SelectedGeneration.Generation4;

        private void radioGen5_CheckedChanged(object sender, EventArgs e) => selectedGeneration = SelectedGeneration.Generation5;

        private void radioGen6_CheckedChanged(object sender, EventArgs e) => selectedGeneration = SelectedGeneration.Generation6;

        private void loadSpinda_Click(object sender, EventArgs e)
        {
            string fileName;
            using (var openFile = new OpenFileDialog
            {
                Filter = "PKM Files|*.pkm|PK4 Files|*.pk4|PK5 Files|*.pk5|PK6 Files|*.pk6|All Files|*.*"
            })
            {
                if (openFile.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                fileName = openFile.FileName;
            }
            labelLoadedSpinda.Text = fileName;
            customData = File.ReadAllBytes(fileName);
        }

        private void buttonClearFile_Click(object sender, EventArgs e)
        {
            customData = null;
            labelLoadedSpinda.Text = string.Empty;
        }
    }
}
