using Microsoft.EntityFrameworkCore;
using ProjectEF.Domain.Entities;

namespace ProjectEF.Data.DbContexts
{
    public class ForEF_DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Region> Regions { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=entityf;Username=postgres;Password=mypost;");
        }
    }
}
