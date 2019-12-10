using System;
using System.IO;
using System.Linq;
using StudentForYou.DB;

namespace StudentForYouProfile
{
    public class ChangeUsername
    {
        private const int maximumUsernameLength = 15;
        private const int minimumUsernameLength = 3;
        //ProfileDB db = new ProfileDB();
        public int IsUsernameTaken(string username)
        {
            // return 0 if everything checks out
            // return 1 if username is taken
            // return 2 if username is too long
            // return 3 if username is too short
            // return 4 if username contains spaces
            if (username.Length > maximumUsernameLength)
            {
                return 2;
            }
            else if (username.Length < minimumUsernameLength)
            {
                return 3;
            }
            else if (username.Contains(' ') == true)
            {
                return 4;
            }

            /*if (db.CheckIfUsernameTaken(username))
            {
                return 1;
            }*/

            return 0;

        }

        public void CreateNewUser(string username, string password)
        {
            //db.InsertIntoUsers(username, DateTime.Now, password);
        }

    }
}
