using EFCore.Queries;

namespace EFCore
{
    class Program
    {
        private static void Main()
        {
            /*dotnet ef dbcontext Scaffold "Server=127.0.0.1,1433;Initial Catalog=AdventureWorks2017;Persist Security Info=False;User ID=sa;Password=myNiceSQLPassword123;" Microsoft.EntityFrameworkCore.SqlServer -o Model*/

            SelectQuery.Execute();
            //JoinQuery.Execute();
            //GroupByQuery.Execute();
            //OrderBy.Execute();
            //SubQuery.Execute();
        }
    }
}