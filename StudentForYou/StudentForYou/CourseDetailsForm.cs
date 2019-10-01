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
    public partial class courseDetailsForm : Form
    {
        String filename;
        String coursetext;
        public courseDetailsForm(String tempfilename)
        {
            
            InitializeComponent();
            this.CourseNameDetailsBox.Text = tempfilename;
            filename = this.CourseNameDetailsBox.Text + ".txt";
            if(System.IO.File.Exists(filename))
            {
                coursetext=System.IO.File.ReadAllText(filename);
                this.CourseDescriptionDetailsBox.Text = coursetext;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            coursetext = this.CourseDescriptionDetailsBox.Text;
            System.IO.File.AppendAllText(filename, coursetext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CourseDescriptionDetailsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseNameDetailsBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
