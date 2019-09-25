namespace StudentForYou
{
    partial class NewPostForm
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
            this.questiontxt = new System.Windows.Forms.RichTextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questiontxt
            // 
            this.questiontxt.Location = new System.Drawing.Point(62, 98);
            this.questiontxt.Name = "questiontxt";
            this.questiontxt.Size = new System.Drawing.Size(658, 308);
            this.questiontxt.TabIndex = 0;
            this.questiontxt.Text = "";
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(62, 27);
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(658, 22);
            this.questionBox.TabIndex = 1;
            this.questionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.questionBox.TextChanged += new System.EventHandler(this.questionBox_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(313, 415);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(146, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // NewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.questiontxt);
            this.Name = "NewPostForm";
            this.Text = "NewPostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox questiontxt;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}