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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void AddSubjectClick(object sender, EventArgs e)
        {
            String SubjectInfo;
      
            SubjectInfo = CourseNameTextBox.Text + "," + SubjectDescriptionBox.Text + "," + SubjectDifficultyTextBox.Text;
            System.IO.File.AppendAllText("allcourses.txt", SubjectInfo);
            System.IO.File.AppendAllText("allcourses.txt", System.Environment.NewLine);
            this.DialogResult = DialogResult.OK;
            
        }

        private void CancelAddSubjectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
