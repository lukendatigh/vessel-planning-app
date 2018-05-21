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
        //Connection string declaration
        public SQLiteConnection myConnection;

        public Database() {
            myConnection = new SQLiteConnection("Data Source = manningAppData.db");

        }

    }
}
