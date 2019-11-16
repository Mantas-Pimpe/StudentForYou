using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentForYou.RecentPosts;

namespace StudentForYou.DB
{
    public class QuestionsDB : DataBase
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

        public List<QuestionDetails> GetQuestions()
        {
            List<QuestionDetails> questionList = new List<QuestionDetails>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select qns.qns_name, qns.qns_text, qns.qns_creation_date, qns.qns_likes, qns.qns_views, qns.qns_comments, qns.qns_id from questions qns";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questionList.Add(new QuestionDetails(reader.GetInt32(6), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(0), Environment.NewLine, reader.GetDateTime(2)));
                        }
                    }
                }
                con.Close();
            }
            return questionList;
        }

        public void AddView(int qns_id)
        {
            var qry = "UPDATE questions SET qns_views = qns_views + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", qns_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddLike(int qns_id)
        {
            var qry = "UPDATE questions SET qns_likes = qns_likes + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", qns_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddDislike(int qns_id)
        {
            var qry = "UPDATE questions SET qns_likes = qns_likes - 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", qns_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddComment(int qns_id)
        {
            var qry = "UPDATE questions SET qns_comments = qns_comments + 1 WHERE qns_id = @qns_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@qns_id", qns_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void InsertIntoComments(int qns_id, string com_text, DateTime com_creation_date, int com_user_id)
        {
            AddComment(qns_id);
            var qry = "INSERT INTO comments(com_user_id, com_text, com_creation_date, com_qns_id) VALUES (@com_user_id, @com_text, @com_creation_date, @com_qns_id)";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@com_user_id", com_user_id);
                    cmd.Parameters.AddWithValue("@com_text", com_text);
                    cmd.Parameters.AddWithValue("@com_creation_date", com_creation_date);
                    cmd.Parameters.AddWithValue("@com_qns_id", qns_id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Comment> GetComments(int qns_id)
        {
            List<Comment> list = new List<Comment>();
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select com.com_id, com.com_user_id, com.com_text, com.com_creation_date, com.com_qns_id from comments com where com.com_qns_id = @qns_id";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", qns_id);
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
