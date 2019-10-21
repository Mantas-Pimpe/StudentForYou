using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public class DescriptionReader
    {
        string filePath;
       public DescriptionReader(string coursename)
        {
            filePath="Resources\\";
                filePath = filePath + coursename;
            filePath = filePath + ".txt";
        }


       public string ReadDescription()
        {
            if(System.IO.File.Exists(filePath).Equals(false))
            {
                System.IO.File.Create(filePath);
            }
            var text = System.IO.File.ReadAllText(filePath);
            return text;

        }
       public void UploadToFile(string texttoupload)
        {
            System.IO.File.AppendAllText(filePath, texttoupload);
        }
    }
}
