using System;
using System.Windows.Forms;
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class AddSubjectForm : Form
    {
        IAddSubjectInterface notTempInterface;
        public AddSubjectForm(IAddSubjectInterface adderInterface)
        {
            InitializeComponent();
            notTempInterface = adderInterface;
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void CourseDescriptionTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CancelAddSubjectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SaveSubjectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            notTempInterface.GetInfo(CourseNameTextBox.Text, CourseDescriptionTextBox.Text, Int32.Parse(DifficultyTextBox.Text));
            notTempInterface.WriteToDB();
        }

        private void CourseDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
