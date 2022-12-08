using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Model;

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
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=db_testing;user=root", new MariaDbServerVersion(new Version(10, 9, 3)));

    public DbSet<InventoryItem> Inventory { get; set; }
}