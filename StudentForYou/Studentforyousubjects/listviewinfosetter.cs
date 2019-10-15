using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public class listviewinfosetter
    {
        List<Course> items=new List<Course>();

        public List<Course> Readfileinfo()
        {
            items.Clear();
            List<string> data = System.IO.File.ReadAllLines(@"Resources\allcourses.txt").ToList();
            foreach (string d in data)
            {
                string[] allcourseinfo=new string[2];
                Course tempcourse = new Course();
                allcourseinfo=d.Split(new char[] { ',' });
                //StringSplitOptions.RemoveEmptyEntries;
                tempcourse.Name = allcourseinfo[0];
                tempcourse.Description = allcourseinfo[1];
                tempcourse.Difficulty = allcourseinfo[2];

                items.Add(tempcourse);
            }
            
            return items;
            
    

        }
    }
}