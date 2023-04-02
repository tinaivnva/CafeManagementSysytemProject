using CafeManagementSystemProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeManagementSystemProject.DataFolder
{
    public class MVCProductDbContext : DbContext
    {
        public MVCProductDbContext(DbContextOptions<MVCOrderDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
