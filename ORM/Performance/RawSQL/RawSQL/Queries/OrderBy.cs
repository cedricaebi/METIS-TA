using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace RawSQL.Queries
{
    public static class OrderBy
    {
        public static void Execute()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            try 
            {
                var builder = new SqlConnectionStringBuilder
                {
                    DataSource = "127.0.0.1,1433",
                    UserID = "sa",
                    Password = "myNiceSQLPassword123",
                    InitialCatalog = "AdventureWorks2017"
                };
                
                using var connection = new SqlConnection(builder.ConnectionString);
                
                connection.Open();       
                var sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM [Production].[ProductInventory] p ");
                sb.Append("ORDER BY p.[Shelf]; ");
                var sql = sb.ToString();

                using var command = new SqlCommand(sql, connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}", reader.GetString(2));
                }
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                var ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value.
                var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds:00}";
                //; is for my shell script, which outputs to a csv 
                Console.WriteLine("RunTime " + elapsedTime + ";");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}