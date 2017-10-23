using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MeiLian.Configuration;
using MeiLian.Web;

namespace MeiLian.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MeiLianDbContextFactory : IDesignTimeDbContextFactory<MeiLianDbContext>
    {
        public MeiLianDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MeiLianDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MeiLianDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MeiLianConsts.ConnectionStringName));

            return new MeiLianDbContext(builder.Options);
        }
    }
}
