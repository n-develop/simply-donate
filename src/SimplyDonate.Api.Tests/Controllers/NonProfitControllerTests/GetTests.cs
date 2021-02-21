using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using SimplyDonate.Api.Controllers;
using Xunit;

namespace SimplyDonate.Api.Tests.Controllers.NonProfitControllerTests
{
    public class GetTests
    {
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