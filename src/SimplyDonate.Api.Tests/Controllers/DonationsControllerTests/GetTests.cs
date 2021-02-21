using System.Collections.Generic;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using SimplyDonate.Api.Controllers;
using SimplyDonate.Api.Models;
using SimplyDonate.Api.Services;
using Xunit;

namespace SimplyDonate.Api.Tests.Controllers.DonationsControllerTests
{
    public class GetTests
    {
        private readonly DonationsController _controller;

        public GetTests()
        {
            var donationsService = Substitute.For<IDonationService>();
            _controller = new DonationsController(donationsService);
        }

        [Fact]
        public void ItReturnsOkObjectResult()
        {
            // Arrange
            // Act
            var result = _controller.Get();
            
            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void ItReturnsCollectionOfDonations()
        {
            // Arrange
            // Act
            var result = _controller.Get() as OkObjectResult;
            
            // Assert
            result.Should().NotBeNull();
            result.Value.Should().BeAssignableTo<IEnumerable<Donation>>();
        }
    }
}