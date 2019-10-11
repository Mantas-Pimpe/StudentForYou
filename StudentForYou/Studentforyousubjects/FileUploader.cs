using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public class FileUploader
    {
        string filepath;
        public FileUploader(string nameofcourse)
        {
            filepath = "Resources\\";
            filepath = filepath + nameofcourse+" "+"downloads";
            filepath = filepath + ".txt";
            File.Directory.Create(filepath);
        }
    }
}
