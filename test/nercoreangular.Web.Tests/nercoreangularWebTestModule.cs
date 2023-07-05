using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using nercoreangular.EntityFrameworkCore;
using nercoreangular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace nercoreangular.Web.Tests
{
    [DependsOn(
        typeof(nercoreangularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class nercoreangularWebTestModule : AbpModule
    {
        public nercoreangularWebTestModule(nercoreangularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(nercoreangularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(nercoreangularWebMvcModule).Assembly);
        }
    }
}