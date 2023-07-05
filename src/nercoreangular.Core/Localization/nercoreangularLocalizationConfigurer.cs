using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace nercoreangular.Localization
{
    public static class nercoreangularLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(nercoreangularConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(nercoreangularLocalizationConfigurer).GetAssembly(),
                        "nercoreangular.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
