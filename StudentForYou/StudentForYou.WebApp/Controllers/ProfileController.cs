//using System;
//using System.IO;
//using Microsoft.AspNetCore.Mvc;
//using MySql.Data.MySqlClient;
//using StudentForYou.WebApp.Models;

//namespace StudentForYou.WebApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProfileController : DataBaseController
//    {
//        // GET: api/Profile
//        [HttpGet]
//        [Route("api/Profile/GetUser/{user_id:int}")]
//        public User GetUser(int user_id)
//        {
//            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
//            {
//                con.Open();
//                var qry = "select user.user_id, user.user_username, user.user_bio, user.user_creation_date, user.user_image from users user where user.user_id = @user_id";
//                using (MySqlCommand cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_id", user_id);
//                    using (MySqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            if (!reader.IsDBNull(0))
//                            {
//                                const int CHUNK_SIZE = 2 * 1024;//??????
//                                byte[] buffer = new byte[CHUNK_SIZE];
//                                long bytesRead;
//                                long fieldOffset = 0;
//                                var stream = new MemoryStream();
//                                while ((bytesRead = reader.GetBytes(4, fieldOffset, buffer, 0, buffer.Length)) == buffer.Length)
//                                {
//                                    stream.Write(buffer, 0, (int)bytesRead);
//                                    fieldOffset += bytesRead;
//                                }
//                                User tmp = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3)/*, new Bitmap(stream)*/);
//                                con.Close();
//                                return tmp;
//                            }
//                        }
//                        return new User(2, "USER MISSING", "USER MISSING", new DateTime(2000, 01, 01)/*, Image.FromFile("Resources/personIcon.jpg")*/);
//                    }
//                }
//            }
//        }
//        // GET: api/Profile
//        [HttpGet]
//        [Route("api/Profile/GetUserLoginID/{user_username:string}")]
//        public int? GetUserLoginID(string user_username, [FromBody]string user_password)
//        {
//            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
//            {
//                con.Open();
//                var qry = "select user.user_id from users user where user.user_username = @user_username and user.user_password = @user_password";
//                using (MySqlCommand cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_username", user_username);
//                    cmd.Parameters.AddWithValue("@user_password", user_password);
//                    using (MySqlDataReader reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            if (!reader.IsDBNull(0))
//                            {
//                                var id = reader.GetInt32(0);
//                                con.Close();
//                                return id;
//                            }
//                        }
//                    }
//                }
//            }
//            return null;
//        }
//        [HttpPut]
//        [Route("api/Profile/PutIntoUsers/{user_username:string}/{user_creation_date:DateTime}")]
//        public void PutIntoUsers(string user_username, DateTime user_creation_date, [FromBody]string user_password)
//        {
//            var qry = "INSERT INTO users(user_username, user_bio ,user_creation_date, user_password, user_image) VALUES (@user_username, 'User has not set his bio yet.', @user_creation_date, @user_password, @user_image)";
//            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
//            {
//                using (MySqlCommand cmd = new MySqlCommand(qry, con))
//                {
//                    con.Open();
//                    cmd.Parameters.AddWithValue("@user_username", user_username.Trim());
//                    cmd.Parameters.AddWithValue("@user_creation_date", user_creation_date);
//                    cmd.Parameters.AddWithValue("@user_image", System.IO.File.ReadAllBytes("Resources/personIcon.jpg"));
//                    cmd.Parameters.AddWithValue("@user_password", user_password.Trim());
//                    cmd.ExecuteNonQuery();
//                }
//            }
//        }
//        [HttpPut]
//        [Route("api/Profile/PutImage/{user_id:int}")]
//        public void PutImage(int user_id, [FromBody]string filePath)
//        {
//            // yra patogiau imt id o ne user nes reikes daug construcint, nes cia i paramaetrus negali is db ateit, i parametrus ateina is webo
//            // cia va nesi tiesiog id ir visos problemos isprestos
//            const string qry = "UPDATE users SET user_image = @user_image WHERE user_id = @user_id";
//            using (var con = new MySqlConnection(GetConnectionString()))
//            {
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    con.Open();
//                    cmd.Parameters.AddWithValue("@user_id", user_id);
//                    cmd.Parameters.AddWithValue("@user_image", System.IO.File.ReadAllBytes(filePath));
//                    cmd.ExecuteNonQuery();
//                    con.Close();
//                }
//            }
//        }
//        // dis needs fixing
//        //public bool CheckIfUsernameTaken(string username)
//        //{
//        //    const string qry = "select user.user_username from users user";
//        //    using (var con = new MySqlConnection(GetConnectionString()))
//        //    {
//        //        con.Open();
//        //        using (var cmd = new MySqlCommand(qry, con))
//        //        {
//        //            using (MySqlDataReader reader = cmd.ExecuteReader())
//        //            {
//        //                while (reader.Read())
//        //                {
//        //                    if (username == reader.GetString(0))
//        //                    {
//        //                        return true;
//        //                    }
//        //                }
//        //            }
//        //        }
//        //    }
//        //    return false;
//        //}
//        [HttpPost]
//        [Route("api/Profile/UpdateUser/{user_id:int}/{username:string}")]
//        public void UpdateUser(int user_id, string username, [FromBody]string userBio)
//        {
//            var qry = "UPDATE users SET user_username = @user_username, user_bio = @user_bio "/*user_img = @user_img,*/ + " WHERE user_id = @user_id";
//            using (MySqlConnection con = new MySqlConnection(GetConnectionString()))
//            {
//                using (MySqlCommand cmd = new MySqlCommand(qry, con))
//                {
//                    con.Open();
//                    cmd.Parameters.AddWithValue("@user_id", user_id);
//                    cmd.Parameters.AddWithValue("@user_username", username);
//                    cmd.Parameters.AddWithValue("@user_bio", userBio);
//                    cmd.ExecuteNonQuery();
//                    con.Close();
//                }
//            }
//        }
//    }
//}
