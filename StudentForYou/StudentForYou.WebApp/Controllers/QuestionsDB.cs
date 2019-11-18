using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentForYou.RecentPosts;

namespace StudentForYou.WebApp.Controllers
{
    public class QuestionsDB : DataBaseController
    {
        public void InsertIntoQuestions(string qns_name, string qns_text, DateTime qns_creation_date, int qns_user_id, int qns_views = 0, int qns_likes = 0, int qns_comments = 0)
        {
            var qry = "INSERT INTO questions(qns_name, qns_text, qns_creation_date, qns_user_id, qns_views, qns_likes, qns_comments) VALUES (@qns_name, @qns_text, @qns_creation_date, @qns_user_id, @qns_views, @qns_likes, @qns_comments)";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
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

        public List<Question> GetQuestions()
        {
            List<Question> questionList = new List<Question>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select qns.qns_id, qns.qns_likes, qns.qns_views, qns.qns_comments, qns.qns_text, qns.qns_name, qns.qns_creation_date from questions qns";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questionList.Add(new Question(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6)));
                        }
                    }
                }
                con.Close();
            }
            return questionList;
        }

        public void AddView(Question question)
        {
            var qry = "UPDATE questions SET qns_views = qns_views + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddLike(Question question)
        {
            var qry = "UPDATE questions SET qns_likes = qns_likes + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddDislike(Question question)
        {
            var qry = "UPDATE questions SET qns_likes = qns_likes - 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddComment(Question question)
        {
            var qry = "UPDATE questions SET qns_comments = qns_comments + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void InsertIntoComments(Question question, string comText, DateTime comCreationDate, User user)
        {
            AddComment(question);
            var qry = "INSERT INTO comments(com_user_id, com_text, com_creation_date, com_qns_id) VALUES (@com_user_id, @com_text, @com_creation_date, @com_qns_id)";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@com_user_id", user.userID);
                    cmd.Parameters.AddWithValue("@com_text", comText.Trim());
                    cmd.Parameters.AddWithValue("@com_creation_date", comCreationDate);
                    cmd.Parameters.AddWithValue("@com_qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Comment> GetComments(Question question)
        {
            List<Comment> list = new List<Comment>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select com.com_id, com.com_user_id, com.com_text, com.com_creation_date, com.com_qns_id from comments com where com.com_qns_id = @qns_id";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Comment(reader.GetInt32(0), reader.GetInt32(4), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3)));
                        }
                    }
                }
                con.Close();
            }
            return list;
        }
    }
}
