using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using nercoreangular.Configuration.Dto;

namespace nercoreangular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : nercoreangularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
