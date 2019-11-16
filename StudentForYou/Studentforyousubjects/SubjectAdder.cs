using System.IO;
using System;
using StudentForYou.DB;

namespace Studentforyousubjects
{
    public class SubjectAdder : IAddSubjectInterface
    {
        string subjectName;
        string courseDescription;
        int difficulty;
        CoursesDB db = new CoursesDB();

        public void GetInfo(string nameInfo, string courseInfo, int difficultyInfo)
        {
            subjectName = nameInfo;
            courseDescription = courseInfo;
            difficulty = difficultyInfo;
        }
        public void WriteToDB()
        {
            db.InsertIntoCourses(subjectName, difficulty, courseDescription, DateTime.Now);
        }
    }
}
