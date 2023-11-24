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
    public class HotelManagerController : ControllerBase
    {
        private readonly HotelListingDbContext _context;

        public HotelManagerController(HotelListingDbContext context)
        {
            _context = context;
        }

        // GET: api/HotelManager
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelManager>>> GetHotelManagers()
        {
            return await _context.HotelManagers.ToListAsync();
        }

        // GET: api/HotelManager/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelManager>> GetHotelManager(int id)
        {
            var hotelManager = await _context.HotelManagers.FindAsync(id);

            if (hotelManager == null)
            {
                return NotFound();
            }

            return hotelManager;
        }

        // PUT: api/HotelManager/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelManager(int id, HotelManager hotelManager)
        {
            if (id != hotelManager.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotelManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelManagerExists(id))
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

        // POST: api/HotelManager
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelManager>> PostHotelManager(HotelManager hotelManager)
        {
            _context.HotelManagers.Add(hotelManager);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelManager", new { id = hotelManager.Id }, hotelManager);
        }

        // DELETE: api/HotelManager/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelManager(int id)
        {
            var hotelManager = await _context.HotelManagers.FindAsync(id);
            if (hotelManager == null)
            {
                return NotFound();
            }

            _context.HotelManagers.Remove(hotelManager);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelManagerExists(int id)
        {
            return _context.HotelManagers.Any(e => e.Id == id);
        }
    }
}
