using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class FileCourse
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public MemoryStream File { get; set; }
        public DateTime FileCreationDate { get; set; }

    }
}
