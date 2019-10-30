using System;
using System.Windows.Forms;
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class CourseDownloads : Form
    {
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

                var selected = CourseDownloadsListView.SelectedItems[0];
                var selectedFilePath = selected.Tag.ToString();
                System.Diagnostics.Process.Start(selectedFilePath);

            }


        }
    }
}
