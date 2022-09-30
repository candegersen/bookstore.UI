using bookstore.Entities.Concrete;
using bookstore.Entities.Dtos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bookstore.DataAccess.Concrete
{
    public class MyDbContext : IdentityDbContext<AppIdentityUser, AppIdentityRole, string>
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<AppIdentityUser>()
        //    .Property(e => e.Id)
        //    .ValueGeneratedOnAdd();

        //}

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Payment> Payment { get; set; }

        public DbSet<Cart> Cart { get; set; }


    }
}
