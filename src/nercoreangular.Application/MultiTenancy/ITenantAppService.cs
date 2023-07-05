using Abp.Application.Services;
using nercoreangular.MultiTenancy.Dto;

namespace nercoreangular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

