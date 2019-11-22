using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string userBio { get; set; }
        
        public string configPrivacy 
        public DateTime userCreationDate { get; set; }

        public User()
        { 
            configPrivacy = ConfigurationManager.AppSettings["PrivacySetting"];

        }



        //public Image userImage;
    }
}
