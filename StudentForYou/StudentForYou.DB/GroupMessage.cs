using System;
namespace StudentForYou.DB
{
    public partial class GroupMessage
    {
        public int MessageID { get; set; }
        public string MessageText { get; set; }
        public int MessageSenderID { get; set; }
        public DateTime MessageTime { get; set; }
        public int CourseID { get; set; }
    }
}
