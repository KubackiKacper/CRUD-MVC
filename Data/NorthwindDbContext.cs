using CRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC.Data
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options)
            : base(options) { }

        public DbSet<Employees> Employees { get; set; }
    }
}
