using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.UI;
using nercoreangular;
using nercoreangular.Authorization;
using nercoreangular.Authorization.Users;
using nercoreangular.ServicesSystem.UserLoginAttempts.Dtos;

namespace nercoreangular.ServicesSystem.UserLoginAttempts
{
    public class UserLoginAttemptsAppService : nercoreangularAppServiceBase, IUserLoginAttemptsAppService
    {
        private readonly IRepository<UserLoginAttempt, long> userLoginAttemptRepository;
        //private readonly IRepository<User, long> userLoginAttemptRepository;
        private readonly UserManager _userManager;

        public UserLoginAttemptsAppService(
            UserManager userManager,
            IRepository<UserLoginAttempt, long> _userLoginAttemptRepository
            )
        {
            userLoginAttemptRepository = _userLoginAttemptRepository;
            _userManager = userManager;
        }

        public async Task<UserLoginAttemptsInforDto> GetUserLoginAttempt(SearchUserLoginAttemptsInput input)
        {
            var q = userLoginAttemptRepository.GetAll().Where(a=> a.Result == AbpLoginResultType.Success);

            if (input.UserNameOrEmail!=null && input.UserNameOrEmail.Length > 0)
            {
                q = q.Where(a => a.UserNameOrEmailAddress != null&& a.UserNameOrEmailAddress.ToLower().Contains(input.UserNameOrEmail.ToLower()));
            }
            var total = q.Count();
            UserLoginAttemptsInforDto result = new UserLoginAttemptsInforDto();
            if(total > 0)
            {
                var tasks = q.ToList();
                var query = tasks[0];
                if (query != null)
                {
                    result.BrowserInfo = query.BrowserInfo;
                    if (query.UserId != null)
                    {
                        var user = await _userManager.GetUserByIdAsync((long)query.UserId);
                        if(user != null)
                        {
                            result.userId = user.Id;
                            result.userName = user.UserName;
                            result.logined = user.logined;
                        }
                    }
                }
                
            }
            return result;
        }

    }
}
