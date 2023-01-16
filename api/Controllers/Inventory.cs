using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InventoryAPI.Model;

namespace InventoryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    private readonly InventoryContext _context;
    public InventoryController(InventoryContext context) => _context = context;


    // GET api/inventory/get/all
    [HttpGet("get/all")]
    public async Task<ActionResult<IEnumerable<InventoryItem>>> GetAllInventory()
    => await _context.Inventory.ToListAsync();


    // GET api/inventory/get/{amount}
    [HttpGet("get/{amount}")]
    public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryByAmount(int amount)
    => await _context.Inventory
            .Where(i => i.Amount == amount)
            .ToListAsync();


    // GET api/inventory/get/{query}
    [HttpGet("get/{query}")]
    public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryByQuery(string query)
    => await _context.Inventory
                .Where(i => i.FtzNumber.Contains(query) ||
                            i.AltName.Contains(query) ||
                            i.Description.Contains(query) ||
                            i.Section.Contains(query) ||
                            i.SectionName.Contains(query) ||
                            i.PlacementNotes.Contains(query))
                .ToListAsync();


    // PUT api/inventory/put/add
    [HttpPut("put/add")]
    public async Task<IActionResult> PutAddInventory(InventoryItem item)
    {
        if (item.Amount == 0)
        {
            item.Amount = 1;
        }

        _context.Inventory.Add(item);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(item.FtzNumber), new { id = item.AltName });
    }
}
