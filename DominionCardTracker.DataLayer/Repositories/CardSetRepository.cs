using Dapper;
using DominionCardTracker.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace DominionCardTracker.DataLayer.Repositories
{
    /*
     This class acts as DAO for the card set
     */
    public class CardSetRepository
    {
        public const string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=DominionCardTracker;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CardSet> SelectAll()
        {
            //var connStr = ConfigurationSettings.GetConnectionString();
            //Console.WriteLine("Connection string: " + connStr);
            using (var connection = new SqlConnection(CONNECTION_STRING)) //(var connection = new SqlConnection(ConfigurationSettings.GetConnectionString()))
            {
                return connection.Query<CardSet>("CardSetSelectAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
