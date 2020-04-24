using System;
using NHibernate.Cfg;

namespace MyNHibernate.Queries
{
    public static class SelectQuery
    {
        public static void Execute(Configuration cfg)
        {
            var sessionFactory = cfg.BuildSessionFactory();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();
            //perform database logic 
            var query = session.CreateQuery("from MyClass").List();
            tx.Commit();

            Console.WriteLine("SELECT-----");
            
            foreach (var album in query)
            {
                Console.WriteLine(album);
            }
        }
    }
}