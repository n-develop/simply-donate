using Microsoft.AspNetCore.Mvc;
using SimplyDonate.Api.Services;

namespace SimplyDonate.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DonationsController : ControllerBase
    {
        private readonly IDonationService _donationService;

        public DonationsController(IDonationService donationService)
        {
            _donationService = donationService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var donations = _donationService.GetAll();
            return Ok(donations);
        }
    }
}