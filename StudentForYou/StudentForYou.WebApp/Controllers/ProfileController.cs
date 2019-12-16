using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using StudentForYou.WebApp.Models;

namespace StudentForYou.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : DataBaseController
    {
        // GET: api/Profile
        
        [HttpGet("{user_id}/GetUser")]
        public User GetUser(int user_id)
        {
            using (var con = new MySqlConnection(GetConnectionString()))
            {
                con.Open();
                var qry =
                    "select user.user_id, user.user_username, user.user_bio, user.user_creation_date, user.user_image from users user where user.user_id = @user_id";
                var tmp = new User();
                using (var cmd = new MySqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                const int CHUNK_SIZE = 2 * 1024; //??????
                                byte[] buffer = new byte[CHUNK_SIZE];
                                long bytesRead;
                                long fieldOffset = 0;
                                var stream = new MemoryStream();
                                while ((bytesRead = reader.GetBytes(4, fieldOffset, buffer, 0, buffer.Length)) ==
                                       buffer.Length)
                                {
                                    stream.Write(buffer, 0, (int) bytesRead);
                                    fieldOffset += bytesRead;
                                }

                                tmp.UserID = reader.GetInt32(0);
                                tmp.UserName = reader.GetString(1);
                                tmp.UserBio = reader.GetString(2);
                                tmp.UserCreationDate = reader.GetDateTime(3);
                                //tmp.userImage = new Bitmap(stream));
                                con.Close();
                                return tmp;
                            }
                        }

                        tmp.UserID = 99;
                        tmp.UserName = "User MISSING";
                        tmp.UserBio = "User MISSING";
                        tmp.UserCreationDate = new DateTime(2000, 01, 01);
                        //tmp.userImage = new Bitmap(stream));
                        con.Close();
                        return tmp;
                    }
                }
            }
        }

        //GET: api/Profile
        //[HttpGet("GetLoginId/{user_username:string}/{user_password:string}")]
        //public int? GetUserLoginId([FromBody] User user)
        //{
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        con.Open();
        //        var qry =
        //            "select user.user_id from users user where user.user_username = @user_username and user.user_password = @user_password";
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            cmd.Parameters.AddWithValue("@user_username", user.UserName);
        //            cmd.Parameters.AddWithValue("@user_password", user.UserPassword);
        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    if (!reader.IsDBNull(0))
        //                    {
        //                        var id = reader.GetInt32(0);
        //                        con.Close();
        //                        return id;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}
        //[HttpPost("PostNewUser")]
        //public void PutIntoUsers(string user_username, DateTime user_creation_date, string user_password)
        //{
        //    var qry = "INSERT INTO users(user_username, user_bio ,user_creation_date, user_password, user_image) VALUES (@user_username, 'User has not set his bio yet.', @user_creation_date, @user_password, @user_image)";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@user_username", user_username.Trim());
        //            cmd.Parameters.AddWithValue("@user_creation_date", user_creation_date);
        //            cmd.Parameters.AddWithValue("@user_image", System.IO.File.ReadAllBytes("Resources/personIcon.jpg"));
        //            cmd.Parameters.AddWithValue("@user_password", user_password.Trim());
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //[HttpPost("PostImage")]
        //public void PutImage(int user_id, [FromBody] string filePath)
        //{
        //    const string qry = "UPDATE users SET user_image = @user_image WHERE user_id = @user_id";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@user_id", user_id);
        //            cmd.Parameters.AddWithValue("@user_image", System.IO.File.ReadAllBytes(filePath));
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}

        //public bool CheckIfUsernameTaken(string username)
        //{
        //    const string qry = "select user.user_username from users user";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        con.Open();
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            using (MySqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    if (username == reader.GetString(0))
        //                    {
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}
        //[HttpPost("{user_id}/UpdateUser")]
        //public void UpdateUser()
        //{
        //    var qry = "UPDATE users SET user_username = @user_username, user_bio = @user_bio "/*user_img = @user_img,*/ + " WHERE user_id = @user_id";
        //    using (var con = new MySqlConnection(GetConnectionString()))
        //    {
        //        using (var cmd = new MySqlCommand(qry, con))
        //        {
        //            con.Open();
        //            cmd.Parameters.AddWithValue("@user_id", user_id);
        //            cmd.Parameters.AddWithValue("@user_username", username);
        //            cmd.Parameters.AddWithValue("@user_bio", userBio);
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }
        //}

        public bool CheckUsernameRequirements(string username)
        {


            int minValue = int.Parse(ConfigurationManager.AppSettings["minUsernameValue"]);
            int maxValue = int.Parse(ConfigurationManager.AppSettings["maxestutisUsernameValue"]);

            if(username.Length<minValue)
            {
                return false;
            }
            if(username.Length>maxValue)
            {
                return false;
            }
            return true;
        }
    }
}

