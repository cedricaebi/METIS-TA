using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class SelectQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new AdventureWorks2017DB();
            
            var query = from p in db.Products
                where p.SellStartDate > new DateTime(2007, 1, 1)
                      && p.ProductNumber.StartsWith("FW")
                select p.Name;
            foreach (var product in query)
            {
                Console.WriteLine(product);
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