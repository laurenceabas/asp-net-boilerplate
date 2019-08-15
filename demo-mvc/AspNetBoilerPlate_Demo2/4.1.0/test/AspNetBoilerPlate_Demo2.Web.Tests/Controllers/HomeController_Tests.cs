using System.Threading.Tasks;
using AspNetBoilerPlate_Demo2.Web.Controllers;
using Shouldly;
using Xunit;

namespace AspNetBoilerPlate_Demo2.Web.Tests.Controllers
{
    public class HomeController_Tests: AspNetBoilerPlate_Demo2WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
