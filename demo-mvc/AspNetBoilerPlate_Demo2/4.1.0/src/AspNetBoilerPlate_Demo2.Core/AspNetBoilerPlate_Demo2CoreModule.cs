using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetBoilerPlate_Demo2.Localization;

namespace AspNetBoilerPlate_Demo2
{
    public class AspNetBoilerPlate_Demo2CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AspNetBoilerPlate_Demo2LocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerPlate_Demo2CoreModule).GetAssembly());
        }
    }
}