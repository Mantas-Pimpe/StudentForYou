using System;
namespace StudentForYou.DB
{ 
    public partial class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewCreationDate { get; set; }
    }
}
