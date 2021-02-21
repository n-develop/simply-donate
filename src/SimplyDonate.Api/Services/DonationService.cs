using System.Collections.Generic;
using System.Linq;
using SimplyDonate.Api.Models;

namespace SimplyDonate.Api.Services
{
    public class DonationService : IDonationService
    {
        public IEnumerable<Donation> GetAll()
        {
            var donations = Enumerable.Range(1, 22).Select(index => new Donation
            {
                Title = $"Coole Sachspende Nr. {index}",
                Description = "Ich habe einiges abzugeben. Dies und das, sowie dieses und jenes. Erat bibendum etiam, lacinia quisque lacus et. Pulvinar sem fringilla, vulputate non habitasse eu varius. Mauris scelerisque porttitor, fusce torquent non congue erat. A suscipit metus, torquent quam, aenean eget libero sapien himenaeos lorem mauris. Ullamcorper donec netus, vitae per venenatis augue aenean. Fermentum risus libero, nec nisl lobortis metus urna. Mi rhoncus arcu, felis ipsum nibh tristique.",
            }).ToList();
            
            return donations;
        }
    }
}