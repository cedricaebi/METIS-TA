using System;
using System.Linq;
using EFCore.Model;
using EFCore.Model.Oracle;
using EFCore.Model.Postgres;
using EFCore.Model.SQLite;

namespace EFCore.Queries
{
    public class SubQuery
    {
        public static void Execute()
        {
            /*EFCORE 3.0
            var context = new ModelContext();
            var query = context.Album.Where(album => context.Artist.Any(
                artist => artist.ArtistId.Equals(album.ArtistId) && artist.ArtistId > 5));
            */
                
            //EFCORE 2.0
            var context = new ModelContext();
            var query = context.Album.Where(album => context.Artist.Any(
                artist => artist.Artistid.Equals(album.Artistid) && artist.Artistid > 5));
            
            Console.WriteLine("SUBQUERY-----");
            
            foreach (var album in query)
            {
                Console.WriteLine("{0}", album.Title);
            }
        }
    }
}