using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oraculo.Api.Models;

namespace Oraculo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TheftController : ControllerBase
    {
        private readonly Context _context;

        public TheftController(Context context)
        {
            _context = context;
        }

        [HttpGet(Name = "ListTheft")]
        public async Task<ActionResult<Theft>> ListTheft()
        {
            var Theft = await _context.Theft.ToListAsync();

            if (Theft == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Theft);
            }
        }

        [HttpGet("{num_bo}")]
        public async Task<ActionResult<Theft>> GetTheft(double num_bo)
        {
            var Theft = await _context.Theft.FindAsync(num_bo);

            if (Theft == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(Theft);
            }

        }

        [HttpPost]
        public async Task<ActionResult<Theft>> CreateTheft(Theft theft)
        {
            _context.Theft.Add(theft);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheft", new { id = theft.Num_bo }, theft);
        }

        [HttpDelete]
        public async Task<ActionResult<Theft>> DeleteTheft(double num_bo)
        {
            var theft = await _context.Theft.FindAsync(num_bo);
            if(theft == null)
            {
                return NotFound();
            }
            else
            {
                _context.Theft.Remove(theft);
                await _context.SaveChangesAsync();

                return NoContent();
            }
           
        }

        //[HttpPut("{id}")]
        //public async Task<ActionResult<Theft>> UpdateTheft(Theft theft, double Num_bo, string Type)
        //{
        //    var Theft = await _context.Theft.FindAsync(Num_bo);

        //    if (Num_bo != theft.Num_bo)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        _context.Entry(theft).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException ex)
        //        {
        //            if (!TheftExists(Num_bo))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw ex;
        //            }

        //            return NoContent();
        //        }
        //    }
        //}

        private bool TheftExists(double num_bo)
        {
            return _context.Theft.Any(x => x.Num_bo == num_bo);
        }
    }
}
