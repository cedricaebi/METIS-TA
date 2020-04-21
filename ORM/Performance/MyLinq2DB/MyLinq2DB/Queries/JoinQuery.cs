using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public class JoinQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new AdventureWorks2017DB();

            var query = from ba in db.BusinessEntityAddresss
                join a in db.Addresss on ba.AddressID equals a.AddressID
                join sp in db.StateProvinces on a.StateProvinceID equals sp.StateProvinceID
                join cr in db.CountryRegions on sp.CountryRegionCode equals cr.CountryRegionCode
                join st in db.SalesTerritorys on sp.TerritoryID equals st.TerritoryID
                select new
                {
                    ba,
                    a,
                    sp,
                    cr,
                    st
                };

            foreach (var queryObject in query)
            {
                //Print first three columns
                Console.WriteLine("{0} {1} {2}", queryObject.ba.BusinessEntityID, queryObject.ba.AddressID,
                    queryObject.ba.AddressTypeID);
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