using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentForYou.WebApp.Models;
using StudentForYou.DB;
using System.Linq;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using StudentForYou.DB.Interfaces;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : EntityFrameworkDB<Course>, ICoursesDB
    {
        DataTableDB datatable = new DataTableDB();
        public CourseController(StudentForYouEntities context)
            : base(context)
        {

        }

        [HttpGet("GetCourses")]
        public List<Course> GetCourses()
        {
            /*var query = "select cou_id CourseID, cou_name CourseName, cou_difficulty CourseDifficulty, cou_description CourseDescription, cou_creation_date CourseCreationDate from courses";
            var list = datatable.GetList<Course>(query);*/
            return GetModelList().ToList();
        }

        [HttpGet("{courseID}/GetCourse")]
        public Course GetCourse(int courseID)
        {
            /*var query = "select cou.cou_id CourseID, cou.cou_name CourseName, cou.cou_difficulty CourseDifficulty, cou.cou_description CourseDescription, cou.cou_creation_date CourseCreationDate from courses cou where cou.cou_id = " + courseID;
            return datatable.GetItem<Course>(query);*/
            return GetModelByID(courseID);
        }

        [HttpPost("PostCourse")]

        public void PostCourse([FromBody] Course course)
        {
            var tuple = WhiteSpaceRemover.CleanCourseBeforePost(course.CourseName, course.CourseDescription);
            course.CourseName = tuple.Result.Item1;
            course.CourseDescription = tuple.Result.Item2;

            InsertModel(course);
            Save();
        }

        [HttpGet("{courseID}/GetReviews")]
        public List<Review> GetReviews(int courseID)
        {
            /*var query = "select cor_id ReviewID, cor_cou_id CourseID, cor_user_id UserID, cor_text ReviewText, cor_creation_date ReviewCreationDate from Review where cor_cou_id = " + courseID;
            var list = datatable.GetList<Review>(query);*/
            //return GetModelList().Where(e => e.ReviewID == courseID).ToList();
            return new List<Review>();
        }

        [HttpPost("{courseID}/PostReview")]
        public void PostReview([FromBody] Review review)
        {
            var text = WhiteSpaceRemover.CleanReviewBeforePost(review.ReviewText);
            review.ReviewText = text.Result;

            //InsertModel(review);
            Save();
        }

        [HttpDelete("{courseID}/DeleteCourse")]
        public void DeleteCourse(int courseID)
        {
            /*datatable.DeleteRow("courses", "cou_id", courseID);
            datatable.DeleteRow("Review", "cor_cou_id", courseID);
            datatable.DeleteRow("GroupMessage", "chg_course_id", courseID);*/
            DeleteModel(courseID);
            /*datatable.DeleteRow("Review", "cor_cou_id", courseID);
            datatable.DeleteRow("GroupMessage", "chg_course_id", courseID);*/
        }

        [HttpGet("GetCourseAmount")]
        public int GetCourseAmount()
        {
            return datatable.GetListAmount(GetCourses());
        }

        [HttpGet("GetCourseAverage")]
        public double GetCourseAverage()
        {
            var tmp = GetCourses().AsEnumerable()
                        .Select(g => g.CourseDifficulty).Average();
            return tmp;
        }

        [HttpGet("GetMostReviewed")]
        public IEnumerable<NameValue> GetMostReviewed()
        {
            var list = GetCourses().AsEnumerable()
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

        [HttpGet("GetAllReviews")]
        public List<Review> GetAllReviews()
        {
            /*var query = "select cor_id ReviewID, cor_cou_id CourseID, cor_user_id UserID, cor_text ReviewText, cor_creation_date ReviewCreationDate from Review";
            var list = datatable.GetList<Review>(query);*/
            //return GetModelList().ToList();
            return new List<Review>();
        }


        //public void UploadFile(User User, Course course, string filePath, DateTime creationDate)
        //{
        //    var qry = "INSERT INTO CourseFile(file, file_name, file_cou_id, file_user_id, file_creation_date) VALUES (@file, @file_name, @file_cou_id, @file_user_id, @file_creation_date)";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@file", System.IO.File.ReadAllBytes(filePath));
        //            cmd.Parameters.AddWithValue("@file_name", filePath.Trim());
        //            cmd.Parameters.AddWithValue("@file_cou_id", course.courseID);
        //            cmd.Parameters.AddWithValue("@file_user_id", User.userID);
        //            cmd.Parameters.AddWithValue("@file_creation_date", creationDate);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}
        //[HttpGet]
        //[Route("api/Course/GetFiles/{courseID:int}")]
        //public List<FileCourse> GetFiles(int courseID)
        //{
        //    var list = new List<FileCourse>();
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        con.Open();
        //        var qry = "select file_id, file, file_name, file_cou_id, file_user_id, file_creation_date from CourseFile where file_cou_id = @file_cou_id";
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            cmd.Parameters.AddWithValue("@file_cou_id", courseID);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    const int CHUNK_SIZE = 2 * 1024;//??????
        //                    byte[] buffer = new byte[CHUNK_SIZE];
        //                    long bytesRead;
        //                    long fieldOffset = 0;
        //                    var stream = new MemoryStream();
        //                    while ((bytesRead = reader.GetBytes(1, fieldOffset, buffer, 0, buffer.Length)) == buffer.Length)
        //                    {
        //                        stream.Write(buffer, 0, (int)bytesRead);
        //                        fieldOffset += bytesRead;
        //                    }
        //                    list.Add(new FileCourse(reader.GetInt32(0), reader.GetString(2), stream, reader.GetDateTime(5)));
        //                }
        //            }
        //        }
        //        con.Close();
        //    }
        //    return list;
        //}
    }
}
