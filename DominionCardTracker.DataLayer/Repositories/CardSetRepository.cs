using Dapper;
using DominionCardTracker.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionCardTracker.DataLayer.Repositories
{
    public class CardSetRepository
    {
        public List<CardSet> SelectAll()
        {
            using(var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                return connection.Query<CardSet>("CardSetSlectAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
