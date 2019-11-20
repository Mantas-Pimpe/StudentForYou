using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.RecentPosts;
using Question = StudentForYou.WebApp.Models.Question;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : DataBaseController
    {
        // GET: api/Question
        [HttpGet]
        [Route("api/Question/GetQuestions")]
        public List<Question> GetQuestions()
        {
            var questionList = new List<Question>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry =
                    "select qns.qns_id, qns.qns_likes, qns.qns_views, qns.qns_comments, qns.qns_text, qns.qns_name, qns.qns_creation_date from questions qns";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questionList.Add(new Question(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2),
                                reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6)));
                        }
                    }
                }

                con.Close();
            }

            return questionList;
        }
        
        // PUT: api/Question/5
        [HttpPut("{id}")]
        [Route("api/Question/PutIntoQuestions/{qns_user_id:int}/{qns_name:string}/{qns_text:string}/" +
               "{qns_creation_date:DateTime}/{qns_views:int}/{qns_likes:int}/{qns_comments:int}")]
        public void PutIntoQuestions(int qns_user_id, string qns_name,  string qns_text,
             DateTime qns_creation_date,  int qns_views = 0, int qns_likes = 0,  int qns_comments = 0)
        {
            var qry =
                "INSERT INTO questions(qns_name, qns_text, qns_creation_date, qns_user_id, qns_views, qns_likes, qns_comments) VALUES (@qns_name, @qns_text, @qns_creation_date, @qns_user_id, @qns_views, @qns_likes, @qns_comments)";
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_name", qns_name.Trim());
                    cmd.Parameters.AddWithValue("@qns_text", qns_text.Trim());
                    cmd.Parameters.AddWithValue("@qns_creation_date", qns_creation_date);
                    cmd.Parameters.AddWithValue("@qns_user_id", qns_user_id);
                    cmd.Parameters.AddWithValue("@qns_views", qns_views);
                    cmd.Parameters.AddWithValue("@qns_likes", qns_likes);
                    cmd.Parameters.AddWithValue("@qns_comments", qns_comments);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpPut("{id}")]
        [Route("api/Question/AddView/{question_id:int}")]
        public void AddView(int question_id)
        {
            const string qry = "UPDATE questions SET qns_views = qns_views + 1 WHERE qns_id = @qns_id";
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpPut("{id}")]
        [Route("api/Question/AddLike/{question_id:int}")]
        public void AddLike(int question_id)
        {
            var qry = "UPDATE questions SET qns_likes = qns_likes + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpPut("{id}")]
        [Route("api/Question/AddDislike/{question_id:int}")]
        public void AddDislike(int question_id)
        {
            // cia irgi reikia id
            var qry = "UPDATE questions SET qns_likes = qns_likes - 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        [HttpGet]
        [Route("api/Question/GetComments/{question_id:int}")]
        public List<Comment> GetComments(int question_id)
        {
            // cia irgi reikia id
            var list = new List<Comment>();
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select com.com_id, com.com_user_id, com.com_text, com.com_creation_date, com.com_qns_id from comments com where com.com_qns_id = @qns_id";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Comment(reader.GetInt32(0), reader.GetInt32(4), reader.GetInt32(1),
                                reader.GetString(2), reader.GetDateTime(3)));
                        }
                    }
                }

                con.Close();
            }

            return list;
        }
    }
}
