using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Review
    {
        public int reviewID;
        public int userID;
        public int courseID;
        public string text;
        public DateTime creationDate;

        public Review(int reviewID, int userID, int courseID, string text, DateTime creationDate)
        {
            this.reviewID = reviewID;
            this.userID = userID;
            this.courseID = courseID;
            this.text = text;
            this.creationDate = creationDate;
        }
    }
}
