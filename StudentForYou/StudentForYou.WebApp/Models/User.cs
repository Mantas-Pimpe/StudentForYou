using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class User
    {
        public int userID;
        public string username;
        public string userBio;
        public DateTime userCreationDate;
        //public Image userImage;

        public User(int id, string username, string bio, DateTime creationDate/*, Image image*/)
        {
            userID = id;
            this.username = username;
            userBio = bio;
            userCreationDate = creationDate;
            //userImage = image;
        }
    }
}
