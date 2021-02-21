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
        private readonly IDonationService _donationService;
        private readonly DonationsController _sut;

        public GetTests()
        {
            _donationService = Substitute.For<IDonationService>();
            _donationService.GetAll().Returns(new List<Donation>());
            _sut = new DonationsController(_donationService);
        }

        [Fact]
        public void ItReturnsOkObjectResult()
        {
            // Arrange
            // Act
            var result = _sut.Get();
            
            // Assert
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void ItReturnsCollectionOfDonations()
        {
            // Arrange
            // Act
            var result = _sut.Get() as OkObjectResult;
            
            // Assert
            result.Should().NotBeNull();
            result.Value.Should().BeAssignableTo<IEnumerable<Donation>>();
        }

        [Fact]
        public void ItCallsDonationService()
        {
            // Arrange
            // Act
            _sut.Get();

            // Assert
            _donationService.Received(1).GetAll();
        }

        [Fact]
        public void ItReturnsResultFromDonationService()
        {
            // Arrange
            var donations = new List<Donation>
            {
                new()
                {
                    Title = "Donation Title", Description = "Donations Description"
                }
            };
            _donationService.GetAll().Returns(donations);
            
            // Act
            var result = _sut.Get() as OkObjectResult;

            // Assert
            result.Value.Should().BeEquivalentTo(donations);
        }
    }
}