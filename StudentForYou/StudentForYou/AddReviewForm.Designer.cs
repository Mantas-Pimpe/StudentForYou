namespace StudentForYou
{
    partial class AddReviewForm
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
            this.PostReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.PostReviewButton = new System.Windows.Forms.Button();
            this.CancelReviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PostReviewTextBox
            // 
            this.PostReviewTextBox.Location = new System.Drawing.Point(35, 71);
            this.PostReviewTextBox.Name = "PostReviewTextBox";
            this.PostReviewTextBox.Size = new System.Drawing.Size(1172, 559);
            this.PostReviewTextBox.TabIndex = 1;
            this.PostReviewTextBox.TabStop = false;
            this.PostReviewTextBox.Text = "";
            // 
            // PostReviewButton
            // 
            this.PostReviewButton.Location = new System.Drawing.Point(72, 656);
            this.PostReviewButton.Name = "PostReviewButton";
            this.PostReviewButton.Size = new System.Drawing.Size(127, 34);
            this.PostReviewButton.TabIndex = 2;
            this.PostReviewButton.Text = "Post";
            this.PostReviewButton.UseVisualStyleBackColor = true;
            this.PostReviewButton.Click += new System.EventHandler(this.PostReviewButton_Click);
            // 
            // CancelReviewButton
            // 
            this.CancelReviewButton.Location = new System.Drawing.Point(1034, 656);
            this.CancelReviewButton.Name = "CancelReviewButton";
            this.CancelReviewButton.Size = new System.Drawing.Size(127, 34);
            this.CancelReviewButton.TabIndex = 3;
            this.CancelReviewButton.Text = "Back";
            this.CancelReviewButton.UseVisualStyleBackColor = true;
            this.CancelReviewButton.Click += new System.EventHandler(this.CancelReviewButton_Click);
            // 
            // AddReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.CancelReviewButton);
            this.Controls.Add(this.PostReviewButton);
            this.Controls.Add(this.PostReviewTextBox);
            this.Name = "AddReviewForm";
            this.Text = "AddReviewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox PostReviewTextBox;
        private System.Windows.Forms.Button PostReviewButton;
        private System.Windows.Forms.Button CancelReviewButton;
    }
}