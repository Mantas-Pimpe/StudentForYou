using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Question
    {
        public int questionID { get; set; }
        public int questionLikes { get; set; }
        public int questionViews { get; set; }
        public int questionAnswers { get; set; }
        public string questionText { get; set; }
        public string questionName { get; set; }
        public DateTime questionCreationDate { get; set; }

    }
}
