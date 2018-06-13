using System;
using System.Data.SQLite;
using System.IO;

namespace Data
{  
    class Database
    {
        public SQLiteConnection connection;
        //database instance constructor and connection string declaration
        public Database()
        {
            connection = new SQLiteConnection("Data Source = manningAppDatabase.db; " +
                "version=3");     
        }

        //opening connection
        public void OpenConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                else return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        //closing connection
        public void CloseConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
                else return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

}
