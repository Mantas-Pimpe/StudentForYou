namespace StudentForYou
{
    partial class CourseDownloads
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
            this.CourseDownloadsListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseDownloadsListView
            // 
            this.CourseDownloadsListView.HideSelection = false;
            this.CourseDownloadsListView.Location = new System.Drawing.Point(12, 12);
            this.CourseDownloadsListView.Name = "CourseDownloadsListView";
            this.CourseDownloadsListView.Size = new System.Drawing.Size(1211, 585);
            this.CourseDownloadsListView.TabIndex = 0;
            this.CourseDownloadsListView.UseCompatibleStateImageBehavior = false;
            this.CourseDownloadsListView.SelectedIndexChanged += new System.EventHandler(this.CourseDownloadsListView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(837, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CourseDownloads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CourseDownloadsListView);
            this.Name = "CourseDownloads";
            this.Text = "Course Downloads";
            this.Load += new System.EventHandler(this.CourseDownloads_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CourseDownloadsListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}