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
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class CourseDownloads : Form
    {
        string filepath;
        FileUploader uploader;
        public CourseDownloads(string coursename)
        {
            InitializeComponent();
            uploader = new FileUploader(coursename);
            CourseDownloadsListView.Items.AddRange(uploader.UploadFiles());
            
            
        }

        private void CourseDownloads_Load(object sender, EventArgs e)
        {

        }

        private void CourseDownloadsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CourseDownloadsListView.Items.Add(uploader.UploadSingleFile());
        }

        private void CourseDownloadsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CourseDownloadsListView.SelectedItems.Count > 0)
            {

                ListViewItem selected = CourseDownloadsListView.SelectedItems[0];
                string selectedFilePath = selected.Tag.ToString();
                System.Diagnostics.Process.Start(selectedFilePath);

            }


        }
    }
}
