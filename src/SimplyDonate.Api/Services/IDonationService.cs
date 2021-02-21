using System.Collections.Generic;
using SimplyDonate.Api.Models;

namespace SimplyDonate.Api.Services
{
    public interface IDonationService
    {
        public IEnumerable<Donation> GetAll();
    }
}