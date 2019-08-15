using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.TestBase;
using AspNetBoilerPlate_Demo2.EntityFrameworkCore;
using Castle.MicroKernel.Registration;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetBoilerPlate_Demo2.Tests
{
    [DependsOn(
        typeof(AspNetBoilerPlate_Demo2ApplicationModule),
        typeof(AspNetBoilerPlate_Demo2EntityFrameworkCoreModule),
        typeof(AbpTestBaseModule)
        )]
    public class AspNetBoilerPlate_Demo2TestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
            SetupInMemoryDb();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerPlate_Demo2TestModule).GetAssembly());
        }

        private void SetupInMemoryDb()
        {
            var services = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase();

            var serviceProvider = WindsorRegistrationHelper.CreateServiceProvider(
                IocManager.IocContainer,
                services
            );

            var builder = new DbContextOptionsBuilder<AspNetBoilerPlate_Demo2DbContext>();
            builder.UseInMemoryDatabase().UseInternalServiceProvider(serviceProvider);

            IocManager.IocContainer.Register(
                Component
                    .For<DbContextOptions<AspNetBoilerPlate_Demo2DbContext>>()
                    .Instance(builder.Options)
                    .LifestyleSingleton()
            );
        }
    }
}