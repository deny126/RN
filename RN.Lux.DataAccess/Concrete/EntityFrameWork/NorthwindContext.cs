using Microsoft.EntityFrameworkCore;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.DataAccess.Concrete.EntityFrameWork
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-DANNY\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
           //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
