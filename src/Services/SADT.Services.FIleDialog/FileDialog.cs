using System.Windows.Forms;

namespace SADT.Services.FIleDialog
{
    /// <inheritdoc/>
    public class FileDialog : IFileDialog
    {
        /// <inheritdoc/>
        public string FilePath { get; set; }

        /// <inheritdoc/>
        public bool OpenFileDialog()
        {
            using var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return false;

            FilePath = openFileDialog.FileName;
            return true;
        }

        /// <inheritdoc/>
        public bool SaveFileDialog()
        {
            using var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return false;

            FilePath = saveFileDialog.FileName;
            return true;
        }

        /// <inheritdoc/>
        public bool FolderBrowserDialog()
        {
            using var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return false;

            FilePath = folderBrowserDialog.SelectedPath;
            return true;
        }
    }
}