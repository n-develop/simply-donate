using System.Collections.Generic;
using FluentAssertions;
using SimplyDonate.Api.Models;
using SimplyDonate.Api.Services;
using Xunit;

namespace SimplyDonate.Api.Tests.Services.DonationServiceTests
{
    public class GetAllTests
    {
        [Fact]
        public void ItHasGetAll()
        {
            // Arrange
            var sut = new DonationService();

            // Act
            // Assert
            sut.GetAll();
        }

        [Fact]
        public void ItReturnsCollectionOfDonations()
        {
            // Arrange
            var sut = new DonationService();

            // Act
            var result = sut.GetAll();

            // Assert
            result.Should().BeAssignableTo<IEnumerable<Donation>>();
        }
    }
}