using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using DataModels.MySQL;
using DataModels.Postgre;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class OrderBy
    {
        public static void Execute()
        {
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new PostgresDB();
            
            var query = from album in db.Albums
                orderby album.Title
                select album;
            
            Console.WriteLine("ORDERBY-----");
            
            foreach (var album in query)
            {
                Console.WriteLine(album.Title);
            }
        }
    }
}