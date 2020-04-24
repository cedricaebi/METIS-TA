using System;
using System.Linq;
using EFCore.Model;
using EFCore.Model.Oracle;
using EFCore.Model.Postgres;
using EFCore.Model.SQLite;
using EFCore.Model.DB2;
using EFCore.Model.SQLServer;

namespace EFCore.Queries
{
    public static class GroupByQuery
    {
        public static void Execute()
        {
            using var context = new ChinookContext();
            
            var query = context.Album.GroupBy(album => album.ArtistId)
                .Select(group => new
                {
                    Count = group.Count(),
                    ArtisID = group.Key
                });

            Console.WriteLine("GROUPBY-----");
            
            foreach (var albumGroup in query)
            {
                Console.WriteLine("{0} {1}", albumGroup.Count, albumGroup.ArtisID);
            }
        }
    }
}