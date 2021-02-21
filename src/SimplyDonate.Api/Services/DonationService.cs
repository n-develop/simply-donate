using System.Collections.Generic;
using System.Linq;
using SimplyDonate.Api.Models;

namespace SimplyDonate.Api.Services
{
    public class DonationService : IDonationService
    {
        public IEnumerable<Donation> GetAll()
        {
            return Enumerable.Empty<Donation>();
        }
    }
}