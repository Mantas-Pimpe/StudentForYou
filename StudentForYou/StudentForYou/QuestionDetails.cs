using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForYou
{
    class QuestionDetails
    {
        public string QuestionLikes;
        public string QuestionViews;
        public string QuestionAnswers;
        public string Question;
        public string AnswersForQuestion;
        
        public QuestionDetails()
        {

        }

        public QuestionDetails(string questionLikes, string questionViews, string questionAnswers, string question, string answerForQuestion)
        {
            QuestionLikes = questionLikes;
            QuestionViews = questionViews;
            QuestionAnswers = questionAnswers;
            Question = question;
            AnswersForQuestion = answerForQuestion;
        }
    }
}
