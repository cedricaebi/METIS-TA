using System;
using System.Diagnostics;
using System.Linq;
using EFCore.Model;

/*namespace EFCore.Queries
{
    public static class JoinQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            using var context = new AdventureWorks2017Context();
            
            var addresses = context.Address;
            var businessEntityAddresses = context.BusinessEntityAddress;
            var stateProvinces = context.StateProvince;
            var countryRegions = context.CountryRegion;
            var salesTerritories = context.SalesTerritory;

            var query = businessEntityAddresses
                .Join(addresses,
                    businessEntity => businessEntity.AddressId,
                    address => address.AddressId,
                    (businessEntity, address) => new
                    {
                        businessEntity,
                        address
                    })
                .Join(stateProvinces,
                    businessEntity => businessEntity.address.StateProvinceId,
                    stateProvince => stateProvince.StateProvinceId,
                    (businessEntity, stateProvince) => new
                    {
                        businessEntity,
                        stateProvince
                    })
                .Join(countryRegions,
                    businessEntity => businessEntity.stateProvince.CountryRegionCode,
                    countryRegion => countryRegion.CountryRegionCode,
                    (businessEntity, countryRegion) => new
                    {
                        businessEntity,
                        countryRegion
                    })
                .Join(salesTerritories,
                    businessEntity => businessEntity.businessEntity.stateProvince.TerritoryId,
                    salesTerritory => salesTerritory.TerritoryId,
                    (businessEntity, salesTerritory) => new
                    {
                        businessEntity,
                        salesTerritory
                    })
                .Where(businessEntity => businessEntity.businessEntity.countryRegion.CountryRegionCode.Equals("US"));

            foreach (var queryObject in query)
            {
                //Print first three rows from table
                //And yes I know the naming is shit, but I don't care :)
                Console.WriteLine("{0} {1} {2}", queryObject.businessEntity.businessEntity.businessEntity.businessEntity.BusinessEntityId,
                    queryObject.businessEntity.businessEntity.businessEntity.address.AddressId,
                    queryObject.businessEntity.businessEntity.businessEntity.businessEntity.AddressTypeId);
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
}*/