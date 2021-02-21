using SimplyDonate.Api.Controllers;
using SimplyDonate.Api.Models;
using Xunit;

namespace SimplyDonate.Api.Tests.Controllers.DonationsControllerTests
{
    public class GetTests
    {
        [Fact]
        public void ItExists()
        {
            var controller = new DonationsController();
        }

        [Fact]
        public void ItHasGet()
        {
            // Arrange
            var controller = new DonationsController();

            // Act
            controller.Get();
        }
    }
}