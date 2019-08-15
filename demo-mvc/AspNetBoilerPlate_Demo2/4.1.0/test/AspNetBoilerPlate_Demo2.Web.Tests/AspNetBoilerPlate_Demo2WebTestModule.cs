using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetBoilerPlate_Demo2.Web.Startup;
namespace AspNetBoilerPlate_Demo2.Web.Tests
{
    [DependsOn(
        typeof(AspNetBoilerPlate_Demo2WebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class AspNetBoilerPlate_Demo2WebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerPlate_Demo2WebTestModule).GetAssembly());
        }
    }
}