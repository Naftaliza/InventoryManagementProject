using System.Data.Entity;

namespace WCFProject
{
    public class InventoryDbContext : DbContext 
    {
        public DbSet<InventoryItem> InventoryItems { get; set; }
    }
}
