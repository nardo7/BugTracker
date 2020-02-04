using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BugTracker.BugDataContext;
using BugTracker.BugDataModel;

namespace BugTracker.WebServer.Controllers
{
    [Produces("application/json")]
    [Route("api/priorities")]
    [ApiController]
    public class PrioritiesController : ControllerBase
    {
        private readonly BugContext _context;

        public PrioritiesController(BugContext context)
        {
            _context = context;
        }

        // GET: api/priorities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Priority>>> GetPriorities()
        {
            return await _context.Priorities.ToListAsync();
        }

        // GET: api/priorities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Priority>> GetPriority(int id)
        {
            var priority = await _context.Priorities.FindAsync(id);

            if (priority == null)
            {
                return NotFound();
            }

            return priority;
        }

        // PUT: api/priorities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPriority(int id, Priority priority)
        {
            if (id != priority.Id)
            {
                return BadRequest();
            }

            _context.Entry(priority).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriorityExists(id))
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

        // POST: api/priorities
        [HttpPost]
        public async Task<ActionResult<Priority>> PostPriority(Priority priority)
        {
            _context.Priorities.Add(priority);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPriority", new { id = priority.Id }, priority);
        }

        // DELETE: api/priorities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Priority>> DeletePriority(int id)
        {
            var priority = await _context.Priorities.FindAsync(id);
            if (priority == null)
            {
                return NotFound();
            }

            _context.Priorities.Remove(priority);
            await _context.SaveChangesAsync();

            return priority;
        }

        private bool PriorityExists(int id)
        {
            return _context.Priorities.Any(e => e.Id == id);
        }
    }
}
