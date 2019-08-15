using Microsoft.EntityFrameworkCore;

namespace AspNetBoilerPlate_Demo2.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AspNetBoilerPlate_Demo2DbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AspNetBoilerPlate_Demo2DbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
