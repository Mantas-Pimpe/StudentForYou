using StudentForYou.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var tmpDB = new ProfileDB();
            this.messageID = messageID;
            this.messageText = messageText;
            messageSender = tmpDB.GetUser(senderID);
            this.messageTime = messageTime;
        }
    }
}
