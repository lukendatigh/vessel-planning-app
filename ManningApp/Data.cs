using System.Data.SQLite;


namespace Data
{  
    class Database
    {
        public  SQLiteConnection connection;
        //database instance constructor and connection string declaration
        public Database()
        {
            connection = new SQLiteConnection("Data Source = manningAppDatabase.db; " +
                "version=3");     
        }

        //opening connection
        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            else return;
        }
        //closing connection
        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
            else return;
        }
    }

    class ManningOfficer
    {
        private string manningOfficerName;
        public void SetName(string name)
        {
            manningOfficerName = name;
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
