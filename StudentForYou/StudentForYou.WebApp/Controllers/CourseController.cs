using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;
using StudentForYou.DB;
using System.Linq;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : DataBaseController
    {
        DataTableDB db = new DataTableDB();
        public IListManager<Course> courseListManager;
        WhiteSpaceRemover spaceRemover = new WhiteSpaceRemover();
        public CourseController()
        {
        courseListManager = new CourseListManager();
        }

        [HttpGet("GetCourses")]
        public List<Course> GetCourses()
        {
            return courseListManager.GetList();
        }
        [HttpGet("GetCourseAmount")]
        public int GetCourseAmount()
        {
           
            return db.GetListAmount(courseListManager.GetList());
        }

        [HttpGet("GetCourseAverage")]
        public double GetCourseAverage()
        {
            var tmp = courseListManager.GetList();
            List<int> difficulties = new List<int>();
               foreach(Course c in tmp)
            {
                difficulties.Add(c.CourseDifficulty);
            }
            var average = difficulties.Aggregate(
                0,
                (result, item) => result + item,
                result => (double)result / difficulties.Count);

            return average; 
        }

        [HttpGet("GetMostReviewed")]
        public IEnumerable<NameValue> GetMostReviewed()
        {
            var list =courseListManager.GetList().AsEnumerable()
                .Join(GetAllReviews(),
                      k1 => k1.CourseID,
                      k2 => k2.CourseID,
                      (k1, k2) => new NameValue
                      {
                          Name = k1.CourseName,
                          Value = k2.CourseID
                      })

                .GroupBy(l => l.Name)
                .Select(group => new NameValue
                {
                    Name = group.Key,
                    Value = group.Count()
                }); //All of the courses that have reviews and a sum of them

            var maxValue = list.Select(m => m.Value).Max();
            list = list.Where(x => x.Value == maxValue);

            return list;
        }

        [HttpGet("{courseID}/GetCourse")]
        public Course GetCourse(int courseID)
        {
            var query = "select cou.cou_id CourseID, cou.cou_name CourseName, cou.cou_difficulty CourseDifficulty, cou.cou_description CourseDescription, cou.cou_creation_date CourseCreationDate from courses cou where cou.cou_id = " + courseID;
            return db.GetItem<Course>(query);
        }

        [HttpPost("PostCourse")]
        public void PostCourse([FromBody] Course course)
        {
            var tuple = spaceRemover.CleanCourseBeforePost(course.CourseName, course.CourseDescription);
            course.CourseName = tuple.Item1;
            course.CourseDescription = tuple.Item2;
            var qry = "INSERT INTO courses(cou_name, cou_difficulty, cou_description, cou_creation_date) VALUES (@cou_name, @cou_difficulty, @cou_description, @cou_creation_date)";
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@cou_name", course.CourseName.Trim());
                    cmd.Parameters.AddWithValue("@cou_description", course.CourseDescription.Trim());
                    cmd.Parameters.AddWithValue("@cou_creation_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cou_difficulty", course.CourseDifficulty);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpGet("{courseID}/GetReviews")]
        public List<Review> GetReviews(int courseID)
        {
            var query = "select cor_id ReviewID, cor_cou_id CourseID, cor_user_id UserID, cor_text ReviewText, cor_creation_date ReviewCreationDate from courses_reviews where cor_cou_id = " + courseID;
            var list = db.GetList<Review>(query);
            return list;
        }

        [HttpPost("{courseID}/PostReview")]
        public void PostReview([FromBody] Review review)
        {
            review.ReviewText = spaceRemover.CleanReviewBeforePost(review.ReviewText);
            var qry = "INSERT INTO courses_reviews(cor_cou_id, cor_user_id, cor_text, cor_creation_date) VALUES (@cor_cou_id, @cor_user_id, @cor_text, @cor_creation_date)";
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@cor_cou_id", review.CourseID);
                    cmd.Parameters.AddWithValue("@cor_text", review.ReviewText.Trim());
                    cmd.Parameters.AddWithValue("@cor_creation_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@cor_user_id", review.UserID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpDelete("{courseID}/DeleteCourse")]
        public void DeleteCourse(int courseID)
        {
            db.DeleteRow("courses", "cou_id", courseID);
            //db.DeleteRow("courses_reviews", "cor_cou_id", courseID);
            //db.DeleteRow("chat_group", "chg_course_id", courseID);
        }

        [HttpGet("GetAllReviews")]
        public List<Review> GetAllReviews()
        {
            var query = "select cor_id ReviewID, cor_cou_id CourseID, cor_user_id UserID, cor_text ReviewText, cor_creation_date ReviewCreationDate from courses_reviews";
            var list = db.GetList<Review>(query);
            return list;
        }

    }
}
