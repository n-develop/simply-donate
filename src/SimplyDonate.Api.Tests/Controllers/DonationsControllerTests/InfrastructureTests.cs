using FluentAssertions;
using SimplyDonate.Api.Controllers;
using SimplyDonate.Api.Services;
using Xunit;

namespace SimplyDonate.Api.Tests.Controllers.DonationsControllerTests
{
    public class InfrastructureTests
    {
        [Fact]
        public void ItAcceptsDonationsService()
        {
            // Arrange
            var donationsService = new TestDonationService();

            // Act
            var controller = new DonationsController(donationsService);

            // Assert
            controller.Should().NotBeNull();
        }
    }
    
    public class TestDonationService : IDonationService
    {}
}