using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class OrderBy
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new AdventureWorks2017DB();
            
            var query = from pi in db.ProductInventorys
                orderby pi.Shelf
                select pi;
            foreach (var pi in query)
            {
                Console.WriteLine(pi.Shelf);
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