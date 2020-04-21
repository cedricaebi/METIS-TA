using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace RawSQL.Queries
{
    public class GroupByQuery
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
                sb.Append("SELECT COUNT(*), a.[City] ");
                sb.Append("FROM [Person].[Address] a ");
                sb.Append("GROUP BY a.[City]");
                var sql = sb.ToString();

                using var command = new SqlCommand(sql, connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write("{0} ", reader.GetValue(i));
                    }
                    Console.WriteLine("");
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