using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int CourseID { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewCreationDate { get; set; }

    }
}
