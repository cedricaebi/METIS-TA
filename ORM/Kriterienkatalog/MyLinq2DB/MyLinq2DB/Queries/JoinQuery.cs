using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using DataModels.MySQL;
using DataModels.Postgre;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public class JoinQuery
    {
        public static void Execute()
        {
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new PostgresDB();

            var query = from album in db.Albums
                join artist in db.Artists on album.ArtistId equals artist.ArtistId
                where album.Title.Equals("Let There Be Rock")
                select new
                {
                    album,
                    artist
                };

            Console.WriteLine("JOIN-----");
            
            foreach (var queryObject in query)
            {
                //Print first three columns
                Console.WriteLine("{0}", queryObject.artist.Name);
            }
        }
    }
}