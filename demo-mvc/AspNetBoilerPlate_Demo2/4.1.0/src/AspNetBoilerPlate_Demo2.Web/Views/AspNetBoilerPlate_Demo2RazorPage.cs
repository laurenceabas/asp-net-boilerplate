using Abp.AspNetCore.Mvc.Views;

namespace AspNetBoilerPlate_Demo2.Web.Views
{
    public abstract class AspNetBoilerPlate_Demo2RazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AspNetBoilerPlate_Demo2RazorPage()
        {
            LocalizationSourceName = AspNetBoilerPlate_Demo2Consts.LocalizationSourceName;
        }
    }
}
