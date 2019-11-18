
using StudentForYou.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class GroupMessage : Message
    {
        public Course course;
        public GroupMessage(int courseID, int messageID, string messageText, int senderID, DateTime messageTime) : base(messageID, messageText, senderID, messageTime)
        {
            var tmpDB = new CoursesDB();
            course = tmpDB.GetCourse(courseID);

        }
    }
}
