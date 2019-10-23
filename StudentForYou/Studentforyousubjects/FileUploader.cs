using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentforyousubjects
{
    public class FileUploader
    {
        string filePath;
        public FileUploader(string nameofcourse)
        {
            filePath = "Resources\\";
            filePath = filePath + nameofcourse + " " + "downloads";
            Directory.CreateDirectory(filePath);
            //filepath = filepath + ".txt";
            // FolderBrowserDialog folderPicker = new FolderBrowserDialog();
        }
        public ListViewItem[] UploadFiles()
        {
            var tempitemlist = new List<ListViewItem>();
            string[] files = Directory.GetFiles(filePath);
            foreach (string file in files)
            {

                var fileName = Path.GetFileNameWithoutExtension(file);
                var item = new ListViewItem(fileName);
                item.Tag = file;

                tempitemlist.Add(item);

            }

            return tempitemlist.ToArray();
        }

        public ListViewItem UploadSingleFile()
        {
          
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
              
                var uploadFilePath = fileDialog.FileName;
                var nameOfFile = Path.GetFileName(uploadFilePath);
                var uploadedFilePath = filePath + "\\" + nameOfFile;
                File.Copy(uploadFilePath,uploadedFilePath);
                
                var item = new ListViewItem(nameOfFile);
                item.Tag = uploadedFilePath;
                return item;
            }
            return null;

        }

    }
}

