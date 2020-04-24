using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using MyNHibernate.Queries;
using NHibernate.Mapping.ByCode;

namespace MyNHibernate
{
    public class MyClass
    {
        public virtual int Id { get; set; }
        public virtual string Something { get; set; }
    }
    
    class Program
    {
        private static void Main()
        {
            var cfg = new Configuration();
            var mapper = new ModelMapper();
            mapper.Class<MyClass>(ca =>
            {
                ca.EntityName("Album");
                ca.Id(x => x.Id, map =>
                {
                    map.Column("Id");
                    map.Generator(Generators.HighLow, gmap => gmap.Params(new { max_low = 100 }));
                });
                ca.Property(x => x.Something, map => map.Length(150));
            });
            
            mapper.AddMappings(typeof(MyClass).Assembly.GetTypes());

            cfg.DataBaseIntegration(x =>
            {
                x.ConnectionString = "Server=127.0.0.1,1433;Initial Catalog=Chinook;Persist Security Info=False;User ID=sa;Password=myNiceSQLPassword123;";
                x.Dialect<MsSql2005Dialect>();
                x.Driver<SqlClientDriver>();
            });
         
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            cfg.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            SelectQuery.Execute(cfg);
           /* JoinQuery.Execute(cfg);
            GroupByQuery.Execute(cfg);
            OrderBy.Execute(cfg);
            SubQuery.Execute(cfg);*/
        }
    }
}