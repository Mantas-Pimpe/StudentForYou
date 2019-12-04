using System;
using StudentForYou.WebApp.Controllers;

namespace StudentForYou.WebApp.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageText { get; set; }
        //public User MessageSender { get; set; }
        public int MessageSenderID { get; set; }
        public DateTime MessageTime { get; set; }

    }
}
