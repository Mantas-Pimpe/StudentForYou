using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Question = StudentForYou.WebApp.Models.Question;

namespace StudentForYou.WebApp.Controllers
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : DataBaseController
    {
        [HttpPost]
        public int Post([FromBody] Model model)
        {
            return 1;
        }

        [HttpGet]
        public List<Question> Get()
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

        //// PUT: api/Question/5
        //[Route("api/Question/PutIntoQuestions/{qns_user_id:int}/{qns_name:string}/{qns_text:string}/" +
        //       "{qns_creation_date:DateTime}/{qns_views:int}/{qns_likes:int}/{qns_comments:int}")]
        //[HttpPut("{id}")]
        //public void PutIntoQuestions([FromBody] Model model)
        //{
        //    var qry =
        //        "INSERT INTO questions(qns_name, qns_text, qns_creation_date, qns_user_id, qns_views, qns_likes, qns_comments) VALUES (@qns_name, @qns_text, @qns_creation_date, @qns_user_id, @qns_views, @qns_likes, @qns_comments)";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@qns_name", qns_name.Trim());
        //            cmd.Parameters.AddWithValue("@qns_text", qns_text.Trim());
        //            cmd.Parameters.AddWithValue("@qns_creation_date", qns_creation_date);
        //            cmd.Parameters.AddWithValue("@qns_user_id", qns_user_id);
        //            cmd.Parameters.AddWithValue("@qns_views", qns_views);
        //            cmd.Parameters.AddWithValue("@qns_likes", qns_likes);
        //            cmd.Parameters.AddWithValue("@qns_comments", qns_comments);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}

        //[Route("api/Question/AddView/{question_id:int}")]
        //[HttpPut("{id}")]
        //public void AddView(int question_id)
        //{
        //    const string qry = "UPDATE questions SET qns_views = qns_views + 1 WHERE qns_id = @qns_id";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@qns_id", question_id);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}

        //[Route("api/Question/AddLike/{question_id:int}")]
        //[HttpPut("{id}")]
        //public void AddLike(int question_id)
        //{
        //    var qry = "UPDATE questions SET qns_likes = qns_likes + 1 WHERE qns_id = @qns_id";
        //    using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@qns_id", question_id);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}

        //[Route("api/Question/AddDislike/{question_id:int}")]
        //[HttpPut("{id}")]
        //public void AddDislike(int question_id)
        //{
        //    // cia irgi reikia id
        //    var qry = "UPDATE questions SET qns_likes = qns_likes - 1 WHERE qns_id = @qns_id";
        //    using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@qns_id", question_id);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}

        //[Route("api/Question/GetComments/{question_id:int}")]
        //[HttpGet]
        //public List<Comment> GetComments(int question_id)
        //{
        //    // cia irgi reikia id
        //    var list = new List<Comment>();
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        con.Open();
        //        var qry = "select com.com_id, com.com_user_id, com.com_text, com.com_creation_date, com.com_qns_id from comments com where com.com_qns_id = @qns_id";
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            cmd.Parameters.AddWithValue("@qns_id", question_id);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    list.Add(new Comment(reader.GetInt32(0), reader.GetInt32(4), reader.GetInt32(1),
        //                        reader.GetString(2), reader.GetDateTime(3)));
        //                }
        //            }
        //        }

        //        con.Close();
        //    }

        //    return list;
        //}
    }
}
