using System;
using System.Linq;
using DataModels;
using DataModels.MySQL;
using DataModels.Postgre;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class SelectQuery
    {
        public static void Execute()
        {
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new PostgresDB();
            
            var query = from album in db.Albums
                where album.Title.StartsWith("B")
                select album.Title;
            
            Console.WriteLine("SELECT-----");
            
            foreach (var product in query)
            {
                Console.WriteLine(product);
            }
        }
    }
}