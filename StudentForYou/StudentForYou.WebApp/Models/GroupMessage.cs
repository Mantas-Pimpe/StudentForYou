using StudentForYou.WebApp.Controllers;
using System;

namespace StudentForYou.WebApp.Models
{
    public class GroupMessage : Message
    {
        public Course course;
        public GroupMessage(int courseID, int messageID, string messageText, int senderID, DateTime messageTime) : base(messageID, messageText, senderID, messageTime)
        {
            //var tmpDB = new CourseController();
            //course = tmpDB.GetCourse(courseID);

        }
    }
}
