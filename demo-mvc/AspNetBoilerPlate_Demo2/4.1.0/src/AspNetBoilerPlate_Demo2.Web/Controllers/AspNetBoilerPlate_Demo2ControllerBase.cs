using Abp.AspNetCore.Mvc.Controllers;

namespace AspNetBoilerPlate_Demo2.Web.Controllers
{
    public abstract class AspNetBoilerPlate_Demo2ControllerBase: AbpController
    {
        protected AspNetBoilerPlate_Demo2ControllerBase()
        {
            LocalizationSourceName = AspNetBoilerPlate_Demo2Consts.LocalizationSourceName;
        }
    }
}