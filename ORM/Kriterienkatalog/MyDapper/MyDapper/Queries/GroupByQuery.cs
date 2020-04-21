using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Dapper;
using MyDapper.Model;
using MyDapper.Model.Custom;

namespace MyDapper.Queries
{
    public static class GroupByQuery
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
            sb.Append("SELECT COUNT(*) as GroupCount, a.City ");
            sb.Append("FROM Person.Address a ");
            sb.Append("GROUP BY a.City");
            var sql = sb.ToString();

            var query = connection.Query<AddressGroup>(sql).ToList();

            foreach (var queryObject in query)
            {
                Console.WriteLine("{0} {1}", queryObject.GroupCount, queryObject.City);
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