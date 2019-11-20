using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Question
    {
        public int questionID;
        public int questionLikes;
        public int questionViews;
        public int questionAnswers;
        public string questionText;
        public string questionName;
        public DateTime questionCreationDate;

        public Question(int questionID, int questionLikes, int questionViews, int questionAnswers, string questionText, string questionName, DateTime questionCreationDate)
        {
            this.questionID = questionID;
            this.questionLikes = questionLikes;
            this.questionViews = questionViews;
            this.questionAnswers = questionAnswers;
            this.questionText = questionText;
            this.questionName = questionName;
            this.questionName = questionName;
            this.questionCreationDate = questionCreationDate;
        }
    }
}
