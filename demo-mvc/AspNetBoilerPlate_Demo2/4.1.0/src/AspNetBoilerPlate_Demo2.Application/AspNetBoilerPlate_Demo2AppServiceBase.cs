using Abp.Application.Services;

namespace AspNetBoilerPlate_Demo2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AspNetBoilerPlate_Demo2AppServiceBase : ApplicationService
    {
        protected AspNetBoilerPlate_Demo2AppServiceBase()
        {
            LocalizationSourceName = AspNetBoilerPlate_Demo2Consts.LocalizationSourceName;
        }
    }
}