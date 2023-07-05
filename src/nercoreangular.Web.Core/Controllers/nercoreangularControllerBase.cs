using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace nercoreangular.Controllers
{
    public abstract class nercoreangularControllerBase: AbpController
    {
        protected nercoreangularControllerBase()
        {
            LocalizationSourceName = nercoreangularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
