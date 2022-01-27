using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DriverContext : DbContext
    {
        public DriverContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}