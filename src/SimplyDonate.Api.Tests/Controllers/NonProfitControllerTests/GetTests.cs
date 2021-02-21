using SimplyDonate.Api.Controllers;
using Xunit;

namespace SimplyDonate.Api.Tests.Controllers.NonProfitControllerTests
{
    public class GetTests
    {
        [Fact]
        public void ItExists()
        {
            // Arrange
            // Act
            var controller = new NonProfitController();
            // Assert
        }

        [Fact]
        public void ItHasGet()
        {
            // Arrange
            var controller = new NonProfitController();

            // Act
            controller.Get();

            // Assert
        }
    }
}