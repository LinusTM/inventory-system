using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryContext _context;
        public InventoryController(InventoryContext context)
        {
            _context = context;
        }

        // GET api/inventory/get/all
        [HttpGet("get/all")]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetAllInventory()
        {
            return await _context.Inventory.ToListAsync();
        }

        // GET api/inventory/get/{amount}
        [HttpGet("get/{amount}")]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryByAmount(int amount)
        {
            return await _context.Inventory
                .Where(i => i.Amount == amount)
                .ToListAsync();
        }

        // GET api/inventory/get/{query}
        [HttpGet("get/{query}")]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryByQuery(string query)
        {
            return await _context.Inventory
                .Where(i => i.FtzNumber.Contains(query) ||
                            i.AltName.Contains(query) ||
                            i.Description.Contains(query) ||
                            i.Section.Contains(query) ||
                            i.SectionName.Contains(query) ||
                            i.PlacementNotes.Contains(query))
                .ToListAsync();
        }

        // PUT api/inventory/put/add
        [HttpPut("put/add")]
        public async Task<IActionResult> PutAddInventory(InventoryItem inventory)
        {
            if (inventory.Amount == 0)
            {
                inventory.Amount = 1;
            }

            _context.Inventory.Add(inventory);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(inventory.FtzNumber), new { id = inventory.AltName });
        }
    }
}

public class InventoryItem
{
    public int Id { get; set; }
    public string FtzNumber { get; set; }
    public string AltName { get; set; }
    public string Description { get; set; }
    public string Section { get; set; }
    public string SectionName { get; set; }
    public string PlacementNotes { get; set; }
    public int Amount { get; set; }
    public string Picture { get; set; }
}

public class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options)
    : base(options)
    { }
    public DbSet<InventoryItem> Inventory { get; set; }
}