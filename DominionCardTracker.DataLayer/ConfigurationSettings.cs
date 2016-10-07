using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionCardTracker.DataLayer
{
    static class ConfigurationSettings      // Let's load the class a single time
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
