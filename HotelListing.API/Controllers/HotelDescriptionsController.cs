using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.API.Data;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelDescriptionsController : ControllerBase
    {
        private readonly HotelListingDbContext _context;

        public HotelDescriptionsController(HotelListingDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelDescriptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDescription>>> GetHotellDescription()
        {
            return await _context.HotellDescription.ToListAsync();
        }

        // GET: api/HotelDescriptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDescription>> GetHotelDescription(int id)
        {
            var hotelDescription = await _context.HotellDescription.FindAsync(id);

            if (hotelDescription == null)
            {
                return NotFound();
            }

            return hotelDescription;
        }

        // PUT: api/HotelDescriptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelDescription(int id, HotelDescription hotelDescription)
        {
            if (id != hotelDescription.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotelDescription).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelDescriptionExists(id))
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

        // POST: api/HotelDescriptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelDescription>> PostHotelDescription(HotelDescription hotelDescription)
        {
            _context.HotellDescription.Add(hotelDescription);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelDescription", new { id = hotelDescription.Id }, hotelDescription);
        }

        // DELETE: api/HotelDescriptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelDescription(int id)
        {
            var hotelDescription = await _context.HotellDescription.FindAsync(id);
            if (hotelDescription == null)
            {
                return NotFound();
            }

            _context.HotellDescription.Remove(hotelDescription);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelDescriptionExists(int id)
        {
            return _context.HotellDescription.Any(e => e.Id == id);
        }
    }
}
