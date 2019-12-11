using System;
namespace StudentForYou.DB
{
    public partial class Question
    {
        public int QuestionID { get; set; }
        public int QuestionLikes { get; set; }
        public int QuestionViews { get; set; }
        public int QuestionAnswers { get; set; }
        public int? UserID { get; set; }
        public string QuestionText { get; set; }
        public string QuestionName { get; set; }
        public DateTime QuestionCreationDate { get; set; }
    }
}
