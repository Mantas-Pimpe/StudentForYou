using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;
using StudentForYou.DB;
using System.Configuration;
using System.Linq;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : DataBaseController
    {
        DataTableDB db = new DataTableDB();
        [HttpGet]
        public List<Question> Get()
        {
            var query = "select qns.qns_id QuestionID, qns.qns_likes QuestionLikes, qns.qns_views QuestionViews, qns.qns_comments QuestionAnswers, qns.qns_text QuestionText, qns.qns_name QuestionName, qns.qns_creation_date QuestionCreationDate from questions qns";
            var list = db.GetList<Question>(query);
            //CheckList.ReplaceList(questionList);
            return list;
        }

        [HttpGet("getQuestionsSortedBy/{key}")]
        public List<Question> GetSortedList(string key)
        {
            var query = "select qns.qns_id QuestionID, qns.qns_likes QuestionLikes, qns.qns_views QuestionViews, qns.qns_comments QuestionAnswers, qns.qns_text QuestionText, qns.qns_name QuestionName, qns.qns_creation_date QuestionCreationDate from questions qns";
            var list = db.GetList<Question>(query);
            key.ToLower();
            for (int i = 0; i < list.Count; i++)
            {
                string name = list[i].QuestionName.ToLower();
                if (!name.Contains(key))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            return list;

        }

        [HttpGet("getComments/{question_id}")]
        public List<Comment> GetComments(int question_id)
        {
            var query = "select com.com_id CommentID, com.com_user_id UserID, com.com_text CommentText, com.com_creation_date CommentDate, com.com_qns_id QuestionID, com.com_likes Likes from comments com where com.com_qns_id = " + question_id;
            var list = db.GetList<Comment>(query);
            var listInDescOrder = list.OrderByDescending(q => q.Likes).ToList();
            return listInDescOrder;
        }

        [HttpPost("PostQuestionAnswer/{questionID}")]
        public void PostQuestionAnswer([FromBody] Comment comment)
        {
            var qry = "INSERT INTO comments(com_user_id, com_text, com_creation_date, com_qns_id, com_likes) VALUES (@com_user_id, @com_text, @com_creation_date, @com_qns_id, @com_likes)";
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    //cmd.Parameters.AddWithValue("@com_id", comment.CommentID);
                    cmd.Parameters.AddWithValue("@com_user_id", comment.UserID);
                    cmd.Parameters.AddWithValue("@com_text", comment.CommentText);
                    cmd.Parameters.AddWithValue("com_creation_date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@com_qns_id", comment.QuestionID);
                    cmd.Parameters.AddWithValue("@com_likes", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        [HttpGet("GetOneQuestion/{questionID}")]
        public Question GetOneQuestion(int questionID)
        {
            var query = "select qns.qns_id QuestionID, qns.qns_likes QuestionLikes, qns.qns_views QuestionViews, qns.qns_comments QuestionAnswers, qns.qns_text QuestionText, qns.qns_name QuestionName, qns.qns_creation_date QuestionCreationDate from questions qns where qns.qns_id = " + questionID;
            return db.GetItem<Question>(query);
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

        [HttpPost("addLike/{question_id}")]
        public void AddLike(int question_id)
        {
            db.UpdateIncreaseByNumber("questions", "qns_likes", "qns_id", question_id, 1);
        }

        [HttpPost("addView/{question_id}")]
        public void AddView(int question_id)
        {
            db.UpdateIncreaseByNumber("questions", "qns_views", "qns_id", question_id, 1);
        }


        [HttpPost("addDislike/{question_id}")]
        public void AddDislike(int question_id)
        {
            db.UpdateIncreaseByNumber("questions", "qns_likes", "qns_id", question_id, -1);
        }

        [HttpPost("addAnswer/{question_id}")]
        public void AddAnswer(int question_id)
        {
            db.UpdateIncreaseByNumber("questions", "qns_comments", "qns_id", question_id, 1);
        }

        [HttpDelete("deleteComment/{comment_id}")]
        public void DeleteComment(int comment_id)
        {
            db.DeleteRow("comments", "com_id", comment_id);
        }

        [HttpDelete("DeleteQuestion/{question_id}")]
        public void DeleteQuestion(int question_id)
        {
            db.DeleteRow("questions", "qns_id", question_id);
            db.DeleteRow("comments", "com_qns_id", question_id);
        }

        [HttpPost("addLikeForAnswer/{comment_id}")]
        public void AddLikeForAnswer(int comment_id)
        {
            db.UpdateIncreaseByNumber("comments", "com_likes", "com_id", comment_id, 1);
        }
    }
}

