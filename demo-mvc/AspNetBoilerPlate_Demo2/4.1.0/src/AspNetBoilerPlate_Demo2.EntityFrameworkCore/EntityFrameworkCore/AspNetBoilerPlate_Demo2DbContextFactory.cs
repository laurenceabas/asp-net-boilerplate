using AspNetBoilerPlate_Demo2.Configuration;
using AspNetBoilerPlate_Demo2.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AspNetBoilerPlate_Demo2.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class AspNetBoilerPlate_Demo2DbContextFactory : IDesignTimeDbContextFactory<AspNetBoilerPlate_Demo2DbContext>
    {
        public AspNetBoilerPlate_Demo2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspNetBoilerPlate_Demo2DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(AspNetBoilerPlate_Demo2Consts.ConnectionStringName)
            );

            return new AspNetBoilerPlate_Demo2DbContext(builder.Options);
        }
    }
}