using System.Collections.Generic;
using System.Linq;
using LinqToDB.Configuration;

namespace MyLinq2DB
{
    public class ConnectionStringSettings : IConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public bool IsGlobal => false;
    }

    public class MySettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "SqlServer";
        public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "AdventureWorks2017",
                        ProviderName = "System.Data.SqlClient",
                        ConnectionString = @"Server=127.0.0.1,1433;Initial Catalog=AdventureWorks2017;User ID=sa;Password=myNiceSQLPassword123;"
                    };
            }
        }
    }
}