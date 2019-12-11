using System;
namespace StudentForYou.DB
{
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserBio { get; set; }
        public DateTime UserCreationDate { get; set; }
        public byte[] userImage { get; set; }

    }
}
