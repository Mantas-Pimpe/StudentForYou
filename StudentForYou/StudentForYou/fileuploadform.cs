using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public partial class fileuploadform : Form
    {
        String directory;
        List<String> filenames=new List<string>();
        public fileuploadform(String directoryname)
        {
            directory = directoryname;
            InitializeComponent();
            if(System.IO.Directory.Exists(directory).Equals(true))
            {

                foreach (string f in System.IO.Directory.GetFiles(directory, "*.txt"))
                {
                    filenames.Add(f);
                }
                this.addtolistview();

               


            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.IO.Directory.CreateDirectory(directory);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                String result = System.IO.Path.GetFileNameWithoutExtension(path);
                String copypath = directory + "\\" + result + ".txt";



                System.IO.File.Copy(path,copypath);
                UploadedFilesListView.Items.Add(new ListViewItem(copypath));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        public void addtolistview()
        {
            foreach (string d in filenames)
            {
                UploadedFilesListView.Items.Add(new ListViewItem(d));
            }
        }

        private void UploadedFilesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.UploadedFilesListView.SelectedItems.Count>0)
            {
                string temppath= UploadedFilesListView.SelectedItems[0].Text;
            System.Diagnostics.Process.Start(temppath);

            }
           
        }
    }
}
