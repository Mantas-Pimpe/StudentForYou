using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int QuestionLikes { get; set; }
        public int QuestionViews { get; set; }
        public int QuestionAnswers { get; set; }
        public string QuestionText { get; set; }
        public string QuestionName { get; set; }
        public DateTime QuestionCreationDate { get; set; }
    }
}
