using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYouProfile
{
    public class ChangeUsername
    {
        private const string filePath = @"Resources\TempDatabase.txt";
        private const int maximumUsernameLength = 15;
        private const int minimumUsernameLength = 3;

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

            string[] lines = File.ReadLines(filePath).ToArray();
            string[] words = null;
            for (int i = 0; i < lines.Length; i++)
            {
                words = lines[i].Split(' ');
                if (words[0] == username)
                {
                    return 1;
                }

                words = null;
            }

            return 0;

        }

    }
}
