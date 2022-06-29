using Microsoft.AspNetCore.Mvc;
using Oraculo.Api.Code;

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

        //[HttpGet("{id}", Name = "GetTheft")]
        //public IActionResult Get(int id)
        //{
        //    //var model = service.GetFilme(id);
        //    //if (model == null)
        //    //    return NotFound();

        //    //var outputModel = ToOutputModel(model);
        //    return Ok(outputModel);
        //}
    }
}
