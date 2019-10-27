using System.IO;
using System;

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
            File.AppendAllText(@"Resources\allcourses.txt", this.ReturnAllInfo());
            File.AppendAllText(@"Resources\allcourses.txt", Environment.NewLine);
        }
        public string ReturnAllInfo()
        {
            string allInfo;
            allInfo = subjectName + "," + courseDescription + "," + difficulty;
            return allInfo;
        }
    }
}
