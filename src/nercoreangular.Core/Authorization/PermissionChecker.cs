using Abp.Authorization;
using nercoreangular.Authorization.Roles;
using nercoreangular.Authorization.Users;

namespace nercoreangular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
