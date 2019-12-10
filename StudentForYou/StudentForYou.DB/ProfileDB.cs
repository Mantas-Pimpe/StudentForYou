//using System;
//using System.Drawing;
//using System.IO;
//using MySql.Data.MySqlClient;
//using StudentForYou.RecentPosts;

//namespace StudentForYou.DB
//{
//    public class ProfileDB : DataBase
//    {
//        public QuestionsDB db;
//        public ProfileDB()
//        {
//            db = new QuestionsDB();
//            db.InsertedComment += new QuestionsDB.Del(UpdateUserKarma);
//            db.InsertedLike += new QuestionsDB.Del(UpdateUserKarma);
//            db.InsertedQuestion += new QuestionsDB.Del(UpdateUserKarma);
//        }
//        public void UpdateUserKarma(Question question)
//        {
//            /*
//             * Kai useris akytviai naudojasi sistema updateinam jo Karmos taskus
//             * 
//             */
//        }

//        public void InsertIntoUsers(string user_username, DateTime user_creation_date, string user_password)
//        {
//            var qry = "INSERT INTO users(user_username, user_bio ,user_creation_date, user_password, user_image) VALUES (@user_username, 'User has not set his bio yet.', @user_creation_date, @user_password, @user_image)";
//            using (var con = new MySqlConnection(GetConnectionString()))
//            {
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_username", user_username.Trim());
//                    cmd.Parameters.AddWithValue("@user_creation_date", user_creation_date);
//                    cmd.Parameters.AddWithValue("@user_image", File.ReadAllBytes("Resources/personIcon.jpg"));
//                    cmd.Parameters.AddWithValue("@user_password", user_password.Trim());
//                    cmd.ExecuteNonQuery();
//                    conManager.CloseConnection(con);
//                }
//            }
//        }

//        public int? GetUserLoginID(string user_username, string user_password)
//        {
//            using (var con = conManager.OpenConnection(lazyConnection))
//            {
//                var qry = "select user.user_id from users user where user.user_username = @user_username and user.user_password = @user_password";
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_username", user_username);
//                    cmd.Parameters.AddWithValue("@user_password", user_password);
//                    using (var reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            if (!reader.IsDBNull(0))
//                            {
//                                var id = reader.GetInt32(0);
//                                conManager.CloseConnection(con);
//                                return id;
//                            }
//                        }
//                    }
//                }
//            }
//            return null;
//        }

//        public Boolean CheckIfUsernameTaken(string username)
//        {
//            using (var con = conManager.OpenConnection(lazyConnection))
//            {
//                var qry = "select user.user_username from users user";
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    using (var reader = cmd.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            if (username == reader.GetString(0))
//                            {
//                                conManager.CloseConnection(con);
//                                return true;
//                            }
//                        }
//                    }
//                }
//                conManager.CloseConnection(con);
//            }

//            return false;
//        }

//        public User GetUser(int user_id)
//        {
//            using (var con = conManager.OpenConnection(lazyConnection))
//            {
//                var qry = "select user.user_id, user.user_username, user.user_bio, user.user_creation_date, user.user_image from users user where user.user_id = @user_id";
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_id", user_id);
//                    using (var reader = cmd.ExecuteReader())
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
//                                User tmp = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), new Bitmap(stream));
//                                conManager.CloseConnection(con);
//                                return tmp;
//                            }
//                        }
//                        return new User(2, "USER MISSING", "USER MISSING", new DateTime(2000, 01, 01), Image.FromFile("Resources/personIcon.jpg"));
//                    }
//                }
//            }
//        }

//        public void UpdateUser(User user)
//        {
//            var qry = "UPDATE users SET user_username = @user_username, user_bio = @user_bio "/*user_img = @user_img,*/ + " WHERE user_id = @user_id";
//            using (var con = conManager.OpenConnection(lazyConnection))
//            {
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_id", user.userID);
//                    cmd.Parameters.AddWithValue("@user_username", user.username);
//                    cmd.Parameters.AddWithValue("@user_bio", user.userBio);
//                    cmd.ExecuteNonQuery();
//                    conManager.CloseConnection(con);
//                }
//            }
//        }

//        public void InsertImage(User user, string filePath)
//        {
//            var qry = "UPDATE users SET user_image = @user_image WHERE user_id = @user_id";
//            using (var con = conManager.OpenConnection(lazyConnection))
//            {
//                using (var cmd = new MySqlCommand(qry, con))
//                {
//                    cmd.Parameters.AddWithValue("@user_id", user.userID);
//                    cmd.Parameters.AddWithValue("@user_image", File.ReadAllBytes(filePath));
//                    cmd.ExecuteNonQuery();
//                    conManager.CloseConnection(con);
//                }
//            }
//        }
//    }
//}

