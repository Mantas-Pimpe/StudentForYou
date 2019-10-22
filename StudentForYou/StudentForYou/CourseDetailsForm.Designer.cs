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
            this.CourseDetailsTextBox = new System.Windows.Forms.TextBox();
            this.CourseDetailsNameBox = new System.Windows.Forms.TextBox();
            this.downloadsListView = new System.Windows.Forms.ListView();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseDetailsBackButton
            // 
            this.CourseDetailsBackButton.Location = new System.Drawing.Point(1112, 783);
            this.CourseDetailsBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseDetailsBackButton.Name = "CourseDetailsBackButton";
            this.CourseDetailsBackButton.Size = new System.Drawing.Size(443, 79);
            this.CourseDetailsBackButton.TabIndex = 1;
            this.CourseDetailsBackButton.Text = "Back";
            this.CourseDetailsBackButton.UseVisualStyleBackColor = true;
            this.CourseDetailsBackButton.Click += new System.EventHandler(this.CourseDetailsBackButton_Click);
            // 
            // CourseDetailsTextBox
            // 
            this.CourseDetailsTextBox.Location = new System.Drawing.Point(67, 97);
            this.CourseDetailsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseDetailsTextBox.Multiline = true;
            this.CourseDetailsTextBox.Name = "CourseDetailsTextBox";
            this.CourseDetailsTextBox.Size = new System.Drawing.Size(1487, 228);
            this.CourseDetailsTextBox.TabIndex = 3;
            this.CourseDetailsTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // CourseDetailsNameBox
            // 
            this.CourseDetailsNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CourseDetailsNameBox.Location = new System.Drawing.Point(56, 15);
            this.CourseDetailsNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseDetailsNameBox.Name = "CourseDetailsNameBox";
            this.CourseDetailsNameBox.ReadOnly = true;
            this.CourseDetailsNameBox.Size = new System.Drawing.Size(1497, 55);
            this.CourseDetailsNameBox.TabIndex = 5;
            this.CourseDetailsNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CourseDetailsNameBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // downloadsListView
            // 
            this.downloadsListView.HideSelection = false;
            this.downloadsListView.Location = new System.Drawing.Point(67, 347);
            this.downloadsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downloadsListView.Name = "downloadsListView";
            this.downloadsListView.Size = new System.Drawing.Size(1487, 414);
            this.downloadsListView.TabIndex = 6;
            this.downloadsListView.UseCompatibleStateImageBehavior = false;
            this.downloadsListView.SelectedIndexChanged += new System.EventHandler(this.CourseDownloadsListView_SelectedIndexChanged);
            this.downloadsListView.DoubleClick += new System.EventHandler(this.DownloadsListView_DoubleClick);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(67, 783);
            this.UploadFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(443, 79);
            this.UploadFileButton.TabIndex = 7;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadClick);
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 876);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.downloadsListView);
            this.Controls.Add(this.CourseDetailsNameBox);
            this.Controls.Add(this.CourseDetailsTextBox);
            this.Controls.Add(this.CourseDetailsBackButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CourseDetailsForm";
            this.Text = "Course Details";
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
    }
}