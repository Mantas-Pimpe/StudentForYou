using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StudentForYouProfile
{
    public class Profile
    {
        private const string filePath = @"Resources\TempDatabase.txt";
        private const string bioFilePath = @"Resources\BioDatabase.txt";
        List<UserBio> userBios = new List<UserBio>();
        List<User> userList = new List<User>();
        private struct User
        {
            public string name;
            public string pictureFilePath;

            public User(string name, string pictureFilePath)
            {
                this.name = name;
                this.pictureFilePath = pictureFilePath;
            }
        }

        private struct UserBio
        {
            public string name;
            public string bio;

            public UserBio(string name, string bio)
            {
                this.name = name;
                this.bio = bio;
            }

        }


        public Tuple<string, string, int, string> GetUserData(string username, string pictureFilePath,
            int currentUserDataLine)
        {
            string line;
            var file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                var words = line.Split(' ');
                if (words[2] == "noPicture")
                    words[2] = pictureFilePath;
                userList.Add(new User(words[0], words[2]));
            }
            file.Close();
            var bioFile = new StreamReader(bioFilePath);
            var j = 0;
            while ((line = bioFile.ReadLine()) != null)
            {
                var bio = new char[100];
                var charCounter = 0;
                var bioCounter = 0;
                var i = 0;
                var bioName = new char[20];
                //reading username
                while (line[i] != ' ')
                {
                    bioName[i] = line[i];
                    i++;
                }
                //reading bio
                foreach (var ch in line)
                {
                    if (ch == '"')
                        charCounter++;
                    if (charCounter == 1 && ch != '"')
                    {
                        bio[bioCounter] = ch;
                        bioCounter++;
                    }



                }
                userBios.Add(new UserBio(new string(bioName),new string(bio)));
                j++;
            }
            bioFile.Close();
            var index = userBios.FindIndex(x => x.name.Contains(username));
            currentUserDataLine = index;
            //var groupJoin = userList.GroupJoin(userBios,  //inner sequence
            //    std => std.name, //outerKeySelector 
            //    s => s.name,     //innerKeySelector
            //    (std, studentsGroup) => new // resultSelector 
            //    {
            //        Students = studentsGroup,
            //        StandarFulldName = std.name
            //        PictureFilePath = 
            //    });
            
            return Tuple.Create(username, userBios[index].bio , currentUserDataLine, userList[currentUserDataLine].pictureFilePath);
        }

        public string PictureChange()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;
                }

            }

            return "noPicture";
        }

        public void SaveUserData(string newUsername, string pictureFilePath, int currentUserDataLine, string bio)
        {
            string lineToWrite = null;
            using (var reader = new StreamReader(filePath))
            {
                for (var i = 0; i <= currentUserDataLine; i++)
                    lineToWrite = reader.ReadLine();
            }

            if (lineToWrite != null)
            {
                var lineWords = lineToWrite.Split(' ');
                lineWords[0] = newUsername;
                lineWords[2] = pictureFilePath;
                lineToWrite = null;
                for (var i = 0; i < lineWords.Length; i++)
                {
                    if (lineWords.Length - 1 == i)
                        lineToWrite += lineWords[i];
                    else
                        lineToWrite = lineToWrite + lineWords[i] + " ";
                }
            }

            var lines = File.ReadAllLines(filePath);
            lines[currentUserDataLine] = lineToWrite;
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var t in lines)
                {
                    writer.WriteLine(t);
                }
            }
            var bioToWrite = '"'+bio+'"';
            var bioLines = File.ReadAllLines(bioFilePath);
            bioLines[currentUserDataLine] = newUsername + " " + bioToWrite;
            using (var writer = new StreamWriter(bioFilePath))
            {
                foreach (var t in bioLines)
                {
                    writer.WriteLine(t);
                }
            }
        }

    }
}
