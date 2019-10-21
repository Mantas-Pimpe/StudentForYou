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
    public partial class AddSubjectForm : Form
    {
        AddSubjectInterface nottempinterface;

       
        public AddSubjectForm(AddSubjectInterface adderinterface)
        {
            InitializeComponent();
            nottempinterface = adderinterface;
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
            nottempinterface.getinfo(CourseNameTextBox.Text, CourseDescriptionTextBox.Text, DifficultyTextBox.Text);
            nottempinterface.writetofile();
        }

        private void CourseDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
