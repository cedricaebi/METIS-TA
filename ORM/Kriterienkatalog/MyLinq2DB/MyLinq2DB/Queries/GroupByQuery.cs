using System;
using System.Linq;
using DataModels.Postgre;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class GroupByQuery
    {
        public static void Execute()
        {
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new PostgresDB();
            
            var query = from album in db.Albums
                group album by album.ArtistId into albumGroup
                select new {
                    ArtistID = albumGroup.Key, 
                    Count = albumGroup.LongCount()
                };
            
            Console.WriteLine("GROUPBY-----");
            
            foreach (var queryObject in query)
            {
                Console.WriteLine("{0} {1}", queryObject.Count, queryObject.ArtistID);
            }
        }
    }
}