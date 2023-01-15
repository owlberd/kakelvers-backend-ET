using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kakaleversbackend.Data;
using kakaleversbackend.Models;

namespace kakaleversbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlantsController : ControllerBase
    {
        private readonly kakaleversbackendContext _context;

        public KlantsController(kakaleversbackendContext context)
        {
            _context = context;
        }

        // GET: api/Klants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Klant>>> GetKlants()
        {
            return await _context.Klants.ToListAsync();
        }

        // GET: api/Klants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Klant>> GetKlant(int id)
        {
            var klant = await _context.Klants.FindAsync(id);

            if (klant == null)
            {
                return NotFound();
            }

            return klant;
        }

        // PUT: api/Klants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKlant(int id, Klant klant)
        {
            if (id != klant.Id)
            {
                return BadRequest();
            }

            _context.Entry(klant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlantExists(id))
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

        // POST: api/Klants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Klant>> PostKlant(Klant klant)
        {
            _context.Klants.Add(klant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKlant", new { id = klant.Id }, klant);
        }

        // DELETE: api/Klants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKlant(int id)
        {
            var klant = await _context.Klants.FindAsync(id);
            if (klant == null)
            {
                return NotFound();
            }

            _context.Klants.Remove(klant);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KlantExists(int id)
        {
            return _context.Klants.Any(e => e.Id == id);
        }
    }
}
