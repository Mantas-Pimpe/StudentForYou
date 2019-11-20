using System;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace StudentForYou.WebApp.Controllers
{
    public class DataBaseController : ControllerBase
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
