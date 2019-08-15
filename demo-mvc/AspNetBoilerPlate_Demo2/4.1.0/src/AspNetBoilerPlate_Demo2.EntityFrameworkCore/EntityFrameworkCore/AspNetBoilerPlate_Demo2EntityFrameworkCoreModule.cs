using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspNetBoilerPlate_Demo2.EntityFrameworkCore
{
    [DependsOn(
        typeof(AspNetBoilerPlate_Demo2CoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class AspNetBoilerPlate_Demo2EntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetBoilerPlate_Demo2EntityFrameworkCoreModule).GetAssembly());
        }
    }
}