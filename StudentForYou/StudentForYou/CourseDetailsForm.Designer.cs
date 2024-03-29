﻿namespace StudentForYou
{
    partial class CourseDetailsForm
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
            this.CourseDetailsBackButton = new System.Windows.Forms.Button();
            this.CourseDetailsTextBox = new System.Windows.Forms.TextBox();
            this.CourseDetailsNameBox = new System.Windows.Forms.TextBox();
            this.downloadsListView = new System.Windows.Forms.ListView();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseDetailsReviewsTextBox = new System.Windows.Forms.RichTextBox();
            this.CourseReviewsLabel = new System.Windows.Forms.Label();
            this.CourseDetailsPostReviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseDetailsBackButton
            // 
            this.CourseDetailsBackButton.Location = new System.Drawing.Point(1076, 649);
            this.CourseDetailsBackButton.Margin = new System.Windows.Forms.Padding(8);
            this.CourseDetailsBackButton.Name = "CourseDetailsBackButton";
            this.CourseDetailsBackButton.Size = new System.Drawing.Size(127, 46);
            this.CourseDetailsBackButton.TabIndex = 1;
            this.CourseDetailsBackButton.Text = "Back";
            this.CourseDetailsBackButton.UseVisualStyleBackColor = true;
            this.CourseDetailsBackButton.Click += new System.EventHandler(this.CourseDetailsBackButton_Click);
            // 
            // CourseDetailsTextBox
            // 
            this.CourseDetailsTextBox.Location = new System.Drawing.Point(38, 119);
            this.CourseDetailsTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.CourseDetailsTextBox.Multiline = true;
            this.CourseDetailsTextBox.Name = "CourseDetailsTextBox";
            this.CourseDetailsTextBox.Size = new System.Drawing.Size(1165, 132);
            this.CourseDetailsTextBox.TabIndex = 3;
            this.CourseDetailsTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // CourseDetailsNameBox
            // 
            this.CourseDetailsNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CourseDetailsNameBox.Location = new System.Drawing.Point(38, 17);
            this.CourseDetailsNameBox.Margin = new System.Windows.Forms.Padding(8);
            this.CourseDetailsNameBox.Name = "CourseDetailsNameBox";
            this.CourseDetailsNameBox.ReadOnly = true;
            this.CourseDetailsNameBox.Size = new System.Drawing.Size(1165, 102);
            this.CourseDetailsNameBox.TabIndex = 5;
            this.CourseDetailsNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CourseDetailsNameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // downloadsListView
            // 
            this.downloadsListView.HideSelection = false;
            this.downloadsListView.Location = new System.Drawing.Point(38, 507);
            this.downloadsListView.Margin = new System.Windows.Forms.Padding(8);
            this.downloadsListView.Name = "downloadsListView";
            this.downloadsListView.Size = new System.Drawing.Size(1165, 120);
            this.downloadsListView.TabIndex = 6;
            this.downloadsListView.UseCompatibleStateImageBehavior = false;
            this.downloadsListView.SelectedIndexChanged += new System.EventHandler(this.CourseDownloadsListView_SelectedIndexChanged);
            this.downloadsListView.DoubleClick += new System.EventHandler(this.DownloadsListView_DoubleClick);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(38, 649);
            this.UploadFileButton.Margin = new System.Windows.Forms.Padding(8);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(127, 46);
            this.UploadFileButton.TabIndex = 7;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(511, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Uploaded Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(511, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 59);
            this.label2.TabIndex = 9;
            this.label2.Text = "Course Details";
            // 
            // CourseDetailsReviewsTextBox
            // 
            this.CourseDetailsReviewsTextBox.Location = new System.Drawing.Point(38, 305);
            this.CourseDetailsReviewsTextBox.Name = "CourseDetailsReviewsTextBox";
            this.CourseDetailsReviewsTextBox.ReadOnly = true;
            this.CourseDetailsReviewsTextBox.Size = new System.Drawing.Size(1165, 151);
            this.CourseDetailsReviewsTextBox.TabIndex = 10;
            this.CourseDetailsReviewsTextBox.Text = "";
            this.CourseDetailsReviewsTextBox.TextChanged += new System.EventHandler(this.CourseDetailsReviewsTextBox_TextChanged);
            // 
            // CourseReviewsLabel
            // 
            this.CourseReviewsLabel.AutoSize = true;
            this.CourseReviewsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CourseReviewsLabel.Location = new System.Drawing.Point(511, 277);
            this.CourseReviewsLabel.Name = "CourseReviewsLabel";
            this.CourseReviewsLabel.Size = new System.Drawing.Size(396, 59);
            this.CourseReviewsLabel.TabIndex = 11;
            this.CourseReviewsLabel.Text = "Course Reviews";
            // 
            // CourseDetailsPostReviewButton
            // 
            this.CourseDetailsPostReviewButton.Location = new System.Drawing.Point(1076, 453);
            this.CourseDetailsPostReviewButton.Margin = new System.Windows.Forms.Padding(8);
            this.CourseDetailsPostReviewButton.Name = "CourseDetailsPostReviewButton";
            this.CourseDetailsPostReviewButton.Size = new System.Drawing.Size(127, 38);
            this.CourseDetailsPostReviewButton.TabIndex = 12;
            this.CourseDetailsPostReviewButton.Text = "Write Review";
            this.CourseDetailsPostReviewButton.UseVisualStyleBackColor = true;
            this.CourseDetailsPostReviewButton.Click += new System.EventHandler(this.CourseDetailsPostReviewButton_Click);
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.CourseDetailsPostReviewButton);
            this.Controls.Add(this.CourseReviewsLabel);
            this.Controls.Add(this.CourseDetailsReviewsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.downloadsListView);
            this.Controls.Add(this.CourseDetailsNameBox);
            this.Controls.Add(this.CourseDetailsTextBox);
            this.Controls.Add(this.CourseDetailsBackButton);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CourseDetailsForm";
            this.Text = "StudentForYou";
            this.Load += new System.EventHandler(this.CourseDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseDetailsBackButton;
        private System.Windows.Forms.TextBox CourseDetailsTextBox;
        private System.Windows.Forms.TextBox CourseDetailsNameBox;
        private System.Windows.Forms.Button UploadFileButton;
        public System.Windows.Forms.ListView downloadsListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CourseDetailsReviewsTextBox;
        private System.Windows.Forms.Label CourseReviewsLabel;
        private System.Windows.Forms.Button CourseDetailsPostReviewButton;
    }
}