using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspNetBoilerPlate_Demo2
{
    [DependsOn(
        typeof(AspNetBoilerPlate_Demo2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspNetBoilerPlate_Demo2ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerPlate_Demo2ApplicationModule).GetAssembly());
        }
    }
}