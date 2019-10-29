namespace StudentForYou
{
    partial class SelectedQuestionForm
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
            this.txtAnswers = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDislike = new System.Windows.Forms.Button();
            this.btnLike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnswers
            // 
            this.txtAnswers.Location = new System.Drawing.Point(24, 143);
            this.txtAnswers.Name = "txtAnswers";
            this.txtAnswers.ReadOnly = true;
            this.txtAnswers.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtAnswers.Size = new System.Drawing.Size(1196, 336);
            this.txtAnswers.TabIndex = 0;
            this.txtAnswers.Text = "";
            this.txtAnswers.TextChanged += new System.EventHandler(this.txtAnswers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(546, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your answer";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 545);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1196, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(524, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Post your answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(24, 120);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(48, 22);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1105, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 22);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label2";
            // 
            // btnDislike
            // 
            this.btnDislike.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDislike.Location = new System.Drawing.Point(1164, 22);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(72, 40);
            this.btnDislike.TabIndex = 6;
            this.btnDislike.Text = "Dislike";
            this.btnDislike.UseVisualStyleBackColor = true;
            // 
            // btnLike
            // 
            this.btnLike.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLike.Location = new System.Drawing.Point(1081, 22);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(72, 40);
            this.btnLike.TabIndex = 7;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // SelectedQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswers);
            this.Name = "SelectedQuestionForm";
            this.Text = "SelectedQuestionForm";
            this.Load += new System.EventHandler(this.SelectedQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Button btnLike;
    }
}