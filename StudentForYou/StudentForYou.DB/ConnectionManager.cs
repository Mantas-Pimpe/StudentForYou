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
            try
            {
             con.Open();
            return con;
            }
            catch (MySqlException e)
            {

                throw;
            }
           

        }
       public MySqlConnection CloseConnection(MySqlConnection con)
        {
            ; try
            {
                con.Close();
            }
            catch (MySqlException e)
            {

                throw;
            }
            return con;
        }

    }
}
