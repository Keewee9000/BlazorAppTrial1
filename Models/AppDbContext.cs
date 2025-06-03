using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppTrial1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<InventoryItem> InventoryItems { get; set; }
    }
}
