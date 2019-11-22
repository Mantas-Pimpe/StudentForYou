using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string userBio { get; set; }
        public DateTime userCreationDate { get; set; }

        //public Image userImage;
    }
}
