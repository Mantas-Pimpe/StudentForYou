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
        string filepath;
        public FileUploader(string nameofcourse)
        {
            filepath = "Resources\\";
            filepath = filepath + nameofcourse + " " + "downloads";
            Directory.CreateDirectory(filepath);
            //filepath = filepath + ".txt";


            // FolderBrowserDialog folderPicker = new FolderBrowserDialog();


        }
        public ListViewItem[] UploadFiles()
        {
            List<ListViewItem> tempitemlist = new List<ListViewItem>();
            string[] files = Directory.GetFiles(filepath);
            foreach (string file in files)
            {

                string fileName = Path.GetFileNameWithoutExtension(file);
                ListViewItem item = new ListViewItem(fileName);
                item.Tag = file;

                tempitemlist.Add(item);

            }

            return tempitemlist.ToArray();
        }

        public ListViewItem UploadSingleFile()
        {
            string uploadfilepath;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
              
                uploadfilepath = fileDialog.FileName;
                string nameoffile = Path.GetFileName(uploadfilepath);
                string uploadedfilepath = filepath + "\\" + nameoffile;
                File.Copy(uploadfilepath,uploadedfilepath);
                
                ListViewItem item = new ListViewItem(nameoffile);
                item.Tag = uploadedfilepath;
                return item;
            }
            return null;

        }

    }
}

