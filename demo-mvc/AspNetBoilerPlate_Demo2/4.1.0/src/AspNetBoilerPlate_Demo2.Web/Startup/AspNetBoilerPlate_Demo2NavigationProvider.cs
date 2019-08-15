using Abp.Application.Navigation;
using Abp.Localization;

namespace AspNetBoilerPlate_Demo2.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class AspNetBoilerPlate_Demo2NavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
			context.Manager.MainMenu
				.AddItem(
					new MenuItemDefinition(
						PageNames.Authors,
						L("Authors"),
						url: "Author",
						icon: "")
				)
				.AddItem(
					new MenuItemDefinition(
						PageNames.Books,
						L("Books"),
						url: "Book",
						icon: "")
				);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AspNetBoilerPlate_Demo2Consts.LocalizationSourceName);
        }
    }
}
