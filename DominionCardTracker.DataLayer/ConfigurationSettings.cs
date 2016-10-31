using System;
using System.Configuration;

namespace DominionCardTracker.DataLayer
{
    public class ConfigurationSettings      // Let's load the class a single time
    {
        private static string _connectionString;

        public static string GetConnectionString()
        {
            if(String.IsNullOrEmpty(_connectionString))
            {
                _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }
            return _connectionString;
        }
    }
}
