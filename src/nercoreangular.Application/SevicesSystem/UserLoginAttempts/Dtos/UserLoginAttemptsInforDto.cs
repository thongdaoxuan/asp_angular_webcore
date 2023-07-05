using Abp.Auditing;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;



namespace nercoreangular.ServicesSystem.UserLoginAttempts.Dtos
{
    public class UserLoginAttemptsInforDto
    {
        public long userId { get; set; }
        public string userName { get; set; }
        public bool logined { get; set; }
        public string BrowserInfo { get; set; }

        public UserLoginAttemptsInforDto()
        {

        }

    }
}
