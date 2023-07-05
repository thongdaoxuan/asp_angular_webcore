using System.Threading.Tasks;
using nercoreangular.Configuration.Dto;

namespace nercoreangular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
