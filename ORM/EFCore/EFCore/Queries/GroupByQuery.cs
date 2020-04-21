using System;
using System.Diagnostics;
using System.Linq;
using EFCore.Model;

namespace EFCore.Queries
{
    public static class GroupByQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            using var context = new AdventureWorks2017Context();
            var query = context.Address.GroupBy(address => address.City)
                .Select(group => new
                {
                    Count = group.Count(),
                    City = group.Key
                });
            
            foreach (var addressGroup in query)
            {
                Console.WriteLine("{0} {1}", addressGroup.Count, addressGroup.City);
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