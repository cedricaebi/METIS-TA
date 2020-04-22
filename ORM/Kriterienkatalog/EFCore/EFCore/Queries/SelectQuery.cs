using System;
using System.Linq;
using EFCore.Model;
using EFCore.Model.MySQL;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Queries
{
    public static class SelectQuery
    {
        public static void Execute()
        {
            using var context = new ChinookContext();
            var query = context.Album.Where(album =>
                    EF.Functions.Like(album.Title, "B%"))
                .Select(album => album.Title);
                
            Console.WriteLine("SELECT-----");
                
            foreach (var album in query)
            {
                Console.WriteLine("{0}", album);
            }
        }
    }
}