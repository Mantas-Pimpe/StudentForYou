﻿namespace StudentForYou
{
    partial class fileuploadform
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
            this.button2 = new System.Windows.Forms.Button();
            this.UploadedFilesListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Upload File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UploadedFilesListView
            // 
            this.UploadedFilesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.UploadedFilesListView.Location = new System.Drawing.Point(29, 55);
            this.UploadedFilesListView.Name = "UploadedFilesListView";
            this.UploadedFilesListView.Size = new System.Drawing.Size(736, 295);
            this.UploadedFilesListView.TabIndex = 4;
            this.UploadedFilesListView.UseCompatibleStateImageBehavior = false;
            this.UploadedFilesListView.SelectedIndexChanged += new System.EventHandler(this.UploadedFilesListView_SelectedIndexChanged);
            // 
            // fileuploadform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UploadedFilesListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "fileuploadform";
            this.Text = "fileuploadform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView UploadedFilesListView;
    }
}