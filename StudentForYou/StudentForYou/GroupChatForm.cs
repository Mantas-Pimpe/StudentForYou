//using System;
//using System.Windows.Forms;
//using System.Diagnostics;
//using StudentForYou.DB;

//namespace StudentForYou
//{
//    public partial class GroupChatForm : Form
//    {
//        GroupChatDB chatDB;
//        private Form prevform;
//        User user;
//        Course course;
//        public GroupChatForm(Form prevForm, User user, Course course)
//        {
//            InitializeComponent();
//            this.prevform = prevForm;
//            chatDB = new GroupChatDB();
//            this.user = user;
//            this.course = course;
//            DisplayMessages();
//        }

//        public void PostMessage(string message)
//        {
            
//        }
//        private void GroupChat_Load(object sender, EventArgs e)
//        {

//        }

//        private void ButtonSend_Click(object sender, EventArgs e)
//        {
//            chatDB.InsertIntoGroupChat(user, course, textMessage.Text, DateTime.Now);
//            textMessage.Clear();
//            DisplayMessages();
//        }

//        private void DisplayMessages()
//        {
//            listMessage.Text = "Welcome to the " + course.name + " chat room!" + Environment.NewLine;
//            var tmpList = chatDB.GetGroupMessages(course);
//            foreach (GroupMessage item in tmpList)
//            {
//                listMessage.Text = listMessage.Text + item.messageTime + "  " + item.messageSender.username + ": " + item.messageText + Environment.NewLine;
//            }
//        }
//        private void TextMessage_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void Back_Click(object sender, EventArgs e)
//        {
//            prevform.Show();
//            this.Close();
//        }

//        private void ListMessage_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void ListMessage_TextChanged(object sender, EventArgs e)
//        {
            
//        }
//    }
//}
