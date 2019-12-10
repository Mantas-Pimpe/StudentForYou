using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;
using StudentForYou.DB;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : DataBaseController
    {
        DataTableDB db = new DataTableDB();
        [HttpGet("GetCourses")]
        public List<Course> GetCourses()
        {
            var query = "select cou_id CourseID, cou_name CourseName, cou_difficulty CourseDifficulty, cou_description CourseDescription, cou_creation_date CourseCreationDate from courses";
            var list = db.GetList<Course>(query);
            //CheckList.ReplaceList(questionList);
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
            var tuple = WhiteSpaceRemover.CleanCourseBeforePost(course.CourseName, course.CourseDescription);
            course.CourseName = tuple.Result.Item1;
            course.CourseDescription = tuple.Result.Item2;
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
            var text = WhiteSpaceRemover.CleanReviewBeforePost(review.ReviewText);
            review.ReviewText = text.Result;
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
        public void DeleteQuestion(int courseID)
        {
            db.DeleteRow("courses", "cou_id", courseID);
            db.DeleteRow("courses_reviews", "cor_cou_id", courseID);
        }

        //public void UploadFile(User user, Course course, string filePath, DateTime creationDate)
        //{
        //    var qry = "INSERT INTO courses_files(file, file_name, file_cou_id, file_user_id, file_creation_date) VALUES (@file, @file_name, @file_cou_id, @file_user_id, @file_creation_date)";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@file", System.IO.File.ReadAllBytes(filePath));
        //            cmd.Parameters.AddWithValue("@file_name", filePath.Trim());
        //            cmd.Parameters.AddWithValue("@file_cou_id", course.courseID);
        //            cmd.Parameters.AddWithValue("@file_user_id", user.userID);
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
        //        var qry = "select file_id, file, file_name, file_cou_id, file_user_id, file_creation_date from courses_files where file_cou_id = @file_cou_id";
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
