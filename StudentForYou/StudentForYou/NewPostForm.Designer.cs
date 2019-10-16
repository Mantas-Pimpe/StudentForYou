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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questiontxt
            // 
            this.questiontxt.Location = new System.Drawing.Point(124, 134);
            this.questiontxt.Margin = new System.Windows.Forms.Padding(6);
            this.questiontxt.Name = "questiontxt";
            this.questiontxt.Size = new System.Drawing.Size(1000, 400);
            this.questiontxt.TabIndex = 0;
            this.questiontxt.Text = "";
            this.questiontxt.TextChanged += new System.EventHandler(this.questiontxt_TextChanged);
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(124, 52);
            this.questionBox.Margin = new System.Windows.Forms.Padding(6);
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(1000, 22);
            this.questionBox.TabIndex = 1;
            this.questionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.questionBox.TextChanged += new System.EventHandler(this.questionBox_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(832, 570);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(292, 45);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // NewPostForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.questiontxt);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewPostForm";
            this.Text = "NewPostForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewPostForm_FormClosed);
            this.Load += new System.EventHandler(this.NewPostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox questiontxt;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button button1;
    }
}