using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class FileCourse
    {
        public int fileID;
        public string fileName;
        public MemoryStream file;
        public DateTime fileCreationDate;
        public FileCourse(int fileID, string fileName, MemoryStream file, DateTime fileCreationDate)
        {
            this.fileID = fileID;
            this.fileName = fileName;
            this.file = file;
            this.fileCreationDate = fileCreationDate;
        }
    }
}
