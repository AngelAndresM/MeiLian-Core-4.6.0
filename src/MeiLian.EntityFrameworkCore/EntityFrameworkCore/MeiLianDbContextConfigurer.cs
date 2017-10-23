using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MeiLian.EntityFrameworkCore
{
    public static class MeiLianDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MeiLianDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MeiLianDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
