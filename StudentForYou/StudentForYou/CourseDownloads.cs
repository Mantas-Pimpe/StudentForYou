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

namespace StudentForYou
{
    public partial class CourseDownloads : Form
    {
        string filepath;
        public CourseDownloads(string coursename)
        {
            InitializeComponent();
            
        }

        private void CourseDownloads_Load(object sender, EventArgs e)
        {

        }

        private void CourseDownloadsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
