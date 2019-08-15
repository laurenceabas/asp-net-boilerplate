using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Reflection.Extensions;

namespace AspNetBoilerPlate_Demo2.Localization
{
    public static class AspNetBoilerPlate_Demo2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flags england", isDefault: true));
            localizationConfiguration.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flags tr"));

            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspNetBoilerPlate_Demo2Consts.LocalizationSourceName,
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspNetBoilerPlate_Demo2LocalizationConfigurer).GetAssembly(),
                        "AspNetBoilerPlate_Demo2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}