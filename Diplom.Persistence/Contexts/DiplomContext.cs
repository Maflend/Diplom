using Diplom.Domain.Entities;
using Diplom.Persistence.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Persistence.Contexts
{
    /// <summary>
    /// Контекст.
    /// </summary>
    public class DiplomContext : DbContext
    {
        public DiplomContext() { }
        public DiplomContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new SaleConfiguration());


            InitialData data = new InitialData();
            data.Initialized(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
    }
}
