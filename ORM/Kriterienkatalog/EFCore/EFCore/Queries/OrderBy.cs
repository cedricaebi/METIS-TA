using System;
using System.Linq;
using EFCore.Model.Oracle;
using EFCore.Model.Postgres;
using EFCore.Model.SQLite;

namespace EFCore.Queries
{
    public class OrderBy
    {
        public static void Execute()
        {
            using var context = new ModelContext();
            var query = context.Album.OrderBy(album => album.Title)
                .Select(album => album);
                
            Console.WriteLine("ORDERBY-----");
            
            foreach (var album in query)
            {
                Console.WriteLine("{0}", album.Title);
            }
        }
    }
}