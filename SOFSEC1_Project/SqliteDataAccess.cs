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

        public static void GetUsername() 
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User_LoginModel>("SELECT * from Person", new DynamicParameters());
            }
        }

        public static List<User_ProfileModel> GetUserProfile()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User_ProfileModel>("SELECT * from user_profile", new DynamicParameters());

                return output.ToList();
            }
        }

    }
}
