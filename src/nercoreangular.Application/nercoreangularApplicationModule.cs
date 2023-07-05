using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using nercoreangular.Authorization;

namespace nercoreangular
{
    [DependsOn(
        typeof(nercoreangularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class nercoreangularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<nercoreangularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(nercoreangularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
