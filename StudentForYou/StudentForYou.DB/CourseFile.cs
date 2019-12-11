

namespace StudentForYou.DB
{
    using System;
    public partial class CourseFile
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public DateTime FileCreationDate { get; set; }

    }
}
