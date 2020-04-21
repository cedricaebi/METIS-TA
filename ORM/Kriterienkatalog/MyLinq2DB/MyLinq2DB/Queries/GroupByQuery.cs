using System;
using System.Diagnostics;
using System.Linq;
using DataModels;
using LinqToDB.Data;

namespace MyLinq2DB.Queries
{
    public static class GroupByQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            
            DataConnection.DefaultSettings = new MySettings();
            
            using var db = new AdventureWorks2017DB();
            
            var query = from a in db.Addresss
                group a by a.City into addressGroup
                select new {
                    City = addressGroup.Key, 
                    Count = addressGroup.Count()
                };
            
            foreach (var queryObject in query)
            {
                Console.WriteLine("{0} {1}", queryObject.Count, queryObject.City);
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