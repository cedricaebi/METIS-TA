using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace RawSQL.Queries
{
    public static class JoinQuery
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
                sb.Append("SELECT * FROM [Person].[BusinessEntityAddress] be ");
                sb.Append("JOIN Person.Address a ON be.AddressID = a.AddressID ");
                sb.Append("JOIN Person.StateProvince sp ON a.StateProvinceID = sp.StateProvinceID ");
                sb.Append("JOIN Person.CountryRegion cr ON sp.CountryRegionCode = cr.CountryRegionCode ");
                sb.Append("JOIN Sales.SalesTerritory st ON sp.TerritoryID = st.TerritoryID ");
                sb.Append("WHERE cr.CountryRegionCode = 'US';");
                var sql = sb.ToString();

                using var command = new SqlCommand(sql, connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //Just outprint first 3 columns
                    for (var i = 0; i < 3; i++)
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