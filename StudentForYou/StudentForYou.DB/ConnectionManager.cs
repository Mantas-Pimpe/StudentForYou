using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentForYou.DB
{
    public class ConnectionManager
    {

       public MySqlConnection OpenConnection(Lazy<MySqlConnection> lazyConnection)
        {
            MySqlConnection con = lazyConnection.Value;

             con.Open();
            return con;
        
       

        }
       public MySqlConnection CloseConnection(MySqlConnection con)
        {

            con.Close();
            return con;
        }

    }
}
