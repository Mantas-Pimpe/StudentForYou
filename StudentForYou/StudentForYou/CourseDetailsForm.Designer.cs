namespace StudentForYou
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
            this.CourseDetailsSaveButton = new System.Windows.Forms.Button();
            this.CourseDetailsTextBox = new System.Windows.Forms.TextBox();
            this.CourseDetailsNameBox = new System.Windows.Forms.TextBox();
            this.DownloadsListView = new System.Windows.Forms.ListView();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseDetailsBackButton
            // 
            this.CourseDetailsBackButton.Location = new System.Drawing.Point(834, 636);
            this.CourseDetailsBackButton.Name = "CourseDetailsBackButton";
            this.CourseDetailsBackButton.Size = new System.Drawing.Size(332, 64);
            this.CourseDetailsBackButton.TabIndex = 1;
            this.CourseDetailsBackButton.Text = "Back";
            this.CourseDetailsBackButton.UseVisualStyleBackColor = true;
            this.CourseDetailsBackButton.Click += new System.EventHandler(this.CourseDetailsBackButton_Click);
            // 
            // CourseDetailsSaveButton
            // 
            this.CourseDetailsSaveButton.Location = new System.Drawing.Point(42, 636);
            this.CourseDetailsSaveButton.Name = "CourseDetailsSaveButton";
            this.CourseDetailsSaveButton.Size = new System.Drawing.Size(332, 64);
            this.CourseDetailsSaveButton.TabIndex = 2;
            this.CourseDetailsSaveButton.Text = "Save";
            this.CourseDetailsSaveButton.UseVisualStyleBackColor = true;
            this.CourseDetailsSaveButton.Click += new System.EventHandler(this.CourseDetailsSaveButton_Click);
            // 
            // CourseDetailsTextBox
            // 
            this.CourseDetailsTextBox.Location = new System.Drawing.Point(50, 79);
            this.CourseDetailsTextBox.Multiline = true;
            this.CourseDetailsTextBox.Name = "CourseDetailsTextBox";
            this.CourseDetailsTextBox.Size = new System.Drawing.Size(1116, 186);
            this.CourseDetailsTextBox.TabIndex = 3;
            this.CourseDetailsTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // CourseDetailsNameBox
            // 
            this.CourseDetailsNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CourseDetailsNameBox.Location = new System.Drawing.Point(42, 12);
            this.CourseDetailsNameBox.Name = "CourseDetailsNameBox";
            this.CourseDetailsNameBox.ReadOnly = true;
            this.CourseDetailsNameBox.Size = new System.Drawing.Size(1124, 45);
            this.CourseDetailsNameBox.TabIndex = 5;
            this.CourseDetailsNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CourseDetailsNameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // DownloadsListView
            // 
            this.DownloadsListView.HideSelection = false;
            this.DownloadsListView.Location = new System.Drawing.Point(50, 282);
            this.DownloadsListView.Name = "DownloadsListView";
            this.DownloadsListView.Size = new System.Drawing.Size(1116, 337);
            this.DownloadsListView.TabIndex = 6;
            this.DownloadsListView.UseCompatibleStateImageBehavior = false;
            this.DownloadsListView.SelectedIndexChanged += new System.EventHandler(this.CourseDownloadsListView_SelectedIndexChanged);
            this.DownloadsListView.DoubleClick += new System.EventHandler(this.DownloadsListView_DoubleClick);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(426, 636);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(332, 64);
            this.UploadFileButton.TabIndex = 7;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadClick);
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.DownloadsListView);
            this.Controls.Add(this.CourseDetailsNameBox);
            this.Controls.Add(this.CourseDetailsTextBox);
            this.Controls.Add(this.CourseDetailsSaveButton);
            this.Controls.Add(this.CourseDetailsBackButton);
            this.Name = "CourseDetailsForm";
            this.Text = "Course Details";
            this.Load += new System.EventHandler(this.CourseDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseDetailsBackButton;
        private System.Windows.Forms.Button CourseDetailsSaveButton;
        private System.Windows.Forms.TextBox CourseDetailsTextBox;
        private System.Windows.Forms.TextBox CourseDetailsNameBox;
        private System.Windows.Forms.Button UploadFileButton;
        public System.Windows.Forms.ListView DownloadsListView;
    }
}