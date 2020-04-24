using System;
using System.Linq;
using EFCore.Model.SQLServer;

namespace EFCore.Queries
{
    public class SubQuery
    {
        public static void Execute()
        {
            var context = new ChinookContext();
            var query = context.Album.Where(album => context.Artist.Any(
                artist => artist.ArtistId.Equals(album.ArtistId) && artist.ArtistId > 5));
            

            Console.WriteLine("SUBQUERY-----");
            
            foreach (var album in query)
            {
                Console.WriteLine("{0}", album.Title);
            }
        }
    }
}