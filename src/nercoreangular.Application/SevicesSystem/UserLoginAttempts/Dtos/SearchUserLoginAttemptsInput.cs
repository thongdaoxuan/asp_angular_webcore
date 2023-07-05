using Abp.Auditing;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;



namespace nercoreangular.ServicesSystem.UserLoginAttempts.Dtos
{
    public class SearchUserLoginAttemptsInput
    {
        public string UserNameOrEmail { get; set; }
       
    }
}
