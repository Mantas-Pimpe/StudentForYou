﻿using System;
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
    public partial class form1 : Form
    {
        List<string> CourseList;
        public form1()
        {
            InitializeComponent();
            CourseList = File.ReadAllLines("allcourses.txt").ToList();
            foreach (string d in CourseList)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(items));
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjectForm AddForm = new AddSubjectForm();
            AddForm.ShowDialog();
            if (AddForm.DialogResult==DialogResult.OK)
                {
                listView1.Items.Clear();
                CourseList = File.ReadAllLines("allcourses.txt").ToList();
                foreach (string d in CourseList)
                {
                    string[] items = d.Split(new char[] { ',' },
                           StringSplitOptions.RemoveEmptyEntries);
                    listView1.Items.Add(new ListViewItem(items));
                }
                this.Show();
            }
            else
            {
              
                this.Show();
            }

            }
            
            


      

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowCourseDetailsButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                this.Hide();
                courseDetailsForm detailsForm = new courseDetailsForm(listView1.SelectedItems[Course.DisplayIndex].Text);
                detailsForm.ShowDialog();
                this.Show();

            }
                

            }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
           
           
        }

        private void SubjectDownloadButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                this.Hide();
            fileuploadform uploadform = new fileuploadform(listView1.SelectedItems[Course.Index].Text);
            uploadform.ShowDialog();
            this.Show();

            }
            
        }

        private void GoBackSubjectsButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
    }


