using System;
using System.Diagnostics;
using System.Linq;
using EFCore.Model;
using EFCore.Model.Oracle;
using EFCore.Model.Postgres;
using EFCore.Model.SQLite;

namespace EFCore.Queries
{
    public static class JoinQuery
    {
        public static void Execute()
        {
            using var context = new ModelContext();
            
            var albums = context.Album;
            var artists = context.Artist;

            /*EFCore 3.0
            var query = albums
                .Join(artists,
                    album => album.ArtistId,
                    artist => artist.ArtistId,
                    (album, artist) => new
                    {
                        album,
                        artist
                    })
                .Where(aa => aa.album.Title.Equals("Let There Be Rock"));
            */
            
            //EFCore 2.0
            var query = albums
                .Join(artists,
                    album => album.Artistid,
                    artist => artist.Artistid,
                    (album, artist) => new
                    {
                        album,
                        artist
                    })
                .Where(aa => aa.album.Title.Equals("Let There Be Rock"));
            
            Console.WriteLine("JOIN-----");
            
            foreach (var queryObject in query)
            {
                //Print first three rows from table
                //And yes I know the naming is shit, but I don't care :)
                Console.WriteLine("{0}", queryObject.artist.Name);
            }
        }
    }
}