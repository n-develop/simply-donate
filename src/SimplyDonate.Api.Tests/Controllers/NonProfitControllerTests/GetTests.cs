using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
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

        [Fact]
        public void ItReturnsOkObjectResult()
        {
            // Arrange
            var controller = new NonProfitController();

            // Act
            var result = controller.Get();

            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }
    }
}