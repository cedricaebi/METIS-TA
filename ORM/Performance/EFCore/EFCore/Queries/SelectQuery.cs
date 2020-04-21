using System;
using System.Diagnostics;
using System.Linq;
using EFCore.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Queries
{
    public static class SelectQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            using var context = new AdventureWorks2017Context();
            var query = context.Product.Where(product =>
                    product.SellStartDate > new DateTime(2007, 1, 1) &&
                    EF.Functions.Like(product.ProductNumber, "FW%"))
                .Select(product => product.Name);
                
                
            foreach (var product in query)
            {
                Console.WriteLine("{0}", product);
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