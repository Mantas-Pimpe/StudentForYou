﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentforyousubjects
{
    public class SubjectAdder : AddSubjectInterface
    {
        string subjectname;
        string coursedescription;
        string difficulty;

        public void getinfo(string nameinfo,string courseinfo,string difficultyinfo)
        {
            
            subjectname = nameinfo;
            coursedescription = courseinfo;
            difficulty = difficultyinfo;


            
        }
        public void writetofile()
        {
            System.IO.File.AppendAllText(@"Resources\allcourses.txt", this.returnallinfo());
            System.IO.File.AppendAllText(@"Resources\allcourses.txt", System.Environment.NewLine);
        }
        public string returnallinfo()
        {
            string allinfo;
            allinfo = subjectname + "," + coursedescription + "," + difficulty;
            return allinfo;
        }
    }
}