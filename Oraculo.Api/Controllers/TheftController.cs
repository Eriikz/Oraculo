using Microsoft.AspNetCore.Mvc;
using Oraculo.Api.Models;

namespace Oraculo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TheftController : ControllerBase
    {
        [HttpGet(Name = "GetTheft")]
        public IEnumerable<Theft> Get()
        {
          return  new List<Theft>();
        }
    }
}
