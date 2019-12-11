using System;

namespace StudentForYou.DB
{
    public partial class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseDifficulty { get; set; }
        public DateTime CourseCreationDate { get; set; }
    }
}
