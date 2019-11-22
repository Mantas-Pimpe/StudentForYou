using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace StudentForYou.DB
{
    public class GroupChatDB : DataBase
    {
  
        public GroupChatDB()
        {
            conManager = new ConnectionManager();
            Lazy<MySqlConnection> lazyConnection;
            lazyConnection = new Lazy<MySqlConnection>(() => new MySqlConnection(GetConnectionString()));
        }
        public void InsertIntoGroupChat(User user, Course course, string text, DateTime creationDate)
        {
            var qry = "INSERT INTO chat_group(chg_user_id, chg_course_id, chg_text, chg_creation_date) VALUES (@chg_user_id, @chg_course_id, @chg_text, @chg_creation_date)";

            using (var con = conManager.OpenConnection(lazyConnection))
            { 
            using (var cmd = new MySqlCommand(qry, con))
            {

                cmd.Parameters.AddWithValue("@chg_user_id", user.userID);
                cmd.Parameters.AddWithValue("@chg_course_id", course.courseID);
                cmd.Parameters.AddWithValue("@chg_text", text.Trim());
                cmd.Parameters.AddWithValue("@chg_creation_date", creationDate);
                cmd.ExecuteNonQuery();
                conManager.CloseConnection(con);
            }
            }
        }
        public List<GroupMessage> GetGroupMessages(Course course)
        {
            List<GroupMessage> list = new List<GroupMessage>();
            using (var con = conManager.OpenConnection(lazyConnection))
            {
                var qry = "select chg_id, chg_user_id, chg_course_id, chg_text, chg_creation_date from chat_group where chg_course_id = @chg_course_id order by chg_creation_date";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@chg_course_id", course.courseID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new GroupMessage(reader.GetInt32(2), reader.GetInt32(0), reader.GetString(3), reader.GetInt32(1), reader.GetDateTime(4)));
                        }
                    }
                }
                conManager.CloseConnection(con);
            }
            return list;
        }
    }
}
