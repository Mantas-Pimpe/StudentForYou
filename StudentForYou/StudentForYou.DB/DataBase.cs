using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using StudentForYou.RecentPosts;

namespace StudentForYou.DB
{
    public struct User
    {
        public int id;
        public string username;
        public string bio;
        public DateTime creationDate;
        //public Image userImg; Darysim atskirai

        public User(int id, string username, string bio, DateTime creationDate)
        {
            this.id = id;
            this.username = username;
            this.bio = bio;
            this.creationDate = creationDate;
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
