using System.Threading.Tasks;
using Abp.Application.Services;
using nercoreangular.Authorization.Accounts.Dto;

namespace nercoreangular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
