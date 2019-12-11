using System;
namespace StudentForYou.DB
{
    public partial class Comment
    {
        public int CommentID { get; set; }
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public int Likes { get; set; }
    }
}
