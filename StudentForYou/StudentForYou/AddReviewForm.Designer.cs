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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PostReviewTextBox
            // 
            this.PostReviewTextBox.Location = new System.Drawing.Point(15, 154);
            this.PostReviewTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PostReviewTextBox.Name = "PostReviewTextBox";
            this.PostReviewTextBox.Size = new System.Drawing.Size(1218, 465);
            this.PostReviewTextBox.TabIndex = 1;
            this.PostReviewTextBox.TabStop = false;
            this.PostReviewTextBox.Text = "";
            // 
            // PostReviewButton
            // 
            this.PostReviewButton.Location = new System.Drawing.Point(15, 631);
            this.PostReviewButton.Margin = new System.Windows.Forms.Padding(6);
            this.PostReviewButton.Name = "PostReviewButton";
            this.PostReviewButton.Size = new System.Drawing.Size(254, 66);
            this.PostReviewButton.TabIndex = 2;
            this.PostReviewButton.Text = "Post";
            this.PostReviewButton.UseVisualStyleBackColor = true;
            this.PostReviewButton.Click += new System.EventHandler(this.PostReviewButton_Click);
            // 
            // CancelReviewButton
            // 
            this.CancelReviewButton.Location = new System.Drawing.Point(979, 631);
            this.CancelReviewButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelReviewButton.Name = "CancelReviewButton";
            this.CancelReviewButton.Size = new System.Drawing.Size(254, 66);
            this.CancelReviewButton.TabIndex = 3;
            this.CancelReviewButton.Text = "Back";
            this.CancelReviewButton.UseVisualStyleBackColor = true;
            this.CancelReviewButton.Click += new System.EventHandler(this.CancelReviewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Write a course review";
            // 
            // AddReviewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelReviewButton);
            this.Controls.Add(this.PostReviewButton);
            this.Controls.Add(this.PostReviewTextBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddReviewForm";
            this.Text = "StudentForYou";
            this.Load += new System.EventHandler(this.AddReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PostReviewTextBox;
        private System.Windows.Forms.Button PostReviewButton;
        private System.Windows.Forms.Button CancelReviewButton;
        private System.Windows.Forms.Label label1;
    }
}