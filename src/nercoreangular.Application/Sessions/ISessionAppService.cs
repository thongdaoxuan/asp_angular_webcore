using System.Threading.Tasks;
using Abp.Application.Services;
using nercoreangular.Sessions.Dto;

namespace nercoreangular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
