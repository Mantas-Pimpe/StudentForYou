using Microsoft.AspNetCore.Mvc;
using StudentForYou.DB;
using StudentForYou.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Controllers
{
    public class CourseListManager : IListManager<Course>
    {
        DataTableDB db;
        public CourseListManager()
        {
          db = new DataTableDB();
        }
        
        public List<Course> GetList()
        {
            var query = "select cou_id CourseID, cou_name CourseName, cou_difficulty CourseDifficulty, cou_description CourseDescription, cou_creation_date CourseCreationDate from courses";
            var list = db.GetList<Course>(query);
            //CheckList.ReplaceList(questionList);
            return list;
        }
    }
}
