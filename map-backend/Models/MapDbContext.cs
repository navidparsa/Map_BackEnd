using Microsoft.EntityFrameworkCore;

namespace map_backend.Models
{
    public class MapDbContext : DbContext
    {
        public MapDbContext(DbContextOptions<MapDbContext> options) : base(options) { }
        public DbSet<Location> Locations { get; set; }

    }
}
