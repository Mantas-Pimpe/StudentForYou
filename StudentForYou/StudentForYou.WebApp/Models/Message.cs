using System;
using StudentForYou.WebApp.Controllers;

namespace StudentForYou.WebApp.Models
{
    public class Message
    {
        public int messageID;
        public string messageText;
        public User messageSender;
        public DateTime messageTime;

        public Message(int messageID, string messageText, int senderID, DateTime messageTime)
        {
            //var tmpDB = new ProfileController();
            this.messageID = messageID;
            this.messageText = messageText;
            //messageSender = tmpDB.GetUser(senderID);
            this.messageTime = messageTime;
        }
    }
}
