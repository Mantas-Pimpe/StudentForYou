namespace StudentForYou
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Difficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Downloads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ShowCourseDetailsButton = new System.Windows.Forms.Button();
            this.SubjectDownloadButton = new System.Windows.Forms.Button();
            this.GoBackSubjectsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Course,
            this.Description,
            this.Difficulty,
            this.Downloads});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 49);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1007, 422);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Course
            // 
            this.Course.Text = "Course";
            this.Course.Width = 88;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 446;
            // 
            // Difficulty
            // 
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.Width = 124;
            // 
            // Downloads
            // 
            this.Downloads.Text = "Downloads";
            this.Downloads.Width = 96;
            // 
            // ShowCourseDetailsButton
            // 
            this.ShowCourseDetailsButton.Location = new System.Drawing.Point(70, 511);
            this.ShowCourseDetailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowCourseDetailsButton.Name = "ShowCourseDetailsButton";
            this.ShowCourseDetailsButton.Size = new System.Drawing.Size(271, 28);
            this.ShowCourseDetailsButton.TabIndex = 4;
            this.ShowCourseDetailsButton.Text = "Course Details";
            this.ShowCourseDetailsButton.UseVisualStyleBackColor = true;
            this.ShowCourseDetailsButton.Click += new System.EventHandler(this.ShowCourseDetailsButton_Click);
            // 
            // SubjectDownloadButton
            // 
            this.SubjectDownloadButton.Location = new System.Drawing.Point(379, 511);
            this.SubjectDownloadButton.Name = "SubjectDownloadButton";
            this.SubjectDownloadButton.Size = new System.Drawing.Size(279, 28);
            this.SubjectDownloadButton.TabIndex = 5;
            this.SubjectDownloadButton.Text = "Downloads";
            this.SubjectDownloadButton.UseVisualStyleBackColor = true;
            this.SubjectDownloadButton.Click += new System.EventHandler(this.SubjectDownloadButton_Click);
            // 
            // GoBackSubjectsButton
            // 
            this.GoBackSubjectsButton.Location = new System.Drawing.Point(897, 511);
            this.GoBackSubjectsButton.Name = "GoBackSubjectsButton";
            this.GoBackSubjectsButton.Size = new System.Drawing.Size(112, 31);
            this.GoBackSubjectsButton.TabIndex = 6;
            this.GoBackSubjectsButton.Text = "Back";
            this.GoBackSubjectsButton.UseVisualStyleBackColor = true;
            this.GoBackSubjectsButton.Click += new System.EventHandler(this.GoBackSubjectsButton_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GoBackSubjectsButton);
            this.Controls.Add(this.SubjectDownloadButton);
            this.Controls.Add(this.ShowCourseDetailsButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "Courses";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Course;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Difficulty;
        private System.Windows.Forms.ColumnHeader Downloads;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button ShowCourseDetailsButton;
        private System.Windows.Forms.Button SubjectDownloadButton;
        private System.Windows.Forms.Button GoBackSubjectsButton;
    }
}