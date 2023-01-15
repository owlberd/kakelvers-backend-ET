using kakaleversbackend.Data;
using kakaleversbackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kakaleversbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductensController : ControllerBase
    {
        private readonly kakaleversbackendContext _context;

        public ProductensController(kakaleversbackendContext context)
        {
            _context = context;
        }

        // GET: api/Productens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producten>>> GetProductens()
        {
            return await _context.Productens.ToListAsync();
        }

        // GET: api/Productens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producten>> GetProducten(int id)
        {
            var producten = await _context.Productens.FindAsync(id);

            if (producten == null)
            {
                return NotFound();
            }

            return producten;
        }

        // PUT: api/Productens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducten(int id, Producten producten)
        {
            if (id != producten.Id)
            {
                return BadRequest();
            }

            _context.Entry(producten).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductenExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Productens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Producten>> PostProducten(Producten producten)
        {
            _context.Productens.Add(producten);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducten", new { id = producten.Id }, producten);
        }

        // DELETE: api/Productens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducten(int id)
        {
            var producten = await _context.Productens.FindAsync(id);
            if (producten == null)
            {
                return NotFound();
            }

            _context.Productens.Remove(producten);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductenExists(int id)
        {
            return _context.Productens.Any(e => e.Id == id);
        }
    }
}
