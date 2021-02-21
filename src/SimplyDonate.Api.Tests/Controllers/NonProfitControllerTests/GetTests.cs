using System.Collections.Generic;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using SimplyDonate.Api.Controllers;
using SimplyDonate.Api.Models;
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

        [Fact]
        public void ItReturnsCollectionOfNonProfits()
        {
            // Arrange
            var controller = new NonProfitController();

            // Act
            var result = controller.Get() as OkObjectResult;

            // Assert
            result.Should().NotBeNull();
            result.Value.Should().BeAssignableTo<IEnumerable<NonProfit>>();
        }
    }
}