using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using DataModels.MySQL;
using DataModels.Postgre;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class SubQuery
    {
        public static void Execute()
        {
            DataConnection.DefaultSettings = new MySettings();
            
            var db = new PostgresDB();

            var query = from album in db.Albums
                from artist in db.Artists
                where album.ArtistId == artist.ArtistId && artist.ArtistId > 5
                select album;

            Console.WriteLine("SUBQUERY-----");
            foreach (var album in query)
            {
                Console.WriteLine(album.Title);
            }
        }
    }
}