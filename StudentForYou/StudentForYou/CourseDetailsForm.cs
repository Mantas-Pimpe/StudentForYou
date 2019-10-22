using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class CourseDetailsForm : Form
    {
        DescriptionReader reader;
       string nameOfCourse;
        string filePath;
        FileUploader uploader;
        public CourseDetailsForm(string courseName)
        {
            InitializeComponent();
            nameOfCourse = courseName;
            reader = new DescriptionReader(courseName);
            CourseDetailsNameBox.Text = courseName;
            CourseDetailsTextBox.Text = reader.ReadDescription();
            uploader = new FileUploader(courseName);
            downloadsListView.Items.AddRange(uploader.UploadFiles());


        }

        private void CourseDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseDetailsSaveButton_Click(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CourseDetailsBackButton_Click(object sender, EventArgs e)
        {
            reader.UploadToFile(CourseDetailsTextBox.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseDownloads downloadsForm = new CourseDownloads(nameOfCourse);
            downloadsForm.ShowDialog();
            this.Show();
        }

        private void CourseDownloadsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadClick(object sender, EventArgs e)
        {
            downloadsListView.Items.Add(uploader.UploadSingleFile());
        }

        private void DownloadsListView_DoubleClick(object sender, EventArgs e)
        { 

              if (downloadsListView.SelectedItems.Count > 0)
            {

                var selected = downloadsListView.SelectedItems[0];
                var selectedFilePath = selected.Tag.ToString();
                System.Diagnostics.Process.Start(selectedFilePath);

            }
            
        }
    }
}
