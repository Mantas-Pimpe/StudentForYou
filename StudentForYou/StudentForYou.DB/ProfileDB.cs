﻿using System;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;

namespace StudentForYou.DB
{
    public class ProfileDB : DataBase
    {
        public void InsertIntoUsers(string user_username, DateTime user_creation_date, string user_password)
        {
            var qry = "INSERT INTO users(user_username, user_bio ,user_creation_date, user_password, user_image) VALUES (@user_username, 'User has not set his bio yet.', @user_creation_date, @user_password, @user_image)";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@user_username", user_username.Trim());
                    cmd.Parameters.AddWithValue("@user_creation_date", user_creation_date);
                    cmd.Parameters.AddWithValue("@user_image", File.ReadAllBytes("Resources/personIcon.jpg"));
                    cmd.Parameters.AddWithValue("@user_password", user_password.Trim());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int? GetUserLoginID(string user_username, string user_password)
        {
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select user.user_id from users user where user.user_username = @user_username and user.user_password = @user_password";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@user_username", user_username);
                    cmd.Parameters.AddWithValue("@user_password", user_password);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                var id = reader.GetInt32(0);
                                con.Close();
                                return id;
                            }
                        }
                    }
                }
            }
            return null;
        }

        public Boolean CheckIfUsernameTaken(string username)
        {
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select user.user_username from users user";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (username == reader.GetString(0))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public User GetUser(int user_id)
        {
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry = "select user.user_id, user.user_username, user.user_bio, user.user_creation_date, user.user_image from users user where user.user_id = @user_id";
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                const int CHUNK_SIZE = 2 * 1024;//??????
                                byte[] buffer = new byte[CHUNK_SIZE];
                                long bytesRead;
                                long fieldOffset = 0;
                                var stream = new MemoryStream();
                                while ((bytesRead = reader.GetBytes(4, fieldOffset, buffer, 0, buffer.Length)) == buffer.Length)
                                {
                                    stream.Write(buffer, 0, (int)bytesRead);
                                    fieldOffset += bytesRead;
                                }
                                User tmp = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), new Bitmap(stream));
                                con.Close();
                                return tmp;
                            }
                        }
                        return new User(2, "USER MISSING", "USER MISSING", new DateTime(2000, 01, 01), Image.FromFile("Resources/personIcon.jpg"));
                    }
                }
            }
        }

        public void UpdateUser(User user)
        {
            var qry = "UPDATE users SET user_username = @user_username, user_bio = @user_bio "/*user_img = @user_img,*/ + " WHERE user_id = @user_id";
            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@user_id", user.userID);
                    cmd.Parameters.AddWithValue("@user_username", user.username);
                    cmd.Parameters.AddWithValue("@user_bio", user.userBio);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        
        public void InsertImage(User user, string filePath) 
        {
            var qry = "UPDATE users SET user_image = @user_image WHERE user_id = @user_id";
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                using (var cmd = new MySqlCommand(qry, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@user_id", user.userID);
                    cmd.Parameters.AddWithValue("@user_image", File.ReadAllBytes(filePath));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
