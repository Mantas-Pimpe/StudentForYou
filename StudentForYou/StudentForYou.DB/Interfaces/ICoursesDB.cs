using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForYou.DB.Interfaces
{
    public interface ICoursesDB : IEntityFrameworkDB<Course>
    {
        List<Course> GetCourses();
        Course GetCourse(int id);
        void PostCourse(Course course);
    }

}
