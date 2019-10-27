using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public class ListViewInfosetter
    {
        List<Course> items=new List<Course>();

        public List<Course> ReadFileInfo()
        {
            items.Clear();
            List<string> data = System.IO.File.ReadAllLines(@"Resources\allcourses.txt").ToList();
            foreach (string d in data)
            {
                string[] allcourseinfo=new string[2];
                var tempCourse = new Course();
                allcourseinfo=d.Split(new char[] { ',' });
                //StringSplitOptions.RemoveEmptyEntries;
                tempCourse.Name = allcourseinfo[0];
                tempCourse.Description = allcourseinfo[1];
                tempCourse.Difficulty = allcourseinfo[2];
                items.Add(tempCourse);
            }
            
            return items;
            
    

        }
       
    }
}