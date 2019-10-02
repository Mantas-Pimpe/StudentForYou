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
        public fileuploadform(String directoryname)
        {
            directory = directoryname;
            InitializeComponent();
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
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
