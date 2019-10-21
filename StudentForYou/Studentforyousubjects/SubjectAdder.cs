using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public class SubjectAdder : IAddSubjectInterface
    {
        string subjectName;
        string courseDescription;
        string difficulty;

       


        public void GetInfo(string NameInfo,string courseInfo,string DifficultyInfo)
        {
            
            subjectName = NameInfo;
            courseDescription = courseInfo;
            difficulty = DifficultyInfo;


            
        }
        public void WriteToFile()
        {
            System.IO.File.AppendAllText(@"Resources\allcourses.txt", this.ReturnAllInfo());
            System.IO.File.AppendAllText(@"Resources\allcourses.txt", System.Environment.NewLine);
        }
        public string ReturnAllInfo()
        {
            string allInfo;
            allInfo = subjectName + "," + courseDescription + "," + difficulty;
            return allInfo;
        }
    }
}
