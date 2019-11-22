using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : DataBaseController
    {
        // GET: api/Question
        [HttpGet]
        public List<Question> Get()
        {
            var questionList = new List<Question>();
            using (var con = new MySqlConnection(GetConnectionString()))
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
                            var tmp = new Question();
                            tmp.QuestionID = reader.GetInt32(0);
                            tmp.QuestionLikes = reader.GetInt32(1);
                            tmp.QuestionViews = reader.GetInt32(2);
                            tmp.QuestionAnswers = reader.GetInt32(3);
                            tmp.QuestionText = reader.GetString(4);
                            tmp.QuestionName = reader.GetString(5);
                            tmp.QuestionCreationDate = reader.GetDateTime(6);
                            questionList.Add(tmp);
                        }
                    }
                }
              con.Close();
            }

           return questionList;
        }


        [HttpGet("getComments/{question_id}")]
        public List<Comment> GetComments(int question_id)
        {
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
                            var tmp = new Comment();
                            tmp.CommentID = reader.GetInt32(0);
                            tmp.QuestionID = reader.GetInt32(1);
                            tmp.CommentText = reader.GetString(2);
                            tmp.CommentDate = reader.GetDateTime(3);
                            tmp.UserID = reader.GetInt32(4);
                            list.Add(tmp);
                        }
                    }
                }

                con.Close();
            }

            return list;
        }

        [HttpGet("GetOneQuestion/{questionID}")]
        public Question GetOneQuestion(int questionID)
        {
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select qns.qns_id, qns.qns_likes, qns.qns_views, qns.qns_comments, qns.qns_text, qns.qns_name, qns.qns_creation_date from questions qns where qns.qns_id = @qns_id";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", questionID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        var tmp = new Question();
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                tmp.QuestionID = reader.GetInt32(0);
                                tmp.QuestionLikes = reader.GetInt32(1);
                                tmp.QuestionViews = reader.GetInt32(2);
                                tmp.QuestionAnswers = reader.GetInt32(3);
                                tmp.QuestionText = reader.GetString(4);
                                tmp.QuestionName = reader.GetString(5);
                                tmp.QuestionCreationDate = reader.GetDateTime(6);
                                return tmp;
                            }
                        }
                        tmp.QuestionID = 99;
                        tmp.QuestionLikes = 0;
                        tmp.QuestionViews = 0;
                        tmp.QuestionAnswers = 0;
                        tmp.QuestionText = "Question MISSING";
                        tmp.QuestionName = "Question MISSING";
                        tmp.QuestionCreationDate = DateTime.Now;
                        con.Close();
                        return tmp;
                    }
                }
            }
        }

        [HttpPut("newquestion/{qns_uses_id}/{qns_name}/{qns_text}")]
        public void PutQuestions(int qns_user_id, string qns_name, string qns_text,
             DateTime qns_creation_date, int qns_views = 0, int qns_likes = 0, int qns_comments = 0)
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
                    cmd.Parameters.AddWithValue("@qns_creation_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@qns_user_id", qns_user_id);
                    cmd.Parameters.AddWithValue("@qns_views", qns_views);
                    cmd.Parameters.AddWithValue("@qns_likes", qns_likes);
                    cmd.Parameters.AddWithValue("@qns_comments", qns_comments);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpPut("addView/{question_id}")]
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

        [HttpPut("addLike/{question_id}")]
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

        [HttpPut("addDislike/{question_id}")]
        public void AddDislike(int question_id)
        {
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
    }
}

