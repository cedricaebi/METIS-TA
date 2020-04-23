using System;
using NHibernate.Cfg;

namespace MyNHibernate.Queries
{
    public class JoinQuery
    {
        public static void Execute(Configuration cfg)
        {
            var sessionFactory = cfg.BuildSessionFactory();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();
            //perform database logic 
            var query = session.CreateQuery("select artist.Name from Album as album inner join album.Artist as artist where album.Title = 'Let There Be Rock'").List();
            tx.Commit();

            Console.WriteLine("JOIN-----");
            
            foreach (var album in query)
            {
                Console.WriteLine(album);
            }
        }
    }
}