using System.Data.Entity;
using SpankedPuppy.Data.Models;

namespace SpankedPuppy.Data.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}