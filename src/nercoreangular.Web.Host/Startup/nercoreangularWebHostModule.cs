using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using nercoreangular.Configuration;

namespace nercoreangular.Web.Host.Startup
{
    [DependsOn(
       typeof(nercoreangularWebCoreModule))]
    public class nercoreangularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public nercoreangularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(nercoreangularWebHostModule).GetAssembly());
        }
    }
}
