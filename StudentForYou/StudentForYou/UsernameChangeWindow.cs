using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    class UsernameChangeWindow: Form
    {
        private TextBox textBox1;
        private Label label1;
        private RoundedButton SaveButton;
        public UsernameChangeWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new StudentForYou.RoundedButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER NEW USERNAME";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(111, 58);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 44);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UsernameChangeWindow
            // 
            this.ClientSize = new System.Drawing.Size(221, 103);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "UsernameChangeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //
            // Check if the username is avaliable
            // Change it with the old one
            // close this from
            //
            this.Close();
        }
    }
}
