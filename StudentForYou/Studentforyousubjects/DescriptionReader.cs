using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public class DescriptionReader
    {
        string filepath;
       public DescriptionReader(string coursename)
        {
            filepath="Resources\\";
                filepath = filepath + coursename;
            filepath = filepath + ".txt";
        }


       public string readdescription()
        {
            if(System.IO.File.Exists(filepath).Equals(false))
            {
                System.IO.File.Create(filepath);
            }
            string text = System.IO.File.ReadAllText(filepath);
            return text;

        }
       public void uploadtofile(string texttoupload)
        {
            System.IO.File.AppendAllText(filepath, texttoupload);
        }
    }
}
