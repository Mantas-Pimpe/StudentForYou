using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentForYou.WebApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserBio { get; set; }
        public DateTime UserCreationDate { get; set; }
        //public Image userImage{ get; set; };
    }
}
