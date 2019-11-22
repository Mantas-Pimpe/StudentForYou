using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentForYou.RecentPosts;

namespace StudentForYou.DB
{
    public class QuestionsDB : DataBase
    {
        public delegate void Del(Question question);
        public event Del InsertedComment;
        public event Del InsertedQuestion;
        public event Del InsertedLike;
        public QuestionsDB()
        {
            InsertedComment += new Del(AddComment);
        }

        public void InsertIntoQuestions(Question question)
        {
            InsertedQuestion(question);
            var qry = "INSERT INTO questions(qns_name, qns_text, qns_creation_date, qns_user_id, qns_views, qns_likes, qns_comments) VALUES (@qns_name, @qns_text, @qns_creation_date, @qns_user_id, @qns_views, @qns_likes, @qns_comments)";
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_name", question.questionName.Trim());
                    cmd.Parameters.AddWithValue("@qns_text", question.questionName.Trim());
                    cmd.Parameters.AddWithValue("@qns_creation_date", question.questionCreationDate);
                    cmd.Parameters.AddWithValue("@qns_user_id", question.questionAuthorID);
                    cmd.Parameters.AddWithValue("@qns_views", question.questionViews);
                    cmd.Parameters.AddWithValue("@qns_likes", question.questionLikes);
                    cmd.Parameters.AddWithValue("@qns_comments", question.questionAnswers);
                    cmd.ExecuteNonQuery();
                    conManager.CloseConnection(con);
                }
            }
        }

        public List<Question> GetQuestions()
        {
            List<Question> questionList = new List<Question>();
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                var qry = "select qns.qns_id, qns.qns_likes, qns.qns_views, qns.qns_comments, qns.qns_text, qns.qns_name, qns.qns_creation_date, qns.qns_user_id from questions qns";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questionList.Add(new Question(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetInt32(7)));
                        }
                    }
                }
                conManager.CloseConnection(con);
            }
            return questionList;
        }

        public void AddView(Question question)
        {
            var qry = "UPDATE questions SET qns_views = qns_views + 1 WHERE qns_id = @qns_id";
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void AddLike(Question question)
        {
            InsertedLike(question);
            var qry = "UPDATE questions SET qns_likes = qns_likes + 1 WHERE qns_id = @qns_id";
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    conManager.CloseConnection(con);
                }
            }
        }

        public void AddDislike(Question question)
        {
            var qry = "UPDATE questions SET qns_likes = qns_likes - 1 WHERE qns_id = @qns_id";
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    conManager.CloseConnection(con);
                }
            }
        }

        public void AddComment(Question question)
        {
            var qry = "UPDATE questions SET qns_comments = qns_comments + 1 WHERE qns_id = @qns_id";
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    conManager.CloseConnection(con);
                }
            }
        }

        public void InsertIntoComments(Question question, string comText, DateTime comCreationDate, User user)
        {
            InsertedComment(question);
            var qry = "INSERT INTO comments(com_user_id, com_text, com_creation_date, com_qns_id) VALUES (@com_user_id, @com_text, @com_creation_date, @com_qns_id)";
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@com_user_id", user.userID);
                    cmd.Parameters.AddWithValue("@com_text", comText.Trim());
                    cmd.Parameters.AddWithValue("@com_creation_date", comCreationDate);
                    cmd.Parameters.AddWithValue("@com_qns_id", question.questionID);
                    cmd.ExecuteNonQuery();
                    conManager.CloseConnection(con);
                }
            }
        }
        public List<Comment> GetComments(Question question)
        {
            List<Comment> list = new List<Comment>();
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                var qry = "select com.com_id, com.com_user_id, com.com_text, com.com_creation_date, com.com_qns_id from comments com where com.com_qns_id = @qns_id";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@qns_id", question.questionID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Comment(reader.GetInt32(0), reader.GetInt32(4), reader.GetInt32(1), reader.GetString(2), reader.GetDateTime(3)));
                        }
                    }
                }
                conManager.CloseConnection(con);
            }
            return list;
        }
    }
}
