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

        public string DefaultConfiguration => "SQLite";
        public string DefaultDataProvider => "SQLite";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Chinook",
                        ProviderName = "SQLite",
                        ConnectionString = @"Data Source=/Users/cedric/sqlite/Chinook.db;"
                    };
            }
        }
    }
}