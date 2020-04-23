using System;
using NHibernate.Cfg;

namespace MyNHibernate.Queries
{
    public static class SubQuery
    {
        public static void Execute(Configuration cfg)
        {
            var sessionFactory = cfg.BuildSessionFactory();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();
            //perform database logic 
            var query = session.CreateQuery("select Title from Album as album where album.Artist.Artistid = some (select Artistid from Artist as artist where artist.Artistid > 5)").List();
            tx.Commit();

            Console.WriteLine("SUBQUERY-----");
            
            foreach (var album in query)
            {
                Console.WriteLine(album);
            }
        }
    }
}