using System;
using System.Windows.Forms;
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class AddSubjectForm : Form
    {
        IAddSubjectInterface notTempinterface;
       
        public AddSubjectForm(IAddSubjectInterface adderInterface)
        {
            InitializeComponent();
            notTempinterface = adderInterface;
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
            notTempinterface.GetInfo(CourseNameTextBox.Text, CourseDescriptionTextBox.Text, DifficultyTextBox.Text);
            notTempinterface.WriteToFile();
        }

        private void CourseDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
