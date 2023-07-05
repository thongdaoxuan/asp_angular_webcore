using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace nercoreangular.EntityFrameworkCore
{
    public static class nercoreangularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<nercoreangularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<nercoreangularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
