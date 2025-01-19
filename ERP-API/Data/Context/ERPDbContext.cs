using Microsoft.EntityFrameworkCore;
using ERP_API.Entities;

namespace ERP_API.Data.Context
{
    public class ERPDbContext : DbContext
    {
        public ERPDbContext(DbContextOptions<ERPDbContext> options)
            : base(options)
        { }

        public DbSet<CartItems> CartItems { get; set; }
        // DbSet properties for other entities...
    }
}
