using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace Data
{  
    class Database
    {
        public  SQLiteConnection con;
        //database instance constructor and connection string declaration
        public Database()
        {
            con = new SQLiteConnection("Data Source = manningAppDatabase.db; version=3");            
        }

        //opening connection
        public void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
            else return;
        }

        //closing connection
        public void CloseConnection()
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            else return;
        }
    }

    class TempData
    {
        private string sessionName;

        public void SetSessionUser(string name)
        {
            sessionName = name;
        }
    }


}
