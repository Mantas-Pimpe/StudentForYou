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
        [HttpGet]
        [Route("api/Course/GetCourse")]
        public List<Course> GetCourse()
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
                            list.Add(new Course(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4)));
                        }
                    }
                }
                con.Close();
            }
            return list;
        }
        [HttpGet]
        [Route("api/Course/GetCourse/{courseID:int}")]
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
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                Course tmp = new Course(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetDateTime(4));
                                con.Close();
                                return tmp;
                            }
                        }
                        return new Course(99, "Course MISSING", 0, "COURSE MISSING", new DateTime(2000, 01, 01));
                    }
                }
            }
        }
        [HttpPut]
        [Route("api/Course/PutIntoCourses/{cou_name:string}/{cou_difficulty:int}/{cou_description:string}/{cou_creation_date:DateTime}")]
        public void PutIntoCourses(string cou_name, int cou_difficulty, string cou_description, DateTime cou_creation_date)
        {
            var qry = "INSERT INTO courses(cou_name, cou_difficulty, cou_description, cou_creation_date) VALUES (@cou_name, @cou_difficulty, @cou_description, @cou_creation_date)";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@cou_name", cou_name.Trim());
                    cmd.Parameters.AddWithValue("@cou_description", cou_description.Trim());
                    cmd.Parameters.AddWithValue("@cou_creation_date", cou_creation_date);
                    cmd.Parameters.AddWithValue("@cou_difficulty", cou_difficulty);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        [HttpGet]
        [Route("api/Course/GetReviews/{courseID:int}")]
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
        [HttpGet]
        [Route("api/Course/GetFiles/{courseID:int}")]
        public List<FileCourse> GetFiles(int courseID)
        {
            var list = new List<FileCourse>();
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select file_id, file, file_name, file_cou_id, file_user_id, file_creation_date from courses_files where file_cou_id = @file_cou_id";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@file_cou_id", courseID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            const int CHUNK_SIZE = 2 * 1024;//??????
                            byte[] buffer = new byte[CHUNK_SIZE];
                            long bytesRead;
                            long fieldOffset = 0;
                            var stream = new MemoryStream();
                            while ((bytesRead = reader.GetBytes(1, fieldOffset, buffer, 0, buffer.Length)) == buffer.Length)
                            {
                                stream.Write(buffer, 0, (int) bytesRead);
                                fieldOffset += bytesRead;
                            }
                            list.Add(new FileCourse(reader.GetInt32(0), reader.GetString(2), stream, reader.GetDateTime(5)));
                        }
                    }
                }
                con.Close();
            }
            return list;
        }
    }
}
