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
                x.ConnectionString = "Server=127.0.0.1,1433;Initial Catalog=Chinook;User ID=sa;Password=myNiceSQLPassword123;";
                x.Dialect<MsSql2012Dialect>();
                x.Driver<SqlClientDriver>();
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