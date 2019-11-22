using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseDifficulty { get; set; }
        public DateTime CourseCreationDate { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Course;

            if (CourseName != other.CourseName || CourseDescription != other.CourseDescription)
            {
                return false;
            }
            return true;
        }

    }
}
