using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart2.Models;

namespace ShoppingCart2.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAll")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ShoppingCartContext _context;

        public CustomersController(ShoppingCartContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        //[Authorize(AuthenticationSchemes = "Basic")]
        public IEnumerable<Customers> GetCustomers()
        {
            return _context.Customers;
        }

        // GET: api/Customers/5
        [EnableCors("AllowAll")]
        [HttpGet("{id}")]
        ///[Authorize]
        [Authorize(AuthenticationSchemes = "Basic")]
        public async Task<IActionResult> GetCustomers([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ident = User.Identity as ClaimsIdentity;
            var currentLoggeedInUserId = ident.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (currentLoggeedInUserId != id.ToString())
            {
                return BadRequest("You are not authorized!");
            }

            var customers = await _context.Customers.SingleOrDefaultAsync(m => m.Id == id);

            if (customers == null)
            {
                return NotFound();
            }

            return Ok(customers);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomers(Guid id, Customers customers)
        {
            if (id != customers.Id)
            {
                return BadRequest();
            }

            _context.Entry(customers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomersExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Customers>> PostCustomers([FromBody] Customers customers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_context.Customers.Any(x => x.Email == customers.Email))
            {
                ModelState.AddModelError("email", "User with mail id already exists!");
                return BadRequest(ModelState);
            }

            _context.Customers.Add(customers);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CustomersExists(customers.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCustomers", new { id = customers.Id }, customers);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customers>> DeleteCustomers(Guid id)
        {
            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();

            return customers;
        }

        private bool CustomersExists(Guid id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
