using System;
using System.Diagnostics;
using System.Linq;
using EFCore.Model;

/*namespace EFCore.Queries
{
    public class SubQuery
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var context = new AdventureWorks2017Context();
            var query = context.Product.Where(p => context.ProductVendor.Any(
                pv => pv.ProductId.Equals(p.ProductId) && pv.MinOrderQty > 5));
                
                
            foreach (var product in query)
            {
                Console.WriteLine("{0}", product.Name);
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