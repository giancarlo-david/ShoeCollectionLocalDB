using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ShoeCollectionLocalDB
{
    public static class DBConnection
    {
        public static SQLiteConnection GetConnection(string id = "Shoes")
        {
            SQLiteConnection connection = null;
            string connectionString = ConfigurationManager.ConnectionStrings[id].ConnectionString;
            connection = new SQLiteConnection(connectionString);

            return connection;
        }
    }
}
