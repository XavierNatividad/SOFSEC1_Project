using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFSEC1_Project
{
    public class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void Login() 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // var output = cnn.Query<ModelName>("SELECT * from Person", new DynamicParameters());
            }
        }

    }
}
