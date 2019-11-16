using System;

namespace StudentForYou.RecentPosts
{
    public class Comment
    {
        public int commentID;
        public int questionID;
        public int userID;
        public string commentText;
        public DateTime commentDate;
        public Comment(int commentID, int questionID, int userID, string commentText, DateTime commentDate)
        {
            this.commentID = commentID;
            this.questionID = questionID;
            this.userID = userID;
            this.commentText = commentText;
            this.commentDate = commentDate;
        }
    }
}
