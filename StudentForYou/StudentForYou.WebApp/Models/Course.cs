using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Course
    {
        public int courseID;
        public string name { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; }
        public DateTime creationDate;

        public Course(int courseID, string name, int difficulty, string description, DateTime creationDate)
        {
            this.courseID = courseID;
            this.name = name;
            this.difficulty = difficulty;
            this.description = description;
            this.creationDate = creationDate;
        }
    }
}
