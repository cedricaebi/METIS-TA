using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class SubQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            DataConnection.DefaultSettings = new MySettings();
            
            var db = new AdventureWorks2017DB();

            var query = from p in db.Products
                from pv in db.ProductVendors
                where p.ProductID == pv.ProductID && pv.MinOrderQty > 5
                select p;

            foreach (var product in query)
            {
                Console.WriteLine(product.Name);
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