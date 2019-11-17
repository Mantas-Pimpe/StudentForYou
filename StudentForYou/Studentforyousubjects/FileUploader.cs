using System.Windows.Forms;

namespace Studentforyousubjects
{
    public class FileUploader
    {
        public string UploadSingleFile()
        {

            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                return fileDialog.FileName;
            }
            return "Resources/personIcon.jpg";

        }

    }
}

