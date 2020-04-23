using MyLinq2DB.Queries;

namespace MyLinq2DB
{
    class Program
    {
        private static void Main()
        {
            SelectQuery.Execute();
            JoinQuery.Execute();
            GroupByQuery.Execute();
            OrderBy.Execute();
            SubQuery.Execute();
        }
    }
}