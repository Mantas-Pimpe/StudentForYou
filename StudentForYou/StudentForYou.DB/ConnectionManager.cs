using System;
using MySql.Data.MySqlClient;

namespace StudentForYou.DB
{
    public class ConnectionManager
    {
        public delegate void MyDel(string info);
        public event MyDel MyEvent;

        public MySqlConnection OpenConnection(Lazy<MySqlConnection> lazyConnection)
        {
            MySqlConnection con = lazyConnection.Value;
            try
            {
                con.Open();
            
            }
            catch (MySqlException ex)
            {
                MyEvent(ex.ToString());
                
            }
            
                return con;
        }
       public MySqlConnection CloseConnection(MySqlConnection con)
        {
            con.Close();
            return con;
        }

    }
}
