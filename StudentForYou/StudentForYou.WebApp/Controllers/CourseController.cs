using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : DataBaseController
    {
        [HttpGet("GetCourses")]
        public List<Course> GetCourses()
        {
            var list = new List<Course>();
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select cou_id, cou_name, cou_difficulty, cou_description, cou_creation_date from courses";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        { 
                            var tmp = new Course();
                            Func<MySqlDataReader, Course, Course> ReadData = delegate (MySqlDataReader readerRef, Course courseRef)
                             {

                                 courseRef.CourseID = reader.GetInt32(0);
                                 courseRef.CourseName = reader.GetString(1);
                                 courseRef.CourseDescription = reader.GetString(3);
                                 courseRef.CourseDifficulty = reader.GetInt32(2);
                                 courseRef.CourseCreationDate = reader.GetDateTime(4);
                                 return courseRef;
                             };


                            list.Add(ReadData(reader, tmp));
                        }
                    }
                }
                con.Close();
            }
            return list;
        }

        [HttpGet("{courseID}/GetCourse")]
        public Course GetCourse(int courseID)
        {
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select cou.cou_id, cou.cou_name, cou.cou_difficulty, cou.cou_description, cou.cou_creation_date from courses cou where cou.cou_id = @cou_id";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@cou_id", courseID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        var tmp = new Course();
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                Func<MySqlDataReader, Course, Course> ReadData = delegate (MySqlDataReader readerRef, Course courseRef)
                                {

                                    courseRef.CourseID = reader.GetInt32(0);
                                    courseRef.CourseName = reader.GetString(1);
                                    courseRef.CourseDescription = reader.GetString(3);
                                    courseRef.CourseDifficulty = reader.GetInt32(2);
                                    courseRef.CourseCreationDate = reader.GetDateTime(4);
                                    return courseRef;
                                };
                            }
                        }
                        tmp.CourseID = 99;
                        tmp.CourseName = "Course MISSING";
                        tmp.CourseDescription = "COURSE MISSING";
                        tmp.CourseDifficulty = 0;
                        tmp.CourseCreationDate = new DateTime(2000, 01, 01);
                        con.Close();
                        return tmp;
                    }
                }
            }
        }
        [HttpPost("PostCourse")]
        public void PutIntoCourses([FromBody] Course course)
        {
            var qry = "INSERT INTO courses(cou_name, cou_difficulty, cou_description, cou_creation_date) VALUES (@cou_name, @cou_difficulty, @cou_description, @cou_creation_date)";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@cou_name", course.CourseName.Trim());
                    cmd.Parameters.AddWithValue("@cou_description", course.CourseDescription.Trim());
                    cmd.Parameters.AddWithValue("@cou_creation_date", course.CourseCreationDate);
                    cmd.Parameters.AddWithValue("@cou_difficulty", course.CourseDifficulty);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpGet("{courseID}/GetReviews")]
        public List<Review> GetReviews(int courseID)
        {
            var list = new List<Review>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select cor_id, cor_cou_id, cor_user_id, cor_text, cor_creation_date from courses_reviews where cor_cou_id = @cor_cou_id";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@cor_cou_id", courseID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Review(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4)));
                        }
                    }
                }
                con.Close();
            }
            return list;
        }
        //public void UploadFile(User user, Course course, string filePath, DateTime creationDate)
        //{
        //    var qry = "INSERT INTO courses_files(file, file_name, file_cou_id, file_user_id, file_creation_date) VALUES (@file, @file_name, @file_cou_id, @file_user_id, @file_creation_date)";
        //    using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
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
