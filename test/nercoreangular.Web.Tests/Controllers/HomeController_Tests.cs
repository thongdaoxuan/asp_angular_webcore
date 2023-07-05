using System.Threading.Tasks;
using nercoreangular.Models.TokenAuth;
using nercoreangular.Web.Controllers;
using Shouldly;
using Xunit;

namespace nercoreangular.Web.Tests.Controllers
{
    public class HomeController_Tests: nercoreangularWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}