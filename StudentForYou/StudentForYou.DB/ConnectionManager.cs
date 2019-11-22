using System;
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
            }
            catch (MySqlException ex)
            {
                string s = "MySqlException: " + ex.ToString();
                Console.WriteLine(s);
            }
            finally
            {
               
            }
            return con;
        }
           
        
       public MySqlConnection CloseConnection(MySqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (MySqlException ex)
            {
                string s = "MySqlException: " + ex.ToString();
                Console.WriteLine(s);
            }
            finally
            {

            }
            return con;
        }

    }
}
