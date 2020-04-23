using System;
using NHibernate.Cfg;

namespace MyNHibernate.Queries
{
    public static class OrderBy
    {
        public static void Execute(Configuration cfg)
        {
            var sessionFactory = cfg.BuildSessionFactory();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();
            //perform database logic 
            var query = session.CreateQuery("select Title from Album order by Title desc").List();
            tx.Commit();

            Console.WriteLine("ORDERBY-----");
            
            foreach (var album in query)
            {
                Console.WriteLine(album);
            }
        }
    }
}