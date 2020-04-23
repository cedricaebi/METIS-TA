using System;
using NHibernate.Cfg;

namespace MyNHibernate.Queries
{
    public static class GroupByQuery
    {
        public static void Execute(Configuration cfg)
        {
            var sessionFactory = cfg.BuildSessionFactory();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();
            //perform database logic 
            var query = session.CreateQuery("select count(*), Artist.Artistid from Album as album group by album.Artist").List();
            tx.Commit();

            Console.WriteLine("GROUPBY-----");
            
            foreach (var album in query)
            {
                var array = (Object[]) album;
                Console.WriteLine("{0}, {1}", array[0], array[1]);
            }
        }
    }
}