using Abp.EntityFrameworkCore;
using AspNetBoilerPlate_Demo2.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetBoilerPlate_Demo2.EntityFrameworkCore
{
    public class AspNetBoilerPlate_Demo2DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
		public virtual DbSet<Author> Authors { get; set; }

		public virtual DbSet<Book> Books { get; set; }

        public AspNetBoilerPlate_Demo2DbContext(DbContextOptions<AspNetBoilerPlate_Demo2DbContext> options) 
            : base(options)
        {

        }
    }
}
