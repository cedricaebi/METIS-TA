using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public static class DbContextExtensions
    {
        public static IQueryable Hello(this DbContext context, string entityName) =>
            context.Hello(context.Model.FindEntityType(entityName).ClrType);

        static readonly MethodInfo SetMethod = typeof(DbContext).GetMethod(nameof(DbContext.Set));

        public static IQueryable Hello(this DbContext context, Type entityType) =>
            (IQueryable)SetMethod.MakeGenericMethod(entityType).Invoke(context, null);
    }
}