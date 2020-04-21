using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;

namespace MyNHibernate
{
    class Program
    {
        private static void Main()
        {
            var cfg = new Configuration();

            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = "Server=127.0.0.1,1433;Initial Catalog=AdventureWorks2017;User ID=sa;Password=myNiceSQLPassword123;";
                x.Dialect<MsSql2012Dialect>();
                x.Driver<SqlClientDriver>();
            });
         
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
         
            var sessionFactory = cfg.BuildSessionFactory();

            using var session = sessionFactory.OpenSession();
            using var tx = session.BeginTransaction();
            //perform database logic 
            var products = session.CreateQuery("select Name from Product");
            tx.Commit();
        }
    }
}