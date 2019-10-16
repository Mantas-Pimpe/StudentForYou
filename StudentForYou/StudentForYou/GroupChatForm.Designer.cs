namespace StudentForYou
{
    partial class GroupChatForm
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
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(123, 587);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(1000, 38);
            this.textMessage.TabIndex = 7;
            this.textMessage.TextChanged += new System.EventHandler(this.TextMessage_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(944, 640);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(179, 40);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(123, 640);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(179, 40);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // listMessage
            // 
            this.listMessage.Location = new System.Drawing.Point(123, 46);
            this.listMessage.Multiline = true;
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(1000, 535);
            this.listMessage.TabIndex = 15;
            this.listMessage.TextChanged += new System.EventHandler(this.ListMessage_TextChanged);
            // 
            // GroupChatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonSend);
            this.Name = "GroupChatForm";
            this.Text = "GroupChat";
            this.Load += new System.EventHandler(this.GroupChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox listMessage;
    }
}