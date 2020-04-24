using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using MyNHibernate.Queries;

namespace MyNHibernate
{
    class Program
    {
        private static void Main()
        {
            var cfg = new Configuration();

            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = "Server=192.168.1.152:39015;databaseName=CHINOOK2;UserID=SYSTEM;Password=myNiceSQLPassword123";
                x.Dialect<HanaColumnStoreDialect>();
                x.Driver<HanaColumnStoreDriver>();
            });
         
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            
            SelectQuery.Execute(cfg);
            JoinQuery.Execute(cfg);
            GroupByQuery.Execute(cfg);
            OrderBy.Execute(cfg);
            SubQuery.Execute(cfg);
        }
    }
}