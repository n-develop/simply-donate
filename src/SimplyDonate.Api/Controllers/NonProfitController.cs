using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SimplyDonate.Api.Models;

namespace SimplyDonate.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NonProfitController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<NonProfit> Get()
        {
            return Enumerable.Range(1, 22).Select(index => new NonProfit
            {
                Name = $"Gemeinnützige Organisation {index}",
                Description = "Hier wird viel Gutes getan. Dies und das, sowie dieses und jenes. Erat bibendum etiam, lacinia quisque lacus et. Pulvinar sem fringilla, vulputate non habitasse eu varius. Mauris scelerisque porttitor, fusce torquent non congue erat. A suscipit metus, torquent quam, aenean eget libero sapien himenaeos lorem mauris. Ullamcorper donec netus, vitae per venenatis augue aenean. Fermentum risus libero, nec nisl lobortis metus urna. Mi rhoncus arcu, felis ipsum nibh tristique.",
                Address = $"Hamburg Str. {index}\n3628{index} Mannheim",
                Email = $"number{index}@awesome.nonprofit"
            });
        }
    }
}