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
        DescriptionReader Reader;
        string nameofcourse;
        public CourseDetailsForm(string coursename)
        {
            InitializeComponent();
            nameofcourse = coursename;
            Reader = new DescriptionReader(coursename);
            CourseDetailsNameBox.Text = coursename;
          
            CourseDetailsTextBox.Text = Reader.readdescription();


        }

        private void CourseDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseDetailsSaveButton_Click(object sender, EventArgs e)
        {
            Reader.uploadtofile(Reader.readdescription());
            this.DialogResult = DialogResult.OK;
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CourseDetailsBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseDownloads Downloadsform = new CourseDownloads(nameofcourse)
            Downloadsform.ShowDialog();
            this.Show();
        }
    }
}
