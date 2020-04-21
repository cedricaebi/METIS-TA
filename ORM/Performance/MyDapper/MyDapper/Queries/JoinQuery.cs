using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Dapper;
using MyDapper.Model;

namespace MyDapper.Queries
{
    public static class JoinQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "127.0.0.1,1433",
                UserID = "sa",
                Password = "myNiceSQLPassword123",
                InitialCatalog = "AdventureWorks2017"
            };

            using var connection = new SqlConnection(builder.ConnectionString);

            var sb = new StringBuilder();
            sb.Append("SELECT * FROM Person.BusinessEntityAddress be ");
            sb.Append("JOIN Person.Address a ON be.AddressID = a.AddressID ");
            sb.Append("JOIN Person.StateProvince sp ON a.StateProvinceID = sp.StateProvinceID ");
            sb.Append("JOIN Person.CountryRegion cr ON sp.CountryRegionCode = cr.CountryRegionCode ");
            sb.Append("JOIN Sales.SalesTerritory st ON sp.TerritoryID = st.TerritoryID ");
            sb.Append("WHERE cr.CountryRegionCode = 'US';");
            var sql = sb.ToString();

            var query = connection.Query<BusinessEntityAddress, Address,
                StateProvince, CountryRegion, SalesTerritory, BusinessEntityAddress>(sql,
                (businessEntityAddress, address, stateProvince, countryRegion, salesTerritory) =>
                {
                    businessEntityAddress.AddressId = address.AddressId;
                    address.StateProvinceId = stateProvince.StateProvinceId;
                    stateProvince.CountryRegionCode = countryRegion.CountryRegionCode;
                    salesTerritory.TerritoryId = stateProvince.TerritoryId;
                    return businessEntityAddress;
                },
                splitOn: "AddressID,StateProvinceID,CountryRegionCode,TerritoryID")
                .AsQueryable();

            foreach (var queryObject in query)
            {
                //Print first three columns
                Console.WriteLine("{0} {1} {2}", queryObject.BusinessEntityId, queryObject.AddressId, queryObject.AddressTypeId);
            }
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            var ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds:00}";
            //; is for my shell script, which outputs to a csv 
            Console.WriteLine("RunTime " + elapsedTime + ";");
        }
    }
}