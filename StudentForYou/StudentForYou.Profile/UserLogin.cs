using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForYouProfile
{
    public class UserLogin
    {

        public bool loginCheck(string username, string password)
        {
            const string filePath = @"Resources\TempDatabase.txt";
            string line;
            var file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(username))
                {

                    var words = line.Split(' ');
                    if (username == words[0] && password == words[1])
                    {
                        file.Close();
                        return true;
                    }
                    words = null;
                }
            }
            file.Close();
            return false;
        }
    }
}
