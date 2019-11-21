using System;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;

namespace StudentForYou.DB
{
    public struct User
    {
        public int userID;
        public string username;
        public string userBio;
        public DateTime userCreationDate;
        public Image userImage;

        public User(int id, string username, string bio, DateTime creationDate, Image image)
        {
            userID = id;
            this.username = username;
            userBio = bio;
            userCreationDate = creationDate;
            userImage = image;
        }
    }
    public struct Review
    {
        public int reviewID;
        public int userID;
        public int courseID;
        public string text;
        public DateTime creationDate;

        public Review(int reviewID, int userID, int courseID, string text, DateTime creationDate)
        {
            this.reviewID = reviewID;
            this.userID = userID;
            this.courseID = courseID;
            this.text = text;
            this.creationDate = creationDate;
        }
    }
    public struct FileCourse
    {
        public int fileID;
        public string fileName;
        public MemoryStream file;
        public DateTime fileCreationDate;
        public FileCourse(int fileID, string fileName, MemoryStream file, DateTime fileCreationDate)
        {
            this.fileID = fileID;
            this.fileName = fileName;
            this.file = file;
            this.fileCreationDate = fileCreationDate;
        }
    }
    public class Message
    {
        public int messageID;
        public string messageText;
        public User messageSender;
        public DateTime messageTime;

        public Message(int messageID, string messageText, int senderID, DateTime messageTime)
        {
            var tmpDB = new ProfileDB();
            this.messageID = messageID;
            this.messageText = messageText;
            messageSender = tmpDB.GetUser(senderID);
            this.messageTime = messageTime;
        }
    }

    public class GroupMessage : Message
    {
        public Course course;
        public GroupMessage(int courseID, int messageID, string messageText, int senderID, DateTime messageTime) : base(messageID, messageText, senderID, messageTime)
        {
            var tmpDB = new CoursesDB();
            course = tmpDB.GetCourse(courseID);
        }
    }

    public class Course
    {
        public int courseID;
        public string name { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; }
        public DateTime creationDate;

        public Course(int courseID, string name, int difficulty, string description, DateTime creationDate)
        {
            this.courseID = courseID;
            this.name = name;
            this.difficulty = difficulty;
            this.description = description;
            this.creationDate = creationDate;
        }
    }

    public class DataBase
    {
       public Lazy<MySqlConnection> lazyConnection;
     public   ConnectionManager conManager;
        public DataBase()
        {
            lazyConnection = new Lazy<MySqlConnection>(() => new MySqlConnection(GetConnectionString()));
            conManager = new ConnectionManager();
        }
       

        public string GetConnectionString()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "remotemysql.com";
            builder.Port = 3306;
            builder.Database = "dx01fvQECG";
            builder.UserID = "dx01fvQECG";
            builder.Password = "LgbVCXMkIm";
            return builder.ConnectionString;
        }
    }
}
