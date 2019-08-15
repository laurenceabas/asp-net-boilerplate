using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetBoilerPlate_Demo2.Configuration;
using AspNetBoilerPlate_Demo2.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AspNetBoilerPlate_Demo2.Web.Startup
{
    [DependsOn(
        typeof(AspNetBoilerPlate_Demo2ApplicationModule), 
        typeof(AspNetBoilerPlate_Demo2EntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class AspNetBoilerPlate_Demo2WebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetBoilerPlate_Demo2WebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AspNetBoilerPlate_Demo2Consts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<AspNetBoilerPlate_Demo2NavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AspNetBoilerPlate_Demo2ApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerPlate_Demo2WebModule).GetAssembly());
        }
    }
}