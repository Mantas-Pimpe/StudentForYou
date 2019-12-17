using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;
using System.IO;
using System.Configuration;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupChatController : DataBaseController
    {

        public delegate void MyDel(string message);
        public event MyDel MyEvent;
        [HttpPost]
        public void Post([FromBody] GroupMessage message)
        {
            var qry = "INSERT INTO chat_group(chg_user_id, chg_course_id, chg_text, chg_creation_date) VALUES (@chg_user_id, @chg_course_id, @chg_text, @chg_creation_date)";

            try
            { 
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                   
                    
                con.Open();
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@chg_user_id", message.MessageSenderID);
                    cmd.Parameters.AddWithValue("@chg_course_id", message.CourseID);
                    cmd.Parameters.AddWithValue("@chg_text", message.MessageText.Trim());
                    cmd.Parameters.AddWithValue("@chg_creation_date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
            catch (Exception e)
            {
                var logName = ConfigurationManager.AppSettings["logfilename"];
                MyEvent(message.MessageText + message.MessageTime + "\n" + e.ToString());
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, logName), true))
                {
                    writer.WriteLine(message.MessageText + message.MessageTime + "\n" + e.ToString());
                }
              
               // File.WriteAllText(filePath, e.ToString());
         
            }
            }
        [HttpGet("{courseID}/Get")]
        public List<GroupMessage> Get(int courseID)
        {
            List<GroupMessage> list = new List<GroupMessage>();
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select chg_id, chg_user_id, chg_course_id, chg_text, chg_creation_date from chat_group where chg_course_id = @chg_course_id order by chg_creation_date";
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@chg_course_id", courseID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tmp = new GroupMessage();
                            tmp.MessageID = reader.GetInt32(0);
                            tmp.CourseID = reader.GetInt32(2);
                            tmp.MessageSenderID = reader.GetInt32(1);
                            tmp.MessageText = reader.GetString(3);
                            tmp.MessageTime = reader.GetDateTime(4);
                            list.Add(tmp);
                        }
                    }
                }
                con.Close();
            }
            return list;
        }
    }
}

